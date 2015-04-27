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
    public partial class main : Form
    {
        String path;

        public main()
        {
            InitializeComponent();
        }
        public main(String pathG)
        {
            InitializeComponent();
            simpleSoft.dbClass db = new dbClass();
            path = pathG;
        }

        

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            simpleSoft.Customer cust = new Customer();
            cust.ShowDialog();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            simpleSoft.Product prod = new Product();
            prod.ShowDialog();
        }

        private void productionChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            simpleSoft.ProductionChart prodChart = new ProductionChart();
            prodChart.ShowDialog();
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            simpleSoft.special sp = new special();
            sp.ShowDialog();
        }

        private void addInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            simpleSoft.addInvoice inv = new addInvoice();
            inv.ShowDialog();
        }

        private void editInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            simpleSoft.editInvoice einv = new editInvoice();
            einv.ShowDialog();
        }
    }
}
