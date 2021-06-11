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
    public partial class uc_admin_crud : UserControl
    {
        private static uc_admin_crud _instance;
        public static uc_admin_crud Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_admin_crud();
                return _instance;
            }
        }
        string cs = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        public uc_admin_crud()
        {
            InitializeComponent();
        }

        private void admin_uc_crud_Load(object sender, EventArgs e)
        {
           BindGridView();
        }

        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from users";
            SqlDataAdapter ada = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            ada.Fill(data);
            dataGridView1.DataSource = data;
            DataGridViewImageColumn dgv = new DataGridViewImageColumn();
            dgv = (DataGridViewImageColumn)dataGridView1.Columns[14];
            dgv.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 60;
        }

        private void insert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);

            string query = "INSERT INTO users values(@usrtype, @fn, @ln, @usn, @pass, @email,  @phn,  @add , @cmopanyname , @website, @collegename, @regdate,@activepack, @usrimg)";
            SqlCommand command = new SqlCommand(query, con);

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
            command.Parameters.AddWithValue("@regdate", dateTimePicker1.Text);
            command.Parameters.AddWithValue("@activepack", activepackbox.Text);
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
            else if (String.IsNullOrEmpty(comnamebox.Text) == true)
            {
                comnamebox.Focus();
                emptycomname.SetError(this.comnamebox, "Please Enter Confirm Password!");
            }
            else if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Account Info Inserted Successfully");
                BindGridView();
                ResetControl();
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
        private void ResetControl()
        {
            comboBox1.Text = string.Empty;
            comboBox2.Text = string.Empty;
            fnbox.Clear();
            usernamebox.Clear();
            emailbox.Clear();
            passwordbox.Clear();
            addressbox.Clear();
            lnbox.Clear();
            comnamebox.Text = string.Empty;
            websitebox.Text = string.Empty;
            collegenamebox.Text = string.Empty;
            phonebox.Clear();
            fnbox.Focus();
            imagebox.Image = Properties.Resources.blankimage;

            emptycomname.Clear();
            emptyadd.Clear();
            emptyphone.Clear();
            emptypass.Clear();
            emptyemail.Clear();
            emptyusn.Clear();
            emptyln.Clear();
            emptyfnerror.Clear();
        }

        private void selectphoto_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg filter(*.jpg)|*.jpg| PNG filter(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    imagebox.ImageLocation = imageLocation;
                }
                else
                {
                    MessageBox.Show("You didn't select any Photo!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cleardata_Click(object sender, EventArgs e)
        {
            ResetControl();
        }

        

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            comboBox2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            fnbox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            lnbox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            usernamebox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            passwordbox.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            emailbox.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            phonebox.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            addressbox.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            comnamebox.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            websitebox.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            collegenamebox.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
            activepackbox.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();
            imagebox.Image = GetPhoto((byte[])dataGridView1.SelectedRows[0].Cells[14].Value);

        }

        private Image GetPhoto(byte[] photo)
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }

        private void update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);

            string query = "update users set usertype = @usrtype, firstname= @fn,lastname= @ln,username= @usn,password=  @pass, email=@email, phone= @phn, address= @add ,companyname= @cmopanyname ,website= @website,collegeename= @collegename,regdate= @regdate, active_pack=@activepack ,user_img = @usrimg where id=@id";
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
            command.Parameters.AddWithValue("@regdate", dateTimePicker1.Text);
            command.Parameters.AddWithValue("@activepack", activepackbox.Text);
            command.Parameters.AddWithValue("@usrimg", SavePhoto()); 


            con.Open();

            int a = command.ExecuteNonQuery();

            if (a>0)
            {
                MessageBox.Show("Account Info Updated Successfully");
                BindGridView();
                ResetControl();
            }
            else
            {
                MessageBox.Show("Data Not Updated!");
            }

            con.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);

            string query = "delete from users where id = @id";
            SqlCommand command = new SqlCommand(query, con);

            command.Parameters.AddWithValue("@id", comboBox2.Text);

            con.Open();

            int a = command.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show("Data Deleted Successfully");
                BindGridView();
                ResetControl();
            }
            else
            {
                MessageBox.Show("Data Not Deleted!");
            }

            con.Close();
        }
    }
}

