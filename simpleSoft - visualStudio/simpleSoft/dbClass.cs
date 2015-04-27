using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data;

namespace simpleSoft
{
    class dbClass
    {
        static String path = ""; 
        

        public dbClass()
        {
            // TODO: Complete member initialization
        }
        static String pathSet = "Data Source = C:\\simpleSoft\\db\\customer.db";
        SQLiteConnection myConn = new SQLiteConnection(@"" + pathSet);

        public void isDigit(KeyPressEventArgs e) {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public void isDigit(TextBox tb1, KeyPressEventArgs e)
        {
            double a;
            if (Double.TryParse(tb1.Text, out a))
            {
                e.Handled = false;
            }
            else
            {
                tb1.Text = "";
            }
        }

        


        public void insertData(String command)
        {
            try
            {
                myConn.Open();
                SQLiteCommand myCom = new SQLiteCommand(myConn);
                myCom.CommandText = command;
                myCom.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : \n" + ex);
            }
            finally 
            {
                myConn.Close();
            }
        }


        public void readData(String command, DataGridView datagrid)
        {
            try
            {

                var dataTable = new DataTable();
                myConn.Open();
                SQLiteDataAdapter mySQLDA = new SQLiteDataAdapter(command, myConn);
                
                mySQLDA.Fill(dataTable);
                datagrid.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : \n" +ex);
            }
            finally
            {
                myConn.Close();
            }

        }

        public void readData(String command, DataGridView datagrid,int a)
        {
            try
            {

                var dataTable = new DataTable();
                myConn.Open();
                SQLiteDataAdapter mySQLDA = new SQLiteDataAdapter(command, myConn);

                mySQLDA.Fill(dataTable);
                datagrid.DataSource = dataTable;

                datagrid.Columns[a].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : \n" + ex);
            }
            finally
            {
                myConn.Close();
            }

        }

        public void readData(String command, TextBox textBox, int increment) //method-overloading
        {
            try
            {
                int data;
                myConn.Open();
                SQLiteCommand sql_cmd = myConn.CreateCommand();
                sql_cmd.CommandText = command;
                data = Convert.ToInt16(sql_cmd.ExecuteScalar().ToString());
                data += increment;
                textBox.Text = "" +data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : \n" +ex);
            }
            finally
            {
                myConn.Close();
            }

        }
        

        public void readData(String command, TextBox textBox)
        {
            try
            {
                string data;
                myConn.Open();
                SQLiteCommand sql_cmd = myConn.CreateCommand();
                sql_cmd.CommandText = command;
                data = sql_cmd.ExecuteScalar().ToString();
                textBox.Text = "" + data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : \n" +ex);
            }
            finally
            {
                myConn.Close();
            }

        }

        public void readData(String command, ComboBox cb_box)
        {
            try
            {
                string data;
                myConn.Open();
                SQLiteCommand sql_cmd = myConn.CreateCommand();
                sql_cmd.CommandText = command;
                data = sql_cmd.ExecuteScalar().ToString();
                cb_box.Items.Add(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : \n" + ex);
            }
            finally
            {
                myConn.Close();
            }

        }


        public void deleteCust(string command)
        {
            try
            {
                myConn.Open();
                SQLiteCommand myCom = new SQLiteCommand(myConn);
                myCom.CommandText = command;
                myCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : \n" +ex);
            }
            finally
            {
                myConn.Close();
            }

        }


        public void deleteProd(string command)
        {
            try
            {
                myConn.Open();
                SQLiteCommand myCom = new SQLiteCommand(myConn);
                myCom.CommandText = command;
                myCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : Something went wrong! \n" +ex);
            }
            finally
            {
                myConn.Close();
            }

        }

        public void clearfield(TextBox a1, TextBox a2, TextBox a3, TextBox a4, TextBox a5)
        {
            a1.Text = "";
            a2.Text = "";
            a3.Text = "";
            a4.Text = "";
            a5.Text = "";
        }
    }
}
