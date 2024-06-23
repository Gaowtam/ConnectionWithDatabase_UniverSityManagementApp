using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UniverSityManagementApp.Models;

namespace UniverSityManagementApp
{
    public partial class Students : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=ESL6;Database=UniversityDB;User=sa;password=123;";
            string query = "select StudentId,RegNo,Name,Email,Phone from tbStudents";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Student> studentList = new List<Student>();

            
            while (reader.Read())
            {
                Student aStudent = new Student();
                aStudent.StudentId = Convert.ToInt32(reader["StudentId"]);
                aStudent.regNo = reader["RegNo"].ToString();
                aStudent.name = reader["Name"].ToString();
                aStudent.email = reader["Email"].ToString();
                aStudent.phone = reader["Phone"].ToString();

                studentList.Add(aStudent);
            }
            reader.Close();
            connection.Close();

            gridStudents.DataSource = studentList;
            gridStudents.DataBind();

        }

  
    }
}