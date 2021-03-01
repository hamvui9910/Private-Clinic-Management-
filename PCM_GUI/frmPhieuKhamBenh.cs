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
namespace PCM_GUI
{
    public partial class frmPhieuKhamBenh : Form
    {
        public frmPhieuKhamBenh()
        {
            InitializeComponent();
        }

        private List<PhieuKhamBenh_DTO> PKB = new List<PhieuKhamBenh_DTO>();       
        private bool IsValidated()
        {
            if (txtHoTen.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Yêu cầu Họ Tên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTen.Focus();
                return false;
            }
            if (txtNgayKham.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Yêu cầu Ngày Khám.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNgayKham.Focus();
                return false;
            }
            if (txtTrieuChung.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Yêu cầu triệu chứng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTrieuChung.Focus();
                return false;
            }
            if (comboBoxLB.SelectedIndex == -1)
            {
                MessageBox.Show("Yêu cầu chọn loại bệnh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboBoxTT.SelectedIndex == -1)
            {
                MessageBox.Show("Yêu cầu chọn thuốc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtSL.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Yêu cầu số lượng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSL.Focus();
                return false;
            }
            if (txtCachDung.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Yêu cầu cách dùng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCachDung.Focus();
                return false;
            }
            else
            {
                int tempSoLuong;
                bool isNumberic = int.TryParse(txtSL.Text.Trim(), out tempSoLuong);
                if (!isNumberic)
                {
                    MessageBox.Show("Số lượng phải là số nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSL.Clear();
                    txtSL.Focus();
                    return false;
                }
            }
            if (txtDonVi.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Yêu cầu đơn vị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDonVi.Focus();
                return false;
            }
            return true;
        }
        private void PrintDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image image = Resources.banner;
            e.Graphics.DrawImage(image, 0, 0, image.Width, image.Height);
            //e.Graphics.DrawString("#Họ Tên: " +txtHoTen.Text.Trim(), new Font("Times New Roman", 14, FontStyle.Italic), Brushes.Black, new Point(25, 145));
            e.Graphics.DrawString("Ngày tạo: " + DateTime.Now, new Font("Times New Roman", 14, FontStyle.Italic), Brushes.Black, new Point(25, 175));
            e.Graphics.DrawString("Tên bệnh nhân: " + txtHoTen.Text.Trim(), new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(25, 205));
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------", new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(25, 325));
            e.Graphics.DrawString("Triệu chứng: " + txtTrieuChung.Text.Trim(), new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(25, 235));
            e.Graphics.DrawString("Loại bệnh: " + comboBoxLB.Text.Trim(), new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(25, 265));
            e.Graphics.DrawString("Thuốc", new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(30, 355));
            e.Graphics.DrawString("Số lượng", new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(200, 355));
            e.Graphics.DrawString("Đơn giá", new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(400, 355));
            e.Graphics.DrawString("Cách Dùng", new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(600, 355));
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------", new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(25, 385));

            int yPos = 415;
            foreach (var i in PKB)
            {
                e.Graphics.DrawString(i.Thuoc1, new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(30, yPos));
                e.Graphics.DrawString(i.SoLuong1.ToString(), new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(225, yPos));
                e.Graphics.DrawString(i.DonGia1.ToString(), new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(425, yPos));
                e.Graphics.DrawString(i.CachDung1.ToString(), new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(625, yPos));
                yPos += 30;
            }
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------", new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(25, yPos));
        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void PrintPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void DataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                var hit = dataGridView1.HitTest(e.X, e.Y);
                dataGridView1.Rows[hit.RowIndex].Selected = true;
                contextMenuStrip1.Show(dataGridView1, e.X, e.Y);
            }
        }

        private void XóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            PKB.RemoveAt(index);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = PKB;
        }

        private void ButtonThem_Click_1(object sender, EventArgs e)
        {
            if (IsValidated())
            {
                PhieuKhamBenh_DTO pkb = new PhieuKhamBenh_DTO()
                {
                    Thuoc1 = comboBoxLB.Text,
                    SoLuong1 = Convert.ToInt16(txtSL.Text.Trim()),
                    DonGia1 = Convert.ToDecimal(txtDonVi.Text.Trim()),
                    CachDung1 = txtCachDung.Text,
                };
                PKB.Add(pkb);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = PKB;
                dataGridView1.Columns[0].HeaderText = "Thuốc";
                dataGridView1.Columns[1].HeaderText = "Số Lượng";
                dataGridView1.Columns[2].HeaderText = "Đơn Giá";
                dataGridView1.Columns[3].HeaderText = "Cách Dùng";

                comboBoxLB.SelectedIndex = -1;
                txtSL.Clear();
                txtDonVi.Clear();
                txtCachDung.Clear();

            }
        }

        private void BtnIn_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void PrintPreviewDialog1_Load_1(object sender, EventArgs e)
        {

        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image image = Resources.banner;
            e.Graphics.DrawImage(image, 0, 0, image.Width, image.Height);
            //e.Graphics.DrawString("#Họ Tên: " +txtHoTen.Text.Trim(), new Font("Times New Roman", 14, FontStyle.Italic), Brushes.Black, new Point(25, 145));
            e.Graphics.DrawString("Ngày tạo: " + DateTime.Now, new Font("Times New Roman", 14, FontStyle.Italic), Brushes.Black, new Point(25, 175));
            e.Graphics.DrawString("Tên bệnh nhân: " + txtHoTen.Text.Trim(), new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(25, 205));
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------", new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(25, 325));
            e.Graphics.DrawString("Triệu chứng: " + txtTrieuChung.Text.Trim(), new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(25, 235));
            e.Graphics.DrawString("Loại bệnh: " + comboBoxTT.Text.Trim(), new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(25, 265));
            e.Graphics.DrawString("Thuốc", new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(30, 355));
            e.Graphics.DrawString("Số lượng", new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(200, 355));
            e.Graphics.DrawString("Đơn vị", new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(400, 355));
            e.Graphics.DrawString("Cách Dùng", new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(600, 355));
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------", new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(25, 385));

            int yPos = 415;
            foreach (var i in PKB)
            {
                e.Graphics.DrawString(i.Thuoc1, new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(30, yPos));
                e.Graphics.DrawString(i.SoLuong1.ToString(), new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(225, yPos));
                e.Graphics.DrawString(i.DonGia1.ToString(), new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(425, yPos));
                e.Graphics.DrawString(i.CachDung1.ToString(), new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(625, yPos));
                yPos += 30;
            }
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------", new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new Point(25, yPos));
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
