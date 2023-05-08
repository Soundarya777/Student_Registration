using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWebApplication1.Models
{
    /// <summary>
    /// Student data
    /// </summary>
    public class StudentRegistrationReply
    {
        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        string registrationNo;
        public string RegistrationNo
        {
            get { return registrationNo; }
            set { registrationNo = value; }
        }
        string registrationStatus;
        public string RegistrationStatus
        {
            get { return registrationStatus; }
            set { registrationStatus = value; }
        }

    }
}