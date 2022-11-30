using EmployeeApi.Data;
using EmployeeApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        [HttpGet]
        public ActionResult<List<GetEmployeeResponseModel>> Get()
        {
            var employees = DataHelper.GetEmployees();
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public ActionResult<List<GetEmployeeResponseModel>> GetById(int id)
        {
            var employee = DataHelper.GetEmployeeById(id);

            return Ok(employee);
        }
    }
}
