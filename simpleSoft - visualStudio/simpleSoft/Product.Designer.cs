namespace simpleSoft
{
    partial class Product
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
            this.txt_code = new System.Windows.Forms.TextBox();
            this.txt_prodPay = new System.Windows.Forms.TextBox();
            this.txt_prodWeight = new System.Windows.Forms.TextBox();
            this.txt_prodMaxPrice = new System.Windows.Forms.TextBox();
            this.txt_prodMinPrice = new System.Windows.Forms.TextBox();
            this.txt_prodDesc = new System.Windows.Forms.TextBox();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_edited = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_code
            // 
            this.txt_code.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_code.Location = new System.Drawing.Point(143, 55);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(92, 20);
            this.txt_code.TabIndex = 0;
            this.txt_code.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_code_KeyPress);
            // 
            // txt_prodPay
            // 
            this.txt_prodPay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_prodPay.Location = new System.Drawing.Point(143, 107);
            this.txt_prodPay.Name = "txt_prodPay";
            this.txt_prodPay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_prodPay.Size = new System.Drawing.Size(100, 20);
            this.txt_prodPay.TabIndex = 3;
            this.txt_prodPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_prodPay_KeyPress);
            // 
            // txt_prodWeight
            // 
            this.txt_prodWeight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_prodWeight.Location = new System.Drawing.Point(143, 132);
            this.txt_prodWeight.Name = "txt_prodWeight";
            this.txt_prodWeight.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_prodWeight.Size = new System.Drawing.Size(100, 20);
            this.txt_prodWeight.TabIndex = 4;
            this.txt_prodWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_prodWeight_KeyPress);
            // 
            // txt_prodMaxPrice
            // 
            this.txt_prodMaxPrice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_prodMaxPrice.Location = new System.Drawing.Point(329, 131);
            this.txt_prodMaxPrice.Name = "txt_prodMaxPrice";
            this.txt_prodMaxPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_prodMaxPrice.Size = new System.Drawing.Size(87, 20);
            this.txt_prodMaxPrice.TabIndex = 6;
            this.txt_prodMaxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_prodMaxPrice_KeyPress);
            // 
            // txt_prodMinPrice
            // 
            this.txt_prodMinPrice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_prodMinPrice.Location = new System.Drawing.Point(329, 107);
            this.txt_prodMinPrice.Name = "txt_prodMinPrice";
            this.txt_prodMinPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_prodMinPrice.Size = new System.Drawing.Size(87, 20);
            this.txt_prodMinPrice.TabIndex = 5;
            this.txt_prodMinPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_prodMinPrice_KeyPress);
            // 
            // txt_prodDesc
            // 
            this.txt_prodDesc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_prodDesc.Location = new System.Drawing.Point(143, 81);
            this.txt_prodDesc.Name = "txt_prodDesc";
            this.txt_prodDesc.Size = new System.Drawing.Size(273, 20);
            this.txt_prodDesc.TabIndex = 2;
            this.txt_prodDesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_prodDesc_KeyPress);
            // 
            // cb_type
            // 
            this.cb_type.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Items.AddRange(new object[] {
            "Manufacture",
            "Purchase",
            "Others"});
            this.cb_type.Location = new System.Drawing.Point(304, 54);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(112, 21);
            this.cb_type.TabIndex = 1;
            this.cb_type.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_type_KeyPress);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Azure;
            this.btn_save.Location = new System.Drawing.Point(198, 174);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(581, 177);
            this.dataGridView1.TabIndex = 18;
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
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_search.Location = new System.Drawing.Point(437, 84);
            this.txt_search.Margin = new System.Windows.Forms.Padding(2);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(129, 20);
            this.txt_search.TabIndex = 11;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(46, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 16);
            this.label9.TabIndex = 31;
            this.label9.Text = "Description";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(46, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 16);
            this.label10.TabIndex = 32;
            this.label10.Text = "Pay Rate / pc";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(244, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 16);
            this.label11.TabIndex = 33;
            this.label11.Text = "Type";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(244, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 16);
            this.label12.TabIndex = 34;
            this.label12.Text = "Min. Price";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(467, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 16);
            this.label13.TabIndex = 34;
            this.label13.Text = "Search";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(245, 134);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 16);
            this.label14.TabIndex = 35;
            this.label14.Text = "Max Price";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(46, 137);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 16);
            this.label15.TabIndex = 36;
            this.label15.Text = "Avg. Weight";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(46, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 16);
            this.label16.TabIndex = 37;
            this.label16.Text = "Code";
            // 
            // btn_edited
            // 
            this.btn_edited.BackColor = System.Drawing.Color.Azure;
            this.btn_edited.Location = new System.Drawing.Point(279, 174);
            this.btn_edited.Name = "btn_edited";
            this.btn_edited.Size = new System.Drawing.Size(75, 23);
            this.btn_edited.TabIndex = 10;
            this.btn_edited.Text = "Edited";
            this.btn_edited.UseVisualStyleBackColor = false;
            this.btn_edited.Click += new System.EventHandler(this.btn_edited_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Azure;
            this.btn_clear.Location = new System.Drawing.Point(361, 174);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(74, 23);
            this.btn_clear.TabIndex = 9;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Azure;
            this.button4.Location = new System.Drawing.Point(117, 174);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(581, 391);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_edited);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.txt_prodMaxPrice);
            this.Controls.Add(this.txt_prodMinPrice);
            this.Controls.Add(this.txt_prodDesc);
            this.Controls.Add(this.txt_prodWeight);
            this.Controls.Add(this.txt_prodPay);
            this.Controls.Add(this.txt_code);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Product";
            this.Text = "::Product::";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.TextBox txt_prodPay;
        private System.Windows.Forms.TextBox txt_prodWeight;
        private System.Windows.Forms.TextBox txt_prodMaxPrice;
        private System.Windows.Forms.TextBox txt_prodMinPrice;
        private System.Windows.Forms.TextBox txt_prodDesc;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_edited;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button button4;
    }
}