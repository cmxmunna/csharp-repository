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
    public partial class user_type : Form
    {
        public user_type()
        {
            InitializeComponent();
        }

        private void user_type_Load(object sender, EventArgs e)
        {

        }
        private void label3_MouseEnter(object sender, EventArgs e)
        {
            premium.ForeColor = Color.Black;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            premium.ForeColor = Color.White;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            home.ForeColor = Color.Black;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            home.ForeColor = Color.White;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            student.ForeColor = Color.Black;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            student.ForeColor = Color.White;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new lite_user_reg().Show();
            this.Hide();
        }

        private void premium_Click(object sender, EventArgs e)
        {
            new premium_user_reg().Show();
            this.Hide();
        }

        private void student_Click(object sender, EventArgs e)
        {
            this.Hide();
            new student_user_reg().Show();
        }
    }
}
