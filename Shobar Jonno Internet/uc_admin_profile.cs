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
    public partial class uc_admin_profile : UserControl
    {
        private static uc_admin_profile _instance;
        public static uc_admin_profile Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_admin_profile();
                return _instance;
            }
        }
        string cs = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        public uc_admin_profile()
        {
            InitializeComponent();
        }

        private void admin_profile_uc_Load(object sender, EventArgs e)
        {
            firstname.Text = "" + globals.firstname;
            lastname.Text = "" + globals.lastname;
            welcomesms.Text = "" + globals.username;
            email.Text = "" + globals.email;
            aboutadmin.Text = "" + globals.admin_details;
            username.Text = "" + globals.username;

            firstname.Visible = true;
            lastname.Visible = true;
            welcomesms.Visible = true;
            email.Visible = true; 
            aboutadmin.Visible = true;
            username.Visible = true;
        }

        private Image GetPhoto(byte[] photo)
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }

    }
}
