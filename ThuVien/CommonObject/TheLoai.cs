using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.ValueObject
{
    public class TheLoai
    {
        private string maTL;

        public string MaTL
        {
            get { return maTL; }
            set { maTL = value; }
        }
        private string tenTL;

        public string TenTL
        {
            get { return tenTL; }
            set { tenTL = value; }
        }
    }
}
