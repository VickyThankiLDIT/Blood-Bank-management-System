namespace Blood_Bank_Management_System
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.srchcmb = new System.Windows.Forms.ComboBox();
            this.srchpnl = new System.Windows.Forms.Panel();
            this.pnlbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnpdf = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.srchpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // srchcmb
            // 
            this.srchcmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.srchcmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srchcmb.FormattingEnabled = true;
            this.srchcmb.Items.AddRange(new object[] {
            "None",
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.srchcmb.Location = new System.Drawing.Point(762, 196);
            this.srchcmb.Name = "srchcmb";
            this.srchcmb.Size = new System.Drawing.Size(138, 28);
            this.srchcmb.TabIndex = 0;
            this.srchcmb.SelectedIndexChanged += new System.EventHandler(this.srchcmb_SelectedIndexChanged);
            // 
            // srchpnl
            // 
            this.srchpnl.BackColor = System.Drawing.Color.Transparent;
            this.srchpnl.Controls.Add(this.pnlbl);
            this.srchpnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.srchpnl.Location = new System.Drawing.Point(0, 0);
            this.srchpnl.Name = "srchpnl";
            this.srchpnl.Size = new System.Drawing.Size(1389, 134);
            this.srchpnl.TabIndex = 2;
            this.srchpnl.Paint += new System.Windows.Forms.PaintEventHandler(this.srchpnl_Paint);
            // 
            // pnlbl
            // 
            this.pnlbl.AutoSize = true;
            this.pnlbl.BackColor = System.Drawing.Color.Transparent;
            this.pnlbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlbl.ForeColor = System.Drawing.Color.Maroon;
            this.pnlbl.Location = new System.Drawing.Point(884, 46);
            this.pnlbl.Name = "pnlbl";
            this.pnlbl.Size = new System.Drawing.Size(202, 57);
            this.pnlbl.TabIndex = 0;
            this.pnlbl.Text = "SEARCH";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(651, 257);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(726, 333);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnpdf
            // 
            this.btnpdf.BackColor = System.Drawing.Color.Transparent;
            this.btnpdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpdf.ForeColor = System.Drawing.Color.Maroon;
            this.btnpdf.Location = new System.Drawing.Point(1291, 195);
            this.btnpdf.Name = "btnpdf";
            this.btnpdf.Size = new System.Drawing.Size(86, 28);
            this.btnpdf.TabIndex = 19;
            this.btnpdf.Text = "PDF";
            this.btnpdf.UseVisualStyleBackColor = false;
            this.btnpdf.Click += new System.EventHandler(this.btnpdf_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(658, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Search:";
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Blood_Bank_Management_System.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1389, 778);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnpdf);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.srchpnl);
            this.Controls.Add(this.srchcmb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            this.srchpnl.ResumeLayout(false);
            this.srchpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox srchcmb;
        private System.Windows.Forms.Panel srchpnl;
        private System.Windows.Forms.Label pnlbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnpdf;
        private System.Windows.Forms.Label label1;
    }
}