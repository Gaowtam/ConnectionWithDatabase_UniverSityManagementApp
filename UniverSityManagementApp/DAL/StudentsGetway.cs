
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using UniverSityManagementApp.Models;

namespace UniverSityManagementApp.DAL
{
    public class StudentsGetway
    {
        public int SaveStudent(Student aStudent)
        {
            string connectionString = "Server=ESL6;Database=UniversityDB;User=sa;password=123;";
            string query = "insert into tbStudents values(" + aStudent.StudentId + ",'" + aStudent.regNo + "','" + aStudent.name + "','" + aStudent.email + "','" + aStudent.phone + "')";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int rowAfffected = command.ExecuteNonQuery();
            connection.Close();

            return rowAfffected;
        }
    }
}