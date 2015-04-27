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
    public partial class Product : Form
    {
        //static String pathSet = "Data Source = C:\\Users\\Danish Jahangir\\Desktop\\customer.db";
        //SQLiteConnection myConn = new SQLiteConnection(@"" + pathSet);
        simpleSoft.dbClass db = new dbClass();

        public Product()
        {
            InitializeComponent();
            db.readData("Select prod_code AS CODE, prod_Desc AS DESCRIPTION, prod_type AS TYPE, prod_minPrice AS MIN_PRICE, prod_maxPrice AS MAX_PRICE, prod_avgWeight AS AVG_WEIGHT from Product",dataGridView1);
            btn_edited.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String searchProduct = txt_search.Text;
            db.readData("Select prod_code AS CODE, prod_Desc AS DESCRIPTION, prod_type AS TYPE, prod_minPrice AS MIN_PRICE, prod_maxPrice AS MAX_PRICE, prod_avgWeight AS AVG_WEIGHT from Product Where prod_code LIKE '" + searchProduct + "%'", dataGridView1);
        
        }

        //private void readData(String command)
        //{
        //    try
        //    {
        //        var dataTable = new DataTable();
        //        myConn.Open();
        //        SQLiteDataAdapter mySQLDA = new SQLiteDataAdapter(command, myConn);
        //        mySQLDA.Fill(dataTable);
        //        myConn.Close();
        //        dataGridView1.DataSource = dataTable;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error : Something went wrong!" +ex);
        //    }
        //}

        //private void insertData(String command)
        //{
        //    try
        //    {
        //        myConn.Open();
        //        SQLiteCommand myCom = new SQLiteCommand(myConn);
        //        myCom.CommandText = command;
        //        myCom.ExecuteNonQuery();
        //        myConn.Close();
        //        MessageBox.Show("Successfully completed task.");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error : " + ex);
        //    }
        //}

        private void clearFeilds() 
        {
            txt_code.Text = "";
            txt_prodDesc.Text = "";
            txt_prodMaxPrice.Text = "";
            txt_prodMinPrice.Text = "";
            txt_prodPay.Text = "";
            txt_prodWeight.Text = "";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            db.insertData("Insert into Product (prod_code,prod_type,prod_Desc,prod_payRate,prod_avgWeight,prod_minPrice,prod_maxPrice) " 
                +"values('" +txt_code.Text + "','"+cb_type.Text +"','"+txt_prodDesc.Text +"','" +txt_prodPay.Text +"','"
                +txt_prodWeight.Text +"','"+txt_prodMinPrice.Text +"','"+txt_prodMaxPrice.Text +"')");
            MessageBox.Show("Product added : " + txt_code);
            clearFeilds();
            this.ActiveControl = txt_code;
            db.readData("Select prod_code AS CODE, prod_Desc AS DESCRIPTION, prod_type AS TYPE, prod_minPrice AS MIN_PRICE, prod_maxPrice AS MAX_PRICE, prod_avgWeight AS AVG_WEIGHT from Product",dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            simpleSoft.main a = new main();
            this.Close();
            a.Show();
        }

        private void btn_searchGo_Click(object sender, EventArgs e)
        {
            String searchProduct = txt_search.Text;
            db.readData("Select prod_code AS CODE, prod_Desc AS DESCRIPTION, prod_type AS TYPE, prod_minPrice AS MIN_PRICE, prod_maxPrice AS MAX_PRICE, prod_avgWeight AS AVG_WEIGHT from Product Where prod_code = '" + searchProduct + "'", dataGridView1);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String selectedProdCode = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            db.deleteProd("Delete from Product where prod_code = '" + selectedProdCode + "'");
            db.readData("Select prod_code AS CODE, prod_Desc AS DESCRIPTION, prod_type AS TYPE, prod_minPrice AS MIN_PRICE, prod_maxPrice AS MAX_PRICE, prod_avgWeight AS AVG_WEIGHT from Product",dataGridView1);
            MessageBox.Show("Item Deleted !");
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            String searchProduct = txt_search.Text;
            db.readData("Select prod_code AS CODE, prod_Desc AS DESCRIPTION, prod_type AS TYPE, prod_minPrice AS MIN_PRICE, prod_maxPrice AS MAX_PRICE, prod_avgWeight AS AVG_WEIGHT from Product Where prod_code LIKE '" + searchProduct + "%'", dataGridView1);
        }

        string code = "";
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedProdCode = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            code = selectedProdCode;
            txt_code.Text = code;
            db.readData("Select prod_Desc from Product where prod_code ='" + selectedProdCode + "'", txt_prodDesc);
            db.readData("Select prod_avgWeight from Product where prod_code ='" + selectedProdCode + "'", txt_prodWeight);
            db.readData("Select prod_maxPrice from Product where prod_code ='" + selectedProdCode + "'", txt_prodMaxPrice);
            db.readData("Select prod_minPrice from Product where prod_code ='" + selectedProdCode + "'", txt_prodMinPrice);
            db.readData("Select prod_payRate from Product where prod_code ='" + selectedProdCode + "'", txt_prodPay);
            btn_edited.Enabled = true;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            if(!(txt_prodDesc.Text == "") || !(txt_code.Text == ""))
            {
                if (MessageBox.Show("Confirm delete " + dataGridView1.CurrentRow.Cells[1].Value + "?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    clearFeilds();
                }
            }
            else
            {
                clearFeilds();
            }
        }

        private void btn_edited_Click(object sender, EventArgs e)
        {
            if (txt_code.Text == "")
            {
                MessageBox.Show("Please input a valid code.");
            }
            else
            {
                db.insertData("Update Product SET prod_Desc ='" + txt_prodDesc.Text + "', prod_avgWeight ='" + txt_prodWeight.Text
                             + "', prod_maxPrice = '" + txt_prodMaxPrice.Text + "', prod_minPrice = '" + txt_prodMinPrice.Text
                             + "', prod_payRate = '" + txt_prodPay.Text + "', prod_type = '" + cb_type.Text
                             + "' where prod_code = '" + code + "'");
                btn_edited.Enabled = false;
                db.readData("Select prod_code AS CODE, prod_Desc AS DESCRIPTION, prod_type AS TYPE, prod_minPrice AS MIN_PRICE, prod_maxPrice AS MAX_PRICE, prod_avgWeight AS AVG_WEIGHT from Product", dataGridView1);
                MessageBox.Show("Product : " +txt_code.Text +" have been edited.");
                code = "";
                clearFeilds();

            
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            String selectedProdCode = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            if (MessageBox.Show("Confirm delete " + dataGridView1.CurrentRow.Cells[0].Value + "?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                db.deleteProd("Delete from Product where prod_code = '" + selectedProdCode + "'");
                db.readData("Select prod_code AS CODE, prod_Desc AS DESCRIPTION, prod_type AS TYPE, prod_minPrice AS MIN_PRICE, prod_maxPrice AS MAX_PRICE, prod_avgWeight AS AVG_WEIGHT from Product", dataGridView1);
                MessageBox.Show("Item Deleted !");
            }
        }

        private void txt_prodPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                db.isDigit(txt_prodPay, e);
                this.ActiveControl = txt_prodWeight;
            }
        }

        private void txt_prodMinPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                db.isDigit(txt_prodMinPrice, e);
                this.ActiveControl = txt_prodMaxPrice;
            }
        }

        private void txt_prodWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                db.isDigit(txt_prodWeight, e);
                this.ActiveControl = txt_prodMinPrice;
            }
        }

        private void txt_prodMaxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                db.isDigit(txt_prodMaxPrice, e);
                this.ActiveControl = btn_save;
            }
        }

        private void txt_code_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                this.ActiveControl = cb_type;
            }
        }

        private void cb_type_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                this.ActiveControl = txt_prodDesc;
            }
        }

        private void txt_prodDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                this.ActiveControl = txt_prodPay;
            }
        }
    }
}
