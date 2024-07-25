using MiniMart.DataAccessLayer.Repositories;
using System;
using System.Data;

namespace MiniMart.BusinessLogicLayer.Services
{
    internal class NhanVienLG : INhanVienRepository
    {
        private readonly INhanVienRepository nhanVienRepository;

        public NhanVienLG()
        {
            this.nhanVienRepository = new NhanVienDB();
        }

        public DataTable GetNhanVien()
        {
            return nhanVienRepository.GetNhanVien();
        }

        public void AddNewEntry(string Mnv, string Sdt, DateTime SinhNhat, string DiaChi, string HoTen, string GioiTinh, string ChucVu, float Luong)
        {
            nhanVienRepository.AddNewEntry(Mnv, Sdt, SinhNhat, DiaChi, HoTen, GioiTinh, ChucVu, Luong);
        }

        public void UpdateEntry(string Mnv, string Sdt, DateTime SinhNhat, string DiaChi, string HoTen, string GioiTinh, string ChucVu, float Luong)
        {
            nhanVienRepository.UpdateEntry(Mnv, Sdt, SinhNhat, DiaChi, HoTen, GioiTinh, ChucVu, Luong);
        }

        public void DeleteEntry(string Mnv)
        {
            nhanVienRepository.DeleteEntry(Mnv);
        }

        public DataTable SearchData(string Mnv, string Sdt, string DiaChi, string HoTen, string GioiTinh, string ChucVu, float Luong)
        {
            return nhanVienRepository.SearchData(Mnv, Sdt, DiaChi, HoTen, GioiTinh, ChucVu, Luong);
        }
    }
}
