using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWebApplication1.Models
{
    public class Student
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
    }
}