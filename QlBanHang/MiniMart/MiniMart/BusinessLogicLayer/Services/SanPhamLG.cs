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

        public DataTable GetSanPhamHetHan()
        {
            return SanPhamDB.SanPhamHetHan();
        }

    }
}
