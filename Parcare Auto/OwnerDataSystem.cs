using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcare_Auto
{
    internal class OwnerDataSystem
    {
        public SqlConnection conn {  get; set; }
            
        public OwnerDataSystem(SqlConnection conn) 
        {
            this.conn = conn;
        }
    }
}
