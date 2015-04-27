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
    public partial class Customer : Form
    {
        //static String pathSet = "Data Source = C:\\Users\\Danish Jahangir\\Desktop\\customer.db";
        //SQLiteConnection myConn = new SQLiteConnection(@"" +pathSet);
        simpleSoft.main a = new main();
        static String path = "";

        
        simpleSoft.dbClass db = new dbClass();
        public Customer()
        {
            InitializeComponent();
            simpleSoft.dbClass db = new dbClass();
            db.readData("Select cust_code AS CODE, cust_name AS NAME, cust_company AS COMPANY, cust_city AS CITY, cust_mobile AS MOBILE1, cust_mobile2 AS MOBILE2, cust_office1 AS OFFICE,cust_fax AS FAX from customer", dataGridView1);
            btn_edited.Enabled = false;
        }

        public void jumpTo(KeyPressEventArgs e, TextBox tb)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                this.ActiveControl = tb;
            }
        }

        public void jumpTo(KeyPressEventArgs e, ComboBox cb)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                this.ActiveControl = cb;
            }
        }

        public void jumpTo(KeyPressEventArgs e, Button cb)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                this.ActiveControl = cb;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_mobile1.Text == "")
            {
                MessageBox.Show("Please enter a single mobile number in mobile1.");
            }
            else
            {
                db.insertData("Insert into customer (cust_company,cust_name,cust_city,cust_mobile,cust_mobile2,cust_mobile3,cust_office1,cust_office2,cust_fax) values ('"
                + txt_company.Text.ToUpper() + "','" + "MR " +txt_custName.Text.ToUpper() + "','" + cb_city.Text + "','" + txt_mobile1.Text + "','"
                + txt_mobile2.Text + "','" + txt_mobile3.Text + "','" + txt_Office1.Text + "','" + txt_Office2.Text + "','"
                + txt_fax.Text + "')");

                clearFields();
                db.readData("Select cust_code AS CODE, cust_name AS NAME, cust_company AS COMPANY, cust_city AS CITY, cust_mobile AS MOBILE1, cust_mobile2 AS MOBILE2, cust_office1 AS OFFICE,cust_fax AS FAX from customer", dataGridView1);
                MessageBox.Show("Data Saved !!");
                this.ActiveControl = txt_custName;
            } 
        }


        private void clearFields() 
        {
            txt_company.Text = "";
            txt_custName.Text = "";
            txt_mobile1.Text = "";
            txt_mobile2.Text = "";
            txt_mobile3.Text = "";
            txt_Office1.Text = "";
            txt_Office2.Text = "";
            txt_fax.Text = "";
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedCustCode = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            db.deleteCust("Delete from customer where cust_code = '" + selectedCustCode + "'");
            db.readData("Select cust_code AS CODE, cust_name AS NAME, cust_company AS COMPANY, cust_city AS CITY, cust_mobile AS MOBILE1, cust_mobile2 AS MOBILE2, cust_office1 AS OFFICE,cust_fax AS FAX from customer", dataGridView1);
                
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String search = txt_search.Text.ToUpper();
            
            if (cb_search.Text == "") 
            {
              MessageBox.Show("Please select type First.");
            }
            else if(cb_search.Text == "Name")
            {
                db.readData("Select cust_code AS CODE, cust_name AS NAME, cust_company AS COMPANY, cust_city AS CITY, cust_mobile AS MOBILE1, cust_mobile2 AS MOBILE2, cust_office1 AS OFFICE,cust_fax AS FAX from customer where cust_name LIKE '" + search + "%'",dataGridView1);
            } 
            else if(cb_search.Text == "Company Name")
            {
                db.readData("Select cust_code AS CODE, cust_name AS NAME, cust_company AS COMPANY, cust_city AS CITY, cust_mobile AS MOBILE1, cust_mobile2 AS MOBILE2, cust_office1 AS OFFICE,cust_fax AS FAX from customer where cust_company LIKE '" + search + "%'", dataGridView1);

            }
            else if(cb_search.Text == "Mobile Number")
            {
                db.readData("Select cust_code AS CODE, cust_name AS NAME, cust_company AS COMPANY, cust_city AS CITY, cust_mobile AS MOBILE1, cust_mobile2 AS MOBILE2, cust_office1 AS OFFICE,cust_fax AS FAX from customer where cust_mobile LIKE '" + search + "%'", dataGridView1);
            }
            else if (cb_search.Text == "Fax")
            {
                db.readData("Select cust_code AS CODE, cust_name AS NAME, cust_company AS COMPANY, cust_city AS CITY, cust_mobile AS MOBILE1, cust_mobile2 AS MOBILE2, cust_office1 AS OFFICE,cust_fax AS FAX from customer where cust_fax LIKE '" + search + "%'", dataGridView1);
            
            }
        
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!(txt_company.Text == "") || !(txt_custName.Text == "") || !(txt_mobile1.Text == "") || !(txt_search.Text == ""))
            {
                if (MessageBox.Show("Confirm Proceed?\n You'll lost any unsaved data", "Confirm Proceed", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (a.Visible == true)
                    {
                        this.Hide();
                    }
                    else
                    {
                        this.Hide();
                        a.Show();
                    }
                }
            } 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm delete " +dataGridView1.CurrentRow.Cells[1].Value +"?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int selectedCustCode = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
                db.deleteCust("Delete from customer where cust_code = '" + selectedCustCode + "'");
                db.readData("Select cust_code AS CODE, cust_name AS NAME, cust_company AS COMPANY, cust_city AS CITY, cust_mobile AS MOBILE1, cust_mobile2 AS MOBILE2, cust_office1 AS OFFICE,cust_fax AS FAX from customer",dataGridView1);
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void LinkSave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        int code;
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedCustCode = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            code = selectedCustCode;

            db.readData("Select cust_name from customer where cust_code = '" +selectedCustCode +"'", txt_custName);
            db.readData("Select cust_company from customer where cust_code ='" + selectedCustCode + "'", txt_company);
            db.readData("Select cust_mobile from customer where cust_code = '" + selectedCustCode + "'", txt_mobile1);
            db.readData("Select cust_mobile2 from customer where cust_code ='" + selectedCustCode + "'", txt_mobile2);
            db.readData("Select cust_mobile3 from customer where cust_code = '" + selectedCustCode + "'", txt_mobile3);
            db.readData("Select cust_office1 from customer where cust_code ='" + selectedCustCode + "'", txt_Office1);
            db.readData("Select cust_office2 from customer where cust_code = '" + selectedCustCode + "'", txt_Office2);
            db.readData("Select cust_fax from customer where cust_code = '" + selectedCustCode + "'", txt_fax);
            btn_edited.Enabled = true;
        }

        private void btn_edited_Click(object sender, EventArgs e)
        {
            if (txt_mobile1.Text == "")
            {
                MessageBox.Show("Please input a valid number in mobile1.");
            }
            else
            {
                db.insertData("UPDATE customer SET cust_name = '" + txt_custName.Text.ToUpper()
                             + "', cust_company = '" + txt_company.Text.ToUpper() + "', cust_mobile = '"
                             + txt_mobile1.Text + "', cust_mobile2 = '" + txt_mobile2.Text
                             + "', cust_mobile3 = '" + txt_mobile3.Text + "', cust_city = '"
                             + cb_city.Text + "', cust_fax ='" + txt_fax.Text
                             + "', cust_office1 = '" + txt_Office1.Text + "', cust_office2 = '"
                             + txt_Office2.Text + "' WHERE cust_code = '" + code + "'");
                db.readData("Select cust_code AS CODE, cust_name AS NAME, cust_company AS COMPANY,"
                           + "cust_city AS CITY, cust_mobile AS MOBILE1, cust_mobile2 AS MOBILE2,"
                           + "cust_office1 AS OFFICE,cust_fax AS FAX from customer", dataGridView1);
                btn_edited.Enabled = false;
                MessageBox.Show("Data Edited for Customer ID :" + code + " : " + txt_company.Text);
                code = 0;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            db.isDigit(e);
            jumpTo(e, txt_mobile1);
        }

        private void txt_mobile1_KeyPress(object sender, KeyPressEventArgs e)
        {
            db.isDigit(e);
            jumpTo(e, txt_mobile2);
        }

        private void txt_mobile2_KeyPress(object sender, KeyPressEventArgs e)
        {
            db.isDigit(e);
            jumpTo(e, txt_mobile3);
        }

        private void txt_mobile3_KeyPress(object sender, KeyPressEventArgs e)
        {
            db.isDigit(e);
            jumpTo(e, txt_Office1);
        }

        private void txt_Office1_KeyPress(object sender, KeyPressEventArgs e)
        {
            db.isDigit(e);

            jumpTo(e, txt_Office2);
        }

        private void txt_Office2_KeyPress(object sender, KeyPressEventArgs e)
        {
            db.isDigit(e);
            jumpTo(e, txt_fax);
        }

        private void txt_fax_KeyPress(object sender, KeyPressEventArgs e)
        {
            db.isDigit(e);
            jumpTo(e, btn_save);
        }

        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cb_search.Text == "Mobile Number" || cb_search.Text == "Fax")
            {
                db.isDigit(e);
            }
            else 
            { 
            }
        }

        private void txt_mobile1_TextChanged(object sender, EventArgs e)
        {
            String search = txt_mobile1.Text;
            db.readData("Select cust_code AS CODE, cust_name AS NAME, cust_company AS COMPANY, cust_city AS CITY, cust_mobile AS MOBILE1, cust_mobile2 AS MOBILE2, cust_office1 AS OFFICE,cust_fax AS FAX from customer where cust_mobile LIKE '" + search + "%'", dataGridView1);
        }

        private void txt_custName_KeyPress(object sender, KeyPressEventArgs e)
        {
            jumpTo(e, cb_city);
        }

        private void cb_city_KeyPress(object sender, KeyPressEventArgs e)
        {
            jumpTo(e, txt_company);
        }

        private void txt_company_KeyPress(object sender, KeyPressEventArgs e)
        {
            jumpTo(e, textBox1);
        }

        private void txt_company_TextChanged(object sender, EventArgs e)
        {
            String search = txt_company.Text;
            db.readData("Select cust_code AS CODE, cust_name AS NAME, cust_company AS COMPANY, cust_city AS CITY, cust_mobile AS MOBILE1, cust_mobile2 AS MOBILE2, cust_office1 AS OFFICE,cust_fax AS FAX from customer where cust_company LIKE '" + search + "%'", dataGridView1);
        
        }

        
    }
}