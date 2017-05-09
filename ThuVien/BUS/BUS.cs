using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLThuVien.DataAccessLayer;
using QLThuVien.ValueObject;

namespace QLThuVien.BUSLayer
{
    public class BUS
    {
        #region Chi Tiet Muon
        public static DataTable xuat_CTM()
        {
            return DAO.xuat_CTM();
        }
        public static int them_CTM(ChiTietMuon a)
        {
            return DAO.them_CTM(a);
        }
        public static int sua_CTM(ChiTietMuon a)
        {
            return DAO.sua_CTM(a);
        }
        public static int xoa_CTM(string soPMT, string maCS)
        {
            return DAO.xoa_CTM(soPMT, maCS);
        }
        #endregion

        #region Chi Tiet Nhap
        public static DataTable xuat_CTN()
        {
            return DAO.xuat_CTN();
        }
        public static int them_CTN(ChiTietNhap a)
        {
            return DAO.them_CTN(a);
        }
        public static int sua_CTN(ChiTietNhap a)
        {
            return DAO.sua_CTN(a);
        }
        public static int xoa_CTN(string sopn)
        {
            return DAO.xoa_CTN(sopn);
        }
        #endregion

        #region Cuon Sach
        public static DataTable xuat_CS()
        {
            return DAO.xuat_CS();
        }
        public static int them_CS(CuonSach a)
        {
            return DAO.them_CS(a);
        }
        public static int sua_CS(CuonSach a)
        {
            return DAO.sua_CS(a);

        }
        public static int xoa_CS(string macs)
        {
            return DAO.xoa_CS(macs);
        }
        #endregion

        #region doc gia
        public static DataTable xuat_DG()
        {
            return DAO.xuat_DG();
        }
        public static int them_DG(DocGia a)
        {
            return DAO.them_DG(a);
        }
        public static int sua_DG(DocGia a)
        {
            return DAO.sua_DG(a);
        }
        public static int xoa_DG(string madg)
        {
            return DAO.xoa_DG(madg);
        }
        #endregion

        #region NCC
        public static DataTable xuat_NCC()
        {
            return DAO.xuat_NCC();
        }
        public static int them_NCC(NCC a)
        {
            return DAO.them_NCC(a);
        }
        public static int sua_NCC(NCC a)
        {
            return DAO.sua_NCC(a);
        }
        public static int xoa_NCC(string mancc)
        {
            return DAO.xoa_NCC(mancc);
        }
        #endregion

        #region NXB
        public static DataTable xuat_NXB()
        {
            return DAO.xuat_NXB();
        }
        public static int them_NXB(NXB a)
        {
            return DAO.them_NXB(a);
        }
        public static int sua_NXB(NXB a)
        {
            return DAO.sua_NXB(a);
        }
        public static int xoa_NXB(string manxb)
        {
            return DAO.xoa_NXB(manxb);
        }
        #endregion

        #region Phieu Muon Tra
        public static DataTable xuat_PMT()
        {
            return DAO.xuat_PMT();
        }
        public static int them_PMT(PhieuMuonTra a)
        {
            return DAO.them_PMT(a);
        }
        public static int sua_PMT(PhieuMuonTra a)
        {
            return DAO.sua_PMT(a);
        }
        public static int xoa_PMT(string sopmt)
        {
            return DAO.xoa_PMT(sopmt);
        }
        #endregion

        #region Phieu Nhap
        public static DataTable xuat_PN()
        {
            return DAO.xuat_PN();
        }
        public static int them_PN(PhieuNhap a)
        {
            return DAO.them_PN(a);
        }
        public static int sua_PN(PhieuNhap a)
        {
            return DAO.sua_PN(a);

        }
        public static int xoa_PN(string sopn)
        {
            return DAO.xoa_PN(sopn);
        }
        #endregion

        #region Phieu Phat
        public static DataTable xuat_PP()
        {
            return DAO.xuat_PP();
        }
        public static int them_PP(PhieuPhat a)
        {
            return DAO.them_PP(a);
        }
        public static int sua_PP(PhieuPhat a)
        {
            return DAO.sua_PP(a);
        }
        public static int xoa_PP(string sopp)
        {
            return DAO.xoa_PP(sopp);
        }
        #endregion

        #region Sach Can Nhap
        public static DataTable xuat_SCN()
        {
            return DAO.xuat_SCN();
        }
        public static int them_SCN(SachCN a)
        {
            return DAO.them_SCN(a);
        }
        public static int sua_SCN(SachCN a)
        {
            return DAO.sua_SCN(a);
        }
        public static int xoa_SCN(string tenscn)
        {
            return DAO.xoa_SCN(tenscn);
        }
        #endregion

        #region tac Gia
        public static DataTable xuat_TG()
        {
            return DAO.xuat_TG();
        }
        public static int them_TG(TacGia a)
        {
            return DAO.them_TG(a);
        }
        public static int sua_TG(TacGia a)
        {
            return DAO.sua_TG(a);
        }
        public static int xoa_TG(string matg)
        {
            return DAO.xoa_TG(matg);
        }
        #endregion

        #region the Loai
        public static DataTable xuat_TL()
        {
            return DAO.xuat_TL();
        }
        public static int them_TL(TheLoai a)
        {
            return DAO.them_TL(a);
        }
        public static int sua_TL(TheLoai a)
        {
            return DAO.sua_TL(a);
        }
        public static int xoa_TL(string matl)
        {
            return DAO.xoa_TL(matl);
        }
        #endregion

        #region Thu Thu
        public static DataTable xuat_TT()
        {
            return DAO.xuat_TT();
        }
        public static int them_TT(ThuThu a)
        {
            return DAO.them_TT(a);
        }
        public static int sua_TT(ThuThu a)
        {
            return DAO.sua_TT(a);
        }
        public static int xoa_TT(string matt)
        {
            return DAO.xoa_TT(matt);
        }
        #endregion

        #region TS_TL
        public static DataTable xuat_TSTL()
        {
            return DAO.xuat_TSTL();
        }
        public static int them_TSTL(TS_TL a)
        {
            return DAO.them_TSTL(a);
        }
        public static int sua_TSTL(TS_TL a)
        {
            return DAO.sua_TSTL(a);
        }
        public static int xoa_TSTL(string mats, string matl)
        {
            return DAO.xoa_TSTL(mats, matl);
        }
        #endregion

        #region tua Sach
        public static DataTable xuat_TS()
        {
            return DAO.xuat_TS();
        }
        public static int them_TS(TuaSach a)
        {
            return DAO.them_TS(a);
        }
        public static int sua_TS(TuaSach a)
        {
            return DAO.sua_TS(a);
        }
        public static int xoa_TS(string mats)
        {
            return DAO.xoa_TS(mats);
        }
        #endregion

        #region Viet
        public static DataTable xuat_V()
        {
            return DAO.xuat_V();
        }
        public static int them_V(Viet a)
        {
            return DAO.them_V(a);
        }
        public static int sua_V(Viet a)
        {
            return DAO.sua_V(a);
        }
        public static int xoa_V(string mats, string matg)
        {
            return DAO.xoa_V(mats, matg);
        }
        #endregion

        #region Update
        public static DataTable xuat_TGcuaTS(string maTS)
        {
            return DAO.xuat_TGcuaTS(maTS);
        }

        public static DataTable xuat_TLcuaTS(string maTS)
        {
            return DAO.xuat_TLcuaTS(maTS);
        }

        public static DataTable xuat_CTNcuaPN(string soPN)
        {
            return DAO.xuat_CTNcuaPN(soPN);
        }

        public static int xuat_TienPN(string soPN)
        {
            return DAO.xuat_TongTienPN(soPN);
        }

        public static DataTable xuat_PMTcuaDG(string maDG)
        {
            return DAO.xuat_PMTcuaDG(maDG);
        }

        public static DataTable xuat_CTMcuaPM(string soPMT)
        {
            return DAO.xuat_CTMcuaPM(soPMT);
        }

        public static DataTable xuat_DGcoMa(string maDG)
        {
            return DAO.xuat_DGcoMa(maDG);
        }

        public static int sua_TrangThaiCS(string maCS, string trangThai)
        {
            return DAO.sua_TrangThaiCS(maCS, trangThai);
        }

        public static string xuat_TenSach(string maCS)
        {
            return DAO.xuat_TenSach(maCS);
        }

        public static bool kiemTra_CS(string maCS)
        {
            return DAO.kiemTra_CS(maCS);
        }

        public static void tinhTien_PMT(string soPMT)
        {
            DAO.tinhTien_PMT(soPMT);
        }

        public static DataTable search(string ten, string nn, string matl, string matg)
        {
            return DAO.search(ten, nn, matl, matg);
        }
        public static DataTable tkmuon()
        {
            return DAO.tkmuon();
        }
        public static DataTable tkvipham()
        {
            return DAO.tkvipham();
        }
        public static DataTable tksachdangmuon()
        {
            return DAO.tksachdangmuon();
        }
        public static DataTable tkmuontrongngay(string a)
        {
            return DAO.tkmuontrongngay(a);
        }

        //public static string xuat_SoPMTnew()
        //{
        //    return DAO.xuat_SoPMTnew();
        //}

        public static int themtdcs(int a, string b, string c)
        {
            return DAO.themtdcs(a, b, c);
        }
        #endregion
    }
}

