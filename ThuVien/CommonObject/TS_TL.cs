using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.ValueObject
{
    public class TS_TL
    {
        private string maTS;

        public string MaTS
        {
            get { return maTS; }
            set { maTS = value; }
        }
        private string maTL;

        public string MaTL
        {
            get { return maTL; }
            set { maTL = value; }
        }
    }
}
