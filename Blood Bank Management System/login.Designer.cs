namespace Blood_Bank_Management_System
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.usrtxt = new System.Windows.Forms.MaskedTextBox();
            this.pwdtxt = new System.Windows.Forms.MaskedTextBox();
            this.login1 = new System.Windows.Forms.Button();
            this.clrbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lnkrst = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usrtxt
            // 
            this.usrtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrtxt.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.usrtxt.Location = new System.Drawing.Point(330, 285);
            this.usrtxt.Name = "usrtxt";
            this.usrtxt.Size = new System.Drawing.Size(253, 38);
            this.usrtxt.TabIndex = 2;
            this.usrtxt.Text = "Username";
            this.usrtxt.Enter += new System.EventHandler(this.usrtxt_Enter);
            this.usrtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usrtxt_KeyPress);
            // 
            // pwdtxt
            // 
            this.pwdtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdtxt.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.pwdtxt.Location = new System.Drawing.Point(330, 329);
            this.pwdtxt.Name = "pwdtxt";
            this.pwdtxt.Size = new System.Drawing.Size(253, 38);
            this.pwdtxt.TabIndex = 3;
            this.pwdtxt.Text = "Password";
            this.pwdtxt.Enter += new System.EventHandler(this.pwdtxt_Enter);
            this.pwdtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pwdtxt_KeyPress);
            // 
            // login1
            // 
            this.login1.BackColor = System.Drawing.Color.Transparent;
            this.login1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login1.ForeColor = System.Drawing.Color.Maroon;
            this.login1.Location = new System.Drawing.Point(268, 399);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(145, 40);
            this.login1.TabIndex = 5;
            this.login1.Text = "&LOGIN";
            this.login1.UseVisualStyleBackColor = false;
            this.login1.Click += new System.EventHandler(this.login1_Click);
            // 
            // clrbtn
            // 
            this.clrbtn.BackColor = System.Drawing.Color.Transparent;
            this.clrbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clrbtn.ForeColor = System.Drawing.Color.Maroon;
            this.clrbtn.Location = new System.Drawing.Point(440, 399);
            this.clrbtn.Name = "clrbtn";
            this.clrbtn.Size = new System.Drawing.Size(143, 40);
            this.clrbtn.TabIndex = 6;
            this.clrbtn.Text = "&CLEAR";
            this.clrbtn.UseVisualStyleBackColor = false;
            this.clrbtn.Click += new System.EventHandler(this.clrbtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 100);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(167, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(586, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Blood Bank Management";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Blood_Bank_Management_System.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(286, 329);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Blood_Bank_Management_System.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(286, 285);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Blood_Bank_Management_System.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(356, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lnkrst
            // 
            this.lnkrst.AutoSize = true;
            this.lnkrst.BackColor = System.Drawing.Color.Transparent;
            this.lnkrst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkrst.LinkColor = System.Drawing.Color.White;
            this.lnkrst.Location = new System.Drawing.Point(451, 370);
            this.lnkrst.Name = "lnkrst";
            this.lnkrst.Size = new System.Drawing.Size(132, 20);
            this.lnkrst.TabIndex = 11;
            this.lnkrst.TabStop = true;
            this.lnkrst.Text = "Reset Password";
            this.lnkrst.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkrst_LinkClicked);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Blood_Bank_Management_System.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(823, 550);
            this.Controls.Add(this.lnkrst);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clrbtn);
            this.Controls.Add(this.login1);
            this.Controls.Add(this.pwdtxt);
            this.Controls.Add(this.usrtxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox usrtxt;
        private System.Windows.Forms.MaskedTextBox pwdtxt;
        private System.Windows.Forms.Button login1;
        private System.Windows.Forms.Button clrbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.LinkLabel lnkrst;
    }
}