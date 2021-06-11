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


namespace Shobar_Jonno_Internet
{
    public partial class user_login : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        public user_login()
        {
            InitializeComponent();
        }

        private void user_login_Load(object sender, EventArgs e)
        {

        }

        private void exit_MouseEnter(object sender, EventArgs e)
        {
            exit.ForeColor = Color.Red;
        }

        private void exit_MouseLeave(object sender, EventArgs e)
        {
            exit.ForeColor = Color.White;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(cs);
            connection.Open();
            string query = "SELECT * FROM users WHERE username = @usn AND password = @pass";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@usn", usernamebox.Text);
            command.Parameters.AddWithValue("@pass", passwordbox.Text);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                globals.id = Convert.ToInt32(dataTable.Rows[0]["id"].ToString());
                globals.usertype = dataTable.Rows[0]["usertype"].ToString();
                globals.firstname = dataTable.Rows[0]["firstname"].ToString();
                globals.lastname = dataTable.Rows[0]["lastname"].ToString();
                globals.username = dataTable.Rows[0]["username"].ToString();
                globals.password = dataTable.Rows[0]["password"].ToString();
                globals.email = dataTable.Rows[0]["email"].ToString();
                globals.phone = dataTable.Rows[0]["phone"].ToString();
                globals.address = dataTable.Rows[0]["address"].ToString();
                globals.companyname = dataTable.Rows[0]["companyname"].ToString();
                globals.companyweb = dataTable.Rows[0]["website"].ToString();
                globals.college = dataTable.Rows[0]["collegeename"].ToString();
                globals.regdate = dataTable.Rows[0]["regdate"].ToString();
                //globals.user_img = Convert.ToByte(dataTable.Rows[0]["user_img"].ToString());
                //globals.datapack = dataTable.Rows[0]["datapack"].ToString();
                new user_portal().Show();
                this.Hide();
            }
            else
            {
                if (usernamebox.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Username to Login", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (passwordbox.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Password to Login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("This Username or Password dosen't Exist \n     Create an account from REGISTER!", "Wrong Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    passwordbox.Clear();
                    passwordbox.Focus();
                }
            }
            connection.Close();
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

        private void reg_MouseEnter(object sender, EventArgs e)
        {
            reg.ForeColor = Color.DarkCyan;
        }

        private void reg_MouseLeave(object sender, EventArgs e)
        {
            reg.ForeColor = Color.White;
        }

        private void reg_Click(object sender, EventArgs e)
        {
            new user_type().Show();
            this.Hide();
        }

        private void back_MouseEnter(object sender, EventArgs e)
        {
            back.ForeColor = Color.DarkCyan;
        }

        private void back_MouseLeave(object sender, EventArgs e)
        {
            back.ForeColor = Color.White;
        }

        private void back_Click(object sender, EventArgs e)
        {
            new SJIForm().Show();
            this.Close();
        }

        
    }
}
