using MiniMart.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMart.BusinessLogicLayer.Services
{
    internal class NhaCungCapLG
    {
        public DataTable GetNhaCungCap()
        {
            return NhaCungCapDB.NhaCungCap();
        }

        public void AddNewEntry(string Mncc, string Ten, string DiaChi, int Sdt, string HopTac)
        {
            NhaCungCapDB.AddNewEntry(Mncc, Ten, DiaChi, Sdt, HopTac);
        }

        public void UpdateEntry(string Mncc, string Ten, string DiaChi, int Sdt, string HopTac)
        {
            NhaCungCapDB.UpdateEntry(Mncc, Ten, DiaChi, Sdt, HopTac);
        }

        public void DeleteEntry(string Mncc)
        {
            NhaCungCapDB.DeleteEntry(Mncc);
        }

        public DataTable SearchData(string Mncc, string Ten, string DiaChi, string Sdt, string HopTac)
        {
            return NhaCungCapDB.SearchData(Mncc, Ten, DiaChi, Sdt, HopTac);
        }
    }
}
