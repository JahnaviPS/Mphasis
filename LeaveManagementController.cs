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
   // [RoutePrefix("api/VTRouting")]
    public class LeaveManagementController : ApiController
    {
        //[HttpGet]
        //public DataTable DisplayData(int a)
        //{
        //    LeaveManagementDAL d = new LeaveManagementDAL();
        //    LeaveManagement b = new LeaveManagement();
        //    b.EmpId = a;

        //    DataTable b1 = d.showAll();
        //    return b1;


        //}
        [HttpPost]
       // [Route("insertleave")]
        public IHttpActionResult InsertData([FromBody] LeaveManagement L)
        {
            LeaveManagementDAL d = new LeaveManagementDAL();
            d.add(L);



            return Ok(new { status = 200, isSuccess = true, message = "Employee added successfully" });

        }
        [HttpGet]
        public List<LeaveManagement> showdetails()
        {
            LeaveManagementDAL d = new LeaveManagementDAL();
            List<LeaveManagement> f = d.showdetails();
            return f;


        }
    }
}
