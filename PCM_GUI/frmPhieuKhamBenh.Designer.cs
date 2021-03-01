namespace PCM_GUI
{
    partial class frmPhieuKhamBenh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuKhamBenh));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonThem = new System.Windows.Forms.Button();
            this.comboBoxLB = new System.Windows.Forms.ComboBox();
            this.comboBoxTT = new System.Windows.Forms.ComboBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.txtCachDung = new System.Windows.Forms.TextBox();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtNgayKham = new System.Windows.Forms.TextBox();
            this.txtTrieuChung = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(415, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 23);
            this.button1.TabIndex = 54;
            this.button1.Text = "Xem Trước Phiếu Khám Bệnh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(415, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(379, 170);
            this.dataGridView1.TabIndex = 52;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.PrintPreviewDialog1_Load_1);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 26);
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(88, 284);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(75, 23);
            this.buttonThem.TabIndex = 53;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.ButtonThem_Click_1);
            // 
            // comboBoxLB
            // 
            this.comboBoxLB.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBoxLB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLB.FormattingEnabled = true;
            this.comboBoxLB.Items.AddRange(new object[] {
            "Paracetamol",
            "Alaxan",
            "Decolgen",
            "Hapacol Codein",
            "Panadol Extra",
            "Phosphalugel",
            "Yumangel",
            "Gastropulgite",
            "Gaviscon",
            "Trimafort",
            "Penicillin",
            "Amoxillin",
            "Aspirin",
            "Codein Sunfat",
            "Pepto-Bismol",
            "Domperidon",
            "Maalox",
            "Carbotrim",
            "Floctafenine",
            "Tramadol",
            "Opioid Morphin",
            "Fentanyl",
            "Oxycodon",
            "Naproxem",
            "Acetaminophen",
            "Efferalgan",
            "Tiffy",
            "Yuraf",
            "Coldacmin",
            "E-cox 90"});
            this.comboBoxLB.Location = new System.Drawing.Point(77, 120);
            this.comboBoxLB.Name = "comboBoxLB";
            this.comboBoxLB.Size = new System.Drawing.Size(306, 21);
            this.comboBoxLB.TabIndex = 51;
            // 
            // comboBoxTT
            // 
            this.comboBoxTT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTT.FormattingEnabled = true;
            this.comboBoxTT.Items.AddRange(new object[] {
            "Nhức Đầu",
            "Đau bụng",
            "Đau bao tử",
            "Sốt",
            "Tiêu Chảy"});
            this.comboBoxTT.Location = new System.Drawing.Point(391, 82);
            this.comboBoxTT.Name = "comboBoxTT";
            this.comboBoxTT.Size = new System.Drawing.Size(220, 21);
            this.comboBoxTT.TabIndex = 50;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(193, 284);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 23);
            this.btnIn.TabIndex = 49;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.BtnIn_Click);
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox15.Location = new System.Drawing.Point(6, 229);
            this.textBox15.Multiline = true;
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(65, 21);
            this.textBox15.TabIndex = 48;
            this.textBox15.Text = "Cách Dùng";
            this.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox14.Location = new System.Drawing.Point(183, 154);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(65, 13);
            this.textBox14.TabIndex = 47;
            this.textBox14.Text = "Đơn Vị";
            this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox13.Location = new System.Drawing.Point(74, 152);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(65, 13);
            this.textBox13.TabIndex = 46;
            this.textBox13.Text = "Số Lượng";
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Location = new System.Drawing.Point(10, 123);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(65, 13);
            this.textBox12.TabIndex = 45;
            this.textBox12.Text = "Tên Thuốc";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCachDung
            // 
            this.txtCachDung.Location = new System.Drawing.Point(74, 199);
            this.txtCachDung.Multiline = true;
            this.txtCachDung.Name = "txtCachDung";
            this.txtCachDung.Size = new System.Drawing.Size(335, 80);
            this.txtCachDung.TabIndex = 44;
            // 
            // txtDonVi
            // 
            this.txtDonVi.Location = new System.Drawing.Point(161, 173);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(107, 20);
            this.txtDonVi.TabIndex = 43;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(74, 173);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(62, 20);
            this.txtSL.TabIndex = 42;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Location = new System.Drawing.Point(302, 82);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(81, 20);
            this.textBox7.TabIndex = 41;
            this.textBox7.Text = "Loại Bệnh";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(302, 59);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(83, 17);
            this.textBox6.TabIndex = 40;
            this.textBox6.Text = "Ngày Khám";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(10, 86);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(61, 26);
            this.textBox5.TabIndex = 39;
            this.textBox5.Text = "Triệu Chứng";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(10, 59);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(55, 17);
            this.textBox1.TabIndex = 38;
            this.textBox1.Text = "Họ Tên";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNgayKham
            // 
            this.txtNgayKham.BackColor = System.Drawing.SystemColors.Window;
            this.txtNgayKham.Location = new System.Drawing.Point(391, 56);
            this.txtNgayKham.Name = "txtNgayKham";
            this.txtNgayKham.Size = new System.Drawing.Size(220, 20);
            this.txtNgayKham.TabIndex = 37;
            // 
            // txtTrieuChung
            // 
            this.txtTrieuChung.BackColor = System.Drawing.SystemColors.Window;
            this.txtTrieuChung.Location = new System.Drawing.Point(77, 82);
            this.txtTrieuChung.Name = "txtTrieuChung";
            this.txtTrieuChung.Size = new System.Drawing.Size(182, 20);
            this.txtTrieuChung.TabIndex = 36;
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.SystemColors.Window;
            this.txtHoTen.Location = new System.Drawing.Point(77, 56);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(182, 20);
            this.txtHoTen.TabIndex = 35;
            // 
            // frmPhieuKhamBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 330);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.comboBoxLB);
            this.Controls.Add(this.comboBoxTT);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.txtCachDung);
            this.Controls.Add(this.txtDonVi);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtNgayKham);
            this.Controls.Add(this.txtTrieuChung);
            this.Controls.Add(this.txtHoTen);
            this.Name = "frmPhieuKhamBenh";
            this.Text = "Phiếu Khám Bệnh";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.ComboBox comboBoxLB;
        private System.Windows.Forms.ComboBox comboBoxTT;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox txtCachDung;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtNgayKham;
        private System.Windows.Forms.TextBox txtTrieuChung;
        private System.Windows.Forms.TextBox txtHoTen;
    }
}