namespace Blood_Bank_Management_System
{
    partial class addblood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addblood));
            this.lbl1nm = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lblwght = new System.Windows.Forms.Label();
            this.lblblodgrp = new System.Windows.Forms.Label();
            this.nmtxt = new System.Windows.Forms.TextBox();
            this.wgttxt = new System.Windows.Forms.TextBox();
            this.agetxt = new System.Windows.Forms.TextBox();
            this.bgcmb = new System.Windows.Forms.ComboBox();
            this.btnins = new System.Windows.Forms.Button();
            this.btnclr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.contxt = new System.Windows.Forms.TextBox();
            this.lblcont = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1nm
            // 
            this.lbl1nm.AutoSize = true;
            this.lbl1nm.BackColor = System.Drawing.Color.Transparent;
            this.lbl1nm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1nm.ForeColor = System.Drawing.Color.Maroon;
            this.lbl1nm.Location = new System.Drawing.Point(913, 206);
            this.lbl1nm.Name = "lbl1nm";
            this.lbl1nm.Size = new System.Drawing.Size(69, 20);
            this.lbl1nm.TabIndex = 0;
            this.lbl1nm.Text = "Name :";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.BackColor = System.Drawing.Color.Transparent;
            this.lblage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.ForeColor = System.Drawing.Color.Maroon;
            this.lblage.Location = new System.Drawing.Point(923, 252);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(47, 20);
            this.lblage.TabIndex = 1;
            this.lblage.Text = "Age:";
            // 
            // lblwght
            // 
            this.lblwght.AutoSize = true;
            this.lblwght.BackColor = System.Drawing.Color.Transparent;
            this.lblwght.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwght.ForeColor = System.Drawing.Color.Maroon;
            this.lblwght.Location = new System.Drawing.Point(913, 306);
            this.lblwght.Name = "lblwght";
            this.lblwght.Size = new System.Drawing.Size(73, 20);
            this.lblwght.TabIndex = 2;
            this.lblwght.Text = "Weight:";
            // 
            // lblblodgrp
            // 
            this.lblblodgrp.AutoSize = true;
            this.lblblodgrp.BackColor = System.Drawing.Color.Transparent;
            this.lblblodgrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblblodgrp.ForeColor = System.Drawing.Color.Maroon;
            this.lblblodgrp.Location = new System.Drawing.Point(893, 415);
            this.lblblodgrp.Name = "lblblodgrp";
            this.lblblodgrp.Size = new System.Drawing.Size(114, 20);
            this.lblblodgrp.TabIndex = 3;
            this.lblblodgrp.Text = "BloodGroup:";
            // 
            // nmtxt
            // 
            this.nmtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmtxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.nmtxt.Location = new System.Drawing.Point(1045, 206);
            this.nmtxt.MaxLength = 10;
            this.nmtxt.Name = "nmtxt";
            this.nmtxt.Size = new System.Drawing.Size(174, 27);
            this.nmtxt.TabIndex = 0;
            this.nmtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nmtxt_KeyPress);
            // 
            // wgttxt
            // 
            this.wgttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wgttxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.wgttxt.Location = new System.Drawing.Point(1045, 304);
            this.wgttxt.MaxLength = 2;
            this.wgttxt.Name = "wgttxt";
            this.wgttxt.Size = new System.Drawing.Size(174, 27);
            this.wgttxt.TabIndex = 2;
            this.wgttxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.wgttxt_KeyPress);
            // 
            // agetxt
            // 
            this.agetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agetxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.agetxt.Location = new System.Drawing.Point(1045, 250);
            this.agetxt.MaxLength = 2;
            this.agetxt.Name = "agetxt";
            this.agetxt.Size = new System.Drawing.Size(174, 27);
            this.agetxt.TabIndex = 1;
            this.agetxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.agetxt_KeyPress);
            // 
            // bgcmb
            // 
            this.bgcmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bgcmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgcmb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bgcmb.FormattingEnabled = true;
            this.bgcmb.Items.AddRange(new object[] {
            "None",
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.bgcmb.Location = new System.Drawing.Point(1045, 411);
            this.bgcmb.Name = "bgcmb";
            this.bgcmb.Size = new System.Drawing.Size(174, 28);
            this.bgcmb.TabIndex = 3;
            // 
            // btnins
            // 
            this.btnins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnins.ForeColor = System.Drawing.Color.Maroon;
            this.btnins.Location = new System.Drawing.Point(897, 482);
            this.btnins.Name = "btnins";
            this.btnins.Size = new System.Drawing.Size(123, 31);
            this.btnins.TabIndex = 4;
            this.btnins.Text = "&INSERT";
            this.btnins.UseVisualStyleBackColor = true;
            this.btnins.Click += new System.EventHandler(this.btnins_Click);
            // 
            // btnclr
            // 
            this.btnclr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclr.ForeColor = System.Drawing.Color.Maroon;
            this.btnclr.Location = new System.Drawing.Point(1082, 482);
            this.btnclr.Name = "btnclr";
            this.btnclr.Size = new System.Drawing.Size(116, 31);
            this.btnclr.TabIndex = 5;
            this.btnclr.Text = "&CLEAR";
            this.btnclr.UseVisualStyleBackColor = true;
            this.btnclr.Click += new System.EventHandler(this.btnclr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(821, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(551, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "DONOR INFORMATION";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = global::Blood_Bank_Management_System.Properties.Resources.background;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.contxt);
            this.panel2.Controls.Add(this.lblcont);
            this.panel2.Controls.Add(this.lblage);
            this.panel2.Controls.Add(this.lbl1nm);
            this.panel2.Controls.Add(this.btnclr);
            this.panel2.Controls.Add(this.lblwght);
            this.panel2.Controls.Add(this.btnins);
            this.panel2.Controls.Add(this.lblblodgrp);
            this.panel2.Controls.Add(this.bgcmb);
            this.panel2.Controls.Add(this.nmtxt);
            this.panel2.Controls.Add(this.agetxt);
            this.panel2.Controls.Add(this.wgttxt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1811, 847);
            this.panel2.TabIndex = 13;
            // 
            // contxt
            // 
            this.contxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.contxt.Location = new System.Drawing.Point(1045, 356);
            this.contxt.MaxLength = 10;
            this.contxt.Name = "contxt";
            this.contxt.Size = new System.Drawing.Size(174, 27);
            this.contxt.TabIndex = 14;
            this.contxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contxt_KeyPress);
            // 
            // lblcont
            // 
            this.lblcont.AutoSize = true;
            this.lblcont.BackColor = System.Drawing.Color.Transparent;
            this.lblcont.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcont.ForeColor = System.Drawing.Color.Maroon;
            this.lblcont.Location = new System.Drawing.Point(913, 358);
            this.lblcont.Name = "lblcont";
            this.lblcont.Size = new System.Drawing.Size(80, 20);
            this.lblcont.TabIndex = 13;
            this.lblcont.Text = "Contact:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1811, 171);
            this.panel1.TabIndex = 15;
            // 
            // addblood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1811, 847);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addblood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addblood";
            this.Load += new System.EventHandler(this.addblood_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl1nm;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblwght;
        private System.Windows.Forms.Label lblblodgrp;
        private System.Windows.Forms.TextBox nmtxt;
        private System.Windows.Forms.TextBox wgttxt;
        private System.Windows.Forms.TextBox agetxt;
        private System.Windows.Forms.ComboBox bgcmb;
        private System.Windows.Forms.Button btnins;
        private System.Windows.Forms.Button btnclr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox contxt;
        private System.Windows.Forms.Label lblcont;
        private System.Windows.Forms.Panel panel1;
    }
}