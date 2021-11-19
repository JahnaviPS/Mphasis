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
    public class LeaveManagementDAL
    {


        public DataTable showAll()
        {
            string s = "select * from LeaveManagement";
            SqlConnection cn = new SqlConnection("Data Source=LAPTOP-JF2QMSQ6\\SQLEXPRESS;Initial Catalog=HRdb;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter(s, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable t = ds.Tables[0];
            return t;
        }
        public void add(LeaveManagement e)
        {
            SqlConnection cn = new SqlConnection("Data Source=LAPTOP-JF2QMSQ6\\SQLEXPRESS;Initial Catalog=HRdb;Integrated Security=True");

            SqlDataAdapter d = new SqlDataAdapter("select * from LeaveManagement", cn);
            DataSet t = new DataSet();
            d.Fill(t);
            DataRow r = t.Tables[0].NewRow();
            r[0] = e.EmpId;
            r[1] = e.TotalLeave;
            r[2] = e.BalanceLeave;
            r[3] = e.CasualLeave;

            r[4] = e.EarnedLeave;
            r[5] = e.UnpaidLeave;

            t.Tables[0].Rows.Add(r);
            SqlCommandBuilder b = new SqlCommandBuilder(d);
            d.Update(t);
        }
        public List<LeaveManagement> showdetails()
        {
            List<LeaveManagement> emp = new List<LeaveManagement>();
            string s = "select * from LeaveManagement";
            SqlConnection cn = new SqlConnection("Data Source=LAPTOP-JF2QMSQ6\\SQLEXPRESS;Initial Catalog=HRdb;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter(s, cn);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable t = ds.Tables[0];
            int p = t.Rows.Count;
            for (int i = 0; i < p; i++)
            {
                LeaveManagement e = new LeaveManagement();
                e.EmpId = Convert.ToInt32(t.Rows[i][0]);
                e.TotalLeave = Convert.ToInt32(t.Rows[i][1]);
                e.BalanceLeave = Convert.ToInt32(t.Rows[i][2]);
                e.CasualLeave = Convert.ToInt32(t.Rows[i][3]);
                e.EarnedLeave = Convert.ToInt32(t.Rows[i][4]);

                e.UnpaidLeave = Convert.ToInt32(t.Rows[i][5]);

                emp.Add(e);

            }
            return emp;
        }
    }
}

