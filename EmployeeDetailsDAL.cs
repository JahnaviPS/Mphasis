using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using HRBAL1;


namespace HRDAL
{
    public class EmployeeDetailsDAL
    {
        public DataTable showDetails(int p)
        {
            string s = "select * from EmployeeDetails where EmployeeId=" + p;
            SqlConnection cn = new SqlConnection("Data Source=LAPTOP-JF2QMSQ6\\SQLEXPRESS;Initial Catalog=HRdb;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter(s, cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "EmployeeDetails");
              DataTable t= ds.Tables["EmployeeDetails"];
            return t;
        }
    }
}
