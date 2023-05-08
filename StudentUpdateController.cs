using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SampleWebApplication1.Models;

namespace SampleWebApplication1.Controllers
{
    public class StudentUpdateController : ApiController
    {
        /// <summary>
        /// To update a student record
        /// </summary>
        /// <param name="stdn"></param>
        /// <returns></returns>
        public string PutStudentRecord(Student stdn)
        {
            //Console.WriteLine("In updateStudentRecord");
            return StudentRegistration.GetInstance().UpdateStudent(stdn);
        }
    }
}
