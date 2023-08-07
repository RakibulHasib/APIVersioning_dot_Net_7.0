using APIVersioning.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIVersioning.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1.0",Deprecated =true)]
    public class EmployeeInfoController : ControllerBase
    {
        [HttpGet("AllEmployee")]
        public IActionResult AllEmployee()
        {
            List<EmployeeInfo> employees = new List<EmployeeInfo>
            {
                new EmployeeInfo
                {
                    ID = 1,
                    Name = "Rakim",
                    Phone = 01646053194,
                    Salary = 40000
                },
                new EmployeeInfo
                {
                    ID = 2,
                    Name = "Hasib",
                    Phone = 01643433909,
                    Salary = 30000
                },
                new EmployeeInfo
                {
                    ID = 3,
                    Name = "Rakibul",
                    Phone = 01646053194,
                    Salary = 50000
                }
            };
            return Ok(employees);
        }

        //Query String version testing
        //http://localhost:5237/api/EmployeeInfo/AllEmployee?api-version=1.0

        //URL version testing
        //http://localhost:5237/api/v2.0/EmployeeInfo/AllEmployee

        //Media Type version testing
        //Key: accept, Value:application/json; x-api-version=2.0

        //Header Type version testing
        //Key:x-api-version, value:2.0/1.0
    }
}
