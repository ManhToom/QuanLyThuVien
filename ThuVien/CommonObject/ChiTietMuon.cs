using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.ValueObject
{
    public class ChiTietMuon
    {
        private string soPMT;

        public string SoPMT
        {
            get { return soPMT; }
            set { soPMT = value; }
        }
        private string maCS;

        public string MaCS
        {
            get { return maCS; }
            set { maCS = value; }
        }

        private int tienCoc;

        public int TienCoc
        {
            get { return tienCoc; }
            set { tienCoc = value; }
        }
        private int tienTToan;

        public int TienTToan
        {
            get { return tienTToan; }
            set { tienTToan = value; }
        }

    }
}
