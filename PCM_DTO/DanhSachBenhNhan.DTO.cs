using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCM_DTO 
{
    public class DanhSachBenhNhan_DTO 
    {
        protected string _mabn;
        public string BN_maBN { get => _mabn; set => _mabn = value; }

        protected string _hoten;
        public string BN_hoten { get => _hoten; set => _hoten = value; }

        protected string _gioitinh;
        public string BN_gioitinh { get => _gioitinh; set => _gioitinh = value; }

        protected string _namsinh;
        public string BN_namsinh { get => _namsinh; set => _namsinh = value; }

        protected string _diachi;
        public string BN_diachi { get => _diachi; set => _diachi = value; }

        protected string _sdt;
        public string BN_sdt { get => _sdt; set => _sdt = value; }

        protected string _ngaykham;
        public string BN_ngaykham { get => _ngaykham; set => _ngaykham = value; }

        protected string _loaibenh;
        public string BN_loaibenh { get => _loaibenh; set => _loaibenh = value; }

        protected string _trieuchung;
        public string BN_trieuchung { get => _trieuchung; set => _trieuchung = value; }
    }
}
