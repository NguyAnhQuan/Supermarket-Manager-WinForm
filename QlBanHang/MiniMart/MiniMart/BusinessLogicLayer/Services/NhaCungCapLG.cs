using MiniMart.DataAccessLayer.Repositories;
using System.Data;

namespace MiniMart.BusinessLogicLayer.Services
{
    internal class NhaCungCapLG
    {
        private readonly INhaCungCapRepository nhaCungCapRepository;

        public NhaCungCapLG(INhaCungCapRepository repository)
        {
            nhaCungCapRepository = repository;
        }

        public DataTable GetNhaCungCap()
        {
            return nhaCungCapRepository.NhaCungCap();
        }

        public void AddNewEntry(string Mncc, string Ten, string DiaChi, int Sdt, string HopTac)
        {
            nhaCungCapRepository.AddNewEntry(Mncc, Ten, DiaChi, Sdt, HopTac);
        }

        public void UpdateEntry(string Mncc, string Ten, string DiaChi, int Sdt, string HopTac)
        {
            nhaCungCapRepository.UpdateEntry(Mncc, Ten, DiaChi, Sdt, HopTac);
        }

        public void DeleteEntry(string Mncc)
        {
            nhaCungCapRepository.DeleteEntry(Mncc);
        }

        public DataTable SearchData(string Mncc, string Ten, string DiaChi, string Sdt, string HopTac)
        {
            return nhaCungCapRepository.SearchData(Mncc, Ten, DiaChi, Sdt, HopTac);
        }
    }
}
