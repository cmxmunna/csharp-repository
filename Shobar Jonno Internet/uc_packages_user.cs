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
    public partial class uc_packages_user : UserControl
    {
        private static uc_packages_user _instance;
        public static uc_packages_user Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_packages_user();
                return _instance;
            }
        }
        string cs = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        public uc_packages_user()
        {
            InitializeComponent();
        }

        private void packages_user_uc_Load(object sender, EventArgs e)
        {
            BindGridView();
            packnamebox.Visible = true;
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

        private void dataGridView1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            comboBox2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            packnamebox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            descriptionbox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            imagebox.Image = GetPhoto((byte[])dataGridView1.SelectedRows[0].Cells[5].Value);
        }

        private void update_Click(object sender, EventArgs e)
        {
            
        }

        private void selectphoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select Profile Image";
            dialog.Filter = "All Files(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imagebox.Image = new Bitmap(dialog.FileName);
            }
            else
            {
                MessageBox.Show("Photo was not Uploaded! Try Again");
            }
        }
        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            imagebox.Image.Save(ms, imagebox.Image.RawFormat);
            return ms.GetBuffer();
        }
    }
}
