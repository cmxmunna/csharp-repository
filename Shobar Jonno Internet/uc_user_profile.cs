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
    public partial class uc_user_profile : UserControl
    {
        private static uc_user_profile _instance;
        public static uc_user_profile Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_user_profile();
                return _instance;
            }
        }
        string cs = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        public uc_user_profile()
        {
            InitializeComponent();
        }

        private void user_profile_uc_Load(object sender, EventArgs e)
        {
            welcomesms.Text = "" + globals.username;
            usertype.Text = "" + globals.usertype;
            firstname.Text = "" + globals.firstname;
            lastname.Text = "" + globals.lastname;
            username.Text = "" + globals.username;
            email.Text = "" + globals.email;
            phone.Text = "" + globals.phone;
            address.Text = "" + globals.address;
            companyname.Text = "" + globals.companyname;
            companyweb.Text = "" + globals.companyweb;
            college.Text = "" + globals.college;
            regdate.Text = "" + globals.regdate;
           // imagebox.Image = "" + globals.user_img;

            usertype.Visible = true;
            welcomesms.Visible = true;
            firstname.Visible = true;
            lastname.Visible = true;
            username.Visible = true;
            email.Visible = true;
            phone.Visible = true;
            address.Visible = true;
            companyname.Visible = true;
            companyweb.Visible = true;
            college.Visible = true;
            regdate.Visible = true;
            userpack.Visible = true;
        }

        private void update_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
