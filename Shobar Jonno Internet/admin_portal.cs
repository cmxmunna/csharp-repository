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
    public partial class admin_portal : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

        public admin_portal()
        {
            InitializeComponent();
        }

        private void admin_portal_Load(object sender, EventArgs e)
        {
            if (!uc_panel.Controls.Contains(uc_admin_profile.Instance))
            {
                uc_panel.Controls.Add(uc_admin_profile.Instance);
                uc_admin_profile.Instance.Dock = DockStyle.Fill;
                uc_admin_profile.Instance.BringToFront();
            }
            else
            {
                uc_admin_profile.Instance.BringToFront();
            }
            
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from users";
            SqlDataAdapter ada = new SqlDataAdapter(query, con);
            

        }
        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from users";
            SqlDataAdapter ada = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            DataGridViewImageColumn dgv = new DataGridViewImageColumn();

        }
        private void logout_Click(object sender, EventArgs e)
        {
            new admin_login().Show();
            this.Close();
        }

        private void profile_Click(object sender, EventArgs e)
        {
            if (!uc_panel.Controls.Contains(uc_admin_profile.Instance))
            {
                uc_panel.Controls.Add(uc_admin_profile.Instance);
                uc_admin_profile.Instance.Dock = DockStyle.Fill;
                uc_admin_profile.Instance.BringToFront();
            }
            else
            {
                uc_admin_profile.Instance.BringToFront();
            }
        }

        private void userdetail_Click(object sender, EventArgs e)
        {
            if (!uc_panel.Controls.Contains(uc_admin_crud.Instance))
            {
                uc_panel.Controls.Add(uc_admin_crud.Instance);
                uc_admin_crud.Instance.Dock = DockStyle.Fill;
                uc_admin_crud.Instance.BringToFront();
            }
            else
            {
                uc_admin_crud.Instance.BringToFront();
            }
        }

        private void usercontrol_Click_1(object sender, EventArgs e)
        {
            if (!uc_panel.Controls.Contains(uc_activeuser.Instance))
            {
                uc_panel.Controls.Add(uc_activeuser.Instance);
                uc_activeuser.Instance.Dock = DockStyle.Fill;
                uc_activeuser.Instance.BringToFront();
            }
            else
            {
                uc_activeuser.Instance.BringToFront();
            }
        }

        private void packages_Click(object sender, EventArgs e)
        {
            if (!uc_panel.Controls.Contains(uc_packages.Instance))
            {
                uc_panel.Controls.Add(uc_packages.Instance);
                uc_packages.Instance.Dock = DockStyle.Fill;
                uc_packages.Instance.BringToFront();
            }
            else
            {
                uc_packages.Instance.BringToFront();
            }
        }
    }
}
