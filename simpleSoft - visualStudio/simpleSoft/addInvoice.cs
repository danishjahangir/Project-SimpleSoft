using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Transactions;
using System.Data.SQLite;

namespace simpleSoft
{
    public partial class addInvoice : Form
    {
        dbClass db = new dbClass();
        public addInvoice()
        {
            InitializeComponent();
            dbClass db = new dbClass();
            db.readData("Select MAX(inv_num) from invoice", txt_inv_number,1);
            addIdataColumn();
            disableforever();
            disableIdata();
            txt_temp.Hide();

        }

        public void addIdataColumn() {
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Quantity", "Quantity");
            dataGridView1.Columns.Add("Rate", "Rate");
            dataGridView1.Columns.Add("Disc %", "Discount");
            dataGridView1.Columns.Add("Total", "Total");
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

        public void disableforever() {
            
            
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
        
        public void enableSave(){
            if(!(lbl_sub_total.Text == "0")){
                btn_inv_save.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (txt_inv_number.Enabled == true) {
                txt_inv_number.Enabled = false;
            }
            else if (txt_inv_number.Enabled == false)
            {
                txt_inv_number.Enabled = true;
            }
        }

        
        private void btn_add_prod_Click(object sender, EventArgs e)
        {
            string firstColum = txt_prod_id.Text.ToUpper();
            string thirdColum = txt_prod_qty.Text;
            string forthColum = txt_prod_rate.Text;
            string fifthColum = txt_prod_disc.Text;
            string sixthColum = txt_prod_total.Text;

            
            string[] row = {firstColum,thirdColum,forthColum,fifthColum,sixthColum};
            dataGridView1.Rows.Add(row);
            int serialCount = (Convert.ToInt16(lbl_serial.Text)) + 1;
            lbl_serial.Text = "" +serialCount;

            int prod_total = Convert.ToInt32(txt_prod_total.Text);
            int subTotal = Convert.ToInt32(lbl_sub_total.Text);
            subTotal = prod_total + subTotal;

            lbl_sub_total.Text = "" +subTotal;

            enableSave();
            amounts();
            clearFieldData();
        }

        public void amounts() {

            int subTotal = Convert.ToInt32(lbl_sub_total.Text);

            int design = Convert.ToInt32(txt_design.Text);
            int cartage = Convert.ToInt32(txt_cartage.Text);
            

            int netTotal = design + cartage + subTotal;
            lbl_total.Text = "" + netTotal;

            int adv = Convert.ToInt32(txt_advance.Text);
            int bal = netTotal - adv;
            lbl_balance.Text = "" + bal;

        }

        public void clearFieldData()
        {
            txt_prod_id.Text = "";
            txt_prod_qty.Text ="0";
            txt_prod_desc.Text ="";
            txt_prod_rate.Text = "0";
            txt_prod_total.Text = "0";
            this.ActiveControl = txt_prod_id;
        }

        

        private void txt_mobile1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_mobile1_KeyPress(object sender, KeyPressEventArgs e)
        {
            db.isDigit(e);
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                db.readData("Select cust_name from customer where cust_mobile = '" + txt_mobile1.Text + "'", txt_cust_name);
                db.readData("Select cust_company from customer where cust_mobile = '" + txt_mobile1.Text + "'", txt_comp_name);
                this.ActiveControl = txt_prod_id;
                enableIdata();
                txt_mobile1.Enabled = false;
            }
            
            
        }

        private void txt_prod_id_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_prod_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                db.readData("Select prod_minPrice from Product where prod_code = '" + txt_prod_id.Text.ToUpper() + "'", txt_prod_rate);
                db.readData("Select prod_Desc from Product where prod_code = '" + txt_prod_id.Text.ToUpper() + "'", txt_prod_desc);
                this.ActiveControl = txt_prod_qty;
            }
        }

        public double calculate(int qty, double rate, double discount) 
        {
            double total = ((qty * rate) * ((100 - discount)/100));
            return total;
        }

        private void txt_prod_qty_Leave(object sender, EventArgs e)
        {
            if (txt_prod_qty.Text == "" || txt_prod_rate.Text == "" || txt_prod_disc.Text == "")
            {

            }
            else
            {
                int qty = Convert.ToInt16(txt_prod_qty.Text);
                double rate = Convert.ToDouble(txt_prod_rate.Text), disc = Convert.ToDouble(txt_prod_disc.Text);

                txt_prod_total.Text = "" + calculate(qty, rate, disc); 
            }
        }

        private void txt_prod_qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            if (txt_prod_qty.Text == "" || txt_prod_rate.Text == "" || txt_prod_disc.Text == "")
            {
                MessageBox.Show("Please input all the fields.");
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                this.ActiveControl = txt_prod_rate;
                int qty = Convert.ToInt16(txt_prod_qty.Text);
                double rate = Convert.ToDouble(txt_prod_rate.Text), disc = Convert.ToDouble(txt_prod_disc.Text);

                txt_prod_total.Text = "" + calculate(qty, rate, disc);
            }
        }

        private void txt_prod_rate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            if (txt_prod_qty.Text == "" || txt_prod_rate.Text == "" || txt_prod_disc.Text == "")
            {
                MessageBox.Show("Please input all the fields.");
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                this.ActiveControl = txt_prod_disc;
                int qty = Convert.ToInt16(txt_prod_qty.Text);
                double rate = Convert.ToDouble(txt_prod_rate.Text), disc = Convert.ToDouble(txt_prod_disc.Text);

                txt_prod_total.Text = "" + calculate(qty, rate, disc);
            }

        }

        private void txt_prod_disc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            if (txt_prod_qty.Text == "" || txt_prod_rate.Text == "" || txt_prod_disc.Text == "")
            {
                MessageBox.Show("Please input all the fields.");
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                this.ActiveControl = btn_add_prod;
                int qty = Convert.ToInt16(txt_prod_qty.Text);
                double rate = Convert.ToDouble(txt_prod_rate.Text), disc = Convert.ToDouble(txt_prod_disc.Text);

                txt_prod_total.Text = "" + calculate(qty, rate, disc);
            }
        }

        private void txt_prod_total_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_prod_rate_Leave(object sender, EventArgs e)
        {
            if (txt_prod_qty.Text == "" || txt_prod_rate.Text == "" || txt_prod_disc.Text == "")
            {

            }
            else
            {
                int qty = Convert.ToInt16(txt_prod_qty.Text);
                double rate = Convert.ToDouble(txt_prod_rate.Text), disc = Convert.ToDouble(txt_prod_disc.Text);

                txt_prod_total.Text = "" + calculate(qty, rate, disc);
                
            }
        }

        private void txt_prod_disc_Leave(object sender, EventArgs e)
        {
            
            if (txt_prod_qty.Text == "" || txt_prod_rate.Text == "" || txt_prod_disc.Text == "")
            {

            }
            else
            {
                int qty = Convert.ToInt16(txt_prod_qty.Text);
                double rate = Convert.ToDouble(txt_prod_rate.Text), disc = Convert.ToDouble(txt_prod_disc.Text);

                txt_prod_total.Text = "" + calculate(qty, rate, disc);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int selectedProdCode = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            dataGridView1.CurrentRow.Dispose();
        }

        private void btn_inv_save_Click(object sender, EventArgs e)
        {

            int num = Convert.ToInt32(dataGridView1.RowCount);
            int inv_num = Convert.ToInt32(txt_inv_number.Text);

            int design = Convert.ToInt32(txt_design.Text);
            int cartage = Convert.ToInt32(txt_cartage.Text);
            int other = Convert.ToInt32(txt_add_less.Text);
            int advance = Convert.ToInt32(txt_advance.Text);
            int ntotal = Convert.ToInt32(lbl_total.Text);

            SQLiteConnection myConn = new SQLiteConnection(@"Data Source = C:\\simpleSoft\\db\\customer.db");
            myConn.Open();

            SQLiteCommand myCom1 = new SQLiteCommand(myConn);
            SQLiteTransaction transaction = myConn.BeginTransaction();



            // Start a local transaction.

            // Must assign both transaction object and connection
            // to Command object for a pending local transaction
            myCom1.Transaction = transaction;
            try
            {
                for (int i = 0; i <= (dataGridView1.Rows.Count - 1); i++)
                {
                    //insertion in invoice data
                    myCom1.CommandText = "Insert into invoice_data(inv_number,inv_prod_id,inv_prod_qty,inv_prod_rate,inv_prod_disc,inv_prod_total) values ('"
                                        + inv_num + "','" + dataGridView1.Rows[i].Cells["ID"].Value
                                        + "','" + dataGridView1.Rows[i].Cells["Quantity"].Value
                                        + "','" + dataGridView1.Rows[i].Cells["Rate"].Value
                                        + "','" + dataGridView1.Rows[i].Cells["Disc %"].Value
                                        + "','" + dataGridView1.Rows[i].Cells["Total"].Value + "')";
                    myCom1.ExecuteNonQuery();
                }

                //insertion in invoice
                myCom1.CommandText = "Insert into invoice(inv_num,inv_cust_code,inv_date,inv_design_amount,inv_cartage_amount,inv_other_amount,inv_advance_amount,inv_other_note,inv_sale_rep) values ('"
                                + inv_num + "','106','" + txt_date.Text + "','"
                                + design + "','" + cartage + "','" + other + "','"
                                + advance + "','" + txt_notes.Text + "','" + cb_sales_reps.Text.ToUpper() + "')";
                myCom1.ExecuteNonQuery();

                db.readData("Select cust_code from customer where cust_name ='" + txt_cust_name.Text.ToUpper() + "'", txt_temp);
                int code = Convert.ToInt32(txt_temp.Text);

                //insertion in customer data
                myCom1.CommandText = "Insert into customer_data(custd_code,custd_inv_number,custd_date,custd_add,custd_less,custd_balance,custd_note) values ('"
                                + code +"','" + inv_num + "','" + txt_date.Text + "','" + ntotal + "','" +advance +"','" + lbl_balance.Text + "','" + txt_notes.Text + "')";
                myCom1.ExecuteNonQuery();

                // Attempt to commit the transaction.
                transaction.Commit();
                Console.WriteLine("Both records are written to database.");

                MessageBox.Show("Inv Number : " + inv_num + " Added successfully.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Rolling Back Transaction : Unable to Process.");
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                Console.WriteLine("  Message: {0}", ex.Message);

                // Attempt to roll back the transaction.
                try
                {
                    transaction.Rollback();
                    MessageBox.Show("Rolled Back");
                }
                catch (Exception ex2)
                {
                    // This catch block will handle any errors that may have occurred
                    // on the server that would cause the rollback to fail, such as
                    // a closed connection.
                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                    Console.WriteLine("  Message: {0}", ex2.Message);
                }
            }
            finally
            {
                myConn.Close();
                //MessageBox.Show("Connection closed");
            }
        }

        private void txt_design_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_cartage_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_add_less_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void txt_advance_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void txt_design_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                amounts();
                this.ActiveControl = txt_cartage;
            }
        }

        private void txt_cartage_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                amounts();
                this.ActiveControl = txt_add_less;
            }
        }

        private void txt_add_less_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                amounts();
                this.ActiveControl = txt_advance;
            }
        }

        private void txt_advance_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                amounts();
                this.ActiveControl = txt_notes;
            }
        }

        private void txt_notes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                this.ActiveControl = btn_inv_save;
            }
        }

        private void btn_inv_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_inv_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            db.isDigit(e);
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                this.ActiveControl = txt_date;
            }
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
            if (cb_sales_reps.Text == "")
            {
                MessageBox.Show("Please enter sales Representative who dealt with client.");
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                this.ActiveControl = txt_mobile1;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (txt_mobile1.Enabled == true) {
                txt_mobile1.Enabled = false;
            }
            else if (txt_mobile1.Enabled == false)
            {
                txt_mobile1.Enabled = true;
            }
        }

        private void btn_inv_print_Click(object sender, EventArgs e)
        {
            PrintInvoice pc = new PrintInvoice();
            pc.ShowDialog();
        }
    }
}
