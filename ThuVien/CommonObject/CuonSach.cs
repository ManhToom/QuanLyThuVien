using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.ValueObject
{
    public class CuonSach
    {
        private string maCS;

        public string MaCS
        {
            get { return maCS; }
            set { maCS = value; }
        }
        private string trangThai;

        public string TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }
        private string maTS;

        public string MaTS
        {
            get { return maTS; }
            set { maTS = value; }
        }
    }
}
