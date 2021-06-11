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
    public partial class admin_login : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

        public admin_login()
        {
            InitializeComponent();
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

        private void admin_login_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(cs);
            connection.Open();
            string query = "SELECT * FROM admin WHERE username = @usn AND password = @pass";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@usn", usernamebox.Text);
            command.Parameters.AddWithValue("@pass", passwordbox.Text);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            if(dataTable.Rows.Count > 0)
            {
                globals.firstname = dataTable.Rows[0]["firstname"].ToString();
                globals.lastname = dataTable.Rows[0]["lastname"].ToString();
                globals.username = dataTable.Rows[0]["username"].ToString();
                globals.email = dataTable.Rows[0]["email"].ToString();
                globals.admin_details = dataTable.Rows[0]["admin_details"].ToString();

                new admin_portal().Show();
                this.Hide();
            }
            else
            {
                if (usernamebox.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Username to Login", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usernamebox.Focus();
                }
                else if (passwordbox.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Password to Login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    passwordbox.Focus();
                }
                else
                {
                    MessageBox.Show("Hey you! Yes youuuu! Seems like you'r not an Admin\nYour Activity has been noted (-_-)", "Wrong Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    passwordbox.Clear();
                    passwordbox.Focus();
                }
            }
            connection.Close();
        }
        private Image GetPhoto(byte[] photo)
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool status = checkBox1.Checked;
            switch(status)
            {
                case true:
                    passwordbox.UseSystemPasswordChar = false;
                    break;
                default:
                    passwordbox.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            new SJIForm().Show();
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

        
    }
}
