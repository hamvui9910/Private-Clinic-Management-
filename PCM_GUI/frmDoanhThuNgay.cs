using PCM_DTO;
using PCM_BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCM_GUI.Properties;
using System.Data.SqlClient;
using System.Configuration;

namespace PCM_GUI
{
    public partial class frmDoanhThuNgay : Form
    {
        private DoanhThu_BUS dtBus;
        public frmDoanhThuNgay()
        {
            InitializeComponent();
        }

        private void FrmDoanhThuNgay_Load(object sender, EventArgs e)
        {
            dtBus = new DoanhThu_BUS();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            dgvDT.DataSource = null;
            //1. Map data from GUI
            DoanhThu_DTO dt = new DoanhThu_DTO();

            //2. Kiểm tra data hợp lệ or not

            //3. Xóa trong DB

            bool kq = dtBus.search(dt);
            if (kq == false)
                MessageBox.Show("Tra cứu thất bại. Vui lòng kiểm tra lại dũ liệu");
            else
            {
                MessageBox.Show("Tra cứu thành công");
                this.loadData_Vao_GridView();
            }
        }

        private void loadData_Vao_GridView()
        {
            List<DoanhThu_DTO> listDoanhThu = dtBus.select();

            if (listDoanhThu == null)
            {
                MessageBox.Show("Có lỗi khi lấy quy định từ DB");
                return;
            }

            dgvDT.Columns.Clear();
            dgvDT.DataSource = null;

            dgvDT.AutoGenerateColumns = false;
            dgvDT.AllowUserToAddRows = false;
            dgvDT.DataSource = listDoanhThu;

            DataGridViewTextBoxColumn clMaHD = new DataGridViewTextBoxColumn();
            clMaHD.Name = "maHD";
            clMaHD.HeaderText = "Mã Hóa Đơn";
            clMaHD.DataPropertyName = "maHD";
            dgvDT.Columns.Add(clMaHD);

            DataGridViewTextBoxColumn clTenBN = new DataGridViewTextBoxColumn();
            clTenBN.Name = "tenBN";
            clTenBN.HeaderText = "Tên Bệnh Nhân";
            clTenBN.DataPropertyName = "tenBN";
            dgvDT.Columns.Add(clTenBN);

            DataGridViewTextBoxColumn cltienthuoc = new DataGridViewTextBoxColumn();
            cltienthuoc.Name = "tienthuoc";
            cltienthuoc.HeaderText = "Tiền Thuốc";
            cltienthuoc.DataPropertyName = "tienthuoc";
            dgvDT.Columns.Add(cltienthuoc);

            DataGridViewTextBoxColumn cltongcong = new DataGridViewTextBoxColumn();
            cltongcong.Name = "tongcong";
            cltongcong.HeaderText = "Tổng Cộng";
            cltongcong.DataPropertyName = "tongcong";
            dgvDT.Columns.Add(cltongcong);

            DataGridViewTextBoxColumn clngaytao = new DataGridViewTextBoxColumn();
            clngaytao.Name = "ngaytao";
            clngaytao.HeaderText = "Ngày Tạo";
            clngaytao.DataPropertyName = "ngaytao";
            dgvDT.Columns.Add(clngaytao);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgvDT.DataSource];
            myCurrencyManager.Refresh();

            decimal total = listDoanhThu.Sum(x => x.tongcong);
            txtTotal.Text = total.ToString();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            dgvDT.DataSource = null;
        }
    }
}
