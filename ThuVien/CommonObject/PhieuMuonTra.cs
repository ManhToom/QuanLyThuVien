using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.ValueObject
{
    public class PhieuMuonTra
    {
        private string soPMT;

        public string SoPMT
        {
            get { return soPMT; }
            set { soPMT = value; }
        }
        private DateTime ngayLap;

        public DateTime NgayLap
        {
            get { return ngayLap; }
            set { ngayLap = value; }
        }
        private DateTime ngayHTra;

        public DateTime NgayHTra
        {
            get { return ngayHTra; }
            set { ngayHTra = value; }
        }
        private DateTime ngayTra;

        public DateTime NgayTra
        {
            get { return ngayTra; }
            set { ngayTra = value; }
        }
        private string maDG;

        public string MaDG
        {
            get { return maDG; }
            set { maDG = value; }
        }
        private string maTT;

        public string MaTT
        {
            get { return maTT; }
            set { maTT = value; }
        }
    }
}
