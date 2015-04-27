using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace simpleSoft
{
    public partial class editInvoice : Form
    {
        dbClass db = new dbClass();
        public editInvoice()
        {
            InitializeComponent();
            db.readData("Select MAX(inv_num) from invoice", txt_inv_number);
            txt_temp.Hide();
        }

        public void addIdataColumn()
        {
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Quantity", "Quantity");
            dataGridView1.Columns.Add("Rate", "Rate");
            dataGridView1.Columns.Add("Disc %", "Discount");
            dataGridView1.Columns.Add("Total", "Total");
        }

        public void removeIdataColumn() 
        {
            dataGridView1.Columns.Remove("ID");
            dataGridView1.Columns.Remove("Quantity");
            dataGridView1.Columns.Remove("Rate");
            dataGridView1.Columns.Remove("Discount");
            dataGridView1.Columns.Remove("Total");
        }

        public void disableforever()
        {

            //Disabling labels fields.
            txt_prod_desc.Enabled = false;
            lbl_sub_total.Enabled = false;
            lbl_total.Enabled = false;
            lbl_balance.Enabled = false;
            btn_inv_save.Enabled = false;
            txt_prod_total.Enabled = false;

            //Disabling Customers Data/Info
            txt_cust_name.Enabled = false;
            txt_comp_name.Enabled = false;

            //Disabling Invoice
            txt_inv_number.Enabled = false;

        }

        public void enableCustData()
        {
            txt_cust_name.Enabled = true;
            txt_comp_name.Enabled = true;
        }

        public void disableIdata()
        {
            txt_add_less.Enabled = false;
            txt_advance.Enabled = false;
            txt_cartage.Enabled = false;
            txt_design.Enabled = false;
            txt_notes.Enabled = false;
            txt_prod_disc.Enabled = false;
            txt_prod_id.Enabled = false;
            txt_prod_qty.Enabled = false;
            txt_prod_rate.Enabled = false;
        }

        public void enableIdata()
        {
            txt_add_less.Enabled = true;
            txt_advance.Enabled = true;
            txt_cartage.Enabled = true;
            txt_design.Enabled = true;
            txt_notes.Enabled = true;
            txt_prod_disc.Enabled = true;
            txt_prod_id.Enabled = true;
            txt_prod_qty.Enabled = true;
            txt_prod_rate.Enabled = true;
        }



        private void btn_add_prod_Click(object sender, EventArgs e)
        {

        }

        private void txt_inv_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                db.readData("Select inv_num from invoice where inv_num = '" + txt_inv_number.Text + "'", txt_inv_number);
                    if (txt_inv_number.Text == "")
                    {
                        MessageBox.Show("Invalid invoice number");
                    }
                    else {
                        this.ActiveControl = txt_date;
                        disableforever();
                        db.readData("Select inv_prod_id AS ID, inv_prod_qty AS Quantity, inv_prod_rate AS Rate, inv_prod_disc Discount, inv_prod_total AS Total from invoice_data where inv_number = '" +txt_inv_number.Text +"'", dataGridView1);
                        db.readData("Select inv_cust_code from invoice where inv_num ='" +txt_inv_number.Text +"'",txt_temp);
                        String id = txt_temp.Text;
                        db.readData("Select cust_mobile from customer where cust_code = '" + id + "'",txt_mobile1);
                        db.readData("Select cust_name from customer where cust_code = '" + id +"'", txt_cust_name);
                        db.readData("Select cust_company from customer where cust_code = '" + id +"'", txt_comp_name);
                        db.readData("Select inv_cartage_amount from invoice where inv_num ='" + txt_inv_number.Text + "'", txt_cartage);
                        db.readData("Select inv_design_amount from invoice where inv_num ='" + txt_inv_number.Text + "'", txt_design);
                        db.readData("Select inv_other_amount from invoice where inv_num ='" + txt_inv_number.Text + "'", txt_add_less);
                        db.readData("Select custd_less from customer_data where custd_inv_number = '" + txt_inv_number.Text + "'", txt_advance);
                        db.readData("Select custd_add from customer_data where custd_inv_number = '" + txt_inv_number.Text + "'", lbl_total);
                        db.readData("Select custd_note from customer_data where custd_inv_number = '" + txt_inv_number.Text + "'", txt_notes);
                        db.readData("Select inv_sale_rep from invoice where inv_num = '" + txt_inv_number.Text + "'", txt_temp);
                        cb_sales_reps.Text = txt_temp.Text;
                        

                        int advance, cartage, design, ntotal;
                        advance = Convert.ToInt32(txt_advance.Text);
                        cartage = Convert.ToInt32(txt_cartage.Text);
                        design = Convert.ToInt32(txt_design.Text);
                        ntotal = Convert.ToInt32(lbl_total.Text);
                        int stotal = ntotal - cartage - design;
                        lbl_sub_total.Text = "" +stotal;
                    }
                }
        }

        private void clearAll() 
        {
            txt_mobile1.Text = "";
            txt_cust_name.Text = "";
            txt_comp_name.Text = "";
            dataGridView1.DataSource = null;
            addIdataColumn();
        }

        private void txt_date_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                this.ActiveControl = cb_sales_reps;
            }
        }

        private void cb_sales_reps_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                this.ActiveControl = txt_mobile1;
            }
        }

        private void txt_mobile1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                this.ActiveControl = txt_prod_id;
            }
        }

        private void txt_prod_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                this.ActiveControl = txt_prod_qty;
            }
        }

        private void txt_prod_qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                this.ActiveControl = txt_prod_rate;
            }
        }

        private void txt_prod_rate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                this.ActiveControl = txt_prod_disc;
            }
        }

        private void txt_prod_disc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                this.ActiveControl = btn_add_prod;
            }
        }

        private void btn_add_prod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                this.ActiveControl = txt_prod_id;
            }
        }

        private void txt_design_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                this.ActiveControl = txt_cartage;
            }
        }

        private void txt_cartage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                this.ActiveControl = txt_add_less;
            }
        }

        private void txt_add_less_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                this.ActiveControl = txt_advance;
            }
        }

        private void txt_advance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                this.ActiveControl = txt_notes;
            }
        }

        private void txt_notes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                btn_inv_save.Enabled = true;
                this.ActiveControl = btn_inv_save;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (txt_inv_number.Enabled == true) 
            {
                txt_inv_number.Enabled = false;
            }
            else if (txt_inv_number.Enabled == false) 
            {
                txt_inv_number.Enabled = true;
                clearAll();
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (txt_mobile1.Enabled == true)
            {
                txt_mobile1.Enabled = false;
            }
            else if (txt_mobile1.Enabled == false)
            {
                txt_mobile1.Enabled = true;
                clearAll();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int selectedCustCode = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (this.dataGridView1.SelectedRows.Count > 0)
            //{
            //    dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            //} 



            //foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            //{
            //    dataGridView1.Rows.RemoveAt(item.Index);
            //}


        }

        private void btn_inv_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
