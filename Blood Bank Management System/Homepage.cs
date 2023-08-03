using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank_Management_System
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void show_info_Click(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            pnlmain.Controls.Clear();
            this.TopLevel = true;
            addblood cap = new addblood();
            cap.TopLevel = false;
            cap.Height = pnlmain.Height;
            cap.Width = pnlmain.Width;
            pnlmain.Controls.Add(cap);
            cap.Show();
        }

        private void getbtn_Click(object sender, EventArgs e)
        {
            pnlmain.Controls.Clear();
            this.TopLevel = true;
            getblood cap = new getblood();
            cap.TopLevel = false;
            cap.Height = pnlmain.Height;
            cap.Width = pnlmain.Width;
            pnlmain.Controls.Add(cap);
            cap.Show();
        }
        private void hpagebtn_Click(object sender, EventArgs e)
        {
            pnlmain.Controls.Clear();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void show_info_Click_1(object sender, EventArgs e)
        {
            pnlmain.Controls.Clear();
            this.TopLevel = true;
            showinfo cap = new showinfo();
            cap.TopLevel = false;
            cap.Height = pnlmain.Height;
            cap.Width = pnlmain.Width;
            pnlmain.Controls.Add(cap);
            cap.Show();
        }

        private void Upd_info_Click(object sender, EventArgs e)
        {
            pnlmain.Controls.Clear();
            this.TopLevel = true;
            UpdatInfo cap = new UpdatInfo();
            cap.TopLevel = false;
            cap.Height = pnlmain.Height;
            cap.Width = pnlmain.Width;
            pnlmain.Controls.Add(cap);
            cap.Show();
        }

        private void chngpwd_Click(object sender, EventArgs e)
        {
            pnlmain.Controls.Clear();
            this.TopLevel = true;
            changePassowrd cap = new changePassowrd();
            cap.TopLevel = false;
            cap.Height = pnlmain.Height;
            cap.Width = pnlmain.Width;
            pnlmain.Controls.Add(cap);
            cap.Show(); 
        }

        private void srchbtn_Click(object sender, EventArgs e)
        {
            pnlmain.Controls.Clear();
            this.TopLevel = true;
            Search cap = new Search();
            cap.TopLevel = false;
            cap.Height = pnlmain.Height;
            cap.Width = pnlmain.Width;
            pnlmain.Controls.Add(cap);
            cap.Show();
        }
        private void About_Click(object sender, EventArgs e)
        {
            pnlmain.Controls.Clear();
            this.TopLevel = true;
            Aboutus cap = new Aboutus();
            cap.TopLevel = false;
            cap.Height = pnlmain.Height;
            cap.Width = pnlmain.Width;
            pnlmain.Controls.Add(cap);
            cap.Show();
        }

        private void Homepage_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }
    }
}
