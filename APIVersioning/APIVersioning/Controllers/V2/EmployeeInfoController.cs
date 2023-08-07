using APIVersioning.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIVersioning.Controllers.V2
{
    [Route("api/v{version:apiVersion}/[controller]")]
    //[Route("api/[controller]")]
    [ApiController]
    [ApiVersion("2.0")]
    public class EmployeeInfoController : ControllerBase
    {
        [HttpGet("AllEmployee")]
        public IActionResult AllEmployee()
        {
            List<UserInfo> users = new List<UserInfo>
            {
                new UserInfo
                {
                    ID = Guid.NewGuid(),
                    Name = "Rakim",
                    Phone = 01646053194,
                    Salary = 40000
                },
                new UserInfo
                {
                    ID = Guid.NewGuid(),
                    Name = "Hasib",
                    Phone = 01643433909,
                    Salary = 30000
                },
                new UserInfo
                {
                    ID = Guid.NewGuid(),
                    Name = "Rakibul",
                    Phone = 01646053194,
                    Salary = 50000
                }
            };
            return Ok(users);
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
