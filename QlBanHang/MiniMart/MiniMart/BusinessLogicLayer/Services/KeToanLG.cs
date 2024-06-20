using MiniMart.DataAccessLayer.Repositories;
using System.Data;

namespace MiniMart.BusinessLogicLayer.Services
{
    internal class KeToanLG
    {
        private KeToanDB keToanDB;

        public KeToanLG()
        {
            keToanDB = new KeToanDB();
        }

        public DataTable GetThongKeThuData()
        {
            return keToanDB.GetThanhTienFromHoaDon();
        }

        public DataTable GetThongKeChiData()
        {
            return keToanDB.GetTongGiaFromKhoNX();
        }

        public DataTable GetThongKeTaiChinhData()
        {
            return keToanDB.CalculateTienLaiLo();
        }
    }
}
