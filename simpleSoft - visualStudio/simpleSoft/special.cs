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
    public partial class special : Form
    {
        dbClass db = new dbClass();
        public special()
        {
            InitializeComponent();
            this.ActiveControl = txt_inv_date;
        }

        private void btn_inv_num_search_Click(object sender, EventArgs e)
        {
            if (txt_inv_mob.Text == "")
            {
            }
            else 
            {
                db.readData("Select cust_company, cust_name, cust_mobile, cust_mobile2, cust_city from customer where cust_mobile = '"+txt_inv_mob.Text +"'", dataGridView1);
                db.readData("Select cust_company from customer where cust_mobile = '" + txt_inv_mob.Text + "'", txt_inv_company);
                //db.readData("Select cust_company from customer where cust_mobile = '" +txt_inv_mob.Text +"'",txt_cust_comp);
                //db.readData("Select cust_name from customer where cust_mobile1 = '" + txt_inv_mob.Text + "'", txt_cust_name);
                //db.readData("Select cust_mobile2 from customer where cust_mobile1 = '" + txt_inv_mob.Text + "'", txt_cust_mob2);
                
            }
        }

        private void btn_inv_prod_search_Click(object sender, EventArgs e)
        {
            if (txt_inv_item_id.Text == "")
            {
            }
            else 
            {
                db.readData("Select prod_code, prod_Desc, prod_maxPrice, prod_type from Product where prod_code = '" +txt_inv_item_id.Text +"'", dataGridView1);
               // db.readData("Select prod_Desc from Product where prod_code = '" + txt_inv_item_id.Text + "'", txt_prod_desc);

            }
        }

        private void btn_prod_add_Click(object sender, EventArgs e)
        {
            if (txt_prod_id.Text == "" || txt_prod_rate.Text == "")
            {
            }
            else
            {
                db.insertData("Insert into Product (prod_code, prod_payRate, prod_Desc , prod_maxPrice, prod_type,prod_avgWeight) values('" 
                    +txt_prod_id.Text +"','" +txt_prod_pricepp.Text +"','" +txt_prod_desc.Text +"','" +txt_prod_rate.Text +"','" +cb_prod_type.Text +"','" +txt_prod_weight.Text +"')");
                clearProduct();
                MessageBox.Show("Added !");
            }
        }

        public void clearProduct() 
        {
            txt_prod_desc.Text = "";
            txt_prod_id.Text = "";
            txt_prod_pricepp.Text = "";
            txt_prod_rate.Text = "";
        }


        

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btn_cust_add_Click(object sender, EventArgs e)
        {
            try{
                if (txt_cust_comp.Text == "" || txt_cust_name.Text == "" || txt_cust_mob1.Text == "")
                {
                }
                else
                {
                    if (cb_cust_city.Text == "")
                    {
                        cb_cust_city.Text = "Karachi";
                    }

                    if (txt_cust_mob2.Text == "")
                    {
                        txt_cust_mob2.Text = "0";
                    }

                    try
                    {
                        db.readData("Select cust_name, cust_company, cust_mobile,cust_city from customer where cust_mobile = '" + txt_cust_mob1.Text + "'", dataGridView1);
                    }
                    catch (Exception)
                    {
 
                    }
                    db.insertData("Insert into customer(cust_company,cust_name,cust_mobile,cust_mobile2,cust_city) values('"
                        + txt_cust_comp.Text + "','" + txt_cust_name.Text + "','" + txt_cust_mob1.Text + "','" + txt_cust_mob2.Text + "','" + cb_cust_city.Text + "')");
                    db.clearfield(txt_cust_comp, txt_cust_mob1, txt_cust_mob2, txt_cust_name, txt_cust_name);
                    txt_cust_mob2.Text = "0";
                    txt_cust_name.Text = "MR";
                    MessageBox.Show("Added !");
                    this.ActiveControl = txt_cust_comp;
                    }
                }
            catch(Exception ex)
            {
                MessageBox.Show("" +ex);
            }
            }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_inv_invnum.Text == "" || txt_inv_item_id.Text == "" || txt_inv_mob.Text == "" || txt_inv_prod_qty.Text == "" || txt_inv_prod_rate.Text == "")
            {
            }
            else
            {
                double rate = Convert.ToInt16(txt_inv_prod_rate.Text);
                int qty = Convert.ToInt16(txt_inv_prod_qty.Text);
                double total = rate * qty;

               // db.insertData("Insert into invoice(inv_cust_id,inv_date,) values");
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txt_cust_mob1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                db.readData("Select cust_name, cust_company, cust_mobile,cust_city from customer where cust_mobile = '" + txt_cust_mob1.Text + "'", dataGridView1);
                this.ActiveControl = txt_cust_mob2;
            }
        }

        private void txt_cust_comp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                this.ActiveControl = txt_cust_name;
            }
        }

        private void txt_cust_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cust_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                this.ActiveControl = txt_cust_mob1;
            }
        }

        private void txt_cust_mob2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                this.ActiveControl = cb_cust_city;
            }
        }

        private void cb_cust_city_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                this.ActiveControl = btn_cust_add;
            }
        }
    }
}
