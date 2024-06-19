using MiniMart.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMart.BusinessLogicLayer.Services
{
    internal class SanPhamLG
    {
        public DataTable GetSanPham()
        {
            return SanPhamDB.SanPham();
        }

        public void AddNewEntry(string Mkh, string HoTen, string DiaChi, int Sdt, string HangKhach)
        {
            SanPhamDB.AddNewEntry(Mkh, HoTen, DiaChi, Sdt, HangKhach);
        }

        public void UpdateEntry(string Mkh, string HoTen, string DiaChi, int Sdt, string HangKhach)
        {
            SanPhamDB.UpdateEntry(Mkh, HoTen, DiaChi, Sdt, HangKhach);
        }

        public void DeleteEntry(string Mkh)
        {
            SanPhamDB.DeleteEntry(Mkh);
        }

        public DataTable SearchData(string Mkh, string HoTen, string DiaChi, string Sdt, string HangKhach)
        {
            return SanPhamDB.SearchData(Mkh, HoTen, DiaChi, Sdt, HangKhach);
        }
    }
}
