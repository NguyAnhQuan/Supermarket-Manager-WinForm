using MiniMart.DataAccessLayer.Repositories;
using System;
using System.Data;

namespace MiniMart.BusinessLogicLayer.Services
{
    internal class SanPhamLG
    {
        private readonly ISanPhamRepository sanPhamRepository;

        public SanPhamLG(ISanPhamRepository repository)
        {
            sanPhamRepository = repository;
        }

        public DataTable GetSanPham()
        {
            return sanPhamRepository.SanPham();
        }

        public void AddNewEntry(string Msp, string Mncc, string TenSp, int SoLuong, float Gia, DateTime NgayNhap, DateTime HetHan, bool HetHang, string PhanLoai)
        {
            sanPhamRepository.AddNewEntry(Msp, Mncc, TenSp, SoLuong, Gia, NgayNhap, HetHan, HetHang, PhanLoai);
        }

        public void UpdateEntry(string Msp, string Mncc, string TenSp, int SoLuong, float Gia, DateTime NgayNhap, DateTime HetHan, bool HetHang, string PhanLoai)
        {
            sanPhamRepository.UpdateEntry(Msp, Mncc, TenSp, SoLuong, Gia, NgayNhap, HetHan, HetHang, PhanLoai);
        }

        public void DeleteEntry(string Msp)
        {
            sanPhamRepository.DeleteEntry(Msp);
        }

        public DataTable SearchData(string Msp, string Mncc, string TenSp, int SoLuong, float Gia, DateTime NgayNhap, DateTime HetHan, bool HetHang, string PhanLoai)
        {
            return sanPhamRepository.SearchData(Msp, Mncc, TenSp, SoLuong, Gia, NgayNhap, HetHan, HetHang, PhanLoai);
        }
    }
}
