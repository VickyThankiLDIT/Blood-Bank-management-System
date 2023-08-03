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
    public partial class addblood : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\project\Blood Bank Management System\Blood Bank Management System\Database1.mdf;Integrated Security=True");

        public addblood()
        {
            InitializeComponent();
            
        }
         
        private void btnins_Click(object sender, EventArgs e)
        {
            try
            {
                if (nmtxt.Text != "" && agetxt.Text != "" && wgttxt.Text != "" && bgcmb.SelectedItem.ToString() != "---select---")
                {
                    if (Convert.ToInt16(agetxt.Text) > 18 && Convert.ToInt16(agetxt.Text) <= 75&&Convert.ToInt16(wgttxt.Text)>=45)
                    {
                        string str = DateTime.Now.ToString("dd-MM-yyyy");
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("insert into bloodtbl (name,age,weight,bloodgrp,date,contact) values('" + nmtxt.Text + "','" + agetxt.Text + "','" + wgttxt.Text + "','" + bgcmb.SelectedItem.ToString() + "','"+str+"','"+ contxt.Text +"')", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Insert successfully", "Blood Bank", MessageBoxButtons.OK);
                        clear();
                        conn.Close();
                        display();
                    }
                    else
                    {
                        MessageBox.Show("Invalid for donate blood...", "Blood Bank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter proper values...", "Blood Bank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Blood Bank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
        void display()
        {
            SqlDataAdapter da = new SqlDataAdapter("select id,name from bloodtbl", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }

        private void addblood_Load(object sender, EventArgs e)
        {
            bgcmb.SelectedIndex = 0;
            display();
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            clear();
        }
        void clear()
        {
            nmtxt.Clear();
            agetxt.Clear();
            wgttxt.Clear();
            contxt.Clear();
            nmtxt.Focus();
            bgcmb.SelectedIndex = 0;
        }

        private void nmtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((Convert.ToInt32(e.KeyChar) >= 65 && Convert.ToInt32(e.KeyChar) <= 90) || (Convert.ToInt32(e.KeyChar) == 95)
                || (Convert.ToInt32(e.KeyChar) >= 97 && Convert.ToInt32(e.KeyChar) <= 122) || (Convert.ToInt32(e.KeyChar) == 8))  
                e.Handled=false;
            else
                e.Handled=true;
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

        private void contxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Convert.ToInt32(e.KeyChar) >= 48 && Convert.ToInt32(e.KeyChar) <= 57) || (Convert.ToInt32(e.KeyChar) == 8))

                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
