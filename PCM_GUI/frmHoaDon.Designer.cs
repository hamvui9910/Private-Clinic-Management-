namespace PCM_GUI
{
    partial class frmHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            this.ItemGroupBox = new System.Windows.Forms.GroupBox();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.lbDVT = new System.Windows.Forms.Label();
            this.dateNgayTao = new System.Windows.Forms.DateTimePicker();
            this.lbNgayTao = new System.Windows.Forms.Label();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.lbMaHoaDon = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.cbLoaiBenh = new System.Windows.Forms.ComboBox();
            this.cbThuoc = new System.Windows.Forms.ComboBox();
            this.lbThuoc = new System.Windows.Forms.Label();
            this.txtTrieuChung = new System.Windows.Forms.TextBox();
            this.lbLoaiBenh = new System.Windows.Forms.Label();
            this.lbTrieuChung = new System.Windows.Forms.Label();
            this.txtTenBN = new System.Windows.Forms.TextBox();
            this.lbTenBN = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbUnit = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTienKham = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongCong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ItemGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemGroupBox
            // 
            this.ItemGroupBox.Controls.Add(this.txtDVT);
            this.ItemGroupBox.Controls.Add(this.lbDVT);
            this.ItemGroupBox.Controls.Add(this.dateNgayTao);
            this.ItemGroupBox.Controls.Add(this.lbNgayTao);
            this.ItemGroupBox.Controls.Add(this.txtMaHoaDon);
            this.ItemGroupBox.Controls.Add(this.lbMaHoaDon);
            this.ItemGroupBox.Controls.Add(this.btnAdd);
            this.ItemGroupBox.Controls.Add(this.txtDonGia);
            this.ItemGroupBox.Controls.Add(this.txtSoLuong);
            this.ItemGroupBox.Controls.Add(this.lbDonGia);
            this.ItemGroupBox.Controls.Add(this.lbSoLuong);
            this.ItemGroupBox.Controls.Add(this.cbLoaiBenh);
            this.ItemGroupBox.Controls.Add(this.cbThuoc);
            this.ItemGroupBox.Controls.Add(this.lbThuoc);
            this.ItemGroupBox.Controls.Add(this.txtTrieuChung);
            this.ItemGroupBox.Controls.Add(this.lbLoaiBenh);
            this.ItemGroupBox.Controls.Add(this.lbTrieuChung);
            this.ItemGroupBox.Controls.Add(this.txtTenBN);
            this.ItemGroupBox.Controls.Add(this.lbTenBN);
            this.ItemGroupBox.Enabled = false;
            this.ItemGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ItemGroupBox.Name = "ItemGroupBox";
            this.ItemGroupBox.Size = new System.Drawing.Size(730, 256);
            this.ItemGroupBox.TabIndex = 0;
            this.ItemGroupBox.TabStop = false;
            // 
            // txtDVT
            // 
            this.txtDVT.BackColor = System.Drawing.SystemColors.Control;
            this.txtDVT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDVT.Location = new System.Drawing.Point(89, 221);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.ReadOnly = true;
            this.txtDVT.Size = new System.Drawing.Size(92, 13);
            this.txtDVT.TabIndex = 21;
            // 
            // lbDVT
            // 
            this.lbDVT.AutoSize = true;
            this.lbDVT.Location = new System.Drawing.Point(20, 221);
            this.lbDVT.Name = "lbDVT";
            this.lbDVT.Size = new System.Drawing.Size(63, 13);
            this.lbDVT.TabIndex = 20;
            this.lbDVT.Text = "Đơn vị tính:";
            this.lbDVT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateNgayTao
            // 
            this.dateNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayTao.Location = new System.Drawing.Point(369, 30);
            this.dateNgayTao.Name = "dateNgayTao";
            this.dateNgayTao.Size = new System.Drawing.Size(92, 20);
            this.dateNgayTao.TabIndex = 19;
            this.dateNgayTao.ValueChanged += new System.EventHandler(this.DateNgayTao_ValueChanged);
            // 
            // lbNgayTao
            // 
            this.lbNgayTao.AutoSize = true;
            this.lbNgayTao.Location = new System.Drawing.Point(311, 33);
            this.lbNgayTao.Name = "lbNgayTao";
            this.lbNgayTao.Size = new System.Drawing.Size(53, 13);
            this.lbNgayTao.TabIndex = 18;
            this.lbNgayTao.Text = "Ngày tạo:";
            this.lbNgayTao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.BackColor = System.Drawing.SystemColors.Control;
            this.txtMaHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaHoaDon.Location = new System.Drawing.Point(109, 30);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.ReadOnly = true;
            this.txtMaHoaDon.Size = new System.Drawing.Size(196, 13);
            this.txtMaHoaDon.TabIndex = 17;
            // 
            // lbMaHoaDon
            // 
            this.lbMaHoaDon.AutoSize = true;
            this.lbMaHoaDon.Location = new System.Drawing.Point(20, 33);
            this.lbMaHoaDon.Name = "lbMaHoaDon";
            this.lbMaHoaDon.Size = new System.Drawing.Size(71, 13);
            this.lbMaHoaDon.TabIndex = 16;
            this.lbMaHoaDon.Text = "Mã Hóa Đơn:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(526, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(181, 186);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Thêm vào hóa đơn";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.BackColor = System.Drawing.SystemColors.Control;
            this.txtDonGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDonGia.Location = new System.Drawing.Point(369, 184);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(92, 13);
            this.txtDonGia.TabIndex = 12;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(239, 184);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(92, 20);
            this.txtSoLuong.TabIndex = 11;
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.Location = new System.Drawing.Point(366, 168);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(47, 13);
            this.lbDonGia.TabIndex = 10;
            this.lbDonGia.Text = "Đơn giá:";
            this.lbDonGia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Location = new System.Drawing.Point(236, 168);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(52, 13);
            this.lbSoLuong.TabIndex = 9;
            this.lbSoLuong.Text = "Số lượng:";
            this.lbSoLuong.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbLoaiBenh
            // 
            this.cbLoaiBenh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiBenh.FormattingEnabled = true;
            this.cbLoaiBenh.Items.AddRange(new object[] {
            "Nhức đầu",
            "Đau bụng",
            "Đau bao tử",
            "Sốt",
            "Tiêu chảy"});
            this.cbLoaiBenh.Location = new System.Drawing.Point(109, 128);
            this.cbLoaiBenh.Name = "cbLoaiBenh";
            this.cbLoaiBenh.Size = new System.Drawing.Size(352, 21);
            this.cbLoaiBenh.TabIndex = 8;
            // 
            // cbThuoc
            // 
            this.cbThuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThuoc.FormattingEnabled = true;
            this.cbThuoc.Items.AddRange(new object[] {
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
            "Oxycodone",
            "Naproxen",
            "Acetaminophen",
            "Efferalgan",
            "Tiffy",
            "Yuraf",
            "Coldacmin",
            "E-cox 90"});
            this.cbThuoc.Location = new System.Drawing.Point(23, 184);
            this.cbThuoc.Name = "cbThuoc";
            this.cbThuoc.Size = new System.Drawing.Size(179, 21);
            this.cbThuoc.TabIndex = 7;
            this.cbThuoc.SelectedValueChanged += new System.EventHandler(this.cbThuoc_SelectedValueChanged);
            // 
            // lbThuoc
            // 
            this.lbThuoc.AutoSize = true;
            this.lbThuoc.Location = new System.Drawing.Point(20, 168);
            this.lbThuoc.Name = "lbThuoc";
            this.lbThuoc.Size = new System.Drawing.Size(41, 13);
            this.lbThuoc.TabIndex = 6;
            this.lbThuoc.Text = "Thuốc:";
            this.lbThuoc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTrieuChung
            // 
            this.txtTrieuChung.Location = new System.Drawing.Point(109, 93);
            this.txtTrieuChung.Name = "txtTrieuChung";
            this.txtTrieuChung.Size = new System.Drawing.Size(352, 20);
            this.txtTrieuChung.TabIndex = 5;
            // 
            // lbLoaiBenh
            // 
            this.lbLoaiBenh.AutoSize = true;
            this.lbLoaiBenh.Location = new System.Drawing.Point(20, 131);
            this.lbLoaiBenh.Name = "lbLoaiBenh";
            this.lbLoaiBenh.Size = new System.Drawing.Size(57, 13);
            this.lbLoaiBenh.TabIndex = 3;
            this.lbLoaiBenh.Text = "Loại bệnh:";
            this.lbLoaiBenh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbTrieuChung
            // 
            this.lbTrieuChung.AutoSize = true;
            this.lbTrieuChung.Location = new System.Drawing.Point(20, 96);
            this.lbTrieuChung.Name = "lbTrieuChung";
            this.lbTrieuChung.Size = new System.Drawing.Size(67, 13);
            this.lbTrieuChung.TabIndex = 2;
            this.lbTrieuChung.Text = "Triệu chứng:";
            // 
            // txtTenBN
            // 
            this.txtTenBN.Location = new System.Drawing.Point(109, 61);
            this.txtTenBN.Name = "txtTenBN";
            this.txtTenBN.Size = new System.Drawing.Size(352, 20);
            this.txtTenBN.TabIndex = 1;
            // 
            // lbTenBN
            // 
            this.lbTenBN.AutoSize = true;
            this.lbTenBN.Location = new System.Drawing.Point(20, 64);
            this.lbTenBN.Name = "lbTenBN";
            this.lbTenBN.Size = new System.Drawing.Size(83, 13);
            this.lbTenBN.TabIndex = 0;
            this.lbTenBN.Text = "Tên bệnh nhân:";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(748, 36);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(134, 57);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Hóa Đơn Mới";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(748, 125);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(134, 57);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "In Hóa Đơn";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Enabled = false;
            this.btnPreview.Location = new System.Drawing.Point(748, 211);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(134, 57);
            this.btnPreview.TabIndex = 3;
            this.btnPreview.Text = "Xem Trước Hóa Đơn";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // dgvHD
            // 
            this.dgvHD.AllowUserToAddRows = false;
            this.dgvHD.AllowUserToDeleteRows = false;
            this.dgvHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHD.Location = new System.Drawing.Point(12, 286);
            this.dgvHD.MultiSelect = false;
            this.dgvHD.Name = "dgvHD";
            this.dgvHD.ReadOnly = true;
            this.dgvHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHD.Size = new System.Drawing.Size(869, 180);
            this.dgvHD.TabIndex = 4;
            this.dgvHD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DgvHD_MouseDown);
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Location = new System.Drawing.Point(748, 493);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(92, 13);
            this.txtTotal.TabIndex = 19;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(674, 495);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(61, 13);
            this.lbTotal.TabIndex = 18;
            this.lbTotal.Text = "Tiền thuốc:";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbUnit
            // 
            this.lbUnit.AutoSize = true;
            this.lbUnit.Location = new System.Drawing.Point(851, 495);
            this.lbUnit.Name = "lbUnit";
            this.lbUnit.Size = new System.Drawing.Size(26, 13);
            this.lbUnit.TabIndex = 20;
            this.lbUnit.Text = "vnđ";
            this.lbUnit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 26);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.XóaToolStripMenuItem_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
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
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(851, 514);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "vnđ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTienKham
            // 
            this.txtTienKham.BackColor = System.Drawing.SystemColors.Control;
            this.txtTienKham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTienKham.Location = new System.Drawing.Point(748, 512);
            this.txtTienKham.Name = "txtTienKham";
            this.txtTienKham.ReadOnly = true;
            this.txtTienKham.Size = new System.Drawing.Size(92, 13);
            this.txtTienKham.TabIndex = 22;
            this.txtTienKham.Text = "0";
            this.txtTienKham.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(674, 514);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tiền khám:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(851, 533);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "vnđ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTongCong
            // 
            this.txtTongCong.BackColor = System.Drawing.SystemColors.Control;
            this.txtTongCong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongCong.Location = new System.Drawing.Point(748, 531);
            this.txtTongCong.Name = "txtTongCong";
            this.txtTongCong.ReadOnly = true;
            this.txtTongCong.Size = new System.Drawing.Size(92, 13);
            this.txtTongCong.TabIndex = 25;
            this.txtTongCong.Text = "0";
            this.txtTongCong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTongCong.TextChanged += new System.EventHandler(this.TxtTongCong_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(674, 533);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Tổng cộng";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(894, 621);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTongCong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTienKham);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbUnit);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.dgvHD);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.ItemGroupBox);
            this.Name = "frmHoaDon";
            this.Text = "Hóa Đơn";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.ItemGroupBox.ResumeLayout(false);
            this.ItemGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ItemGroupBox;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.ComboBox cbLoaiBenh;
        private System.Windows.Forms.ComboBox cbThuoc;
        private System.Windows.Forms.Label lbThuoc;
        private System.Windows.Forms.TextBox txtTrieuChung;
        private System.Windows.Forms.Label lbLoaiBenh;
        private System.Windows.Forms.Label lbTrieuChung;
        private System.Windows.Forms.TextBox txtTenBN;
        private System.Windows.Forms.Label lbTenBN;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label lbMaHoaDon;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.DataGridView dgvHD;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbUnit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTienKham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTongCong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateNgayTao;
        private System.Windows.Forms.Label lbNgayTao;
        private System.Windows.Forms.Label lbDVT;
        private System.Windows.Forms.TextBox txtDVT;
    }
}