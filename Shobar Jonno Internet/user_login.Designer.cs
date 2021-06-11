
namespace Shobar_Jonno_Internet
{
    partial class user_login
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
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reg = new System.Windows.Forms.Label();
            this.info2 = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.usernamebox = new System.Windows.Forms.TextBox();
            this.passwordbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 111);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("BankGothic Md BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Login Panel";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("BankGothic Md BT", 12F);
            this.exit.ForeColor = System.Drawing.SystemColors.Window;
            this.exit.Location = new System.Drawing.Point(191, 288);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(44, 17);
            this.exit.TabIndex = 1;
            this.exit.Text = "Exit";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            this.exit.MouseEnter += new System.EventHandler(this.exit_MouseEnter);
            this.exit.MouseLeave += new System.EventHandler(this.exit_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("BankGothic Md BT", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(15, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "User Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("BankGothic Md BT", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(21, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Password";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.reg);
            this.panel2.Controls.Add(this.info2);
            this.panel2.Controls.Add(this.info);
            this.panel2.Controls.Add(this.back);
            this.panel2.Controls.Add(this.exit);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.usernamebox);
            this.panel2.Controls.Add(this.passwordbox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 338);
            this.panel2.TabIndex = 2;
            // 
            // reg
            // 
            this.reg.AutoSize = true;
            this.reg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reg.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg.ForeColor = System.Drawing.Color.White;
            this.reg.Location = new System.Drawing.Point(214, 249);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(93, 17);
            this.reg.TabIndex = 4;
            this.reg.Text = "Register!";
            this.reg.Click += new System.EventHandler(this.reg_Click);
            this.reg.MouseEnter += new System.EventHandler(this.reg_MouseEnter);
            this.reg.MouseLeave += new System.EventHandler(this.reg_MouseLeave);
            // 
            // info2
            // 
            this.info2.AutoSize = true;
            this.info2.Font = new System.Drawing.Font("Bradley Hand ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info2.ForeColor = System.Drawing.Color.White;
            this.info2.Location = new System.Drawing.Point(31, 249);
            this.info2.Name = "info2";
            this.info2.Size = new System.Drawing.Size(183, 19);
            this.info2.TabIndex = 4;
            this.info2.Text = "Don\'t have any account?";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Bradley Hand ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.ForeColor = System.Drawing.Color.White;
            this.info.Location = new System.Drawing.Point(43, 25);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(261, 19);
            this.info.TabIndex = 4;
            this.info.Text = "Sign in with your ISP id number.";
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Font = new System.Drawing.Font("BankGothic Md BT", 12F);
            this.back.ForeColor = System.Drawing.SystemColors.Window;
            this.back.Location = new System.Drawing.Point(120, 287);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(51, 17);
            this.back.TabIndex = 1;
            this.back.Text = "Back";
            this.back.Click += new System.EventHandler(this.back_Click);
            this.back.MouseEnter += new System.EventHandler(this.back_MouseEnter);
            this.back.MouseLeave += new System.EventHandler(this.back_MouseLeave);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("BankGothic Md BT", 18F);
            this.button1.Location = new System.Drawing.Point(87, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "Log In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // usernamebox
            // 
            this.usernamebox.Font = new System.Drawing.Font("Courier New", 12F);
            this.usernamebox.Location = new System.Drawing.Point(131, 71);
            this.usernamebox.MaxLength = 20;
            this.usernamebox.Name = "usernamebox";
            this.usernamebox.Size = new System.Drawing.Size(173, 26);
            this.usernamebox.TabIndex = 2;
            // 
            // passwordbox
            // 
            this.passwordbox.AccessibleDescription = "";
            this.passwordbox.AccessibleName = "";
            this.passwordbox.Font = new System.Drawing.Font("Courier New", 12F);
            this.passwordbox.Location = new System.Drawing.Point(131, 123);
            this.passwordbox.MaxLength = 18;
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.Size = new System.Drawing.Size(173, 26);
            this.passwordbox.TabIndex = 2;
            this.passwordbox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("BankGothic Md BT", 8F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(184, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Show Password";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(290, 152);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // user_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 446);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "user_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "user_login";
            this.Load += new System.EventHandler(this.user_login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox passwordbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox usernamebox;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label reg;
        private System.Windows.Forms.Label info2;
        private System.Windows.Forms.Label back;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
    }
}