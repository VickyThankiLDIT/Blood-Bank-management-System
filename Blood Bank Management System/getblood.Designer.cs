namespace Blood_Bank_Management_System
{
    partial class getblood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(getblood));
            this.pnlgetbld = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gtnm = new System.Windows.Forms.Label();
            this.gtqty = new System.Windows.Forms.Label();
            this.gtrsn = new System.Windows.Forms.Label();
            this.gtcity = new System.Windows.Forms.Label();
            this.gtcont = new System.Windows.Forms.Label();
            this.txtnm = new System.Windows.Forms.TextBox();
            this.txtqn = new System.Windows.Forms.TextBox();
            this.txtrsn = new System.Windows.Forms.TextBox();
            this.txtcnt = new System.Windows.Forms.TextBox();
            this.cmbcity = new System.Windows.Forms.ComboBox();
            this.clrbtn = new System.Windows.Forms.Button();
            this.btncnf = new System.Windows.Forms.Button();
            this.lblbg = new System.Windows.Forms.Label();
            this.cmbbg = new System.Windows.Forms.ComboBox();
            this.lblav = new System.Windows.Forms.Label();
            this.txtav = new System.Windows.Forms.TextBox();
            this.pnlgetbld.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlgetbld
            // 
            this.pnlgetbld.BackColor = System.Drawing.Color.Transparent;
            this.pnlgetbld.Controls.Add(this.label1);
            this.pnlgetbld.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlgetbld.Location = new System.Drawing.Point(0, 0);
            this.pnlgetbld.Name = "pnlgetbld";
            this.pnlgetbld.Size = new System.Drawing.Size(1453, 181);
            this.pnlgetbld.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(821, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 58);
            this.label1.TabIndex = 16;
            this.label1.Text = "Get Blood Information";
            // 
            // gtnm
            // 
            this.gtnm.AutoSize = true;
            this.gtnm.BackColor = System.Drawing.Color.Transparent;
            this.gtnm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtnm.Location = new System.Drawing.Point(885, 225);
            this.gtnm.Name = "gtnm";
            this.gtnm.Size = new System.Drawing.Size(103, 20);
            this.gtnm.TabIndex = 1;
            this.gtnm.Text = "UserName:";
            // 
            // gtqty
            // 
            this.gtqty.AutoSize = true;
            this.gtqty.BackColor = System.Drawing.Color.Transparent;
            this.gtqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtqty.Location = new System.Drawing.Point(888, 342);
            this.gtqty.Name = "gtqty";
            this.gtqty.Size = new System.Drawing.Size(85, 20);
            this.gtqty.TabIndex = 2;
            this.gtqty.Text = "Quantity:";
            // 
            // gtrsn
            // 
            this.gtrsn.AutoSize = true;
            this.gtrsn.BackColor = System.Drawing.Color.Transparent;
            this.gtrsn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtrsn.Location = new System.Drawing.Point(888, 513);
            this.gtrsn.Name = "gtrsn";
            this.gtrsn.Size = new System.Drawing.Size(78, 20);
            this.gtrsn.TabIndex = 3;
            this.gtrsn.Text = "Reason:";
            // 
            // gtcity
            // 
            this.gtcity.AutoSize = true;
            this.gtcity.BackColor = System.Drawing.Color.Transparent;
            this.gtcity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtcity.Location = new System.Drawing.Point(902, 455);
            this.gtcity.Name = "gtcity";
            this.gtcity.Size = new System.Drawing.Size(48, 20);
            this.gtcity.TabIndex = 4;
            this.gtcity.Text = "City:";
            // 
            // gtcont
            // 
            this.gtcont.AutoSize = true;
            this.gtcont.BackColor = System.Drawing.Color.Transparent;
            this.gtcont.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtcont.Location = new System.Drawing.Point(885, 394);
            this.gtcont.Name = "gtcont";
            this.gtcont.Size = new System.Drawing.Size(80, 20);
            this.gtcont.TabIndex = 5;
            this.gtcont.Text = "Contact:";
            // 
            // txtnm
            // 
            this.txtnm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnm.Location = new System.Drawing.Point(1041, 219);
            this.txtnm.Name = "txtnm";
            this.txtnm.Size = new System.Drawing.Size(246, 27);
            this.txtnm.TabIndex = 6;
            this.txtnm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnm_KeyPress);
            // 
            // txtqn
            // 
            this.txtqn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqn.Location = new System.Drawing.Point(1041, 339);
            this.txtqn.MaxLength = 3;
            this.txtqn.Name = "txtqn";
            this.txtqn.Size = new System.Drawing.Size(246, 27);
            this.txtqn.TabIndex = 7;
            this.txtqn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqn_KeyPress);
            // 
            // txtrsn
            // 
            this.txtrsn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrsn.Location = new System.Drawing.Point(1041, 509);
            this.txtrsn.Multiline = true;
            this.txtrsn.Name = "txtrsn";
            this.txtrsn.Size = new System.Drawing.Size(246, 59);
            this.txtrsn.TabIndex = 8;
            this.txtrsn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtrsn_KeyPress);
            // 
            // txtcnt
            // 
            this.txtcnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcnt.Location = new System.Drawing.Point(1041, 394);
            this.txtcnt.MaxLength = 10;
            this.txtcnt.Name = "txtcnt";
            this.txtcnt.Size = new System.Drawing.Size(246, 27);
            this.txtcnt.TabIndex = 10;
            this.txtcnt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcnt_KeyPress);
            // 
            // cmbcity
            // 
            this.cmbcity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcity.FormattingEnabled = true;
            this.cmbcity.Items.AddRange(new object[] {
            "None",
            "Ahemdabad",
            "Pune",
            "Bombay",
            "Rajkot",
            "Baroda",
            "Porbandar"});
            this.cmbcity.Location = new System.Drawing.Point(1041, 452);
            this.cmbcity.Name = "cmbcity";
            this.cmbcity.Size = new System.Drawing.Size(246, 28);
            this.cmbcity.TabIndex = 11;
            // 
            // clrbtn
            // 
            this.clrbtn.BackColor = System.Drawing.Color.Transparent;
            this.clrbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clrbtn.Location = new System.Drawing.Point(1101, 651);
            this.clrbtn.Name = "clrbtn";
            this.clrbtn.Size = new System.Drawing.Size(110, 39);
            this.clrbtn.TabIndex = 15;
            this.clrbtn.Text = "&CLEAR";
            this.clrbtn.UseVisualStyleBackColor = false;
            this.clrbtn.Click += new System.EventHandler(this.clrbtn_Click);
            // 
            // btncnf
            // 
            this.btncnf.BackColor = System.Drawing.Color.Transparent;
            this.btncnf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncnf.Location = new System.Drawing.Point(932, 651);
            this.btncnf.Name = "btncnf";
            this.btncnf.Size = new System.Drawing.Size(112, 39);
            this.btncnf.TabIndex = 14;
            this.btncnf.Text = "C&ONFIRM";
            this.btncnf.UseVisualStyleBackColor = false;
            this.btncnf.Click += new System.EventHandler(this.btncnf_Click);
            // 
            // lblbg
            // 
            this.lblbg.AutoSize = true;
            this.lblbg.BackColor = System.Drawing.Color.Transparent;
            this.lblbg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbg.Location = new System.Drawing.Point(869, 278);
            this.lblbg.Name = "lblbg";
            this.lblbg.Size = new System.Drawing.Size(120, 20);
            this.lblbg.TabIndex = 17;
            this.lblbg.Text = "Blood Group:";
            // 
            // cmbbg
            // 
            this.cmbbg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbg.FormattingEnabled = true;
            this.cmbbg.Items.AddRange(new object[] {
            "None",
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.cmbbg.Location = new System.Drawing.Point(1041, 275);
            this.cmbbg.Name = "cmbbg";
            this.cmbbg.Size = new System.Drawing.Size(246, 28);
            this.cmbbg.TabIndex = 18;
            this.cmbbg.SelectedIndexChanged += new System.EventHandler(this.cmbbg_SelectedIndexChanged);
            // 
            // lblav
            // 
            this.lblav.AutoSize = true;
            this.lblav.BackColor = System.Drawing.Color.Transparent;
            this.lblav.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblav.Location = new System.Drawing.Point(885, 589);
            this.lblav.Name = "lblav";
            this.lblav.Size = new System.Drawing.Size(91, 20);
            this.lblav.TabIndex = 19;
            this.lblav.Text = "Available:";
            // 
            // txtav
            // 
            this.txtav.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtav.Location = new System.Drawing.Point(1041, 586);
            this.txtav.Name = "txtav";
            this.txtav.ReadOnly = true;
            this.txtav.Size = new System.Drawing.Size(246, 27);
            this.txtav.TabIndex = 20;
            // 
            // getblood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Blood_Bank_Management_System.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1453, 768);
            this.Controls.Add(this.txtav);
            this.Controls.Add(this.lblav);
            this.Controls.Add(this.cmbbg);
            this.Controls.Add(this.lblbg);
            this.Controls.Add(this.clrbtn);
            this.Controls.Add(this.btncnf);
            this.Controls.Add(this.cmbcity);
            this.Controls.Add(this.txtcnt);
            this.Controls.Add(this.txtrsn);
            this.Controls.Add(this.txtqn);
            this.Controls.Add(this.txtnm);
            this.Controls.Add(this.gtcont);
            this.Controls.Add(this.gtcity);
            this.Controls.Add(this.gtrsn);
            this.Controls.Add(this.gtqty);
            this.Controls.Add(this.gtnm);
            this.Controls.Add(this.pnlgetbld);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "getblood";
            this.Text = "getblood";
            this.Load += new System.EventHandler(this.getblood_Load);
            this.pnlgetbld.ResumeLayout(false);
            this.pnlgetbld.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlgetbld;
        private System.Windows.Forms.Label gtnm;
        private System.Windows.Forms.Label gtqty;
        private System.Windows.Forms.Label gtrsn;
        private System.Windows.Forms.Label gtcity;
        private System.Windows.Forms.Label gtcont;
        private System.Windows.Forms.TextBox txtnm;
        private System.Windows.Forms.TextBox txtqn;
        private System.Windows.Forms.TextBox txtrsn;
        private System.Windows.Forms.TextBox txtcnt;
        private System.Windows.Forms.ComboBox cmbcity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clrbtn;
        private System.Windows.Forms.Button btncnf;
        private System.Windows.Forms.Label lblbg;
        private System.Windows.Forms.ComboBox cmbbg;
        private System.Windows.Forms.Label lblav;
        private System.Windows.Forms.TextBox txtav;
    }
}