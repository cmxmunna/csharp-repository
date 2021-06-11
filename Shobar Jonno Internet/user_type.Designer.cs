
namespace Shobar_Jonno_Internet
{
    partial class user_type
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.premium = new System.Windows.Forms.Label();
            this.home = new System.Windows.Forms.Label();
            this.student = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("BankGothic Md BT", 21.75F);
            this.label1.Location = new System.Drawing.Point(58, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select User Type";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 66);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.panel2.Controls.Add(this.premium);
            this.panel2.Controls.Add(this.home);
            this.panel2.Controls.Add(this.student);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 539);
            this.panel2.TabIndex = 4;
            // 
            // premium
            // 
            this.premium.AutoSize = true;
            this.premium.BackColor = System.Drawing.Color.DarkCyan;
            this.premium.Cursor = System.Windows.Forms.Cursors.Hand;
            this.premium.Font = new System.Drawing.Font("BankGothic Md BT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.premium.ForeColor = System.Drawing.Color.White;
            this.premium.Location = new System.Drawing.Point(129, 173);
            this.premium.Name = "premium";
            this.premium.Size = new System.Drawing.Size(182, 39);
            this.premium.TabIndex = 1;
            this.premium.Text = "Premium";
            this.premium.Click += new System.EventHandler(this.premium_Click);
            this.premium.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            this.premium.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            // 
            // home
            // 
            this.home.AutoSize = true;
            this.home.BackColor = System.Drawing.Color.DarkCyan;
            this.home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home.Font = new System.Drawing.Font("BankGothic Md BT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.ForeColor = System.Drawing.Color.White;
            this.home.Location = new System.Drawing.Point(157, 262);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(126, 39);
            this.home.TabIndex = 1;
            this.home.Text = "Home";
            this.home.Click += new System.EventHandler(this.label4_Click);
            this.home.MouseEnter += new System.EventHandler(this.label4_MouseEnter);
            this.home.MouseLeave += new System.EventHandler(this.label4_MouseLeave);
            // 
            // student
            // 
            this.student.AutoSize = true;
            this.student.BackColor = System.Drawing.Color.DarkCyan;
            this.student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.student.Font = new System.Drawing.Font("BankGothic Md BT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student.ForeColor = System.Drawing.Color.White;
            this.student.Location = new System.Drawing.Point(124, 352);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(190, 39);
            this.student.TabIndex = 1;
            this.student.Text = "Student";
            this.student.Click += new System.EventHandler(this.student_Click);
            this.student.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.student.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Shobar_Jonno_Internet.Properties.Resources.label_bg;
            this.pictureBox1.Location = new System.Drawing.Point(1, -26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(449, 606);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // user_type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 605);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "user_type";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "user_type";
            this.Load += new System.EventHandler(this.user_type_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label premium;
        private System.Windows.Forms.Label home;
        private System.Windows.Forms.Label student;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}