using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniverSityManagementApp
{
    public class Student
    {
        public int StudentId { get; set; }
        public string regNo { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }

        /*  public Student(string studentid,string regno,string name,string email,string phone)
          {
              this.regNo = regno;
              this.name = name;
              this.email = email;
              this.phone = phone;
          }*/

    }
}