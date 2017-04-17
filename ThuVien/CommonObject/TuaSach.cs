using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.ValueObject
{
    public  class TuaSach
    {
        private string maTS;

        public string MaTS
        {
            get { return maTS; }
            set { maTS = value; }
        }
        private string tenTS;

        public string TenTS
        {
            get { return tenTS; }
            set { tenTS = value; }
        }
        private int namXB;

        public int NamXB
        {
            get { return namXB; }
            set { namXB = value; }
        }
        private int Gia;

        public int Gia1
        {
            get { return Gia; }
            set { Gia = value; }
        }
        private string viTri;

        public string ViTri
        {
            get { return viTri; }
            set { viTri = value; }
        }
        private string noiDungTT;

        public string NoiDungTT
        {
            get { return noiDungTT; }
            set { noiDungTT = value; }
        }
        private string nnChinh;

        public string NnChinh
        {
            get { return nnChinh; }
            set { nnChinh = value; }
        }
        private string maNXB;

        public string MaNXB
        {
            get { return maNXB; }
            set { maNXB = value; }
        }
    }
}
