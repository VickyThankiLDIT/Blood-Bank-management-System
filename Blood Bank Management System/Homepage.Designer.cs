namespace Blood_Bank_Management_System
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.chngpwd = new System.Windows.Forms.Button();
            this.srchbtn = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.hpagebtn = new System.Windows.Forms.Button();
            this.show_info = new System.Windows.Forms.Button();
            this.Upd_info = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.getbtn = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.pnlmain = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 174);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.chngpwd);
            this.panel2.Controls.Add(this.srchbtn);
            this.panel2.Controls.Add(this.About);
            this.panel2.Controls.Add(this.hpagebtn);
            this.panel2.Controls.Add(this.show_info);
            this.panel2.Controls.Add(this.Upd_info);
            this.panel2.Controls.Add(this.addbtn);
            this.panel2.Controls.Add(this.getbtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1924, 51);
            this.panel2.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1872, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 51);
            this.button1.TabIndex = 10;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chngpwd
            // 
            this.chngpwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chngpwd.Location = new System.Drawing.Point(1073, 0);
            this.chngpwd.Name = "chngpwd";
            this.chngpwd.Size = new System.Drawing.Size(307, 51);
            this.chngpwd.TabIndex = 9;
            this.chngpwd.Text = "Change Password";
            this.chngpwd.UseVisualStyleBackColor = true;
            this.chngpwd.Click += new System.EventHandler(this.chngpwd_Click);
            // 
            // srchbtn
            // 
            this.srchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srchbtn.Location = new System.Drawing.Point(1377, 0);
            this.srchbtn.Name = "srchbtn";
            this.srchbtn.Size = new System.Drawing.Size(278, 51);
            this.srchbtn.TabIndex = 8;
            this.srchbtn.Text = "Search Information";
            this.srchbtn.UseVisualStyleBackColor = true;
            this.srchbtn.Click += new System.EventHandler(this.srchbtn_Click);
            // 
            // About
            // 
            this.About.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About.Location = new System.Drawing.Point(1651, 0);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(223, 51);
            this.About.TabIndex = 7;
            this.About.Text = "About Us";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // hpagebtn
            // 
            this.hpagebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpagebtn.Location = new System.Drawing.Point(3, 0);
            this.hpagebtn.Name = "hpagebtn";
            this.hpagebtn.Size = new System.Drawing.Size(167, 51);
            this.hpagebtn.TabIndex = 1;
            this.hpagebtn.Text = "Home";
            this.hpagebtn.UseVisualStyleBackColor = true;
            this.hpagebtn.Click += new System.EventHandler(this.hpagebtn_Click);
            // 
            // show_info
            // 
            this.show_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_info.Location = new System.Drawing.Point(571, 0);
            this.show_info.Name = "show_info";
            this.show_info.Size = new System.Drawing.Size(211, 51);
            this.show_info.TabIndex = 5;
            this.show_info.Text = "Show Information";
            this.show_info.UseVisualStyleBackColor = true;
            this.show_info.Click += new System.EventHandler(this.show_info_Click_1);
            // 
            // Upd_info
            // 
            this.Upd_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upd_info.Location = new System.Drawing.Point(780, 0);
            this.Upd_info.Name = "Upd_info";
            this.Upd_info.Size = new System.Drawing.Size(296, 51);
            this.Upd_info.TabIndex = 4;
            this.Upd_info.Text = "Update Information";
            this.Upd_info.UseVisualStyleBackColor = true;
            this.Upd_info.Click += new System.EventHandler(this.Upd_info_Click);
            // 
            // addbtn
            // 
            this.addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.Location = new System.Drawing.Point(166, 0);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(227, 51);
            this.addbtn.TabIndex = 2;
            this.addbtn.Text = "Add Donor";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // getbtn
            // 
            this.getbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getbtn.Location = new System.Drawing.Point(391, 0);
            this.getbtn.Name = "getbtn";
            this.getbtn.Size = new System.Drawing.Size(182, 51);
            this.getbtn.TabIndex = 3;
            this.getbtn.Text = "Get Donor";
            this.getbtn.UseVisualStyleBackColor = true;
            this.getbtn.Click += new System.EventHandler(this.getbtn_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.Transparent;
            this.lblname.Font = new System.Drawing.Font("Microsoft YaHei UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.Maroon;
            this.lblname.Location = new System.Drawing.Point(821, 42);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(575, 57);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Blood Bank Management";
            // 
            // pnlmain
            // 
            this.pnlmain.BackgroundImage = global::Blood_Bank_Management_System.Properties.Resources.background;
            this.pnlmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlmain.Location = new System.Drawing.Point(0, 174);
            this.pnlmain.Name = "pnlmain";
            this.pnlmain.Size = new System.Drawing.Size(1924, 809);
            this.pnlmain.TabIndex = 1;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 983);
            this.Controls.Add(this.pnlmain);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homepage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Homepage_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button hpagebtn;
        private System.Windows.Forms.Button getbtn;
        private System.Windows.Forms.Button Upd_info;
        private System.Windows.Forms.Button show_info;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button srchbtn;
        private System.Windows.Forms.Button chngpwd;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Panel pnlmain;


    }
}