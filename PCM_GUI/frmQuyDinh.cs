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
    public partial class frmQuyDinh : Form
    {
        private QuyDinh_BUS qdBus;
        public frmQuyDinh()
        {
            InitializeComponent();
        }

        private void frmQuyDinh_Load(object sender, EventArgs e)
        {
            qdBus = new QuyDinh_BUS();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //1. Map data from GUI
            QuyDinh_DTO qd = new QuyDinh_DTO();
            qd.maQD = txtmaQD.Text;
            qd.tenQD = txttenQD.Text;
            qd.noidung = txtnoidung.Text;

            //2. Kiểm tra data hợp lệ or not

            //3. Thêm vào DB
            bool kq = qdBus.them(qd);
            if (kq == false)
                MessageBox.Show("Thêm thất bại. Vui lòng kiểm tra lại dũ liệu");
            else
            {
                txtmaQD.Text = "";
                txttenQD.Text = "";
                txtnoidung.Text = "";
                MessageBox.Show("Thêm thành công");
                this.loadData_Vao_GridView();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //1. Map data from GUI
            QuyDinh_DTO qd = new QuyDinh_DTO();
            qd.tenQD = txttenQD.Text;
            qd.maQD = txtmaQD.Text;
            qd.noidung = txtnoidung.Text;

            //2. Kiểm tra data hợp lệ or not

            //3. Sửa vào DB
            bool kq = qdBus.sua(qd);
            if (kq == false)
                MessageBox.Show("Sửa thất bại. Vui lòng kiểm tra lại dũ liệu");
            else
            {
                txtmaQD.Text = "";
                txttenQD.Text = "";
                txtnoidung.Text = "";
                MessageBox.Show("Sửa thành công");
                this.loadData_Vao_GridView();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //1. Map data from GUI
            QuyDinh_DTO qd = new QuyDinh_DTO();
            qd.maQD = txtmaQD.Text;

            //2. Kiểm tra data hợp lệ or not

            //3. Xóa trong DB
            bool kq = qdBus.xoa(qd);
            if (kq == false)
                MessageBox.Show("Xóa thất bại. Vui lòng kiểm tra lại dũ liệu");
            else
            {
                txtmaQD.Text = "";
                txttenQD.Text = "";
                txtnoidung.Text = "";
                MessageBox.Show("Xóa thành công");
                this.loadData_Vao_GridView();
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            this.loadData_Vao_GridView();
        }
        private void loadData_Vao_GridView()
        {
            List<QuyDinh_DTO> listQuyDinh = qdBus.select();

            if (listQuyDinh == null)
            {
                MessageBox.Show("Có lỗi khi lấy quy định từ DB");
                return;
            }

            dgvQuyDinh.Columns.Clear();
            dgvQuyDinh.DataSource = null;

            dgvQuyDinh.AutoGenerateColumns = false;
            dgvQuyDinh.AllowUserToAddRows = false;
            dgvQuyDinh.DataSource = listQuyDinh;

            DataGridViewTextBoxColumn clMa = new DataGridViewTextBoxColumn();
            clMa.Name = "maQD";
            clMa.HeaderText = "Mã Quy Định";
            clMa.DataPropertyName = "maQD";
            dgvQuyDinh.Columns.Add(clMa);

            DataGridViewTextBoxColumn clTen = new DataGridViewTextBoxColumn();
            clTen.Name = "tenQD";
            clTen.HeaderText = "Tên Quy Định";
            clTen.DataPropertyName = "tenQD";
            dgvQuyDinh.Columns.Add(clTen);

            DataGridViewTextBoxColumn clnoidung = new DataGridViewTextBoxColumn();
            clnoidung.Name = "noidung";
            clnoidung.HeaderText = "Nội Dung";
            clnoidung.DataPropertyName = "noidung";
            dgvQuyDinh.Columns.Add(clnoidung);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgvQuyDinh.DataSource];
            myCurrencyManager.Refresh();
        }


        private void XóaQuyĐịnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ' Get the current cell location.
            int currentRowIndex = dgvQuyDinh.CurrentCellAddress.Y;// 'current row selected


            //'Verify that indexing OK
            if (-1 < currentRowIndex && currentRowIndex < dgvQuyDinh.RowCount)
            {
                QuyDinh_DTO qd = (QuyDinh_DTO)dgvQuyDinh.Rows[currentRowIndex].DataBoundItem;
                if (qd != null)
                {
                    bool kq = qdBus.xoa(qd);
                    if (kq == false)
                        MessageBox.Show("Xóa quy định thất bại. Vui lòng kiểm tra lại dữ liệu");
                    else
                    {
                        MessageBox.Show("Xóa quy định thành công");
                        this.loadData_Vao_GridView();
                    }

                }
            }
        }

        private void DgvQuyDinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            if (numrow == -1)
            {
                txtmaQD.Text = "";
                txttenQD.Text = "";
                txtnoidung.Text = "";
            }
            else
            {
                txtmaQD.Text = dgvQuyDinh.Rows[numrow].Cells[0].Value.ToString();
                txttenQD.Text = dgvQuyDinh.Rows[numrow].Cells[1].Value.ToString();
                txtnoidung.Text = dgvQuyDinh.Rows[numrow].Cells[2].Value.ToString();
            }
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

        private void DgvQuyDinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtmaQD_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

