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
    public partial class uc_packages : UserControl
    {
        private static uc_packages _instance;
        public static uc_packages Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_packages();
                return _instance;
            }
        }
        string cs = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        public uc_packages()
        {
            InitializeComponent();
        }

        private void packages_Load(object sender, EventArgs e)
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

        private void insert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);

            string query = "INSERT INTO packages values(@usrtype, @packname, @packdescription, @createdate, @packimg)";
            SqlCommand command = new SqlCommand(query, con);

            command.Parameters.AddWithValue("@usrtype", comboBox1.Text);
            command.Parameters.AddWithValue("@packname", fnbox.Text);
            command.Parameters.AddWithValue("@packdescription", addressbox.Text);
            command.Parameters.AddWithValue("@createdate", dateTimePicker1.Text);
            command.Parameters.AddWithValue("@packimg", SavePhoto());


            con.Open();

            if (String.IsNullOrEmpty(fnbox.Text) == true)
            {
                fnbox.Focus();
                emptyfnerror.SetError(this.fnbox, "Please Enter a Name!");
            }
            else if (String.IsNullOrEmpty(addressbox.Text) == true)
            {
                addressbox.Focus();
                emptyadd.SetError(this.addressbox, "Please Enter Some Description!");
            }
            else if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Package Info Inserted Successfully");
                BindGridView();
                ResetControl();
            }
            else
            {
                MessageBox.Show("Something Error! Try Again");
            }

            con.Close();
        }
        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            imagebox.Image.Save(ms, imagebox.Image.RawFormat);
            return ms.GetBuffer();
        }
        private void ResetControl()
        {
            comboBox1.Text = string.Empty;
            comboBox2.Text = string.Empty;
            fnbox.Clear();
            addressbox.Clear();
            fnbox.Focus();
            imagebox.Image = Properties.Resources.packbackground;
            emptyadd.Clear();
            emptyfnerror.Clear();
        }

        private void selectphoto_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg filter(*.jpg)|*.jpg| PNG filter(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    imagebox.ImageLocation = imageLocation;
                }
                else
                {
                    MessageBox.Show("You didn't select any Photo!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cleardata_Click(object sender, EventArgs e)
        {
            ResetControl();
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
        private Image GetPhoto(byte[] photo)
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }

        private void update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);

            string query = "update packages set usertype = @usrtype, packname= @packanme,packdetails= @packdetails ,createdate= @createdate,pack_img = @packimg where id=@id";
            SqlCommand command = new SqlCommand(query, con);

            command.Parameters.AddWithValue("@id", comboBox2.Text);
            command.Parameters.AddWithValue("@usrtype", comboBox1.Text);
            command.Parameters.AddWithValue("@packanme", fnbox.Text);
            command.Parameters.AddWithValue("@packdetails", addressbox.Text);
            command.Parameters.AddWithValue("@createdate", dateTimePicker1.Text);
            command.Parameters.AddWithValue("@packimg", SavePhoto());

            con.Open();

            int a = command.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show("Package Info Updated Successfully");
                BindGridView();
                ResetControl();
            }
            else
            {
                MessageBox.Show("Data Not Updated!");
            }

            con.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);

            string query = "delete from packages where id = @id";
            SqlCommand command = new SqlCommand(query, con);

            command.Parameters.AddWithValue("@id", comboBox2.Text);

            con.Open();

            int a = command.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show("Data Deleted Successfully");
                BindGridView();
                ResetControl();
            }
            else
            {
                MessageBox.Show("Data Not Deleted!");
            }

            con.Close();
        }
    }
}
