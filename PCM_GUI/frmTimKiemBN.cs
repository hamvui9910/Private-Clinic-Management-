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

namespace PCM_GUI
{
    public partial class frmTimKiemBN : Form
    {
        private DanhSachBenhNhan_BUS dsbnBus;
        public frmTimKiemBN()
        {
            InitializeComponent();
        }

        private void FrmTimKiemBN_Load(object sender, EventArgs e)
        {
            dsbnBus = new DanhSachBenhNhan_BUS();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
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

            dgvTimBN.Columns.Clear();
            dgvTimBN.DataSource = null;

            dgvTimBN.AutoGenerateColumns = false;
            dgvTimBN.AllowUserToAddRows = false;
            dgvTimBN.DataSource = listKhamBenh;

            DataGridViewTextBoxColumn clNgayKham = new DataGridViewTextBoxColumn();
            clNgayKham.Name = "BN_ngaykham";
            clNgayKham.HeaderText = "Ngày Khám";
            clNgayKham.DataPropertyName = "BN_NgayKham";
            dgvTimBN.Columns.Add(clNgayKham);

            DataGridViewTextBoxColumn clMa = new DataGridViewTextBoxColumn();
            clMa.Name = "BN_maBN";
            clMa.HeaderText = "Mã Bệnh Nhân";
            clMa.DataPropertyName = "BN_maBN";
            dgvTimBN.Columns.Add(clMa);

            DataGridViewTextBoxColumn clTen = new DataGridViewTextBoxColumn();
            clTen.Name = "BN_hoten";
            clTen.HeaderText = "Họ Tên";
            clTen.DataPropertyName = "BN_hoten";
            dgvTimBN.Columns.Add(clTen);


            DataGridViewTextBoxColumn clLoaiBenh = new DataGridViewTextBoxColumn();
            clLoaiBenh.Name = "BN_loaibenh";
            clLoaiBenh.HeaderText = "Loại Bệnh";
            clLoaiBenh.DataPropertyName = "BN_loaibenh";
            dgvTimBN.Columns.Add(clLoaiBenh);

            DataGridViewTextBoxColumn clTrieuChung = new DataGridViewTextBoxColumn();
            clTrieuChung.Name = "BN_trieuchung";
            clTrieuChung.HeaderText = "Triệu Chứng";
            clTrieuChung.DataPropertyName = "BN_trieuchung";
            dgvTimBN.Columns.Add(clTrieuChung);



            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgvTimBN.DataSource];
            myCurrencyManager.Refresh();
        }
        private void DgvTimBN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

   
    }
}
