namespace simpleSoft
{
    partial class special
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_inv_date = new System.Windows.Forms.DateTimePicker();
            this.txt_cust_comp = new System.Windows.Forms.TextBox();
            this.txt_inv_invnum = new System.Windows.Forms.TextBox();
            this.txt_inv_item_id = new System.Windows.Forms.TextBox();
            this.txt_inv_prod_qty = new System.Windows.Forms.TextBox();
            this.txt_inv_prod_rate = new System.Windows.Forms.TextBox();
            this.txt_cust_name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_prod_id = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_inv_company = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_inv_prod_search = new System.Windows.Forms.Button();
            this.btn_inv_mob_search = new System.Windows.Forms.Button();
            this.txt_inv_mob = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_prod_desc = new System.Windows.Forms.TextBox();
            this.txt_prod_rate = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_prod_weight = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_prod_pricepp = new System.Windows.Forms.TextBox();
            this.cb_prod_type = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_prod_add = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.cb_cust_city = new System.Windows.Forms.ComboBox();
            this.btn_cust_add = new System.Windows.Forms.Button();
            this.txt_cust_mob2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_cust_mob1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_inv_date
            // 
            this.txt_inv_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_inv_date.Location = new System.Drawing.Point(105, 67);
            this.txt_inv_date.Name = "txt_inv_date";
            this.txt_inv_date.Size = new System.Drawing.Size(134, 20);
            this.txt_inv_date.TabIndex = 0;
            // 
            // txt_cust_comp
            // 
            this.txt_cust_comp.Location = new System.Drawing.Point(92, 10);
            this.txt_cust_comp.Name = "txt_cust_comp";
            this.txt_cust_comp.Size = new System.Drawing.Size(100, 20);
            this.txt_cust_comp.TabIndex = 16;
            this.txt_cust_comp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cust_comp_KeyPress);
            // 
            // txt_inv_invnum
            // 
            this.txt_inv_invnum.Location = new System.Drawing.Point(148, 48);
            this.txt_inv_invnum.Name = "txt_inv_invnum";
            this.txt_inv_invnum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_inv_invnum.Size = new System.Drawing.Size(64, 20);
            this.txt_inv_invnum.TabIndex = 3;
            this.txt_inv_invnum.Text = "00";
            // 
            // txt_inv_item_id
            // 
            this.txt_inv_item_id.Location = new System.Drawing.Point(78, 72);
            this.txt_inv_item_id.Name = "txt_inv_item_id";
            this.txt_inv_item_id.Size = new System.Drawing.Size(92, 20);
            this.txt_inv_item_id.TabIndex = 4;
            // 
            // txt_inv_prod_qty
            // 
            this.txt_inv_prod_qty.Location = new System.Drawing.Point(137, 150);
            this.txt_inv_prod_qty.Name = "txt_inv_prod_qty";
            this.txt_inv_prod_qty.Size = new System.Drawing.Size(75, 20);
            this.txt_inv_prod_qty.TabIndex = 6;
            // 
            // txt_inv_prod_rate
            // 
            this.txt_inv_prod_rate.Location = new System.Drawing.Point(137, 177);
            this.txt_inv_prod_rate.Name = "txt_inv_prod_rate";
            this.txt_inv_prod_rate.Size = new System.Drawing.Size(75, 20);
            this.txt_inv_prod_rate.TabIndex = 7;
            // 
            // txt_cust_name
            // 
            this.txt_cust_name.Location = new System.Drawing.Point(92, 39);
            this.txt_cust_name.Name = "txt_cust_name";
            this.txt_cust_name.Size = new System.Drawing.Size(100, 20);
            this.txt_cust_name.TabIndex = 17;
            this.txt_cust_name.Text = "MR";
            this.txt_cust_name.TextChanged += new System.EventHandler(this.txt_cust_name_TextChanged);
            this.txt_cust_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cust_name_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Company Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Inv Num";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Item";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Qty";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Rate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Code";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txt_prod_id
            // 
            this.txt_prod_id.Location = new System.Drawing.Point(65, 9);
            this.txt_prod_id.Name = "txt_prod_id";
            this.txt_prod_id.Size = new System.Drawing.Size(44, 20);
            this.txt_prod_id.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_inv_company);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.btn_inv_prod_search);
            this.panel1.Controls.Add(this.btn_inv_mob_search);
            this.panel1.Controls.Add(this.txt_inv_invnum);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_inv_mob);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_inv_prod_rate);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txt_inv_prod_qty);
            this.panel1.Controls.Add(this.txt_inv_item_id);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(27, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 234);
            this.panel1.TabIndex = 17;
            // 
            // txt_inv_company
            // 
            this.txt_inv_company.Location = new System.Drawing.Point(78, 124);
            this.txt_inv_company.Name = "txt_inv_company";
            this.txt_inv_company.Size = new System.Drawing.Size(92, 20);
            this.txt_inv_company.TabIndex = 26;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 131);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 13);
            this.label16.TabIndex = 27;
            this.label16.Text = "Company";
            // 
            // btn_inv_prod_search
            // 
            this.btn_inv_prod_search.Location = new System.Drawing.Point(173, 72);
            this.btn_inv_prod_search.Name = "btn_inv_prod_search";
            this.btn_inv_prod_search.Size = new System.Drawing.Size(39, 20);
            this.btn_inv_prod_search.TabIndex = 5;
            this.btn_inv_prod_search.Text = "Go";
            this.btn_inv_prod_search.UseVisualStyleBackColor = true;
            this.btn_inv_prod_search.Click += new System.EventHandler(this.btn_inv_prod_search_Click);
            // 
            // btn_inv_mob_search
            // 
            this.btn_inv_mob_search.Location = new System.Drawing.Point(173, 99);
            this.btn_inv_mob_search.Name = "btn_inv_mob_search";
            this.btn_inv_mob_search.Size = new System.Drawing.Size(39, 20);
            this.btn_inv_mob_search.TabIndex = 2;
            this.btn_inv_mob_search.Text = "Go";
            this.btn_inv_mob_search.UseVisualStyleBackColor = true;
            this.btn_inv_mob_search.Click += new System.EventHandler(this.btn_inv_num_search_Click);
            // 
            // txt_inv_mob
            // 
            this.txt_inv_mob.Location = new System.Drawing.Point(78, 99);
            this.txt_inv_mob.Name = "txt_inv_mob";
            this.txt_inv_mob.Size = new System.Drawing.Size(92, 20);
            this.txt_inv_mob.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Mobile";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 354);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(510, 94);
            this.dataGridView1.TabIndex = 18;
            // 
            // txt_prod_desc
            // 
            this.txt_prod_desc.Location = new System.Drawing.Point(13, 39);
            this.txt_prod_desc.Name = "txt_prod_desc";
            this.txt_prod_desc.Size = new System.Drawing.Size(127, 20);
            this.txt_prod_desc.TabIndex = 11;
            // 
            // txt_prod_rate
            // 
            this.txt_prod_rate.Location = new System.Drawing.Point(52, 65);
            this.txt_prod_rate.Name = "txt_prod_rate";
            this.txt_prod_rate.Size = new System.Drawing.Size(44, 20);
            this.txt_prod_rate.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.txt_prod_weight);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txt_prod_pricepp);
            this.panel2.Controls.Add(this.cb_prod_type);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.btn_prod_add);
            this.panel2.Controls.Add(this.txt_prod_rate);
            this.panel2.Controls.Add(this.txt_prod_desc);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txt_prod_id);
            this.panel2.Location = new System.Drawing.Point(248, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 113);
            this.panel2.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(142, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "Weight";
            // 
            // txt_prod_weight
            // 
            this.txt_prod_weight.Location = new System.Drawing.Point(194, 40);
            this.txt_prod_weight.Name = "txt_prod_weight";
            this.txt_prod_weight.Size = new System.Drawing.Size(44, 20);
            this.txt_prod_weight.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(139, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Price/Pc";
            // 
            // txt_prod_pricepp
            // 
            this.txt_prod_pricepp.Location = new System.Drawing.Point(194, 9);
            this.txt_prod_pricepp.Name = "txt_prod_pricepp";
            this.txt_prod_pricepp.Size = new System.Drawing.Size(44, 20);
            this.txt_prod_pricepp.TabIndex = 10;
            // 
            // cb_prod_type
            // 
            this.cb_prod_type.FormattingEnabled = true;
            this.cb_prod_type.Items.AddRange(new object[] {
            "Purchase",
            "Manufacture"});
            this.cb_prod_type.Location = new System.Drawing.Point(145, 66);
            this.cb_prod_type.Name = "cb_prod_type";
            this.cb_prod_type.Size = new System.Drawing.Size(93, 21);
            this.cb_prod_type.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(102, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Type";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Rate";
            // 
            // btn_prod_add
            // 
            this.btn_prod_add.Location = new System.Drawing.Point(199, 90);
            this.btn_prod_add.Name = "btn_prod_add";
            this.btn_prod_add.Size = new System.Drawing.Size(39, 20);
            this.btn_prod_add.TabIndex = 15;
            this.btn_prod_add.Text = "Go";
            this.btn_prod_add.UseVisualStyleBackColor = true;
            this.btn_prod_add.Click += new System.EventHandler(this.btn_prod_add_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.cb_cust_city);
            this.panel3.Controls.Add(this.btn_cust_add);
            this.panel3.Controls.Add(this.txt_cust_mob2);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txt_cust_mob1);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txt_cust_comp);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txt_cust_name);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(249, 148);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(246, 143);
            this.panel3.TabIndex = 24;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 119);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(24, 13);
            this.label17.TabIndex = 22;
            this.label17.Text = "City";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // cb_cust_city
            // 
            this.cb_cust_city.FormattingEnabled = true;
            this.cb_cust_city.Items.AddRange(new object[] {
            "Karachi",
            "Hyderabad",
            "Mir Pur Khas",
            "Raheem Yar Khan",
            "Sukkur",
            "Quetta",
            "Nawab Shah",
            "Sibbi",
            "Badin",
            "Qazi Ahmed",
            "Tando Adam",
            "Sanghar",
            "Jacobabad",
            "Gawadar",
            "Bhawal Nagar",
            "Sehwan Sharif",
            "Kotri"});
            this.cb_cust_city.Location = new System.Drawing.Point(92, 116);
            this.cb_cust_city.Name = "cb_cust_city";
            this.cb_cust_city.Size = new System.Drawing.Size(100, 21);
            this.cb_cust_city.TabIndex = 20;
            this.cb_cust_city.Text = "karachi";
            this.cb_cust_city.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_cust_city_KeyPress);
            // 
            // btn_cust_add
            // 
            this.btn_cust_add.Location = new System.Drawing.Point(198, 116);
            this.btn_cust_add.Name = "btn_cust_add";
            this.btn_cust_add.Size = new System.Drawing.Size(39, 21);
            this.btn_cust_add.TabIndex = 21;
            this.btn_cust_add.Text = "Go";
            this.btn_cust_add.UseVisualStyleBackColor = true;
            this.btn_cust_add.Click += new System.EventHandler(this.btn_cust_add_Click);
            // 
            // txt_cust_mob2
            // 
            this.txt_cust_mob2.Location = new System.Drawing.Point(92, 91);
            this.txt_cust_mob2.Name = "txt_cust_mob2";
            this.txt_cust_mob2.Size = new System.Drawing.Size(100, 20);
            this.txt_cust_mob2.TabIndex = 19;
            this.txt_cust_mob2.Text = "0";
            this.txt_cust_mob2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cust_mob2_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Mobile";
            // 
            // txt_cust_mob1
            // 
            this.txt_cust_mob1.Location = new System.Drawing.Point(92, 65);
            this.txt_cust_mob1.Name = "txt_cust_mob1";
            this.txt_cust_mob1.Size = new System.Drawing.Size(100, 20);
            this.txt_cust_mob1.TabIndex = 18;
            this.txt_cust_mob1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cust_mob1_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Mobile";
            // 
            // special
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 448);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_inv_date);
            this.Controls.Add(this.panel1);
            this.Name = "special";
            this.Text = "special";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker txt_inv_date;
        private System.Windows.Forms.TextBox txt_cust_comp;
        private System.Windows.Forms.TextBox txt_inv_invnum;
        private System.Windows.Forms.TextBox txt_inv_item_id;
        private System.Windows.Forms.TextBox txt_inv_prod_qty;
        private System.Windows.Forms.TextBox txt_inv_prod_rate;
        private System.Windows.Forms.TextBox txt_cust_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_prod_id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_prod_desc;
        private System.Windows.Forms.TextBox txt_prod_rate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_inv_prod_search;
        private System.Windows.Forms.Button btn_inv_mob_search;
        private System.Windows.Forms.TextBox txt_inv_mob;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_prod_add;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_cust_add;
        private System.Windows.Forms.TextBox txt_cust_mob2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_cust_mob1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_prod_type;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_prod_pricepp;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_prod_weight;
        private System.Windows.Forms.TextBox txt_inv_company;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cb_cust_city;
    }
}