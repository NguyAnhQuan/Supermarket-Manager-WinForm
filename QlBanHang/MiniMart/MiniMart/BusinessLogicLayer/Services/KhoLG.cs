using System;
using System.Data;
using MiniMart.DataAccessLayer.Repositories;

namespace MiniMart.BusinessLogicLayer.Services
{
    internal class KhoLG
    {
        public DataTable GetNhapData()
        {
            return KhoDb.DataNhap();
        }

        public DataTable GetXuatData()
        {
            return KhoDb.DataXuat();
        }

        public DataTable GetSanPhamHetHan()
        {
            return KhoDb.SanPhamHetHan();
        }

        public bool CheckDuplicate(string mnx)
        {
            return KhoDb.CheckDuplicate(mnx);
        }

        public void AddNewEntry(string mnx, string msp, string mncc, int soLuong, decimal tongGia, DateTime thoiGian)
        {
            KhoDb.AddNewEntry(mnx, msp, mncc, soLuong, tongGia, thoiGian);
        }

        public void UpdateEntry(string mnx, string msp, string mncc, int soLuong, decimal tongGia, DateTime thoiGian)
        {
            KhoDb.UpdateEntry(mnx, msp, mncc, soLuong, tongGia, thoiGian);
        }

        public void DeleteEntry(string mnx)
        {
            KhoDb.DeleteEntry(mnx);
        }

        public DataTable SearchData(string columnName, string keyword, DateTime fromDate, DateTime toDate)
        {
            return KhoDb.SearchData(columnName, keyword, fromDate, toDate);
        }

        public TimeSpan CalculateDateDifference(DateTime date1, DateTime date2)
        {
            return date2 - date1;
        }
    }
}
