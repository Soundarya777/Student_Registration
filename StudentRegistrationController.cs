using SampleWebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SampleWebApplication1.Controllers
{
    public class StudentRegistrationController : ApiController
    {
        /// <summary>
        /// To register new student
        /// </summary>
        /// <param name="studentregd"></param>
        /// <returns></returns>
        public StudentRegistrationReply PostStudent(Student studentregd)
        {
            //Console.WriteLine("In registerStudent");
            StudentRegistrationReply stdregreply = new StudentRegistrationReply();
            StudentRegistration.GetInstance().Add(studentregd);
            stdregreply.Name = studentregd.Name;
            stdregreply.Age = studentregd.Age;
            stdregreply.RegistrationNo = studentregd.RegistrationNo;
            stdregreply.RegistrationStatus = "Successful";
            return stdregreply;
        }
    }
}
