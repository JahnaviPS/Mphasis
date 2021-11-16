using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.SqlClient;
using System.Data;
using HRBAL1;
using HRDAL;
using System.Web.Http.Cors;

namespace HRServiceProject.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class EmpDetController : ApiController
    {
        [HttpGet]
        public DataTable Get(int a)
        {
            EmployeeDetailsDAL d = new EmployeeDetailsDAL();
            EmployeeDetails b = new EmployeeDetails();
            b.EmployeeID = a;
           
            DataTable b1=d.showDetails(b.EmployeeID);
            return b1;
            
            //    b.EmployeeName = p.EmployeeName;
            //    b.DateOfBirth =p.DateOfBirth;
            //    b.Gender = p.Gender;
            //    b.EmpStatus = p.EmpStatus;
            //    b.Designation = p.Designation;
            //    b.DeptNo = p.DeptNo;
            //    b.Address = p.Address;
            //    b.Nationality = p.Nationality;
            //    b.PhoneNo = p.PhoneNo;
            //    b.WorkLocation = p.WorkLocation;
            //    b.JoiningDate = p.JoiningDate;
            //    b.ManagerId = p.ManagerId;



            //    return Content("Your ticket booking reference =" + p);
            //}
        }
    }
}
