using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMart.DataAccessLayer
{
    internal interface IDatabaseConnection
    {
        void OpenConnection();
        void CloseConnection();
        SqlConnection GetConnection();
    }


}
