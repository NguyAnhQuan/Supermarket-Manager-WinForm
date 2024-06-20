using MiniMart.DataAccessLayer.Repositories;
using System;
using System.Data;

namespace MiniMart.BusinessLogicLayer.Services
{
    internal class SanPhamLG
    {
        private readonly SanPhamDB sanPhamDB;

        public SanPhamLG()
        {
            sanPhamDB = new SanPhamDB();
        }

        public DataTable GetSanPham()
        {
            return SanPhamDB.SanPham();
        }

        public void AddNewEntry(string Msp, string Mncc, string TenSp, int SoLuong, float Gia, DateTime NgayNhap, DateTime HetHan, bool HetHang, string PhanLoai)
        {
            SanPhamDB.AddNewEntry(Msp, Mncc, TenSp, SoLuong, Gia, NgayNhap, HetHan, HetHang ? true : false, PhanLoai);
        }

        public void UpdateEntry(string Msp, string Mncc, string TenSp, int SoLuong, float Gia, DateTime NgayNhap, DateTime HetHan, bool HetHang, string PhanLoai)
        {
            SanPhamDB.UpdateEntry(Msp, Mncc, TenSp, SoLuong, Gia, NgayNhap, HetHan, HetHang ? true : false, PhanLoai);
        }

        public void DeleteEntry(string Msp)
        {
            SanPhamDB.DeleteEntry(Msp);
        }

        public DataTable SearchData(string Msp, string Mncc, string TenSp, int SoLuong, float Gia, DateTime NgayNhap, DateTime HetHan, bool HetHang, string PhanLoai)
        {
            return SanPhamDB.SearchData(Msp, Mncc, TenSp, SoLuong, Gia, NgayNhap, HetHan, HetHang ? true : false, PhanLoai);
        }
    }
}
