using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank_Management_System
{
    public partial class Form2 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\project\Blood Bank Management System\Blood Bank Management System\Database1.mdf;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }
        public void Clear()
        {
            txtmail.Clear();
            txtnew.Clear();
            txtcnf.Clear();
            txtmail.Focus();
        }
        private void subtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmail.Text != "" && txtnew.Text != "" && txtcnf.Text != "")
                {
                    SqlDataAdapter da = new SqlDataAdapter("select * from LoginTable where mail='" + txtmail.Text + "'", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        conn.Open();
                        string str = "update LoginTable set pwd='" + txtnew.Text + "' where mail='" + txtmail.Text + "'";
                        SqlCommand cmd = new SqlCommand(str, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Password has been changed...", "Blood Bank", MessageBoxButtons.OK);
                        conn.Close();
                        this.Hide();
                        login l = new login();
                        l.Show();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Email...", "Blood Bank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter password...", "Blood Bank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString(), "Blood Bank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Convert.ToInt32(e.KeyChar) >= 65 && Convert.ToInt32(e.KeyChar) <= 90) || (Convert.ToInt32(e.KeyChar) == 64)
               || (Convert.ToInt32(e.KeyChar) >= 97 && Convert.ToInt32(e.KeyChar) <= 122) || (Convert.ToInt32(e.KeyChar) == 46)
                || (Convert.ToInt32(e.KeyChar) >= 48 && Convert.ToInt32(e.KeyChar) <= 57)||(Convert.ToInt32(e.KeyChar)==8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtnew_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Convert.ToInt32(e.KeyChar) >= 65 && Convert.ToInt32(e.KeyChar) <= 90) || (Convert.ToInt32(e.KeyChar) == 64)
               || (Convert.ToInt32(e.KeyChar) >= 97 && Convert.ToInt32(e.KeyChar) <= 122) || (Convert.ToInt32(e.KeyChar) == 46)
                || (Convert.ToInt32(e.KeyChar) >= 48 && Convert.ToInt32(e.KeyChar) <= 57) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtcnf_KeyPress(object sender, KeyPressEventArgs e)
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
            Clear();
        }

        
    }
}
