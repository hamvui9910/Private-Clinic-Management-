namespace PCM_GUI
{
    partial class frmTimKiemBN
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
            this.dgvTimBN = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimBN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTimBN
            // 
            this.dgvTimBN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimBN.Location = new System.Drawing.Point(12, 187);
            this.dgvTimBN.Name = "dgvTimBN";
            this.dgvTimBN.Size = new System.Drawing.Size(776, 197);
            this.dgvTimBN.TabIndex = 7;
            this.dgvTimBN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTimBN_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(332, 93);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(139, 54);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(176, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(60, 13);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Họ Tên";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(242, 67);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(329, 20);
            this.txtTen.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmTimKiemBN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTimBN);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtTen);
            this.Name = "frmTimKiemBN";
            this.Text = "Tra Cứu Bệnh Nhân";
            this.Load += new System.EventHandler(this.FrmTimKiemBN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimBN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTimBN;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}