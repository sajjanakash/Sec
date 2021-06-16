using JWTAuthApi2.Data;
using JWTAuthApi2.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JWTAuthApi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeContext _db;
        public EmployeeController(EmployeeContext db)
        {
            _db = db;
        }
        // GET: api/<EmployeeController>
        [HttpGet]
        [Authorize(Roles =RoleModel.Admin)]
        public IEnumerable<Employee> Get()
        {
            return _db.Employees.ToList();
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        [Authorize(Roles = RoleModel.User)]
        public Employee Get(int id)
        {
            return _db.Employees.Find(id);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
