using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCM_DTO
{
    public class QuyDinh_DTO
    {
        protected string _maQD;
        public string maQD { get => _maQD; set => _maQD = value; }

        protected string _tenQD;
        public string tenQD { get => _tenQD; set => _tenQD = value; }

        protected string _noidung;
        public string noidung { get => _noidung; set => _noidung = value; }
    }
}
