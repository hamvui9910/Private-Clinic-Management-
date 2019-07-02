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
using System.IO;

namespace PCM_GUI
{
    public partial class frmHoaDon : Form
    {
        private HoaDon_BUS hoadonBUS;
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
            hoadonBUS = new HoaDon_BUS();
        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void XuatHD_Click(object sender, EventArgs e)
        {
            HoaDon_DTO hoadon = new HoaDon_DTO();
            hoadon._HD_ngaykham = txtDate.Text;
            hoadon._HD_hoten = txtTen.Text;
            hoadon._HD_tienthuoc = txtThuoc.Text;
            hoadon._HD_tienkham = txtKham.Text;
            hoadon._HD_tongcong = txtSum.Text;

            bool kq = hoadonBUS.them(hoadon);
            if (kq == false)
                MessageBox.Show("Thêm thất bại. Vui lòng kiểm tra lại dũ liệu");
            else
            {
                string[] inhoadon = new string[] { hoadon._HD_ngaykham, hoadon._HD_hoten, hoadon._HD_tienkham, hoadon._HD_tienthuoc, hoadon._HD_tongcong };
                String filepath = "C:\\Program Files\\hoadon.txt";// đường dẫn của file muốn tạo
            	FileStream fs = new FileStream(filepath, FileMode.Create);//Tạo file mới tên là test.txt            
	using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode ))
                {
                    foreach (string s in inhoadon)
                    {
                        sw.WriteLine(s);
                    }
                } swWriter.Flush();
	 fs.Close;
            } 

                
        }

        private void txtKham_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
