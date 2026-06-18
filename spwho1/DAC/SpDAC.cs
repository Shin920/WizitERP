using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace spwho1.SpDAC
{
    public class Session
    {
        public int SpID { get; set; }

        public string Status { get; set; }

        public string Hostname { get; set; }

        public string EmpNo { get; set; }

        public string EmpName { get; set; }
        
        public string Blkby { get; set; }

        public string Command { get; set; }
    }

    class SpDAC : IDisposable
    {
        SqlConnection conn;

        public SpDAC()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
            conn.Open();
        }
        public void Dispose()
        {

        }
    }
}
