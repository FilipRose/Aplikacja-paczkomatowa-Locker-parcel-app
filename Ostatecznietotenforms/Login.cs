using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ostatecznietotenforms
{
    class Login
    {
        public SqlConnection sqlCon = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();

        public string locate = @"Data Source=ROSE-COMPUTER;Initial Catalog=Serwis_Zarzadzajacy;Integrated Security=True";
    }
}
