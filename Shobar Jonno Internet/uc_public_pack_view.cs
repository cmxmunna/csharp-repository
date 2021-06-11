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
    public partial class uc_public_pack_view : UserControl
    {
        private static uc_public_pack_view _instance;
        public static uc_public_pack_view Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_public_pack_view();
                return _instance;
            }
        }
        string cs = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        public uc_public_pack_view()
        {
            InitializeComponent();
        }

        private void uc_public_pack_view_Load(object sender, EventArgs e)
        {
            BindGridView();
        }
        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from packages";
            SqlDataAdapter ada = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            ada.Fill(data);
            dataGridView1.DataSource = data;
            DataGridViewImageColumn dgv = new DataGridViewImageColumn();
            dgv = (DataGridViewImageColumn)dataGridView1.Columns[5];
            dgv.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 60;
        }

        private Image GetPhoto(byte[] photo)
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            comboBox2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            fnbox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            addressbox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            imagebox.Image = GetPhoto((byte[])dataGridView1.SelectedRows[0].Cells[5].Value);
        }
    }
    
}
