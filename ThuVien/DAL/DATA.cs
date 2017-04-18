using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using QLThuVien.ValueObject;

namespace QLThuVien.DataAccessLayer
{
    public class DAO
    {

        #region NXB
        public static DataTable xuat_NXB()
        {
            return DataProvider.GetData("get_NXB");
        }

        public static int them_NXB(NXB a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@manxb", a.MaNXB),
                new SqlParameter("@tennxb", a.TenNXB),
                new SqlParameter("@diachinxb", a.DiaChi),
                new SqlParameter("@sdtnxb", a.SDT1),
                new SqlParameter("@emailnxb", a.Email),

            };
            return DataProvider.ExecuteNonQuery("them_NXB", para);
        }

        public static int sua_NXB(NXB a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@manxb", a.MaNXB),
                new SqlParameter("@tennxb", a.TenNXB),
                new SqlParameter("@diachinxb", a.DiaChi),
                new SqlParameter("@sdtnxb", a.SDT1),
                new SqlParameter("@emailnxb", a.Email),

            };
            return DataProvider.ExecuteNonQuery("sua_NXB", para);
        }

        public static int xoa_NXB(string manxb)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@manxb",manxb)
            };
            return DataProvider.ExecuteNonQuery("xoa_NXB", para);
        }
        #endregion

        #region Tac Gia
        public static DataTable xuat_TG()
        {
            return DataProvider.GetData("get_TG");
        }

        public static int them_TG(TacGia a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@matg", a.MaTG),
                new SqlParameter("@tentg", a.TenTG),
                 new SqlParameter("@gioitinhtg", a.GioiTinh),
                new SqlParameter("@ngaysinhtg", a.NgaySinh),
                new SqlParameter("@quequantg", a.QueQuan),


            };
            return DataProvider.ExecuteNonQuery("them_TG", para);
        }

        public static int sua_TG(TacGia a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@matg", a.MaTG),
                new SqlParameter("@tentg", a.TenTG),
                 new SqlParameter("@gioitinhtg", a.GioiTinh),
                new SqlParameter("@ngaysinhtg", a.NgaySinh),
                new SqlParameter("@quequantg", a.QueQuan),


            };
            return DataProvider.ExecuteNonQuery("sua_TG", para);
        }

        public static int xoa_TG(string matg)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@matg",matg)
            };
            return DataProvider.ExecuteNonQuery("xoa_TG", para);
        }
        #endregion

        #region The Loai
        public static DataTable xuat_TL()
        {
            return DataProvider.GetData("get_TL");
        }

        public static int them_TL(TheLoai a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@matl", a.MaTL),
                new SqlParameter("@tentl", a.TenTL),



            };
            return DataProvider.ExecuteNonQuery("them_TL", para);
        }

        public static int sua_TL(TheLoai a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@matl", a.MaTL),
                new SqlParameter("@tentl", a.TenTL),



            };
            return DataProvider.ExecuteNonQuery("sua_TL", para);
        }

        public static int xoa_TL(string matl)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@matl",matl)
            };
            return DataProvider.ExecuteNonQuery("xoa_TL", para);
        }
        #endregion

        #region TS_TL
        public static DataTable xuat_TSTL()
        {
            return DataProvider.GetData("get_TL");
        }

        public static int them_TSTL(TS_TL a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mats", a.MaTS),
                new SqlParameter("@matl", a.MaTL),

            };
            return DataProvider.ExecuteNonQuery("them_TSTL", para);
        }

        public static int sua_TSTL(TS_TL a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mats", a.MaTS),
                new SqlParameter("@matl", a.MaTL),

            };
            return DataProvider.ExecuteNonQuery("sua_TSTL", para);
        }

        public static int xoa_TSTL(string mats, string matl)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mats",mats),
                new SqlParameter("@matl", matl)
            };
            return DataProvider.ExecuteNonQuery("xoa_TSTL", para);
        }
        #endregion

        #region Viet
        public static DataTable xuat_V()
        {

            return DataProvider.GetData("get_V");
        }

        public static int them_V(Viet a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mats", a.MaTS),
                new SqlParameter("@matg", a.MaTG)
            };
            return DataProvider.ExecuteNonQuery("them_V", para);
        }

        public static int sua_V(Viet a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mats", a.MaTS),
                new SqlParameter("@matg", a.MaTG)
            };
            return DataProvider.ExecuteNonQuery("sua_V", para);
        }

        public static int xoa_V(string mats, string matg)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mats",mats),
                new SqlParameter("@matg",matg)
            };
            return DataProvider.ExecuteNonQuery("xoa_V", para);
        }
        #endregion

        #region Cuon Sach
        public static DataTable xuat_CS()
        {
            return DataProvider.GetData("get_CS");
        }

        public static int them_CS(CuonSach a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mats", a.MaTS),
                new SqlParameter("@trangthai", a.TrangThai),
                new SqlParameter("@mats", a.MaTS)
            };
            return DataProvider.ExecuteNonQuery("them_CS", para);

        }

        public static int sua_CS(CuonSach a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mats", a.MaTS),
                new SqlParameter("@trangthai", a.TrangThai),
                new SqlParameter("@mats", a.MaTS)
            };
            return DataProvider.ExecuteNonQuery("sua_CS", para);
        }

        public static int xoa_CS(string macs)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@macs",macs)
            };
            return DataProvider.ExecuteNonQuery("xoa_CS", para);
        }
        #endregion

        #region Chi Tiet Nhap
        public static DataTable xuat_CTN()
        {
            return DataProvider.GetData("get_CTN");
        }

        public static int them_CTN(ChiTietNhap a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@sopn", a.SoPN),
                new SqlParameter("@mats", a.MaTS),
                new SqlParameter("@soluong", a.SoLuong),
                new SqlParameter("@dongia", a.DonGia),

            };
            return DataProvider.ExecuteNonQuery("them_CTN", para);

        }

        public static int sua_CTN(ChiTietNhap a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@sopn", a.SoPN),
                new SqlParameter("@mats", a.MaTS),
                new SqlParameter("@soluong", a.SoLuong),
                new SqlParameter("@dongia", a.DonGia),

            };
            return DataProvider.ExecuteNonQuery("sua_CTN", para);
        }

        public static int xoa_CTN(string sopn)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@sopn",sopn)
            };
            return DataProvider.ExecuteNonQuery("xoa_CTN", para);
        }
        #endregion

        #region Phieu Nhap
        public static DataTable xuat_PN()
        {
            return DataProvider.GetData("get_PN");
        }

        public static int them_PN(PhieuNhap a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@sopn", a.SoPN),
                new SqlParameter("@ngaylap", a.NgayLap),
                new SqlParameter("@matt", a.MaTT),
                new SqlParameter("@mancc", a.MaNCC),
            };
            return DataProvider.ExecuteNonQuery("them_PN", para);
        }

        public static int sua_PN(PhieuNhap a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@sopn", a.SoPN),
                new SqlParameter("@ngaylap", a.NgayLap),
                new SqlParameter("@matt", a.MaTT),
                new SqlParameter("@mancc", a.MaNCC),
            };
            return DataProvider.ExecuteNonQuery("sua_PN", para);
        }

        public static int xoa_PN(string sopn)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@sopn",sopn)
            };
            return DataProvider.ExecuteNonQuery("xoa_PN", para);
        }
        #endregion

        #region Nha Cung Cap
        public static DataTable xuat_NCC()
        {
            return DataProvider.GetData("get_NCC");
        }

        public static int them_NCC(NCC a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mancc", a.MaNCC),
                new SqlParameter("@tenncc", a.TenNCC),
                new SqlParameter("@diachincc", a.DiaChi),
                new SqlParameter("@sdtncc", a.SDT1),
                new SqlParameter("@emailncc", a.Email),

            };
            return DataProvider.ExecuteNonQuery("them_NCC", para);
        }

        public static int sua_NCC(NCC a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mancc", a.MaNCC),
                new SqlParameter("@tenncc", a.TenNCC),
                new SqlParameter("@diachincc", a.DiaChi),
                new SqlParameter("@sdtncc", a.SDT1),
                new SqlParameter("@emailncc", a.Email),

            };
            return DataProvider.ExecuteNonQuery("sua_NCC", para);
        }

        public static int xoa_NCC(string mancc)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mancc",mancc)
            };
            return DataProvider.ExecuteNonQuery("xoa_NCC", para);
        }
        #endregion

        #region SAch Can Nhap
        public static DataTable xuat_SCN()
        {
            return DataProvider.GetData("get_SCN");
        }

        public static int them_SCN(SachCN a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                 new SqlParameter("@tensach", a.TenSach),
                 new SqlParameter("@tacgia", a.TacGia),
                 new SqlParameter("@theloai", a.TheLoai),
                 new SqlParameter("@loainhap", a.LaoiHinhNhap),
                 new SqlParameter("@matt", a.MaTT),
                 new SqlParameter("@mancc", a.MaNCC),
            };
            return DataProvider.ExecuteNonQuery("them_SCN", para);
        }

        public static int sua_SCN(SachCN a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                 new SqlParameter("@tensach", a.TenSach),
                 new SqlParameter("@tacgia", a.TacGia),
                 new SqlParameter("@theloai", a.TheLoai),
                 new SqlParameter("@loainhap", a.LaoiHinhNhap),
                 new SqlParameter("@matt", a.MaTT),
                 new SqlParameter("@mancc", a.MaNCC),
            };
            return DataProvider.ExecuteNonQuery("sua_SCN", para);
        }

        public static int xoa_SCN(string tenscn)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@tensach",tenscn)
            };
            return DataProvider.ExecuteNonQuery("xoa_SCN", para);
        }
        #endregion

        #region Tua Sach
        public static DataTable xuat_TS()
        {
            return DataProvider.GetData("get_TS");
        }

        public static int them_TS(TuaSach a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                  new SqlParameter("@mats", a.MaTS),
                  new SqlParameter("@tents", a.TenTS),
                  new SqlParameter("@namxb", a.NamXB),
                  new SqlParameter("@gia", (float)a.Gia1),
                  new SqlParameter("@vitri", a.ViTri),
                  new SqlParameter("@noidung", a.NoiDungTT),
                  new SqlParameter("@nnchinh", a.NnChinh),
                  new SqlParameter("@manxb", a.MaNXB),

            };
            return DataProvider.ExecuteNonQuery("them_TS", para);
        }

        public static int sua_TS(TuaSach a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                  new SqlParameter("@mats", a.MaTS),
                  new SqlParameter("@tents", a.TenTS),
                  new SqlParameter("@namxb", a.NamXB),
                  new SqlParameter("@gia", a.Gia1),
                  new SqlParameter("@vitri", a.ViTri),
                  new SqlParameter("@noidung", a.NoiDungTT),
                  new SqlParameter("@nnchinh", a.NnChinh),
                  new SqlParameter("@manxb", a.MaNXB),

            };
            return DataProvider.ExecuteNonQuery("sua_TS", para);
        }

        public static int xoa_TS(string mats)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mats", mats)
            };
            return DataProvider.ExecuteNonQuery("xoa_TS", para);
        }
        #endregion

        #region Doc Gia
        public static DataTable xuat_DG()
        {
            return DataProvider.GetData("get_DG");
        }

        public static int them_DG(DocGia a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                      new SqlParameter("@madg", a.MaDG),
                      new SqlParameter("@tendg", a.TenDG),
                      new SqlParameter("@gioitinhdg", a.GioiTinh),
                      new SqlParameter("@ngaysinhdg", a.NgaySinh),
                      new SqlParameter("@diachidg", a.DiaChi),
                      new SqlParameter("@sdtdg", a.SDT1),
                      new SqlParameter("@loaidg", a.LoaiDG),


            };
            return DataProvider.ExecuteNonQuery("them_DG", para);
        }

        public static int sua_DG(DocGia a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                      new SqlParameter("@madg", a.MaDG),
                      new SqlParameter("@tendg", a.TenDG),
                      new SqlParameter("@gioitinhdg", a.GioiTinh),
                      new SqlParameter("@ngaysinhdg", a.NgaySinh),
                      new SqlParameter("@diachidg", a.DiaChi),
                      new SqlParameter("@sdtdg", a.SDT1),
                      new SqlParameter("@loaidg", a.LoaiDG),


            };
            return DataProvider.ExecuteNonQuery("sua_DG", para);
        }

        public static int xoa_DG(string madg)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@madg",madg)
            };
            return DataProvider.ExecuteNonQuery("xoa_DG", para);
        }
        #endregion

        #region Phieu Muon Tra
        public static DataTable xuat_PMT()
        {
            return DataProvider.GetData("get_PMT");
        }

        public static int them_PMT(PhieuMuonTra a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                       new SqlParameter("@sopmt", a.SoPMT),
                       new SqlParameter("@ngaylappmt", a.NgayLap),
                        new SqlParameter("@ngayhtra", a.NgayHTra),
                        new SqlParameter("@ngaytra", DBNull.Value),
                       new SqlParameter("@madg", a.MaDG),
                       new SqlParameter("@matt", a.MaTT),

                      };
            return DataProvider.ExecuteNonQuery("them_PMT", para);
        }

        public static int sua_PMT(PhieuMuonTra a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                       new SqlParameter("@sopmt", a.SoPMT),
                       new SqlParameter("@ngaylappmt", a.NgayLap),
                         new SqlParameter("@ngayhtra", a.NgayHTra),
                        new SqlParameter("@ngaytra",(DateTime.Compare(a.NgayTra,a.NgayLap)!=0)?a.NgayTra:(object)DBNull.Value),
                       new SqlParameter("@madg", a.MaDG),
                       new SqlParameter("@matt", a.MaTT),

                      };
            return DataProvider.ExecuteNonQuery("sua_PMT", para);
        }

        public static int xoa_PMT(string sopmt)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@sopmt",sopmt)
            };
            return DataProvider.ExecuteNonQuery("xoa_PMT", para);
        }
        #endregion

        #region Chi Tiet Muon
        public static DataTable xuat_CTM()
        {
            return DataProvider.GetData("get_CTM");
        }

        public static int them_CTM(ChiTietMuon a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@sopmt", a.SoPMT),
                new SqlParameter("@macs", a.MaCS),

                new SqlParameter("@tiencoc", a.TienCoc),
                new SqlParameter("@tienttoan", DBNull.Value)

            };
            return DataProvider.ExecuteNonQuery("them_CTM", para);
        }

        public static int sua_CTM(ChiTietMuon a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@sopmt", a.SoPMT),
                new SqlParameter("@macs", a.MaCS),

                new SqlParameter("@tiencoc", a.TienCoc),
                new SqlParameter("@tienttoan", (a.TienTToan==-1)?(object)DBNull.Value:a.TienTToan)

            };
            return DataProvider.ExecuteNonQuery("sua_CTM", para);
        }

        public static int xoa_CTM(string soPMT, string maCS)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@sopmt",soPMT),
                new SqlParameter("@macs",maCS)
            };
            return DataProvider.ExecuteNonQuery("xoa_CTM", para);
        }
        #endregion

        #region Phieu Phat
        public static DataTable xuat_PP()
        {
            return DataProvider.GetData("get_PP");
        }

        public static int them_PP(PhieuPhat a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                       new SqlParameter("@sopp", a.SoPP),
                       new SqlParameter("@ngaylap", a.NgayLap),
                       new SqlParameter("@loivp", a.LoiVP),
                       new SqlParameter("@tienphat", a.TienPhat),
                       new SqlParameter("@tensach", a.TenSach),
                       new SqlParameter("@sopmt", a.SoPMT),


                      };
            return DataProvider.ExecuteNonQuery("them_PP", para);
        }

        public static int sua_PP(PhieuPhat a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                       new SqlParameter("@sopp", a.SoPP),
                       new SqlParameter("@ngaylap", a.NgayLap),
                       new SqlParameter("@loivp", a.LoiVP),
                       new SqlParameter("@tienphat", a.TienPhat),
                       new SqlParameter("@tensach", a.TenSach),
                       new SqlParameter("@sopmt", a.SoPMT),


                      };
            return DataProvider.ExecuteNonQuery("sua_PP", para);
        }

        public static int xoa_PP(string sopp)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@sopp",sopp)
            };
            return DataProvider.ExecuteNonQuery("xoa_PP", para);
        }
        #endregion

        #region Thu Thu
        public static DataTable xuat_TT()
        {
            return DataProvider.GetData("get_TT");
        }

        public static int them_TT(ThuThu a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                       new SqlParameter("@matt", a.MaTT),
                       new SqlParameter("@tentt", a.TenTT),
                       new SqlParameter("@gioitinhtt", a.GioiTinh),
                       new SqlParameter("@ngaysinhtt", a.NgaySinh),
                       new SqlParameter("@diachitt", a.DiaChi),
                       new SqlParameter("@sdttt", a.SDT1),
                       new SqlParameter("@capbac", a.CapBac),


                      };
            return DataProvider.ExecuteNonQuery("them_TT", para);
        }

        public static int sua_TT(ThuThu a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                       new SqlParameter("@matt", a.MaTT),
                       new SqlParameter("@tentt", a.TenTT),
                       new SqlParameter("@gioitinhtt", a.GioiTinh),
                       new SqlParameter("@ngaysinhtt", a.NgaySinh),
                       new SqlParameter("@diachitt", a.DiaChi),
                       new SqlParameter("@sdttt", a.SDT1),
                       new SqlParameter("@capbac", a.CapBac),


                      };
            return DataProvider.ExecuteNonQuery("sua_TT", para);
        }

        public static int xoa_TT(string matt)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@matt",matt)
            };
            return DataProvider.ExecuteNonQuery("xoa_TT", para);
        }
        #endregion

        #region update
        public static DataTable xuat_TGcuaTS(string maTS)
        {
            return DataProvider.GetData("get_TGcuaTS " + "'" + maTS + "'");
        }

        public static DataTable xuat_TLcuaTS(string maTS)
        {
            return DataProvider.GetData("get_TLcuaTS" + "'" + maTS + "'");
        }

        public static DataTable xuat_CTNcuaPN(string soPN)
        {
            return DataProvider.GetData("get_CTNcuaPN" + "'" + soPN + "'");
        }

        public static int xuat_TongTienPN(string soPN)
        {
            int tongTien = 0;
            SqlParameter tien = new SqlParameter("@tongtien", tongTien);
            tien.Direction = ParameterDirection.Output;
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@soPN", soPN),
                tien
            };
            DataProvider.ExecuteNonQuery("get_tien", para);
            try
            {
                tongTien = (int)tien.Value;
            }
            catch (Exception)
            {

                tongTien = 0;
            }
            return tongTien;
        }

        public static DataTable xuat_PMTcuaDG(string maDG)
        {
            return DataProvider.GetData("get_PMTcuaDG" + "'" + maDG + "'");
        }

        public static DataTable xuat_CTMcuaPM(string soPMT)
        {
            return DataProvider.GetData("get_CTMcuaPM" + "'" + soPMT + "'");
        }

        public static DataTable xuat_DGcoMa(string maDG)
        {
            return DataProvider.GetData("get_DGcoMa" + "'" + maDG + "'");
        }

        public static int sua_TrangThaiCS(string maCS, string trangThai)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maCS", maCS),
                new SqlParameter("@trangthai", trangThai)
            };
            return DataProvider.ExecuteNonQuery("sua_TrangThaiCS", para);
        }

        public static string xuat_TenSach(string maCS)
        {
            string tenSach = null;
            DataTable dt = DataProvider.GetData("get_TenSach" + "'" + maCS + "'");
            if (dt.Rows.Count > 0)
            {
                tenSach = (string)dt.Rows[0].ItemArray[0];
            }
            return tenSach;
        }

        public static bool kiemTra_CS(string maCS)
        {
            bool test = true;
            if (DataProvider.GetData("kiemtra_CS" + "'" + maCS + "'").Rows.Count > 0)
                test = false;
            return test;
        }

        public static void tinhTien_PMT(string soPMT)
        {
            DataProvider.ExecuteNonQuery("tinhTien_PMT", new SqlParameter[] { new SqlParameter("@soPMT", soPMT) });
        }

        public static DataTable search(string ten, string nn, string matl, string matg)
        {
            return DataProvider.GetData("search" + "'" + ten + "','" + nn + "','" + matl + "','" + matg + "'");

        }

        public static DataTable tkmuon()
        {
            return DataProvider.GetData("tkmuon");
        }
        public static DataTable tkvipham()
        {
            return DataProvider.GetData("tkvipham");
        }
        public static DataTable tksachdangmuon()
        {
            return DataProvider.GetData("tksachdangmuon");
        }
        public static DataTable tkmuontrongngay(string a)
        {
            return DataProvider.GetData("tkmuontrongngay" + "'" + a + "'");
        }

        //public static string xuat_SoPMTnew()
        //{
        //    string soPMT = null;
        //    soPMT = (string)DataProvider.GetData("get_NewSoPMT").Rows[0].ItemArray[0];
        //    return soPMT;
        //}

        public static int themtdcs(int a, string b, string c)
        {
            return DataProvider.ExecuteNonQuery("themtd_CS", new SqlParameter[] { new SqlParameter("@soluong", a), new SqlParameter("@trangthai", b), new SqlParameter("@mats", c) });
        }
        #endregion
    }
}
