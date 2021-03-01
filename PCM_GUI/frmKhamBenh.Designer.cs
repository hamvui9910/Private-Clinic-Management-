namespace PCM_GUI
{
    partial class frmKhamBenh
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
            this.dgvKhamBenh = new System.Windows.Forms.DataGridView();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhamBenh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKhamBenh
            // 
            this.dgvKhamBenh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhamBenh.Location = new System.Drawing.Point(12, 212);
            this.dgvKhamBenh.Name = "dgvKhamBenh";
            this.dgvKhamBenh.Size = new System.Drawing.Size(727, 245);
            this.dgvKhamBenh.TabIndex = 11;
            this.dgvKhamBenh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDS_CellContentClick);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(229, 73);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(301, 20);
            this.txtTen.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(123, 76);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 13);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Họ tên";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(271, 115);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(234, 57);
            this.btnLoad.TabIndex = 12;
            this.btnLoad.Text = "Tìm kiếm";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmKhamBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 469);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgvKhamBenh);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.textBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmKhamBenh";
            this.Text = "Danh Sách Khám Bệnh";
            this.Load += new System.EventHandler(this.FrmKhamBenh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhamBenh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKhamBenh;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}