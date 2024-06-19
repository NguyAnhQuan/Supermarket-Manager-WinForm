using MiniMart.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMart.BusinessLogicLayer.Services
{
    internal class KhachHangLG
    {
        public DataTable GetKhachHang()
        {
            return KhachHangDB.KhachHang();
        }

        

        public void AddNewEntry(string Mkh, string HoTen, string DiaChi, int Sdt, string HangKhach)
        {
            KhachHangDB.AddNewEntry(Mkh, HoTen, DiaChi, Sdt, HangKhach);
        }

        public void UpdateEntry(string Mkh, string HoTen, string DiaChi, int Sdt, string HangKhach)
        {
            KhachHangDB.UpdateEntry(Mkh, HoTen, DiaChi, Sdt, HangKhach);
        }

        public void DeleteEntry(string Mkh)
        {
            KhachHangDB.DeleteEntry(Mkh);
        }

        public DataTable SearchData(string Mkh, string HoTen, string DiaChi, string Sdt, string HangKhach)
        {
            return KhachHangDB.SearchData( Mkh, HoTen, DiaChi, Sdt, HangKhach);
        }

    }
}
