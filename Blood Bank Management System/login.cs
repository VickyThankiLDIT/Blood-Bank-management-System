using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Blood_Bank_Management_System
{
    public partial class login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\project\Blood Bank Management System\Blood Bank Management System\Database1.mdf;Integrated Security=True");
        public login()
        {
            InitializeComponent();
        }
        void clear()
        {
            usrtxt.Clear();
            pwdtxt.Clear();
            usrtxt.Focus();
        }
        private void login1_Click(object sender, EventArgs e)
        {
            try
            {
                if (usrtxt.Text != "" && pwdtxt.Text != "")
                {
                    SqlDataAdapter da = new SqlDataAdapter("select * from LoginTable where usr='" + usrtxt.Text + "' and pwd='" 
                        + pwdtxt.Text + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Login successfully","Blood Bank", MessageBoxButtons.OK, MessageBoxIcon.None);
                        Homepage ad = new Homepage();
                        ad.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login Failed", "Blood Bank", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Blood Bank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void pwdtxt_Enter(object sender, EventArgs e)
        {
            pwdtxt.UseSystemPasswordChar = true;
            pwdtxt.Text = "";
            pwdtxt.ForeColor = Color.Black;
        }

        private void usrtxt_Enter(object sender, EventArgs e)
        {
            usrtxt.Text = "";
            usrtxt.ForeColor = Color.Black;
        }

        private void lnkrst_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void usrtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Convert.ToInt32(e.KeyChar) >= 65 && Convert.ToInt32(e.KeyChar) <= 90) || (Convert.ToInt32(e.KeyChar) == 95)
                || (Convert.ToInt32(e.KeyChar) >= 97 && Convert.ToInt32(e.KeyChar) <= 122) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void pwdtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Convert.ToInt32(e.KeyChar) >= 65 && Convert.ToInt32(e.KeyChar) <= 90) || (Convert.ToInt32(e.KeyChar) == 64)
               || (Convert.ToInt32(e.KeyChar) >= 97 && Convert.ToInt32(e.KeyChar) <= 122) || (Convert.ToInt32(e.KeyChar) == 46)
                || (Convert.ToInt32(e.KeyChar) >= 48 && Convert.ToInt32(e.KeyChar) <= 57) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}