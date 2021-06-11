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
    public partial class user_portal : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

        public user_portal()
        {
            InitializeComponent();
        }

        private void user_portal_Load(object sender, EventArgs e)
        {
            if (!uc_panel.Controls.Contains(uc_user_profile.Instance))
            {
                uc_panel.Controls.Add(uc_user_profile.Instance);
                uc_user_profile.Instance.Dock = DockStyle.Fill;
                uc_user_profile.Instance.BringToFront();
            }
            else
            {
                uc_user_profile.Instance.BringToFront();
            }
        }

        private void packages_Click(object sender, EventArgs e)
        {
            if (!uc_panel.Controls.Contains(uc_packages_user.Instance))
            {
                uc_panel.Controls.Add(uc_packages_user.Instance);
                uc_packages_user.Instance.Dock = DockStyle.Fill;
                uc_packages_user.Instance.BringToFront();
            }
            else
            {
                uc_packages_user.Instance.BringToFront();
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            new user_login().Show();
            this.Close();
        }

        private void profile_Click(object sender, EventArgs e)
        {
            if (!uc_panel.Controls.Contains(uc_user_profile.Instance))
            {
                uc_panel.Controls.Add(uc_user_profile.Instance);
                uc_user_profile.Instance.Dock = DockStyle.Fill;
                uc_user_profile.Instance.BringToFront();
            }
            else
            {
                uc_user_profile.Instance.BringToFront();
            }
        }

        private void updateprofile_Click(object sender, EventArgs e)
        {
            if (!uc_panel.Controls.Contains(uc_user_profile_update.Instance))
            {
                uc_panel.Controls.Add(uc_user_profile_update.Instance);
                uc_user_profile_update.Instance.Dock = DockStyle.Fill;
                uc_user_profile_update.Instance.BringToFront();
            }
            else
            {
                uc_user_profile_update.Instance.BringToFront();
            }
        }
    }
}
