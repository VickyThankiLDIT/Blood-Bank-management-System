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
    public partial class getblood : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\project\Blood Bank Management System\Blood Bank Management System\Database1.mdf;Integrated Security=True");

        public getblood()
        {
            InitializeComponent();
        }

        private void getblood_Load(object sender, EventArgs e)
        {
            cmbbg.SelectedIndex = 0;
            cmbcity.SelectedIndex = 0;
        }
        public void Clear()
        {
            txtnm.Clear();
            txtqn.Clear();
            cmbbg.SelectedIndex = 0;
            txtcnt.Clear();
            cmbcity.SelectedIndex = 0;
            txtrsn.Clear();
            txtnm.Focus();
        }
        private void btncnf_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnm.Text != "" && txtqn.Text != "" && txtcnt.Text != "" && cmbbg.SelectedItem.ToString() != "---select---" && txtrsn.Text != "" && cmbcity.SelectedItem.ToString() != "---select---")
                {
                    if (txtav.Text == "0")
                    {
                        MessageBox.Show(cmbbg.SelectedItem.ToString() + " blood group unavailable");
                    }
                    else
                    {
                        int qty=Convert.ToInt32(txtqn.Text);
                        int ava=Convert.ToInt32(txtav.Text);
                        if (qty > ava)
                        {
                            MessageBox.Show("Only " + ava + " bottles of blood are available...Please try again later...");
                        }
                        else
                        {
                            string str = DateTime.Now.ToString("dd-MM-yyyy");
                            conn.Open();
                            SqlCommand cmd = new SqlCommand("insert into getBlood (pnm,qty,bloodgrp,contact,city,reason) values('" + txtnm.Text + "','" + txtqn.Text + "','" + cmbbg.SelectedItem.ToString() + "','" + txtcnt.Text + "','" + cmbcity.SelectedItem.ToString() + "','" + txtrsn.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Insert successfully", "Blood Bank", MessageBoxButtons.OK);
                            conn.Close();


                            str = "select Id from BloodTbl where bloodgrp='" + cmbbg.SelectedItem.ToString() + "' and available='true'";
                            SqlDataAdapter da = new SqlDataAdapter(str, conn);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            if (dt.Rows.Count>0)
                            {
                                for (int i = 0; i < dt.Rows.Count; i++)
                                {
                                    conn.Open();
                                    cmd = new SqlCommand("Update BloodTbl set available='false' where Id=" + Convert.ToInt32(dt.Rows[i][0]), conn);
                                    cmd.ExecuteNonQuery();
                                    conn.Close();
                                }
                            }
                            //conn.Close();
                            Clear();
                        }
                    
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
        //   void display()
        //   {
        //     SqlDataAdapter da = new SqlDataAdapter("select id,pnm from getBlood", conn);
        //   DataTable dt = new DataTable();
        //  da.Fill(dt);
        //}

        private void clrbtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void cmbbg_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            string str = "select count(*) from Bloodtbl where bloodgrp='" + cmbbg.SelectedItem.ToString() + "' and available='True'";
            SqlCommand cmd = new SqlCommand(str, conn);
            txtav.Text = cmd.ExecuteScalar().ToString();
            conn.Close();
        }

        private void txtnm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Convert.ToInt32(e.KeyChar) >= 65 && Convert.ToInt32(e.KeyChar) <= 90) || (Convert.ToInt32(e.KeyChar) == 95)
                || (Convert.ToInt32(e.KeyChar) >= 97 && Convert.ToInt32(e.KeyChar) <= 122) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void txtqn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Convert.ToInt32(e.KeyChar) >= 48 && Convert.ToInt32(e.KeyChar) <= 57) || (Convert.ToInt32(e.KeyChar) == 8))

                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtcnt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Convert.ToInt32(e.KeyChar) >= 48 && Convert.ToInt32(e.KeyChar) <= 57) || (Convert.ToInt32(e.KeyChar) == 8))

                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtrsn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Convert.ToInt32(e.KeyChar) >= 65 && Convert.ToInt32(e.KeyChar) <= 90) || (Convert.ToInt32(e.KeyChar) == 95)
               || (Convert.ToInt32(e.KeyChar) >= 97 && Convert.ToInt32(e.KeyChar) <= 122) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

    }

}

