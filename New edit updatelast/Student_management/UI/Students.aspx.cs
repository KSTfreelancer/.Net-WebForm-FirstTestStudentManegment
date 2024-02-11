using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Net;
using System.Security.Policy;
using System.Xml.Linq;
using Student_management.Manager;
using Student_management.Models;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;  


namespace Student_management.UI
{
    public partial class Students : System.Web.UI.Page
    {
        StudentManager aManager = new StudentManager();
        private void ClearAllInput()
        {
            studentidTextBox.Value = "";
            studentnameTextBox.Value="";
            studentaddressTextBox.Value="";
            studentageTextBox.Value="";
            studentrollTextBox.Value="";
            studentphoneTextBox.Value="";
            studentregTextBox.Value="";
            studentsessionTextBox.Value="";
            studentdepartmentTextBox.Value="";
            studentcourseTextBox.Value="";
        }

        private void GridView()
        {

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_manegment;Integrated Security=True");
            con.Open();
            string query = "select * from Students";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            GridView1.AutoGenerateColumns = false;
            GridView1.DataSource = sdr;
            GridView1.DataBind();
            con.Close();

        }
        private void ClearAllLabel()
        {
            deletLabel.Text = "";
            updateLabel.Text = "";
            saveLabel.Text = "";
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                GridView();
            } 
            
        }
       

        protected void studentSearch_click(object sender, EventArgs e)
        {
            ClearAllLabel();
            string Id = studentidTextBox.Value.ToString();
            Student aStudent = aManager.SearchId(Convert.ToInt32(Id.ToString()));

            studentnameTextBox.Value = aStudent.Name;
            studentaddressTextBox.Value = aStudent.Address;
            studentageTextBox.Value = aStudent.Age;
            studentrollTextBox.Value = aStudent.Roll;
            studentphoneTextBox.Value = aStudent.Phone;
            studentregTextBox.Value = aStudent.RegNo;
            studentsessionTextBox.Value = aStudent.Session;
            studentdepartmentTextBox.Value = aStudent.Department;
            studentcourseTextBox.Value = aStudent.Course;

            //=================================================================
            
                SearchLabel.Text = "";
                saveLabel.Text = "";
                updateLabel.Text = "";
                deletLabel.Text = "";
            
        }
        protected void studentSave_click(object sender, EventArgs e)
        {
            ClearAllLabel();
            Student aStudent =new Student();
            aStudent.Id = Convert.ToInt32(studentidTextBox.Value.ToString());
            aStudent.Name = studentnameTextBox.Value.ToString();
            aStudent.Address = studentaddressTextBox.Value.ToString();
            aStudent.Age = studentageTextBox.Value.ToString();
            aStudent.Roll = studentrollTextBox.Value.ToString();
            aStudent.Phone = studentphoneTextBox.Value.ToString();
            aStudent.RegNo = studentregTextBox.Value.ToString();
            aStudent.Session = studentsessionTextBox.Value.ToString();
            aStudent.Department = studentdepartmentTextBox.Value.ToString();
            aStudent.Course = studentcourseTextBox.Value.ToString();

            StudentManager aManager =new StudentManager();
            string message = aManager.SaveStudent(aStudent);
            if (message == "Data hass been saved.")
            {
                saveLabel.Text = message;
            }
            else
            {
                deletLabel.Text = message;
            }

            GridView();
            ClearAllInput();

        }
        protected void studentUpdate_click(object sender, EventArgs e)
        {
            ClearAllLabel();
            Student aStudent = new Student();
            aStudent.Id = Convert.ToInt32(studentidTextBox.Value.ToString());
            aStudent.Name = studentnameTextBox.Value.ToString();
            aStudent.Address = studentaddressTextBox.Value.ToString();
            aStudent.Age = studentageTextBox.Value.ToString();
            aStudent.Roll = studentrollTextBox.Value.ToString();
            aStudent.Phone = studentphoneTextBox.Value.ToString();
            aStudent.RegNo = studentregTextBox.Value.ToString();
            aStudent.Session = studentsessionTextBox.Value.ToString();
            aStudent.Department = studentdepartmentTextBox.Value.ToString();
            aStudent.Course = studentcourseTextBox.Value.ToString();

            StudentManager aManager = new StudentManager();
            string message = aManager.UpdateStudent(aStudent);
            updateLabel.Text = message;
            deletLabel.Text = "";
            saveLabel.Text = "";
            GridView();
            ClearAllInput();
        }

        protected void studentDelete_click(object sender, EventArgs e)
        {
            ClearAllLabel();
            Student aStudent = new Student();
            aStudent.Id = Convert.ToInt32(studentidTextBox.Value.ToString());
            
            StudentManager aManager = new StudentManager();
            string message = aManager.DeletStudent(aStudent);
            deletLabel.Text = message;
            saveLabel.Text = "";
            updateLabel.Text = "";
            GridView();
            ClearAllInput();
        }

        protected void downloadpdf_click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_manegment;Integrated Security=True");
            con.Open();
            string query = "select * from Students";


            SqlDataAdapter Sqladtr = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            Sqladtr.Fill(ds);
            

            Crystal_Report.CrystalReport1 crpt = new Crystal_Report.CrystalReport1();
            crpt.Load(Server.MapPath("CrystalReport1.rpt"));
            crpt.SetDataSource(ds.Tables["Students"]);

            CrystalReportViewer1.ReportSource = crpt;
            crpt.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, false, "Student Info Report");

            con.Close();
        }

        protected void EditFrid_click(object sender, EventArgs e)
        {
            Response.Redirect("Student_Edit.aspx");
        }

        protected void serchOptionBtn_Click(object sender, EventArgs e)
        {
            
            SqlConnection cmd = new SqlConnection("Data Source=.;Initial Catalog=Student_manegment;Integrated Security=True");
            cmd.Open();
            string query = "select * from Students where Roll like '%'+@Roll+'%' or Name like '%'+@Name+'%' or RegNo like '%'+@RegNo+'%' ";
            SqlCommand cmd2 = new SqlCommand(query, cmd);
            cmd2.Parameters.AddWithValue("@Name", searchOptionTextBox.Text);
            cmd2.Parameters.AddWithValue("@Roll", searchOptionTextBox.Text);
            cmd2.Parameters.AddWithValue("@RegNo", searchOptionTextBox.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd2);

            sda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            cmd.Close();
           
        }

       
    }
}