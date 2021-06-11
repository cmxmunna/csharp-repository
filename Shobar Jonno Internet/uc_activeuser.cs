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
    public partial class uc_activeuser : UserControl
    {
        private static uc_activeuser _instance;
        public static uc_activeuser Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_activeuser();
                return _instance;
            }
        }
        string cs = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        public uc_activeuser()
        {
            InitializeComponent();
        }

        private void activeuser_uc_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}
