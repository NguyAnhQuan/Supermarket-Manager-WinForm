using System;
using System.Data;

namespace MiniMart.DataAccessLayer.Repositories
{
    internal interface INhanVienRepository
    {
        DataTable GetNhanVien();
        void AddNewEntry(string Mnv, string Sdt, DateTime SinhNhat, string DiaChi, string HoTen, string GioiTinh, string ChucVu, float Luong);
        void UpdateEntry(string Mnv, string Sdt, DateTime SinhNhat, string DiaChi, string HoTen, string GioiTinh, string ChucVu, float Luong);
        void DeleteEntry(string Mnv);
        DataTable SearchData(string Mnv, string Sdt, string DiaChi, string HoTen, string GioiTinh, string ChucVu, float Luong);
    }
}
