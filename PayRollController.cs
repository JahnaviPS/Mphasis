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
    public class PayRollController : ApiController
    {
       


        [HttpPost]

        public IHttpActionResult InsertDetais([FromBody] Payroll L)
        {
            PayrollDAL d = new PayrollDAL();
            d.add(L);



            return Ok(new { status = 200, isSuccess = true, message = "Employee added successfully" });

        }
        [HttpGet]
        public List<Payroll> displaypayroll()
        {
            PayrollDAL d = new PayrollDAL();
            List<Payroll> f = d.displaypayroll();
            return f;


        }
    }
}
