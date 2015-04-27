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
    public partial class signin : Form
    {
        public signin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public string path = "";
        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_uname.Text.Equals("123") && txt_pwd.Text.Equals("123"))
            {
                path = txt_path.Text;

                main mF = new main();
                this.Visible = false;
                mF.Visible = true;
            }
            else {
                MessageBox.Show("Enter a valid password and/or username.");
            }
        }
    }
}
