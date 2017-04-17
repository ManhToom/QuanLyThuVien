using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.ValueObject
{
    public class SachCN
    {
        private string tenSach;

        public string TenSach
        {
            get { return tenSach; }
            set { tenSach = value; }
        }
        private string tacGia;

        public string TacGia
        {
            get { return tacGia; }
            set { tacGia = value; }
        }
        private string theLoai;

        public string TheLoai
        {
            get { return theLoai; }
            set { theLoai = value; }
        }
        private string laoiHinhNhap;

        public string LaoiHinhNhap
        {
            get { return laoiHinhNhap; }
            set { laoiHinhNhap = value; }
        }
        private string maTT;

        public string MaTT
        {
            get { return maTT; }
            set { maTT = value; }
        }
        private string maNCC;

        public string MaNCC
        {
            get { return maNCC; }
            set { maNCC = value; }
        }
    }
}
