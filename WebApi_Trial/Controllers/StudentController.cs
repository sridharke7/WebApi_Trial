using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi_Trial.Models;
using WebApi_Trial;
using System.Web.Mvc;

namespace WebApi_Trial.Controllers
{
    public class StudentController : ApiController
    {
        public IHttpActionResult GetAllStudents()
        {
            IList<StudentViewModel> students = null;

            using (var ctx = new SchoolDatabaseContext())
            {
                students = ctx.Students
                            .Select(s => new StudentViewModel()
                            {
                                Id = s.StudentID,
                                FirstName = s.FirstName,
                                LastName = s.LastName
                            }).ToList<StudentViewModel>();
            }

            if (students.Count == 0)
            {
                return NotFound();
            }

            return Ok(students);
        }
    }
}
