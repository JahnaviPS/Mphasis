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
    public class PayrollDAL
    {
        public void add(Payroll e)
        {
            SqlConnection cn = new SqlConnection("Data Source=LAPTOP-JF2QMSQ6\\SQLEXPRESS;Initial Catalog=HRdb;Integrated Security=True");

            SqlDataAdapter d = new SqlDataAdapter("select * from PayRoll", cn);
            DataSet t = new DataSet();
            d.Fill(t);
            DataRow r = t.Tables[0].NewRow();
            r[0] = e.Empid;
            r[1] = e.BankaccountNo;
            r[2] = e.Basicpay;
            r[3] = e.HRA;

            r[4] = e.Medicalallowance;
            r[5] = e.Tax;
            r[6] = e.Bonus;
            r[7] = e.Noofworkdays;
            r[8] = e.Grosspay;
            r[9] = e.Pfno;
       


        t.Tables[0].Rows.Add(r);
            SqlCommandBuilder b = new SqlCommandBuilder(d);
            d.Update(t);
        }
        public List<Payroll> displaypayroll()
        {
            List<Payroll> emp = new List<Payroll>();
            string s = "select * from PayRoll";
            SqlConnection cn = new SqlConnection("Data Source=LAPTOP-JF2QMSQ6\\SQLEXPRESS;Initial Catalog=HRdb;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter(s, cn);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable t = ds.Tables[0];
            int p = t.Rows.Count;
            for (int i = 0; i < p; i++)
            {
                Payroll e = new Payroll();
                e.Empid = Convert.ToInt32(t.Rows[i][0]);
                e.BankaccountNo = Convert.ToInt32(t.Rows[i][1]);
                e.Basicpay = Convert.ToInt32(t.Rows[i][2]);
                e.HRA = Convert.ToInt32(t.Rows[i][3]);
                e.Medicalallowance = Convert.ToInt32(t.Rows[i][4]);

                e.Tax = Convert.ToInt32(t.Rows[i][5]);
                 e.Bonus= Convert.ToInt32(t.Rows[i][5]); ;
                 e.Noofworkdays= Convert.ToInt32(t.Rows[i][5]);
                e.Grosspay=Convert.ToInt32(t.Rows[i][5]);
                e.Pfno=Convert.ToInt32(t.Rows[i][5]);

                emp.Add(e);

            }
            return emp;
        }
    }
}
