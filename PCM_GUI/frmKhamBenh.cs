using PCM_BUS;
using PCM_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PCM_GUI
{
    public partial class frmKhamBenh : Form
    {
        private DanhSachBenhNhan_BUS dsbnBus;
        public frmKhamBenh()
        {
            InitializeComponent();
        }

        private void FrmKhamBenh_Load(object sender, EventArgs e)
        {
            dsbnBus = new DanhSachBenhNhan_BUS();
        }
    

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "")
            {
                errorProvider1.SetError(txtTen, "Ten Khong Duoc Bo Trong");
            }
            else
            {
                errorProvider1.Dispose();
                this.loadData_Vao_GridView();

            }
        }
        private void loadData_Vao_GridView()
        {
            List<DanhSachBenhNhan_DTO> listKhamBenh = dsbnBus.selectNameByKeyWord(txtTen.Text);

            if (listKhamBenh == null)
            {
                MessageBox.Show("Có lỗi khi lấy quy định từ DB");
                return;
            }

            dgvKhamBenh.Columns.Clear();
            dgvKhamBenh.DataSource = null;

            dgvKhamBenh.AutoGenerateColumns = false;
            dgvKhamBenh.AllowUserToAddRows = false;
            dgvKhamBenh.DataSource = listKhamBenh;

            DataGridViewTextBoxColumn clNgayKham = new DataGridViewTextBoxColumn();
            clNgayKham.Name = "BN_ngaykham";
            clNgayKham.HeaderText = "Ngày Khám";
            clNgayKham.DataPropertyName = "BN_NgayKham";
            dgvKhamBenh.Columns.Add(clNgayKham);

            DataGridViewTextBoxColumn clMa = new DataGridViewTextBoxColumn();
            clMa.Name = "BN_maBN";
            clMa.HeaderText = "Mã Bệnh Nhân";
            clMa.DataPropertyName = "BN_maBN";
            dgvKhamBenh.Columns.Add(clMa);

            DataGridViewTextBoxColumn clTen = new DataGridViewTextBoxColumn();
            clTen.Name = "BN_hoten";
            clTen.HeaderText = "Họ Tên";
            clTen.DataPropertyName = "BN_hoten";
            dgvKhamBenh.Columns.Add(clTen);

            DataGridViewTextBoxColumn clGioiTinh = new DataGridViewTextBoxColumn();
            clGioiTinh.Name = "BN_gioitinh";
            clGioiTinh.HeaderText = "Giới tính";
            clGioiTinh.DataPropertyName = "BN_gioitinh";
            dgvKhamBenh.Columns.Add(clGioiTinh);

            DataGridViewTextBoxColumn clNamSinh = new DataGridViewTextBoxColumn();
            clNamSinh.Name = "BN_namsinh";
            clNamSinh.HeaderText = "Năm Sinh";
            clNamSinh.DataPropertyName = "BN_namsinh";
            dgvKhamBenh.Columns.Add(clNamSinh);

            DataGridViewTextBoxColumn clDiaChi = new DataGridViewTextBoxColumn();
            clDiaChi.Name = "BN_diachi";
            clDiaChi.HeaderText = "Địa Chỉ";
            clDiaChi.DataPropertyName = "BN_diachi";
            dgvKhamBenh.Columns.Add(clDiaChi);

            DataGridViewTextBoxColumn clSDT = new DataGridViewTextBoxColumn();
            clSDT.Name = "BN_sdt";
            clSDT.HeaderText = "Số Điện Thoại";
            clSDT.DataPropertyName = "BN_sdt";
            dgvKhamBenh.Columns.Add(clSDT);



            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgvKhamBenh.DataSource];
            myCurrencyManager.Refresh();
        }

        private void DgvDS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void showmain()
        {
            frmMain main = new frmMain();
            main.ShowDialog();
        }
        private void TrởVềToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(showmain));
            thread.Start();
            this.Close();
        }
    }
}
