using PCM_DAL;
using PCM_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PCM_BUS
{
    public class DanhSachBenhNhan_BUS
    {
        private DanhSachBenhNhan_DAL dsbnDal;

        public DanhSachBenhNhan_BUS()
        {
            dsbnDal = new DanhSachBenhNhan_DAL();
        }

        public bool them(DanhSachBenhNhan_DTO dsbn)
        {
            bool re = dsbnDal.them(dsbn);
            return re;
        }

        public bool xoa(DanhSachBenhNhan_DTO dsbn)
        {
            bool re = dsbnDal.xoa(dsbn);
            return re;
        }

        public bool sua(DanhSachBenhNhan_DTO dsbn)
        {
            bool re = dsbnDal.sua(dsbn);
            return re;
        }

        public List<DanhSachBenhNhan_DTO> select()
        {
            return dsbnDal.select();
        }
        public List<DanhSachBenhNhan_DTO> selectNameByKeyWord(string sKeyword)
        {
            return dsbnDal.selectNameByKeyWord(sKeyword);
        }
    }
}
