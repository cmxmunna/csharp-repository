using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shobar_Jonno_Internet
{
    public partial class SJIForm : Form
    {
        public SJIForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            new admin_login().Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void User_Click(object sender, EventArgs e)
        {
            new user_login().Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new tnc().Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new GuestView().Show();
        }
    }
}
