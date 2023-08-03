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
    public partial class UpdatInfo : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\project\Blood Bank Management System\Blood Bank Management System\Database1.mdf;Integrated Security=True");
        public UpdatInfo()
        {
            InitializeComponent();
        }

        private void UpdatInfo_Load(object sender, EventArgs e)
        {
            bindcmb();
        }
        public void bindcmb()
        {
            try
            {
                con.Open();
                string sel = "select Id from Bloodtbl";
                SqlCommand cmd = new SqlCommand(sel, con);
                SqlDataReader read = cmd.ExecuteReader();
                cmbid.Items.Add("---select---");
                while (read.Read())
                {
                    cmbid.Items.Add(read[0].ToString());
                }
                con.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString(), "Blood Bank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbid.SelectedIndex != 0)
                {
                    string id = cmbid.SelectedItem.ToString();
                    string str = "select * from Bloodtbl where Id=" + id;
                    SqlDataAdapter da = new SqlDataAdapter(str, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    nmtxt.Text = dt.Rows[0][1].ToString();
                    agetxt.Text = dt.Rows[0][2].ToString();
                    wgttxt.Text = dt.Rows[0][3].ToString();
                    bgcmb.SelectedItem = dt.Rows[0][4].ToString();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString(), "Blood Bank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnins_Click(object sender, EventArgs e)
        {
            if (bgcmb.SelectedIndex != 0)
            {
                con.Open();
                string upd = "update Bloodtbl set name='" + nmtxt.Text + "',age='" + agetxt.Text + "',weight='" + wgttxt.Text + "',bloodgrp='" + bgcmb.SelectedItem.ToString() + "' where Id=" + cmbid.SelectedItem.ToString() ;
                SqlCommand cmd = new SqlCommand(upd, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Information updated successfully...", "Blood Bank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                clear();
            }
        }
        
        private void clear()
        {
            nmtxt.Clear();
            agetxt.Clear();
            wgttxt.Clear();
            bgcmb.SelectedIndex = 0;
            cmbid.SelectedIndex = 0;
        }

        private void nmtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Convert.ToInt32(e.KeyChar) >= 65 && Convert.ToInt32(e.KeyChar) <= 90) || (Convert.ToInt32(e.KeyChar) == 95)
                || (Convert.ToInt32(e.KeyChar) >= 97 && Convert.ToInt32(e.KeyChar) <= 122) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void agetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Convert.ToInt32(e.KeyChar) >= 48 && Convert.ToInt32(e.KeyChar) <= 57) || (Convert.ToInt32(e.KeyChar) == 8))

                e.Handled = false;
            else
                e.Handled = true;
        }

        private void wgttxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Convert.ToInt32(e.KeyChar) >= 48 && Convert.ToInt32(e.KeyChar) <= 57) || (Convert.ToInt32(e.KeyChar) == 8))

                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
