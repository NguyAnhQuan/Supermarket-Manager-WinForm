using MiniMart.DataAccessLayer.Repositories;
using System;
using System.Data;

namespace MiniMart.BusinessLogicLayer.Services
{
    internal class ThuNganLG
    {
        public DataTable SearchSanPham(string Msp, string TenSp, string PhanLoai)
        {
            return ThuNganDB.SearchData(Msp, TenSp, PhanLoai);
        }

        public string SearchHD()
        {
            return ThuNganDB.TruyvanHD();
        }

        public void AddHD(DateTime NgayXuat, string Msp, int SoLuong, float DonGia, float ThanhTien, string Mkh, string Mnv)
        {
            string currentMhd = SearchHD();
            int currentNumber = int.Parse(currentMhd.Substring(2)); 
            string newMhd = "HD" + (currentNumber + 1); 
            ThuNganDB.ThemHD(newMhd, NgayXuat, Msp, SoLuong, DonGia, ThanhTien, Mkh, Mnv);
        }


        public DataTable SearchKhachHang(string Mkh)
        {
            return ThuNganDB.SearchDataKH(Mkh);
        }

        

    }
}
