namespace Blood_Bank_Management_System
{
    partial class UpdatInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatInfo));
            this.lblage = new System.Windows.Forms.Label();
            this.lbl1nm = new System.Windows.Forms.Label();
            this.btnclr = new System.Windows.Forms.Button();
            this.lblwght = new System.Windows.Forms.Label();
            this.btnins = new System.Windows.Forms.Button();
            this.lblblodgrp = new System.Windows.Forms.Label();
            this.bgcmb = new System.Windows.Forms.ComboBox();
            this.nmtxt = new System.Windows.Forms.TextBox();
            this.agetxt = new System.Windows.Forms.TextBox();
            this.wgttxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbid = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblh = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.BackColor = System.Drawing.Color.Transparent;
            this.lblage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.ForeColor = System.Drawing.Color.Maroon;
            this.lblage.Location = new System.Drawing.Point(870, 296);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(47, 20);
            this.lblage.TabIndex = 8;
            this.lblage.Text = "Age:";
            // 
            // lbl1nm
            // 
            this.lbl1nm.AutoSize = true;
            this.lbl1nm.BackColor = System.Drawing.Color.Transparent;
            this.lbl1nm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1nm.ForeColor = System.Drawing.Color.Maroon;
            this.lbl1nm.Location = new System.Drawing.Point(870, 252);
            this.lbl1nm.Name = "lbl1nm";
            this.lbl1nm.Size = new System.Drawing.Size(69, 20);
            this.lbl1nm.TabIndex = 6;
            this.lbl1nm.Text = "Name :";
            // 
            // btnclr
            // 
            this.btnclr.BackColor = System.Drawing.Color.Transparent;
            this.btnclr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclr.ForeColor = System.Drawing.Color.Maroon;
            this.btnclr.Location = new System.Drawing.Point(1019, 494);
            this.btnclr.Name = "btnclr";
            this.btnclr.Size = new System.Drawing.Size(116, 31);
            this.btnclr.TabIndex = 15;
            this.btnclr.Text = "&CLEAR";
            this.btnclr.UseVisualStyleBackColor = false;
            // 
            // lblwght
            // 
            this.lblwght.AutoSize = true;
            this.lblwght.BackColor = System.Drawing.Color.Transparent;
            this.lblwght.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwght.ForeColor = System.Drawing.Color.Maroon;
            this.lblwght.Location = new System.Drawing.Point(870, 348);
            this.lblwght.Name = "lblwght";
            this.lblwght.Size = new System.Drawing.Size(73, 20);
            this.lblwght.TabIndex = 10;
            this.lblwght.Text = "Weight:";
            // 
            // btnins
            // 
            this.btnins.BackColor = System.Drawing.Color.Transparent;
            this.btnins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnins.ForeColor = System.Drawing.Color.Maroon;
            this.btnins.Location = new System.Drawing.Point(874, 494);
            this.btnins.Name = "btnins";
            this.btnins.Size = new System.Drawing.Size(123, 31);
            this.btnins.TabIndex = 14;
            this.btnins.Text = "&Update";
            this.btnins.UseVisualStyleBackColor = false;
            this.btnins.Click += new System.EventHandler(this.btnins_Click);
            // 
            // lblblodgrp
            // 
            this.lblblodgrp.AutoSize = true;
            this.lblblodgrp.BackColor = System.Drawing.Color.Transparent;
            this.lblblodgrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblblodgrp.ForeColor = System.Drawing.Color.Maroon;
            this.lblblodgrp.Location = new System.Drawing.Point(870, 405);
            this.lblblodgrp.Name = "lblblodgrp";
            this.lblblodgrp.Size = new System.Drawing.Size(114, 20);
            this.lblblodgrp.TabIndex = 12;
            this.lblblodgrp.Text = "BloodGroup:";
            // 
            // bgcmb
            // 
            this.bgcmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bgcmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.bgcmb.Location = new System.Drawing.Point(1009, 401);
            this.bgcmb.Name = "bgcmb";
            this.bgcmb.Size = new System.Drawing.Size(174, 28);
            this.bgcmb.TabIndex = 13;
            // 
            // nmtxt
            // 
            this.nmtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmtxt.Location = new System.Drawing.Point(1009, 250);
            this.nmtxt.Name = "nmtxt";
            this.nmtxt.Size = new System.Drawing.Size(174, 27);
            this.nmtxt.TabIndex = 7;
            this.nmtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nmtxt_KeyPress);
            // 
            // agetxt
            // 
            this.agetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agetxt.Location = new System.Drawing.Point(1009, 294);
            this.agetxt.Name = "agetxt";
            this.agetxt.Size = new System.Drawing.Size(174, 27);
            this.agetxt.TabIndex = 9;
            this.agetxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.agetxt_KeyPress);
            // 
            // wgttxt
            // 
            this.wgttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wgttxt.Location = new System.Drawing.Point(1009, 348);
            this.wgttxt.Name = "wgttxt";
            this.wgttxt.Size = new System.Drawing.Size(174, 27);
            this.wgttxt.TabIndex = 11;
            this.wgttxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.wgttxt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(870, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID:";
            // 
            // cmbid
            // 
            this.cmbid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbid.FormattingEnabled = true;
            this.cmbid.Location = new System.Drawing.Point(1009, 199);
            this.cmbid.Name = "cmbid";
            this.cmbid.Size = new System.Drawing.Size(174, 28);
            this.cmbid.TabIndex = 17;
            this.cmbid.SelectedIndexChanged += new System.EventHandler(this.cmbid_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1304, 175);
            this.panel1.TabIndex = 18;
            // 
            // lblh
            // 
            this.lblh.AutoSize = true;
            this.lblh.Font = new System.Drawing.Font("Microsoft YaHei UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblh.ForeColor = System.Drawing.Color.Maroon;
            this.lblh.Location = new System.Drawing.Point(821, 42);
            this.lblh.Name = "lblh";
            this.lblh.Size = new System.Drawing.Size(456, 57);
            this.lblh.TabIndex = 0;
            this.lblh.Text = "Update Information";
            // 
            // UpdatInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Blood_Bank_Management_System.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1304, 641);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbid);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.lbl1nm);
            this.Controls.Add(this.btnclr);
            this.Controls.Add(this.lblwght);
            this.Controls.Add(this.btnins);
            this.Controls.Add(this.lblblodgrp);
            this.Controls.Add(this.bgcmb);
            this.Controls.Add(this.nmtxt);
            this.Controls.Add(this.agetxt);
            this.Controls.Add(this.wgttxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdatInfo";
            this.Text = "UpdatInfo";
            this.Load += new System.EventHandler(this.UpdatInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lbl1nm;
        private System.Windows.Forms.Button btnclr;
        private System.Windows.Forms.Label lblwght;
        private System.Windows.Forms.Button btnins;
        private System.Windows.Forms.Label lblblodgrp;
        private System.Windows.Forms.ComboBox bgcmb;
        private System.Windows.Forms.TextBox nmtxt;
        private System.Windows.Forms.TextBox agetxt;
        private System.Windows.Forms.TextBox wgttxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblh;
    }
}