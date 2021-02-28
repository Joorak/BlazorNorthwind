using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorNorthwind.Server.Services;
using BlazorNorthwind.Shared.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace BlazorWithFirestore.Server.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        EmployeeService objemployee;
        public EmployeeController(IWebHostEnvironment HostEnvironment)
        {
            objemployee = new(HostEnvironment);
        }

        [HttpGet]
        public Task<List<Employee>> Get()
        {
            return objemployee.GetAllEmployees();
        }

        [HttpGet("{id}")]
        public Task<Employee> Get(string id)
        {
            return objemployee.GetEmployeeData(id);
        }

        [HttpPost]
        public void Post([FromBody] Employee employee)
        {
            objemployee.AddEmployee(employee);
        }

        [HttpPut]
        public void Put([FromBody] Employee employee)
        {
            objemployee.UpdateEmployee(employee);
        }

        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            objemployee.DeleteEmployee(id);

        }
        [HttpGet("GetCities")]
        public Task<List<Cities>> GetCities()
        {
            return objemployee.GetCityData();
        }
    }
}