using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniverSityManagementApp.DAL;
using UniverSityManagementApp.Models;

namespace UniverSityManagementApp.BLL
{
    public class StudentManager
    {
        public string SaveStudent(Student aStudent)
        {
            StudentsGetway geteway = new StudentsGetway();
            if(aStudent.regNo.Length<5)
            {
                return "Registration No Must Be Greater Than 5 Char";
            }
            int rowAffected = geteway.SaveStudent(aStudent);
            if (rowAffected > 0)
            {
                return "Save Successfull";
            }
            return "Save Failed";
        }
    }
}