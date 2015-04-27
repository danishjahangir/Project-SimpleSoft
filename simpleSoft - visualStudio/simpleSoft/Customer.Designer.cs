namespace simpleSoft
{
    partial class Customer
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
            this.components = new System.ComponentModel.Container();
            this.txt_company = new System.Windows.Forms.TextBox();
            this.txt_custName = new System.Windows.Forms.TextBox();
            this.cb_city = new System.Windows.Forms.ComboBox();
            this.txt_mobile1 = new System.Windows.Forms.TextBox();
            this.txt_mobile3 = new System.Windows.Forms.TextBox();
            this.txt_mobile2 = new System.Windows.Forms.TextBox();
            this.txt_Office1 = new System.Windows.Forms.TextBox();
            this.txt_Office2 = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_fax = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_edited = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.cb_search = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.OpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_company
            // 
            this.txt_company.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_company.Location = new System.Drawing.Point(69, 122);
            this.txt_company.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_company.Name = "txt_company";
            this.txt_company.Size = new System.Drawing.Size(154, 22);
            this.txt_company.TabIndex = 2;
            this.txt_company.TextChanged += new System.EventHandler(this.txt_company_TextChanged);
            this.txt_company.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_company_KeyPress);
            // 
            // txt_custName
            // 
            this.txt_custName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_custName.Location = new System.Drawing.Point(69, 95);
            this.txt_custName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_custName.Name = "txt_custName";
            this.txt_custName.Size = new System.Drawing.Size(114, 22);
            this.txt_custName.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txt_custName, "Name plz");
            this.txt_custName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_custName_KeyPress);
            // 
            // cb_city
            // 
            this.cb_city.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cb_city.DisplayMember = "Karachi";
            this.cb_city.FormattingEnabled = true;
            this.cb_city.Items.AddRange(new object[] {
            "Default",
            "Karachi",
            "Hyderabad",
            "Sukkur",
            "Bawalpur",
            "Sadiqabad",
            "Haripur",
            "Lahore",
            "Islamabad",
            "Faisalabad",
            "Dado",
            "Larkana",
            "Khairpur",
            "Gwadar",
            "Quetta"});
            this.cb_city.Location = new System.Drawing.Point(241, 91);
            this.cb_city.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_city.Name = "cb_city";
            this.cb_city.Size = new System.Drawing.Size(116, 24);
            this.cb_city.TabIndex = 1;
            this.toolTip1.SetToolTip(this.cb_city, "Enter City here");
            this.cb_city.ValueMember = "Karachi";
            this.cb_city.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_city_KeyPress);
            // 
            // txt_mobile1
            // 
            this.txt_mobile1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_mobile1.Location = new System.Drawing.Point(69, 149);
            this.txt_mobile1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_mobile1.Name = "txt_mobile1";
            this.txt_mobile1.Size = new System.Drawing.Size(114, 22);
            this.txt_mobile1.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txt_mobile1, "Enter mobile here");
            this.txt_mobile1.TextChanged += new System.EventHandler(this.txt_mobile1_TextChanged);
            this.txt_mobile1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mobile1_KeyPress);
            // 
            // txt_mobile3
            // 
            this.txt_mobile3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_mobile3.Location = new System.Drawing.Point(69, 175);
            this.txt_mobile3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_mobile3.Name = "txt_mobile3";
            this.txt_mobile3.Size = new System.Drawing.Size(114, 22);
            this.txt_mobile3.TabIndex = 6;
            this.txt_mobile3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mobile3_KeyPress);
            // 
            // txt_mobile2
            // 
            this.txt_mobile2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_mobile2.Location = new System.Drawing.Point(251, 147);
            this.txt_mobile2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_mobile2.Name = "txt_mobile2";
            this.txt_mobile2.Size = new System.Drawing.Size(106, 22);
            this.txt_mobile2.TabIndex = 5;
            this.txt_mobile2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mobile2_KeyPress);
            // 
            // txt_Office1
            // 
            this.txt_Office1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_Office1.Location = new System.Drawing.Point(251, 174);
            this.txt_Office1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Office1.Name = "txt_Office1";
            this.txt_Office1.Size = new System.Drawing.Size(106, 22);
            this.txt_Office1.TabIndex = 7;
            this.txt_Office1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Office1_KeyPress);
            // 
            // txt_Office2
            // 
            this.txt_Office2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_Office2.Location = new System.Drawing.Point(69, 201);
            this.txt_Office2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Office2.Name = "txt_Office2";
            this.txt_Office2.Size = new System.Drawing.Size(114, 22);
            this.txt_Office2.TabIndex = 8;
            this.txt_Office2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Office2_KeyPress);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_save.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.Black;
            this.btn_save.Location = new System.Drawing.Point(148, 237);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(67, 24);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_fax
            // 
            this.txt_fax.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_fax.Location = new System.Drawing.Point(251, 201);
            this.txt_fax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_fax.Name = "txt_fax";
            this.txt_fax.Size = new System.Drawing.Size(106, 22);
            this.txt_fax.TabIndex = 9;
            this.txt_fax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_fax_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 279);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.Size = new System.Drawing.Size(646, 226);
            this.dataGridView1.TabIndex = 11;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.editToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 48);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(7, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mobile1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(7, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Mobile3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(7, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Office2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(-3, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Company";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(189, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "City";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(189, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Mobile2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(189, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Office1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(189, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Fax";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(527, 96);
            this.txt_search.Margin = new System.Windows.Forms.Padding(2);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(107, 22);
            this.txt_search.TabIndex = 15;
            this.txt_search.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_search_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(370, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Search";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(290, 237);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 24);
            this.button2.TabIndex = 13;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_edited
            // 
            this.btn_edited.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_edited.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edited.ForeColor = System.Drawing.Color.Black;
            this.btn_edited.Location = new System.Drawing.Point(219, 237);
            this.btn_edited.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_edited.Name = "btn_edited";
            this.btn_edited.Size = new System.Drawing.Size(67, 24);
            this.btn_edited.TabIndex = 11;
            this.btn_edited.Text = "Edited";
            this.btn_edited.UseVisualStyleBackColor = false;
            this.btn_edited.Click += new System.EventHandler(this.btn_edited_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(77, 237);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(67, 24);
            this.button5.TabIndex = 12;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // cb_search
            // 
            this.cb_search.FormattingEnabled = true;
            this.cb_search.Items.AddRange(new object[] {
            "Name",
            "Company Name",
            "Mobile Number",
            "Fax"});
            this.cb_search.Location = new System.Drawing.Point(423, 95);
            this.cb_search.Name = "cb_search";
            this.cb_search.Size = new System.Drawing.Size(99, 24);
            this.cb_search.TabIndex = 14;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // OpenDialog
            // 
            this.OpenDialog.FileName = "OpenDialog";
            this.OpenDialog.Filter = "Text Document|*.txt";
            // 
            // SaveDialog
            // 
            this.SaveDialog.Filter = "Text Document|*.txt";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(454, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 16);
            this.label11.TabIndex = 39;
            this.label11.Text = "Contact  03452223364";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(229, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 16);
            this.label12.TabIndex = 41;
            this.label12.Text = "Initial Bal";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.Location = new System.Drawing.Point(310, 120);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(47, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(646, 505);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cb_search);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn_edited);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_fax);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_Office2);
            this.Controls.Add(this.txt_Office1);
            this.Controls.Add(this.txt_mobile2);
            this.Controls.Add(this.txt_mobile3);
            this.Controls.Add(this.txt_mobile1);
            this.Controls.Add(this.cb_city);
            this.Controls.Add(this.txt_custName);
            this.Controls.Add(this.txt_company);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Customer";
            this.Text = "::Customer Profile::";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_company;
        private System.Windows.Forms.TextBox txt_custName;
        private System.Windows.Forms.ComboBox cb_city;
        private System.Windows.Forms.TextBox txt_mobile1;
        private System.Windows.Forms.TextBox txt_mobile3;
        private System.Windows.Forms.TextBox txt_mobile2;
        private System.Windows.Forms.TextBox txt_Office1;
        private System.Windows.Forms.TextBox txt_Office2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_fax;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Button btn_edited;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox cb_search;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog OpenDialog;
        private System.Windows.Forms.SaveFileDialog SaveDialog;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
    }
}

