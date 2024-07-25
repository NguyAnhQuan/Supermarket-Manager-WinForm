using MiniMart.DataAccessLayer.Repositories;
using System;
using System.Data;

namespace MiniMart.BusinessLogicLayer.Services
{
    internal class ThuNganLG
    {
        private readonly IThuNganRepository thuNganRepository;

        public ThuNganLG(IThuNganRepository repository)
        {
            thuNganRepository = repository;
        }

        public DataTable SearchSanPham(string Msp, string TenSp, string PhanLoai)
        {
            return thuNganRepository.SearchData(Msp, TenSp, PhanLoai);
        }

        public string SearchHD()
        {
            return thuNganRepository.TruyvanHD();
        }

        public void AddHD(DateTime NgayXuat, string Msp, int SoLuong, float DonGia, float ThanhTien, string Mkh, string Mnv)
        {
            string currentMhd = SearchHD();
            int currentNumber = int.Parse(currentMhd.Substring(2));
            string newMhd = "HD" + (currentNumber + 1);
            thuNganRepository.ThemHD(newMhd, NgayXuat, Msp, SoLuong, DonGia, ThanhTien, Mkh, Mnv);
        }

        public DataTable SearchKhachHang(string Mkh)
        {
            return thuNganRepository.SearchDataKH(Mkh);
        }
    }
}
