using SampleWebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace SampleWebApplication1.Controllers
{
    /// <summary>
    /// To get all students
    /// </summary>
    public class InfoController : ApiController
    {
        //[HttpGet]
        public /*void*/ List<Student> GetAllStudents()
        {
            return StudentRegistration.GetInstance().getAllStudent();
        }
    }
}
