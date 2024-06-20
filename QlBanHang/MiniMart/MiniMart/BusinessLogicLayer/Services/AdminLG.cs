using MiniMart.DataAccessLayer.Repositories;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMart.BusinessLogicLayer.Services
{
    internal class AdminLG
    {
        private readonly AdminDB adminDB;

        public AdminLG()
        {
            adminDB = new AdminDB();
        }

        public DataTable GetDangNhap()
        {
            return AdminDB.DangNhap();
        }

        public void AddNewEntry(string Mdn, string Mnv, DateTime Giovao, DateTime GioRa, string MatKhau)
        {
            AdminDB.AddNewEntry( Mdn,  Mnv,  Giovao,  GioRa,  MatKhau);
        }

        public void UpdateEntry(string Mdn, string Mnv, DateTime Giovao, DateTime GioRa, string MatKhau)
        {
            AdminDB.UpdateEntry(Mdn, Mnv, Giovao, GioRa, MatKhau);
        }

        public void DeleteEntry(string Mnv)
        {
            AdminDB.DeleteEntry(Mnv);
        }

        public DataTable SearchData(string Mdn, string Mnv, DateTime? Giovao, DateTime? GioRa, string MatKhau)
        {
            return AdminDB.SearchData(Mdn, Mnv, Giovao, GioRa, MatKhau);
        }
    }
}
