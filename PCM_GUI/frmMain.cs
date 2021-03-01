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
using System.Threading;

namespace PCM_GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
        }


        private void showkb()
        {
            frmKhamBenh dskb = new frmKhamBenh();
            dskb.ShowDialog();
        }

        private void showqd()
        {
            frmQuyDinh qd = new frmQuyDinh();
            qd.ShowDialog();
        }


        private void showtbn()
        {
            frmThemBenhNhan tbn = new frmThemBenhNhan();
            tbn.ShowDialog();
        }
        private void ThêmBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(showtbn));
            thread.Start();
        }
        private void showbn()
        {
            frmBenhNhan bn = new frmBenhNhan();
            bn.ShowDialog();
        }

        private void showhd()
        {
            frmHoaDon hd = new frmHoaDon();
            hd.ShowDialog();
        }

        private void showpkb()
        {
            frmPhieuKhamBenh pkb = new frmPhieuKhamBenh();
            pkb.ShowDialog();
        }
        private void showbcdt()
        {
            frmDoanhThuNgay pkb = new frmDoanhThuNgay();
            pkb.ShowDialog();
        }
        private void showtkbn()
        {
            frmTimKiemBN tkbn = new frmTimKiemBN();
            tkbn.ShowDialog();
        }

        private void showbcsdt()
        {
            frmSuDungThuoc tkbn = new frmSuDungThuoc();
            tkbn.ShowDialog();
        }

        private void ĐóngỨngDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DanhSáchBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(showbn));
            thread.Start();
        }

        private void DanhSáchKhámBệnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(showkb));
            thread.Start();
        }

        private void QuyĐịnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(showqd));
            thread.Start();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
        
        }

        private void LậpHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(showhd));
            thread.Start();
        }

        private void LậpPhiếuKhámBệnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(showpkb));
            thread.Start();
        }

        private void TheoNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(showbcdt));
            thread.Start();
        }

        private void TìmKiếmBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(showtkbn));
            thread.Start();
        }

        private void báoCáoSửDụngThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(showbcsdt));
            thread.Start();
        }
    }
}
