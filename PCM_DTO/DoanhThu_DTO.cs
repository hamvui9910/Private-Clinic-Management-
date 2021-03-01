using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCM_DTO
{
    public class DoanhThu_DTO : HoaDon_DTO 
    {
        protected string _maHD;
        public string maHD { get => _maHD; set =>_maHD = value; }
        protected string _ngaytao;
        public string ngaytao { get => _ngaytao; set => _ngaytao = value; }
        protected string _tenBN;
        public string tenBN { get => _tenBN; set => _tenBN = value; }
        protected decimal _tienthuoc;
        public decimal tienthuoc { get => _tienthuoc; set => _tienthuoc = value; }
        protected decimal _tongcong;
        public decimal tongcong { get => _tongcong; set => _tongcong = value; }
    }
}
