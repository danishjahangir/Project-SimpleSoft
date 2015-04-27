using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace simpleSoft
{
    public partial class ProductionChart : Form
    {
        simpleSoft.dbClass db = new dbClass();

        

        public ProductionChart()
        {
            InitializeComponent();
            db.readData("select kar_name from karigar", cb_karName);
            db.readData("select prod_code from Product", cb_prod_id);
        }

        private void ProductionChart_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_karAdd_Click(object sender, EventArgs e)
        {
            db.insertData("Insert into Karigar(kar_name) values('"+txt_karName.Text +"')");
            clearFields();
            MessageBox.Show("Task successfully done!");
        }

        

        private void clearFields() 
        {
            txt_karName.Text = "";
            txt_otherNote.Text = "";
            txt_prod_rate.Text = "";
            txt_prod_qty.Text = "";
            txt_search.Text = "";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            db.insertData("Insert into ProductionChart "
                          +"(prodChart_date,prodChart_karigar,prodChart_note,prodChart_product" 
                          +",prodChart_qty,prodChart_rate,prodChart_total)"
                          +"values (' " + txt_date.Text + "','" + cb_karName.Text + "','" 
                          + txt_otherNote.Text + "','" + cb_prod_id.Text 
                          + "','" + txt_prod_qty.Text + "','" + txt_prod_rate.Text + "','" + txt_totalAmount.Text + "')");
            clearFields();
            txt_otherNote.Text = txt_date.Text;
            MessageBox.Show("Record updated successfully.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            db.insertData("Insert into karigar_advance (kara_date, kara_name, kara_advance, kara_paid, kara_add, kara_less) values('" 
                          +txt_kara_date.Text +"','" +txt_kara_name.Text +"','" +txt_kara_advance.Text
                          +"','" +txt_payment.Text +"','" +txt_add.Text +"','" +txt_less.Text + "')");
            MessageBox.Show("Task Completed Succesfully.");

        }

        private void cb_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_searchGo_Click(object sender, EventArgs e)
        {
            if(cb_search.Text.Equals("Karigar"))
            {
                db.readData("Select kar_name from karigar" ,dataGridView1);
            } else if(cb_search.Text.Equals("Product"))
            {
                db.readData("Select prod_code, prod_payRate,prod_type from Product" , dataGridView1);
            }
            else if (cb_search.Text.Equals("KarigarDetail"))
            {
                if (txt_search.Text.Equals("")) 
                {
                    MessageBox.Show("Please enter a valid karigar name.");
                }
                else if (!(txt_search.Text.Equals(""))) 
                {
                    db.readData("Select prodChart_karigar,prodChart_product,prodChart_qty,prodChart_rate,prodChart_total,prodChart_note from ProductionChart where prodChart_karigar = '" +txt_search.Text +"'", dataGridView1,0);
                    db.readData("Select sum(prodChart_total) from ProductionChart where prodChart_karigar = '" + txt_search.Text + "'",txt_total);
                    db.readData("Select sum(kara_advance) from karigar_advance where kara_name = '" +txt_search.Text + "'",txt_advance);
                    db.readData("Select sum(kara_paid) from karigar_advance where kara_name = '" + txt_search.Text + "'", txt_payment);

                    if (txt_payment.Text == "")
                    {
                        txt_payment.Text = "0.0";
                    }
                    else if (txt_advance.Text == "") 
                    {
                        txt_advance.Text = "0.0";
                    } else if(txt_total.Text == "")
                    {
                        txt_total.Text = "0.0";
                    }


                    double total = Convert.ToDouble(txt_total.Text);
                    double advance = Convert.ToDouble(txt_advance.Text);
                    double payment = Convert.ToDouble(txt_payment.Text);

                    double balance = (total - advance - payment);

                    txt_balance.Text = "" + balance;
                }
            }
        }

        public void jumpTo(KeyPressEventArgs e, TextBox tb)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                this.ActiveControl = tb;
            }
        }

        public void jumpTo(KeyPressEventArgs e, Button bt)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                this.ActiveControl = bt;
            }
        }


        private void txt_date_KeyPress(object sender, KeyPressEventArgs e)
        {
            jumpTo(e, cb_karName);
        }

        private void cb_karName_KeyPress(object sender, KeyPressEventArgs e)
        {
            jumpTo(e, cb_prod_id);
        }

        private void cb_prod_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            jumpTo(e, txt_prod_qty);
        }

        private void txt_prod_qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            jumpTo(e, txt_prod_rate);

            if (txt_prod_qty.Text == "" || txt_prod_rate.Text == "")
            { 
            }
            else
            {
                double rate = Convert.ToDouble(txt_prod_rate.Text);
                int qty = Convert.ToInt32(txt_prod_qty.Text);
                double total = rate * qty;
                txt_totalAmount.Text = "" + total;
            }
        }

        private void txt_prod_rate_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            jumpTo(e, txt_otherNote);

            if (txt_prod_qty.Text == "" || txt_prod_rate.Text == "")
            {
            }
            else
            {
                double rate = Convert.ToDouble(txt_prod_rate.Text);
                int qty = Convert.ToInt32(txt_prod_qty.Text);
                double total = rate * qty;
                txt_totalAmount.Text = "" + total;
            }
        }

        private void txt_otherNote_KeyPress(object sender, KeyPressEventArgs e)
        {
            jumpTo(e, btn_save);
        }

        private void btn_save_KeyPress(object sender, KeyPressEventArgs e)
        {
            jumpTo(e, cb_prod_id);
        }

        
    }
}