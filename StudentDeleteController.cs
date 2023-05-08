using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SampleWebApplication1.Models;

namespace SampleWebApplication1.Controllers
{
    /// <summary>
    /// To remove/delete a student
    /// </summary>
    public class StudentDeleteController : ApiController
    {
        //[Route("student/remove/{regdNum}")]
        public string DeleteStudentRecord(Student stud)
        {
            //Console.WriteLine("In deleteStudentRecord");
            return StudentRegistration.GetInstance().Remove(stud);
        }
    }
}
