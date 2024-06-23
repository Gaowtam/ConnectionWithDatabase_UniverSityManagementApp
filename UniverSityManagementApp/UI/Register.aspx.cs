using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UniverSityManagementApp.BLL;
using UniverSityManagementApp.Models;

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

            StudentManager aManager = new StudentManager();
            String msg = aManager.SaveStudent(aStudent);
            lblShow.Text = msg;
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            Response.Redirect(url: "Students.aspx");
        }
    }
}