using System.Data;

namespace MiniMart.DataAccessLayer.Repositories
{
    public interface INhaCungCapRepository
    {
        DataTable NhaCungCap();
        void AddNewEntry(string Mncc, string Ten, string DiaChi, int Sdt, string HopTac);
        void UpdateEntry(string Mncc, string Ten, string DiaChi, int Sdt, string HopTac);
        void DeleteEntry(string Mncc);
        DataTable SearchData(string Mncc, string Ten, string DiaChi, string Sdt, string HopTac);
    }
}
