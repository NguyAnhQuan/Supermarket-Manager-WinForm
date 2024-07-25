using System;
using System.Data;

namespace MiniMart.DataAccessLayer.Repositories
{
    internal interface IThuNganRepository
    {
        DataTable SearchData(string Msp, string TenSp, string PhanLoai);
        string TruyvanHD();
        void ThemHD(string Mhd, DateTime NgayXuat, string Msp, int SoLuong, float DonGia, float ThanhTien, string Mkh, string Mnv);
        DataTable SearchDataKH(string Mkh);
    }
}
