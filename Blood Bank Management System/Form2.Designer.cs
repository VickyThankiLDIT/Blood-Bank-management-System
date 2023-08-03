namespace Blood_Bank_Management_System
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.rctpwd = new System.Windows.Forms.Label();
            this.emllb = new System.Windows.Forms.Label();
            this.nwpwd = new System.Windows.Forms.Label();
            this.cnpwd = new System.Windows.Forms.Label();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.txtnew = new System.Windows.Forms.TextBox();
            this.txtcnf = new System.Windows.Forms.TextBox();
            this.subtn = new System.Windows.Forms.Button();
            this.clrbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.rctpwd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 100);
            this.panel1.TabIndex = 0;
            // 
            // rctpwd
            // 
            this.rctpwd.AutoSize = true;
            this.rctpwd.Font = new System.Drawing.Font("Microsoft YaHei UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rctpwd.ForeColor = System.Drawing.Color.Maroon;
            this.rctpwd.Location = new System.Drawing.Point(359, 26);
            this.rctpwd.Name = "rctpwd";
            this.rctpwd.Size = new System.Drawing.Size(373, 58);
            this.rctpwd.TabIndex = 0;
            this.rctpwd.Text = "Reset Password";
            // 
            // emllb
            // 
            this.emllb.AutoSize = true;
            this.emllb.BackColor = System.Drawing.Color.Transparent;
            this.emllb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emllb.ForeColor = System.Drawing.Color.Maroon;
            this.emllb.Location = new System.Drawing.Point(322, 169);
            this.emllb.Name = "emllb";
            this.emllb.Size = new System.Drawing.Size(149, 20);
            this.emllb.TabIndex = 1;
            this.emllb.Text = "Email Address  :";
            // 
            // nwpwd
            // 
            this.nwpwd.AutoSize = true;
            this.nwpwd.BackColor = System.Drawing.Color.Transparent;
            this.nwpwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nwpwd.ForeColor = System.Drawing.Color.Maroon;
            this.nwpwd.Location = new System.Drawing.Point(322, 214);
            this.nwpwd.Name = "nwpwd";
            this.nwpwd.Size = new System.Drawing.Size(145, 20);
            this.nwpwd.TabIndex = 2;
            this.nwpwd.Text = "New Password :";
            // 
            // cnpwd
            // 
            this.cnpwd.AutoSize = true;
            this.cnpwd.BackColor = System.Drawing.Color.Transparent;
            this.cnpwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnpwd.ForeColor = System.Drawing.Color.Maroon;
            this.cnpwd.Location = new System.Drawing.Point(322, 264);
            this.cnpwd.Name = "cnpwd";
            this.cnpwd.Size = new System.Drawing.Size(175, 20);
            this.cnpwd.TabIndex = 4;
            this.cnpwd.Text = "Confirm Password :";
            // 
            // txtmail
            // 
            this.txtmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtmail.Location = new System.Drawing.Point(521, 166);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(227, 27);
            this.txtmail.TabIndex = 5;
            this.txtmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmail_KeyPress);
            // 
            // txtnew
            // 
            this.txtnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtnew.Location = new System.Drawing.Point(525, 214);
            this.txtnew.Name = "txtnew";
            this.txtnew.Size = new System.Drawing.Size(227, 27);
            this.txtnew.TabIndex = 6;
            this.txtnew.UseSystemPasswordChar = true;
            this.txtnew.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnew_KeyPress);
            // 
            // txtcnf
            // 
            this.txtcnf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcnf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtcnf.Location = new System.Drawing.Point(525, 264);
            this.txtcnf.Name = "txtcnf";
            this.txtcnf.Size = new System.Drawing.Size(223, 27);
            this.txtcnf.TabIndex = 7;
            this.txtcnf.UseSystemPasswordChar = true;
            this.txtcnf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcnf_KeyPress);
            // 
            // subtn
            // 
            this.subtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtn.ForeColor = System.Drawing.Color.Maroon;
            this.subtn.Location = new System.Drawing.Point(414, 347);
            this.subtn.Name = "subtn";
            this.subtn.Size = new System.Drawing.Size(106, 33);
            this.subtn.TabIndex = 8;
            this.subtn.Text = "&Submit";
            this.subtn.UseVisualStyleBackColor = true;
            this.subtn.Click += new System.EventHandler(this.subtn_Click);
            // 
            // clrbtn
            // 
            this.clrbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clrbtn.ForeColor = System.Drawing.Color.Maroon;
            this.clrbtn.Location = new System.Drawing.Point(564, 347);
            this.clrbtn.Name = "clrbtn";
            this.clrbtn.Size = new System.Drawing.Size(106, 33);
            this.clrbtn.TabIndex = 9;
            this.clrbtn.Text = "&Clear";
            this.clrbtn.UseVisualStyleBackColor = true;
            this.clrbtn.Click += new System.EventHandler(this.clrbtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Blood_Bank_Management_System.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(947, 543);
            this.Controls.Add(this.clrbtn);
            this.Controls.Add(this.subtn);
            this.Controls.Add(this.txtcnf);
            this.Controls.Add(this.txtnew);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.cnpwd);
            this.Controls.Add(this.nwpwd);
            this.Controls.Add(this.emllb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label rctpwd;
        private System.Windows.Forms.Label emllb;
        private System.Windows.Forms.Label nwpwd;
        private System.Windows.Forms.Label cnpwd;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.TextBox txtnew;
        private System.Windows.Forms.TextBox txtcnf;
        private System.Windows.Forms.Button subtn;
        private System.Windows.Forms.Button clrbtn;
    }
}