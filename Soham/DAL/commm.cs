using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class commm
    {
        private static string m_ConnectionString = "Data Source=148.72.232.167;Initial Catalog=vishnu;Persist Security Info=True;User ID=vishnu;Password=vishnu@125;trusted_connection=false";

        public static string GetConnectionString()
        {
            return m_ConnectionString;
        }
    }
}
