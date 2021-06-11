
namespace Shobar_Jonno_Internet
{
    partial class uc_packages
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.imagebox = new System.Windows.Forms.PictureBox();
            this.selectphoto = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.cleardata = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.fnbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.fn = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addressbox = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.emptyadd = new System.Windows.Forms.ErrorProvider(this.components);
            this.emptyfnerror = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyadd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyfnerror)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(18, 404);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 241);
            this.panel1.TabIndex = 71;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1113, 241);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("BankGothic Md BT", 21.75F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(36, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(317, 31);
            this.label8.TabIndex = 70;
            this.label8.Text = "Paackage Control";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Courier New", 12F);
            this.dateTimePicker1.Location = new System.Drawing.Point(900, 69);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(212, 20);
            this.dateTimePicker1.TabIndex = 69;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.imagebox);
            this.panel3.Location = new System.Drawing.Point(918, 121);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(194, 150);
            this.panel3.TabIndex = 68;
            // 
            // imagebox
            // 
            this.imagebox.BackgroundImage = global::Shobar_Jonno_Internet.Properties.Resources.blankimage;
            this.imagebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagebox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagebox.Image = global::Shobar_Jonno_Internet.Properties.Resources.packbackground;
            this.imagebox.Location = new System.Drawing.Point(0, 0);
            this.imagebox.Name = "imagebox";
            this.imagebox.Size = new System.Drawing.Size(194, 150);
            this.imagebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagebox.TabIndex = 10;
            this.imagebox.TabStop = false;
            // 
            // selectphoto
            // 
            this.selectphoto.BackColor = System.Drawing.Color.SkyBlue;
            this.selectphoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectphoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectphoto.Font = new System.Drawing.Font("BankGothic Lt BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectphoto.Location = new System.Drawing.Point(967, 277);
            this.selectphoto.Name = "selectphoto";
            this.selectphoto.Size = new System.Drawing.Size(111, 38);
            this.selectphoto.TabIndex = 66;
            this.selectphoto.Text = "Select Pack Image";
            this.selectphoto.UseVisualStyleBackColor = false;
            this.selectphoto.Click += new System.EventHandler(this.selectphoto_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Red;
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("BankGothic Lt BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(757, 256);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(111, 38);
            this.delete.TabIndex = 63;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Lime;
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("BankGothic Lt BT", 14.25F);
            this.update.Location = new System.Drawing.Point(618, 256);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(111, 38);
            this.update.TabIndex = 64;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // cleardata
            // 
            this.cleardata.BackColor = System.Drawing.Color.Tomato;
            this.cleardata.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cleardata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cleardata.Font = new System.Drawing.Font("BankGothic Lt BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cleardata.Location = new System.Drawing.Point(757, 197);
            this.cleardata.Name = "cleardata";
            this.cleardata.Size = new System.Drawing.Size(111, 38);
            this.cleardata.TabIndex = 65;
            this.cleardata.Text = "Clear Data";
            this.cleardata.UseVisualStyleBackColor = false;
            this.cleardata.Click += new System.EventHandler(this.cleardata_Click);
            // 
            // insert
            // 
            this.insert.BackColor = System.Drawing.Color.RoyalBlue;
            this.insert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insert.Font = new System.Drawing.Font("BankGothic Lt BT", 14.25F);
            this.insert.Location = new System.Drawing.Point(618, 197);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(111, 38);
            this.insert.TabIndex = 67;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = false;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("BankGothic Md BT", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(837, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 61;
            this.label5.Text = "Date";
            // 
            // fnbox
            // 
            this.fnbox.Font = new System.Drawing.Font("Courier New", 12F);
            this.fnbox.Location = new System.Drawing.Point(130, 104);
            this.fnbox.MaxLength = 30;
            this.fnbox.Name = "fnbox";
            this.fnbox.Size = new System.Drawing.Size(459, 26);
            this.fnbox.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(282, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 17);
            this.label10.TabIndex = 47;
            this.label10.Text = "Pack ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(22, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 17);
            this.label9.TabIndex = 48;
            this.label9.Text = "Pack Type";
            // 
            // fn
            // 
            this.fn.AutoSize = true;
            this.fn.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fn.ForeColor = System.Drawing.SystemColors.Window;
            this.fn.Location = new System.Drawing.Point(14, 108);
            this.fn.Name = "fn";
            this.fn.Size = new System.Drawing.Size(102, 17);
            this.fn.TabIndex = 49;
            this.fn.Text = "Pack Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(10, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 17);
            this.label7.TabIndex = 54;
            this.label7.Text = "Description";
            // 
            // addressbox
            // 
            this.addressbox.AccessibleDescription = "";
            this.addressbox.AccessibleName = "";
            this.addressbox.Font = new System.Drawing.Font("Courier New", 12F);
            this.addressbox.Location = new System.Drawing.Point(130, 147);
            this.addressbox.MaxLength = 1000;
            this.addressbox.Multiline = true;
            this.addressbox.Name = "addressbox";
            this.addressbox.Size = new System.Drawing.Size(459, 225);
            this.addressbox.TabIndex = 60;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Courier New", 12F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.comboBox2.Location = new System.Drawing.Point(367, 67);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(104, 26);
            this.comboBox2.TabIndex = 42;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Courier New", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Premium",
            "Home",
            "Student"});
            this.comboBox1.Location = new System.Drawing.Point(130, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 38;
            // 
            // emptyadd
            // 
            this.emptyadd.ContainerControl = this;
            // 
            // emptyfnerror
            // 
            this.emptyfnerror.ContainerControl = this;
            // 
            // packages_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.selectphoto);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.cleardata);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fnbox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.fn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addressbox);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "packages_uc";
            this.Size = new System.Drawing.Size(1145, 659);
            this.Load += new System.EventHandler(this.packages_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyadd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyfnerror)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox imagebox;
        private System.Windows.Forms.Button selectphoto;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button cleardata;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fnbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label fn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox addressbox;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ErrorProvider emptyadd;
        private System.Windows.Forms.ErrorProvider emptyfnerror;
    }
}
