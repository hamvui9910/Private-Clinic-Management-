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
    public class QuyDinh_BUS
    {
        private QuyDinh_DAL qdDal;     
        
        public QuyDinh_BUS()
        {
            qdDal = new QuyDinh_DAL();
        }

        public bool them(QuyDinh_DTO qd)
        {
            bool re = qdDal.them(qd);
            return re;
        }

        public bool xoa(QuyDinh_DTO qd)
        {
            bool re = qdDal.xoa(qd);
            return re;
        }

        public bool sua(QuyDinh_DTO qd)
        {
            bool re = qdDal.sua(qd);
            return re;
        }

        public List<QuyDinh_DTO> select()
        {
            return qdDal.select();
        }
        public List<QuyDinh_DTO> selectByKeyWord(string sKeyword)
        {
            return qdDal.selectByKeyWord(sKeyword);
        }
    }
}
