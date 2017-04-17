using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.ValueObject
{
    public class PhieuPhat
    {
        private string soPP;

        public string SoPP
        {
            get { return soPP; }
            set { soPP = value; }
        }
        private DateTime ngayLap;

        public DateTime NgayLap
        {
            get { return ngayLap; }
            set { ngayLap = value; }
        }
        private string loiVP;

        public string LoiVP
        {
            get { return loiVP; }
            set { loiVP = value; }
        }
        private int tienPhat;

        public int TienPhat
        {
            get { return tienPhat; }
            set { tienPhat = value; }
        }
        private string tenSach;

        public string TenSach
        {
            get { return tenSach; }
            set { tenSach = value; }
        }
        private string soPMT;

        public string SoPMT
        {
            get { return soPMT; }
            set { soPMT = value; }
        }

    }
}
