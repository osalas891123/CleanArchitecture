using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Student")]
    public class StudentController : Controller
    {
        private readonly IStudentService studentService;
        public StudentController(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        [HttpGet]
        [Route("All")]
        public IActionResult GetAllStudents()
        {
            throw new NotImplementedException();
        }

        [HttpGet("id/{id:int}")]
        public IActionResult GetById(int id)
        {
            var student = studentService.GetById(id);
            return Ok(student);
        }
    }
}