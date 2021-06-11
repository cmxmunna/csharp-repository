
namespace Shobar_Jonno_Internet
{
    partial class user_portal
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.profile = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.payment = new System.Windows.Forms.Button();
            this.packages = new System.Windows.Forms.Button();
            this.updateprofile = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uc_panel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 659);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.profile, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.logout, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.payment, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.packages, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.updateprofile, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 150);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(165, 509);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // profile
            // 
            this.profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.profile.Font = new System.Drawing.Font("BankGothic Lt BT", 14.25F);
            this.profile.ForeColor = System.Drawing.Color.White;
            this.profile.Location = new System.Drawing.Point(3, 3);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(159, 81);
            this.profile.TabIndex = 33;
            this.profile.Text = "Profile";
            this.profile.UseVisualStyleBackColor = false;
            this.profile.Click += new System.EventHandler(this.profile_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logout.Font = new System.Drawing.Font("BankGothic Lt BT", 14.25F);
            this.logout.ForeColor = System.Drawing.Color.White;
            this.logout.Location = new System.Drawing.Point(3, 348);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(159, 78);
            this.logout.TabIndex = 38;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // payment
            // 
            this.payment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.payment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.payment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.payment.Font = new System.Drawing.Font("BankGothic Lt BT", 14.25F);
            this.payment.ForeColor = System.Drawing.Color.White;
            this.payment.Location = new System.Drawing.Point(3, 261);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(159, 80);
            this.payment.TabIndex = 37;
            this.payment.Text = "Payment";
            this.payment.UseVisualStyleBackColor = false;
            // 
            // packages
            // 
            this.packages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.packages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.packages.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.packages.Font = new System.Drawing.Font("BankGothic Lt BT", 14.25F);
            this.packages.ForeColor = System.Drawing.Color.White;
            this.packages.Location = new System.Drawing.Point(3, 175);
            this.packages.Name = "packages";
            this.packages.Size = new System.Drawing.Size(159, 79);
            this.packages.TabIndex = 36;
            this.packages.Text = "Packages";
            this.packages.UseVisualStyleBackColor = false;
            this.packages.Click += new System.EventHandler(this.packages_Click);
            // 
            // updateprofile
            // 
            this.updateprofile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.updateprofile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateprofile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateprofile.Font = new System.Drawing.Font("BankGothic Lt BT", 14.25F);
            this.updateprofile.ForeColor = System.Drawing.Color.White;
            this.updateprofile.Location = new System.Drawing.Point(3, 90);
            this.updateprofile.Name = "updateprofile";
            this.updateprofile.Size = new System.Drawing.Size(159, 79);
            this.updateprofile.TabIndex = 36;
            this.updateprofile.Text = "Settings";
            this.updateprofile.UseVisualStyleBackColor = false;
            this.updateprofile.Click += new System.EventHandler(this.updateprofile_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(165, 150);
            this.panel5.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Shobar_Jonno_Internet.Properties.Resources.IFA;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // uc_panel
            // 
            this.uc_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.uc_panel.Location = new System.Drawing.Point(163, 0);
            this.uc_panel.Name = "uc_panel";
            this.uc_panel.Size = new System.Drawing.Size(1145, 659);
            this.uc_panel.TabIndex = 3;
            // 
            // user_portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 659);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uc_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "user_portal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "user_portal";
            this.Load += new System.EventHandler(this.user_portal_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel uc_panel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button profile;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button payment;
        private System.Windows.Forms.Button packages;
        private System.Windows.Forms.Button updateprofile;
    }
}