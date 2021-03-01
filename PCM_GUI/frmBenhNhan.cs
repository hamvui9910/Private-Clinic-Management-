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
    public partial class frmBenhNhan : Form
    {
        private DanhSachBenhNhan_BUS dsbnBus;

        public frmBenhNhan()
        {
            InitializeComponent();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            //1. Map data from GUI
            DanhSachBenhNhan_DTO bn = new DanhSachBenhNhan_DTO();
            bn.BN_maBN = txtMaBN.Text;
            bn.BN_ngaykham = txtDate.Text;
            bn.BN_hoten = txtTen.Text;
            bn.BN_loaibenh = txtLoaiBenh.Text;
            bn.BN_trieuchung = txtTrieuChung.Text;

            //2. Kiểm tra data hợp lệ or not

            //3. Sửa vào DB
            bool kq = dsbnBus.sua(bn);
            if (kq == false)
                MessageBox.Show("Sửa thất bại. Vui lòng kiểm tra lại dữ liệu");
            else
            {
                txtMaBN.Text = "";
                txtTen.Text = "";
                txtDate.Text = "";
                txtLoaiBenh.Text = "";
                txtTrieuChung.Text = "";
                MessageBox.Show("Sửa thành công");
                this.loadData_Vao_GridView();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            //1. Map data from GUI
            DanhSachBenhNhan_DTO bn = new DanhSachBenhNhan_DTO();
            bn.BN_maBN = txtMaBN.Text;

            //2. Kiểm tra data hợp lệ or not

            //3. Xóa trong DB
            bool kq = dsbnBus.xoa(bn);
            if (kq == false)
                MessageBox.Show("Xóa thất bại. Vui lòng kiểm tra lại dũ liệu");
            else
            {
                txtMaBN.Text = "";
                txtTen.Text = "";
                txtDate.Text = "";
                txtLoaiBenh.Text = "";
                txtTrieuChung.Text = "";
                MessageBox.Show("Xóa thành công");
                this.loadData_Vao_GridView();
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            this.loadData_Vao_GridView();
        }

        private void FrmBenhNhan_Load(object sender, EventArgs e)
        {
            dsbnBus = new DanhSachBenhNhan_BUS();
        }
        private void loadData_Vao_GridView()
        {
            List<DanhSachBenhNhan_DTO> listBenhNhan = dsbnBus.selectNameByKeyWord(txtTen.Text);

            if (listBenhNhan == null)
            {
                MessageBox.Show("Có lỗi khi lấy quy định từ DB");
                return;
            }

            dgvBenhNhan.Columns.Clear();
            dgvBenhNhan.DataSource = null;

            dgvBenhNhan.AutoGenerateColumns = false;
            dgvBenhNhan.AllowUserToAddRows = false;
            dgvBenhNhan.DataSource = listBenhNhan;

            DataGridViewTextBoxColumn clNgayKham = new DataGridViewTextBoxColumn();
            clNgayKham.Name = "BN_ngaykham";
            clNgayKham.HeaderText = "Ngày Khám";
            clNgayKham.DataPropertyName = "BN_NgayKham";
            dgvBenhNhan.Columns.Add(clNgayKham);

            DataGridViewTextBoxColumn clMa = new DataGridViewTextBoxColumn();
            clMa.Name = "BN_maBN";
            clMa.HeaderText = "Mã Bệnh Nhân";
            clMa.DataPropertyName = "BN_maBN";
            dgvBenhNhan.Columns.Add(clMa);

            DataGridViewTextBoxColumn clTen = new DataGridViewTextBoxColumn();
            clTen.Name = "BN_hoten";
            clTen.HeaderText = "Họ Tên";
            clTen.DataPropertyName = "BN_hoten";
            dgvBenhNhan.Columns.Add(clTen);

            DataGridViewTextBoxColumn clLoaiBenh = new DataGridViewTextBoxColumn();
            clLoaiBenh.Name = "BN_loaibenh";
            clLoaiBenh.HeaderText = "Loại Bệnh";
            clLoaiBenh.DataPropertyName = "BN_loaibenh";
            dgvBenhNhan.Columns.Add(clLoaiBenh);

            DataGridViewTextBoxColumn clTrieuChung = new DataGridViewTextBoxColumn();
            clTrieuChung.Name = "BN_trieuchung";
            clTrieuChung.HeaderText = "Triệu Chứng";
            clTrieuChung.DataPropertyName = "BN_trieuchung";
            dgvBenhNhan.Columns.Add(clTrieuChung);



            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgvBenhNhan.DataSource];
            myCurrencyManager.Refresh();
        }

        private void DgvBenhNhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void DgvBenhNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            if (numrow == -1)
            {
                txtMaBN.Text = null;
                txtTen.Text = null;
                txtDate.Text = null;
                txtLoaiBenh.Text = null;
                txtTrieuChung.Text = null;
            }
            else
            {
                txtMaBN.Text = dgvBenhNhan.Rows[numrow].Cells[0].Value.ToString();
                txtTen.Text = dgvBenhNhan.Rows[numrow].Cells[1].Value.ToString();
                txtDate.Text = dgvBenhNhan.Rows[numrow].Cells[2].Value.ToString();
                txtLoaiBenh.Text = dgvBenhNhan.Rows[numrow].Cells[3].Value.ToString();
                txtTrieuChung.Text = dgvBenhNhan.Rows[numrow].Cells[4].Value.ToString();
            }
        }
    }
}

