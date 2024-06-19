using MiniMart.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;

namespace MiniMart.BusinessLogicLayer.Services
{
    internal class NhanVienLG
    {
        public DataTable GetNhanVien()
        {
            return NhanVienDB.NhanVien();
        }

        public void AddNewEntry(string Mnv, string Sdt, string SinhNhat, string DiaChi, string HoTen, string GioiTinh, string ChucVu, float Luong)
        {
            NhanVienDB.AddNewEntry( Mnv,  Sdt,  SinhNhat,  DiaChi,  HoTen,  GioiTinh,  ChucVu, Luong);
        }

        public void UpdateEntry(string Mnv, string Sdt, string SinhNhat, string DiaChi, string HoTen, string GioiTinh, string ChucVu, float Luong)
        {
            NhanVienDB.UpdateEntry(Mnv, Sdt, SinhNhat, DiaChi, HoTen, GioiTinh, ChucVu, Luong);
        }

        public void DeleteEntry(string Mnv)
        {
            NhanVienDB.DeleteEntry(Mnv);
        }

        public DataTable SearchData(string Mnv, string Sdt, string SinhNhat, string DiaChi, string HoTen, string GioiTinh, string ChucVu, float Luong)
        {
            return NhanVienDB.SearchData(Mnv, Sdt, SinhNhat, DiaChi, HoTen, GioiTinh, ChucVu, Luong);
        }
    }
}
