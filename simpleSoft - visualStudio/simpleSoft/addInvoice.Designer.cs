namespace simpleSoft
{
    partial class addInvoice
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_comp_name = new System.Windows.Forms.TextBox();
            this.txt_inv_number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cust_name = new System.Windows.Forms.TextBox();
            this.txt_mobile1 = new System.Windows.Forms.TextBox();
            this.txt_prod_id = new System.Windows.Forms.TextBox();
            this.txt_prod_qty = new System.Windows.Forms.TextBox();
            this.txt_prod_rate = new System.Windows.Forms.TextBox();
            this.txt_prod_disc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_prod_total = new System.Windows.Forms.TextBox();
            this.btn_add_prod = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_notes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_serial = new System.Windows.Forms.Label();
            this.btn_inv_save = new System.Windows.Forms.Button();
            this.btn_inv_print = new System.Windows.Forms.Button();
            this.btn_inv_printDC = new System.Windows.Forms.Button();
            this.btn_inv_exit = new System.Windows.Forms.Button();
            this.txt_design = new System.Windows.Forms.TextBox();
            this.txt_cartage = new System.Windows.Forms.TextBox();
            this.txt_add_less = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_advance = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cb_sales_reps = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txt_date = new System.Windows.Forms.DateTimePicker();
            this.txt_prod_desc = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lbl_sub_total = new System.Windows.Forms.TextBox();
            this.lbl_total = new System.Windows.Forms.TextBox();
            this.lbl_balance = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.txt_temp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(0, 359);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(473, 118);
            this.dataGridView1.TabIndex = 0;
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
            this.deleteToolStripMenuItem.Text = "Edit";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Delete";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(324, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Date";
            // 
            // txt_comp_name
            // 
            this.txt_comp_name.Location = new System.Drawing.Point(155, 64);
            this.txt_comp_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_comp_name.Name = "txt_comp_name";
            this.txt_comp_name.Size = new System.Drawing.Size(115, 20);
            this.txt_comp_name.TabIndex = 16;
            this.toolTip1.SetToolTip(this.txt_comp_name, "Company Name");
            // 
            // txt_inv_number
            // 
            this.txt_inv_number.Location = new System.Drawing.Point(374, 20);
            this.txt_inv_number.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_inv_number.Name = "txt_inv_number";
            this.txt_inv_number.Size = new System.Drawing.Size(95, 20);
            this.txt_inv_number.TabIndex = 0;
            this.txt_inv_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_inv_number_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(293, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Exp Inv #";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_cust_name
            // 
            this.txt_cust_name.Location = new System.Drawing.Point(155, 40);
            this.txt_cust_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cust_name.Name = "txt_cust_name";
            this.txt_cust_name.Size = new System.Drawing.Size(115, 20);
            this.txt_cust_name.TabIndex = 19;
            this.toolTip1.SetToolTip(this.txt_cust_name, "Customer Name");
            // 
            // txt_mobile1
            // 
            this.txt_mobile1.Location = new System.Drawing.Point(43, 64);
            this.txt_mobile1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_mobile1.Name = "txt_mobile1";
            this.txt_mobile1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_mobile1.Size = new System.Drawing.Size(100, 20);
            this.txt_mobile1.TabIndex = 3;
            this.txt_mobile1.TextChanged += new System.EventHandler(this.txt_mobile1_TextChanged);
            this.txt_mobile1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mobile1_KeyPress);
            // 
            // txt_prod_id
            // 
            this.txt_prod_id.Location = new System.Drawing.Point(43, 117);
            this.txt_prod_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_prod_id.Name = "txt_prod_id";
            this.txt_prod_id.Size = new System.Drawing.Size(71, 20);
            this.txt_prod_id.TabIndex = 4;
            this.txt_prod_id.TextChanged += new System.EventHandler(this.txt_prod_id_TextChanged);
            this.txt_prod_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_prod_id_KeyPress);
            // 
            // txt_prod_qty
            // 
            this.txt_prod_qty.Location = new System.Drawing.Point(122, 117);
            this.txt_prod_qty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_prod_qty.Name = "txt_prod_qty";
            this.txt_prod_qty.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_prod_qty.Size = new System.Drawing.Size(55, 20);
            this.txt_prod_qty.TabIndex = 5;
            this.txt_prod_qty.Text = "0";
            this.txt_prod_qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_prod_qty_KeyPress);
            this.txt_prod_qty.Leave += new System.EventHandler(this.txt_prod_qty_Leave);
            // 
            // txt_prod_rate
            // 
            this.txt_prod_rate.Location = new System.Drawing.Point(183, 117);
            this.txt_prod_rate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_prod_rate.Name = "txt_prod_rate";
            this.txt_prod_rate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_prod_rate.Size = new System.Drawing.Size(55, 20);
            this.txt_prod_rate.TabIndex = 6;
            this.txt_prod_rate.Text = "0";
            this.txt_prod_rate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_prod_rate_KeyPress);
            this.txt_prod_rate.Leave += new System.EventHandler(this.txt_prod_rate_Leave);
            // 
            // txt_prod_disc
            // 
            this.txt_prod_disc.Location = new System.Drawing.Point(244, 117);
            this.txt_prod_disc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_prod_disc.Name = "txt_prod_disc";
            this.txt_prod_disc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_prod_disc.Size = new System.Drawing.Size(55, 20);
            this.txt_prod_disc.TabIndex = 7;
            this.txt_prod_disc.Text = "0";
            this.txt_prod_disc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_prod_disc_KeyPress);
            this.txt_prod_disc.Leave += new System.EventHandler(this.txt_prod_disc_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(40, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Prod Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(136, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Qty";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(194, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(244, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Disc(%)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(311, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "Total";
            // 
            // txt_prod_total
            // 
            this.txt_prod_total.Location = new System.Drawing.Point(303, 117);
            this.txt_prod_total.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_prod_total.Name = "txt_prod_total";
            this.txt_prod_total.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_prod_total.Size = new System.Drawing.Size(55, 20);
            this.txt_prod_total.TabIndex = 8;
            this.txt_prod_total.Text = "0";
            this.txt_prod_total.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_prod_total_KeyPress);
            // 
            // btn_add_prod
            // 
            this.btn_add_prod.Location = new System.Drawing.Point(364, 114);
            this.btn_add_prod.Name = "btn_add_prod";
            this.btn_add_prod.Size = new System.Drawing.Size(75, 23);
            this.btn_add_prod.TabIndex = 9;
            this.btn_add_prod.Text = "Add";
            this.btn_add_prod.UseVisualStyleBackColor = true;
            this.btn_add_prod.Click += new System.EventHandler(this.btn_add_prod_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(42, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "Mobile Number";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txt_notes
            // 
            this.txt_notes.Location = new System.Drawing.Point(70, 304);
            this.txt_notes.Name = "txt_notes";
            this.txt_notes.Size = new System.Drawing.Size(369, 20);
            this.txt_notes.TabIndex = 16;
            this.toolTip1.SetToolTip(this.txt_notes, "Add Notes here");
            this.txt_notes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_notes_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(19, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 16);
            this.label9.TabIndex = 35;
            this.label9.Text = "Notes";
            // 
            // lbl_serial
            // 
            this.lbl_serial.AutoSize = true;
            this.lbl_serial.BackColor = System.Drawing.Color.Transparent;
            this.lbl_serial.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_serial.ForeColor = System.Drawing.Color.Black;
            this.lbl_serial.Location = new System.Drawing.Point(19, 121);
            this.lbl_serial.Name = "lbl_serial";
            this.lbl_serial.Size = new System.Drawing.Size(16, 16);
            this.lbl_serial.TabIndex = 36;
            this.lbl_serial.Text = "0";
            // 
            // btn_inv_save
            // 
            this.btn_inv_save.Location = new System.Drawing.Point(95, 330);
            this.btn_inv_save.Name = "btn_inv_save";
            this.btn_inv_save.Size = new System.Drawing.Size(75, 23);
            this.btn_inv_save.TabIndex = 17;
            this.btn_inv_save.Text = "Save";
            this.btn_inv_save.UseVisualStyleBackColor = true;
            this.btn_inv_save.Click += new System.EventHandler(this.btn_inv_save_Click);
            // 
            // btn_inv_print
            // 
            this.btn_inv_print.Location = new System.Drawing.Point(176, 330);
            this.btn_inv_print.Name = "btn_inv_print";
            this.btn_inv_print.Size = new System.Drawing.Size(75, 23);
            this.btn_inv_print.TabIndex = 18;
            this.btn_inv_print.Text = "Print";
            this.btn_inv_print.UseVisualStyleBackColor = true;
            this.btn_inv_print.Click += new System.EventHandler(this.btn_inv_print_Click);
            // 
            // btn_inv_printDC
            // 
            this.btn_inv_printDC.Location = new System.Drawing.Point(258, 330);
            this.btn_inv_printDC.Name = "btn_inv_printDC";
            this.btn_inv_printDC.Size = new System.Drawing.Size(75, 23);
            this.btn_inv_printDC.TabIndex = 19;
            this.btn_inv_printDC.Text = "Print DC";
            this.btn_inv_printDC.UseVisualStyleBackColor = true;
            // 
            // btn_inv_exit
            // 
            this.btn_inv_exit.Location = new System.Drawing.Point(339, 330);
            this.btn_inv_exit.Name = "btn_inv_exit";
            this.btn_inv_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_inv_exit.TabIndex = 20;
            this.btn_inv_exit.Text = "Exit";
            this.btn_inv_exit.UseVisualStyleBackColor = true;
            this.btn_inv_exit.Click += new System.EventHandler(this.btn_inv_exit_Click);
            // 
            // txt_design
            // 
            this.txt_design.Location = new System.Drawing.Point(364, 168);
            this.txt_design.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_design.Name = "txt_design";
            this.txt_design.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_design.Size = new System.Drawing.Size(75, 20);
            this.txt_design.TabIndex = 12;
            this.txt_design.Text = "0";
            this.txt_design.TextChanged += new System.EventHandler(this.txt_design_TextChanged);
            this.txt_design.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_design_KeyPress);
            // 
            // txt_cartage
            // 
            this.txt_cartage.Location = new System.Drawing.Point(364, 190);
            this.txt_cartage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cartage.Name = "txt_cartage";
            this.txt_cartage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_cartage.Size = new System.Drawing.Size(75, 20);
            this.txt_cartage.TabIndex = 13;
            this.txt_cartage.Text = "0";
            this.txt_cartage.TextChanged += new System.EventHandler(this.txt_cartage_TextChanged);
            this.txt_cartage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cartage_KeyPress);
            // 
            // txt_add_less
            // 
            this.txt_add_less.Location = new System.Drawing.Point(364, 212);
            this.txt_add_less.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_add_less.Name = "txt_add_less";
            this.txt_add_less.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_add_less.Size = new System.Drawing.Size(75, 20);
            this.txt_add_less.TabIndex = 14;
            this.txt_add_less.Text = "0";
            this.txt_add_less.TextChanged += new System.EventHandler(this.txt_add_less_TextChanged);
            this.txt_add_less.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_add_less_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(276, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 16);
            this.label10.TabIndex = 44;
            this.label10.Text = "Add/Less";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(276, 197);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 16);
            this.label11.TabIndex = 45;
            this.label11.Text = "Cartage";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(276, 173);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 16);
            this.label12.TabIndex = 46;
            this.label12.Text = "Design";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(277, 261);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 16);
            this.label13.TabIndex = 48;
            this.label13.Text = "Advance";
            // 
            // txt_advance
            // 
            this.txt_advance.Location = new System.Drawing.Point(364, 256);
            this.txt_advance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_advance.Name = "txt_advance";
            this.txt_advance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_advance.Size = new System.Drawing.Size(75, 20);
            this.txt_advance.TabIndex = 15;
            this.txt_advance.Text = "0";
            this.txt_advance.TextChanged += new System.EventHandler(this.txt_advance_TextChanged);
            this.txt_advance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_advance_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(277, 241);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 16);
            this.label14.TabIndex = 49;
            this.label14.Text = "Total";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(277, 277);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 16);
            this.label17.TabIndex = 51;
            this.label17.Text = "Balance";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(70, 169);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 126);
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(285, 68);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 16);
            this.label18.TabIndex = 54;
            this.label18.Text = "Sales Reps";
            // 
            // cb_sales_reps
            // 
            this.cb_sales_reps.DisplayMember = "1";
            this.cb_sales_reps.FormattingEnabled = true;
            this.cb_sales_reps.Items.AddRange(new object[] {
            "Faizan Ahmed",
            "Hanif",
            "Qaiser Anwar"});
            this.cb_sales_reps.Location = new System.Drawing.Point(374, 68);
            this.cb_sales_reps.Name = "cb_sales_reps";
            this.cb_sales_reps.Size = new System.Drawing.Size(95, 21);
            this.cb_sales_reps.TabIndex = 2;
            this.cb_sales_reps.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_sales_reps_KeyPress);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // txt_date
            // 
            this.txt_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_date.Location = new System.Drawing.Point(374, 44);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(95, 20);
            this.txt_date.TabIndex = 0;
            this.txt_date.Value = new System.DateTime(2015, 1, 8, 0, 0, 0, 0);
            this.txt_date.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_date_KeyPress);
            // 
            // txt_prod_desc
            // 
            this.txt_prod_desc.Location = new System.Drawing.Point(43, 138);
            this.txt_prod_desc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_prod_desc.Name = "txt_prod_desc";
            this.txt_prod_desc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_prod_desc.Size = new System.Drawing.Size(227, 20);
            this.txt_prod_desc.TabIndex = 55;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(276, 151);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 16);
            this.label16.TabIndex = 56;
            this.label16.Text = "Sub - Total";
            // 
            // lbl_sub_total
            // 
            this.lbl_sub_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sub_total.Location = new System.Drawing.Point(364, 147);
            this.lbl_sub_total.Name = "lbl_sub_total";
            this.lbl_sub_total.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_sub_total.Size = new System.Drawing.Size(75, 20);
            this.lbl_sub_total.TabIndex = 57;
            this.lbl_sub_total.Text = "0";
            // 
            // lbl_total
            // 
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(364, 234);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_total.Size = new System.Drawing.Size(75, 20);
            this.lbl_total.TabIndex = 58;
            this.lbl_total.Text = "0";
            // 
            // lbl_balance
            // 
            this.lbl_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_balance.Location = new System.Drawing.Point(364, 278);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_balance.Size = new System.Drawing.Size(75, 20);
            this.lbl_balance.TabIndex = 59;
            this.lbl_balance.Text = "0";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // txt_temp
            // 
            this.txt_temp.Location = new System.Drawing.Point(5, 285);
            this.txt_temp.Name = "txt_temp";
            this.txt_temp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_temp.Size = new System.Drawing.Size(10, 20);
            this.txt_temp.TabIndex = 60;
            // 
            // addInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(473, 477);
            this.Controls.Add(this.txt_temp);
            this.Controls.Add(this.lbl_balance);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_sub_total);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_prod_desc);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.cb_sales_reps);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_advance);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_add_less);
            this.Controls.Add(this.txt_cartage);
            this.Controls.Add(this.txt_design);
            this.Controls.Add(this.btn_inv_exit);
            this.Controls.Add(this.btn_inv_printDC);
            this.Controls.Add(this.btn_inv_print);
            this.Controls.Add(this.btn_inv_save);
            this.Controls.Add(this.lbl_serial);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_notes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_add_prod);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_prod_total);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_prod_disc);
            this.Controls.Add(this.txt_prod_rate);
            this.Controls.Add(this.txt_prod_qty);
            this.Controls.Add(this.txt_prod_id);
            this.Controls.Add(this.txt_mobile1);
            this.Controls.Add(this.txt_cust_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_inv_number);
            this.Controls.Add(this.txt_comp_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "addInvoice";
            this.Text = "invoice";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_comp_name;
        private System.Windows.Forms.TextBox txt_inv_number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cust_name;
        private System.Windows.Forms.TextBox txt_mobile1;
        private System.Windows.Forms.TextBox txt_prod_id;
        private System.Windows.Forms.TextBox txt_prod_qty;
        private System.Windows.Forms.TextBox txt_prod_rate;
        private System.Windows.Forms.TextBox txt_prod_disc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_prod_total;
        private System.Windows.Forms.Button btn_add_prod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_notes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_serial;
        private System.Windows.Forms.Button btn_inv_save;
        private System.Windows.Forms.Button btn_inv_print;
        private System.Windows.Forms.Button btn_inv_printDC;
        private System.Windows.Forms.Button btn_inv_exit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txt_design;
        private System.Windows.Forms.TextBox txt_cartage;
        private System.Windows.Forms.TextBox txt_add_less;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_advance;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cb_sales_reps;
        private System.Windows.Forms.DateTimePicker txt_date;
        private System.Windows.Forms.TextBox txt_prod_desc;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox lbl_sub_total;
        private System.Windows.Forms.TextBox lbl_total;
        private System.Windows.Forms.TextBox lbl_balance;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox txt_temp;
    }
}