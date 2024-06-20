using System;
using System.Data;
using System.Data.SqlClient;

namespace MiniMart.DataAccessLayer.Repositories
{
    internal interface ISanPhamRepository
    {
        DataTable SanPham();
        void AddNewEntry(string Msp, string Mncc, string TenSp, int SoLuong, float Gia, DateTime NgayNhap, DateTime HetHan, bool HetHang, string PhanLoai);
        void UpdateEntry(string Msp, string Mncc, string TenSp, int SoLuong, float Gia, DateTime NgayNhap, DateTime HetHan, bool HetHang, string PhanLoai);
        void DeleteEntry(string Msp);
        DataTable SearchData(string Msp, string Mncc, string TenSp, int SoLuong, float Gia, DateTime NgayNhap, DateTime HetHan, bool HetHang, string PhanLoai);
    }
}
