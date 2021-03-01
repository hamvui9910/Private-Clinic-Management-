using PCM_DAL;
using PCM_DTO;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCM_BUS
{
    public class DoanhThu_BUS
    {
        private DoanhThu_DAL dtDal;

        public DoanhThu_BUS()
        {
            dtDal = new DoanhThu_DAL();
        }

        public bool search(DoanhThu_DTO dt)
        {
            bool re = dtDal.search(dt);
            return re;
        }
        public List<DoanhThu_DTO> select()
        {
            return dtDal.select();
        }
        public List<DoanhThu_DTO> selectByKeyWord(string sKeyword)
        {
            return dtDal.selectByKeyWord(sKeyword);
        }
    }
}
