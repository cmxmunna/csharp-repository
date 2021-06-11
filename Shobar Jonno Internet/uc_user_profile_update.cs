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
    public partial class uc_user_profile_update : UserControl
    {
        private static uc_user_profile_update _instance;
        public static uc_user_profile_update Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_user_profile_update();
                return _instance;
            }
        }
        string cs = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        public uc_user_profile_update()
        {
            InitializeComponent();
        }

        private void uc_user_profile_update_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "" + globals.usertype;
            comboBox2.Text = "" + globals.id;
            fnbox.Text = "" + globals.firstname;
            lnbox.Text = "" + globals.lastname;
            usernamebox.Text = "" + globals.username;
            passwordbox.Text = "" + globals.password;
            emailbox.Text = "" + globals.email;
            phonebox.Text = "" + globals.phone;
            addressbox.Text = "" + globals.address;
            comnamebox.Text = "" + globals.companyname;
            websitebox.Text = "" + globals.companyweb;
            collegenamebox.Text = "" + globals.college;
            regdate.Text = "" + globals.regdate;

            regdate.Visible = true;
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

        private void button1_Click(object sender, EventArgs e)
        {
            n1.Visible = true;
            n2.Visible = true;
            n3.Visible = true;
            n4.Visible = true;
            c1.Visible = true;
            c2.Visible = true;
            c3.Visible = true;
            c4.Visible = true;
        }

        private void selectphoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select Profile Image";
            dialog.Filter = "jpg filter(*.jpg)|*.jpg| PNG filter(*.png)|*.png| All Files(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imagebox.Image = new Bitmap(dialog.FileName);
            }
            else
            {
                MessageBox.Show("Photo was not Uploaded! Try Again");
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "update users set usertype = @usrtype, firstname= @fn,lastname= @ln,username= @usn,password=  @pass, email=@email, phone= @phn, address= @add ,companyname= @cmopanyname ,website= @website,collegeename= @collegename,regdate= @regdate,user_img = @usrimg where id=@id";
            SqlCommand command = new SqlCommand(query, con);

            command.Parameters.AddWithValue("@id", comboBox2.Text);
            command.Parameters.AddWithValue("@usrtype", comboBox1.Text);
            command.Parameters.AddWithValue("@fn", fnbox.Text);
            command.Parameters.AddWithValue("@ln", lnbox.Text);
            command.Parameters.AddWithValue("@usn", usernamebox.Text);
            command.Parameters.AddWithValue("@pass", passwordbox.Text);
            command.Parameters.AddWithValue("@email", emailbox.Text);
            command.Parameters.AddWithValue("@phn", phonebox.Text);
            command.Parameters.AddWithValue("@add", addressbox.Text);
            command.Parameters.AddWithValue("@cmopanyname", comnamebox.Text);
            command.Parameters.AddWithValue("@website", websitebox.Text);
            command.Parameters.AddWithValue("@collegename", collegenamebox.Text);
            command.Parameters.AddWithValue("@regdate", regdate.Text);
            command.Parameters.AddWithValue("@usrimg", SavePhoto());

            con.Open();

            int a = command.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Account Info Updated Successfully");
            }
            else
            {
                MessageBox.Show("Data Not Updated!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            con.Close();
        }
        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            imagebox.Image.Save(ms, imagebox.Image.RawFormat);
            return ms.GetBuffer();
        }
    }
}
