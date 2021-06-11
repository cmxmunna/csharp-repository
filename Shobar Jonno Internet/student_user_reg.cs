using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace Shobar_Jonno_Internet
{
    public partial class student_user_reg : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        
        public student_user_reg()
        {
            InitializeComponent();
        }

        private void student_user_reg_Load(object sender, EventArgs e)
        {

        }

        private void exit_MouseEnter(object sender, EventArgs e)
        {
            exit.ForeColor = Color.DarkCyan;
        }

        private void exit_MouseLeave(object sender, EventArgs e)
        {
            exit.ForeColor = Color.White;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            new user_login().Show();
            this.Close();
        }
        private void cleardata_Click(object sender, EventArgs e)
        {
            fnbox.Clear();
            usernamebox.Clear();
            emailbox.Clear();
            passwordbox.Clear();
            confirmpassbox.Clear();
            addressbox.Clear();
            lnbox.Clear();
            phonebox.Clear();
            collegenamebox.Clear();
            fnbox.Focus();
            imagebox.Image = Properties.Resources.blankimage;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool status = checkBox1.Checked;
            switch (status)
            {
                case true:
                    passwordbox.UseSystemPasswordChar = false;
                    break;
                default:
                    passwordbox.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            bool status = checkBox2.Checked;
            switch (status)
            {
                case true:
                    confirmpassbox.UseSystemPasswordChar = false;
                    break;
                default:
                    confirmpassbox.UseSystemPasswordChar = true;
                    break;
            }
        }


        private void register_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(cs);
            
            string query = "INSERT INTO users values(@usrtype, @fn, @ln, @usn, @pass, @email,  @phn,  @add , @cmopanyname , @website, @collegename,@regdate,@activepack, @usrimg)";
            SqlCommand command = new SqlCommand(query,con);

            command.Parameters.AddWithValue("@usrtype", usertype.Text);
            command.Parameters.AddWithValue("@fn", fnbox.Text);
            command.Parameters.AddWithValue("@ln", lnbox.Text);
            command.Parameters.AddWithValue("@usn", usernamebox.Text);
            command.Parameters.AddWithValue("@pass", passwordbox.Text);
            command.Parameters.AddWithValue("@email", emailbox.Text);
            command.Parameters.AddWithValue("@phn", phonebox.Text);
            command.Parameters.AddWithValue("@add", addressbox.Text);
            command.Parameters.AddWithValue("@cmopanyname", emptyvalue.Text);
            command.Parameters.AddWithValue("@website", emptyvalue.Text);
            command.Parameters.AddWithValue("@collegename", collegenamebox.Text);
            command.Parameters.AddWithValue("@regdate", dateTimePicker1.Text);
            command.Parameters.AddWithValue("@activepack", emptyvalue.Text);
            command.Parameters.AddWithValue("@usrimg", SavePhoto());

            con.Open();

             if (String.IsNullOrEmpty(fnbox.Text) == true)
             {
                 fnbox.Focus();
                 emptyfnerror.SetError(this.fnbox, "Please Enter First Name!");
             }
             else if (String.IsNullOrEmpty(lnbox.Text) == true)
             {
                 lnbox.Focus();
                 emptyln.SetError(this.lnbox, "Please Enter last Name!");
             }
             else if (String.IsNullOrEmpty(usernamebox.Text) == true)
             {
                 usernamebox.Focus();
                 emptyusn.SetError(this.usernamebox, "Please Enter User Name!");
             }
             else if (String.IsNullOrEmpty(emailbox.Text) == true)
             {
                 emailbox.Focus();
                 emptyemail.SetError(this.emailbox, "Please Enter an Email!");
             }
             else if (String.IsNullOrEmpty(passwordbox.Text) == true)
             {
                 passwordbox.Focus();
                 emptypass.SetError(this.passwordbox, "Please Enter Security Password!");
             }
             else if (String.IsNullOrEmpty(confirmpassbox.Text) == true)
             {
                 confirmpassbox.Focus();
                 emptyconpass.SetError(this.confirmpassbox, "Please Enter Confirm Password!");
             }
             else if (passwordbox.Text != confirmpassbox.Text)
             {
                 confirmpasserror.SetError(this.confirmpassbox, "Confirm Password in not matching!!");
             }
             else if (String.IsNullOrEmpty(phonebox.Text) == true)
             {
                 phonebox.Focus();
                 emptyphone.SetError(this.phonebox, "Please Enter Contact Number!");
             }
             else if (String.IsNullOrEmpty(addressbox.Text) == true)
             {
                 addressbox.Focus();
                 emptyadd.SetError(this.addressbox, "Please Enter Your Address(Where you want internet connection)!");
             }
             else if (tnc.Checked == false)
             {
                 checktnc.SetError(this.tnc, "Please Check our Terms and Conditions!");
             }
             else if (String.IsNullOrEmpty(collegenamebox.Text) == true)
             {
                 collegenamebox.Focus();
                 emptycollegename.SetError(this.collegenamebox, "Please Enter Your College Name!");
             }
            else if (imagebox.Image == null)
            {
                emptyprofilephoto.SetError(this.imagebox, "Please Upload an Profile Image!");
            }
            else if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Account Created Successfully");
                new user_login().Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Something Error! Try Again");
            }

            con.Close();

        }

        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            imagebox.Image.Save(ms, imagebox.Image.RawFormat);
            return ms.GetBuffer();
        }

        private void confirmpassbox_Leave(object sender, EventArgs e)
        {
            if (passwordbox.Text != confirmpassbox.Text)
            {
                confirmpasserror.SetError(this.confirmpassbox, "Confirm Password in not matching!!");
            }
            else
            {
                confirmpasserror.Clear();
                emptyconpass.Clear();
            }
        }

        private void fnbox_Leave(object sender, EventArgs e)
        {
            emptyfnerror.Clear();
        }

        private void lnbox_Leave(object sender, EventArgs e)
        {
            emptyln.Clear();
        }

        private void usernamebox_Leave(object sender, EventArgs e)
        {
            emptyusn.Clear();
        }

        private void emailbox_Leave(object sender, EventArgs e)
        {
            emptyemail.Clear();
        }

        private void passwordbox_Leave(object sender, EventArgs e)
        {
            emptypass.Clear();
        }

        private void phonebox_Leave(object sender, EventArgs e)
        {
            emptyphone.Clear();
        }

        private void addressbox_Leave(object sender, EventArgs e)
        {
            emptyadd.Clear();
        }

        private void tnc_Click(object sender, EventArgs e)
        {
            checktnc.Clear();
        }

        private void collegenamebox_Leave(object sender, EventArgs e)
        {
            emptycollegename.Clear();
        }

        private void upload_Click(object sender, EventArgs e)
        {
             OpenFileDialog dialog = new OpenFileDialog();
             dialog.Title = "Select Profile Image";
             dialog.Filter = "jpg filter(*.jpg)|*.jpg| PNG filter(*.png)|*.png| All Files(*.*)|*.*";

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                imagebox.Image = new Bitmap(dialog.FileName);
            }
            else
            {
                MessageBox.Show("Photo was not Uploaded! Try Again");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new tnc().Show();
        }
    }
}
