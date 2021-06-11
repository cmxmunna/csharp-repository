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
    public partial class GuestView : Form
    {
        public GuestView()
        {
            InitializeComponent();
        }

        private void GuestView_Load(object sender, EventArgs e)
        {
            if (!uc_panel.Controls.Contains(uc_public_pack_view.Instance))
            {
                uc_panel.Controls.Add(uc_public_pack_view.Instance);
                uc_public_pack_view.Instance.Dock = DockStyle.Fill;
                uc_public_pack_view.Instance.BringToFront();
            }
            else
            {
                uc_public_pack_view.Instance.BringToFront();
            }
        }

        private void profile_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
