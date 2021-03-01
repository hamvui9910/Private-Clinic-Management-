using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace PCM_GUI
{
    public partial class frmSuDungThuoc : Form
    {
        public frmSuDungThuoc()
        {
            InitializeComponent();
        }

        private void frmSuDungThuoc_Load(object sender, EventArgs e)
        {
            LoadDataLenDGV();
        }

        private void LoadDataLenDGV()
        {
            dgvThuoc.DataSource = GetAllThuoc();
        }

        private DataTable GetAllThuoc()
        {
            DataTable dtThuoc = new DataTable();
            string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
            using (SqlConnection cnn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT [maHD] as [Mã Hóa Đơn],[maThuoc] as [Mã Thuốc],[tenThuoc] as [Tên Thuốc],[donviTinh] as [Đơn Vị Tính],[soLuong] as [Số Lượng],[donGia] as [Đơn Giá],[thanhTien] as [Thành Tiền] FROM [ThongKe]", cnn))
                {
                    cnn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dtThuoc.Load(reader);                    
                }
            }
            //dgvThuoc.Columns[0].HeaderText = "Mã Hóa Đơn";
            //dgvThuoc.Columns[1].HeaderText = "Mã Thuốc";
            //dgvThuoc.Columns[2].HeaderText = "Tên Thuốc";
            //dgvThuoc.Columns[3].HeaderText = "Đơn Vị Tính";
            //dgvThuoc.Columns[4].HeaderText = "Số Lượng";
            //dgvThuoc.Columns[5].HeaderText = "Đơn Giá";
            //dgvThuoc.Columns[5].HeaderText = "Thành Tiền";

            return dtThuoc;
        }

    }
}
