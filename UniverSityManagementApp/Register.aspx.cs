using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UniverSityManagementApp
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string regNo = txtRegNo.Text;
            string name = txtName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;

            Student aStudent = new Student();
            aStudent.StudentId =Convert.ToInt32(id);
            aStudent.regNo = regNo;
            aStudent.name = name;
            aStudent.email = email;
            aStudent.phone = phone;

            string connectionString = "Server=ESL6;Database=UniversityDB;User=sa;password=123;";
            string query = "insert into tbStudents values("+aStudent.StudentId+",'"+aStudent.regNo+"','"+aStudent.name+"','"+aStudent.email+"','"+aStudent.phone+"')";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int rowAfffected=command.ExecuteNonQuery();
            connection.Close();
            if(rowAfffected>0)
            {
                lblShow.Text = "Save Successfull";
            }
            else
            {
                lblShow.Text = "Save Failed";
            }
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            Response.Redirect(url: "Students.aspx");
        }
    }
}