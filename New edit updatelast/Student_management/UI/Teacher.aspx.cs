using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Student_management.Manager;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Student_management.UI
{
    public partial class Teacher : System.Web.UI.Page
    {
        private void GridView()
        {

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_manegment;Integrated Security=True");
            con.Open();
            string query = "select * from Teacher";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            GridView1.AutoGenerateColumns = false;
            GridView1.DataSource = sdr;
            GridView1.DataBind();
            con.Close();

        }
        private void ClearAllInput()
        {
            teacheridTextBox.Value = "";
            teachernameTextBox.Value = "";
            teacheraddressTextBox.Value = "";
            teacherageTextBox.Value = "";
            teachersubjectTextBox.Value = "";
            teacherphoneTextBox.Value = "";
            teacherdepartmentTextBox.Value = "";
            teacherdateofjoinTextBox.Value = "";
        }
        private void ClearAllLabel()
        {
            deletLabel.Text = "";
            updateLabel.Text = "";
            saveLabel.Text = "";
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView();
        }
        TeacherManager aManager = new TeacherManager();
        protected void teacherSearch_click(object sender, EventArgs e)
        {
            ClearAllLabel();
            int Id = Convert.ToInt32(teacheridTextBox.Value);
            Student_management.Models.Teacher aTeacher = aManager.dptSearchId(Id);


            teachernameTextBox.Value = aTeacher.Name;
            teacheraddressTextBox.Value = aTeacher.Address;
            teacherageTextBox.Value = aTeacher.Age;
            teachersubjectTextBox.Value = aTeacher.Subject;
            teacherphoneTextBox.Value = aTeacher.Phone;
            teacherdepartmentTextBox.Value = aTeacher.Department;
            teacherdateofjoinTextBox.Value = aTeacher.DateOfJoin;


            //=================================================================

            SearchLabel.Text = "";
            saveLabel.Text = "";
            updateLabel.Text = "";
            deletLabel.Text = "";
            GridView();
        }

        protected void teacherSave_click(object sender, EventArgs e)
        {
            ClearAllLabel();
            Student_management.Models.Teacher aTeacher = new Student_management.Models.Teacher();

                aTeacher.Id = Convert.ToInt32(teacheridTextBox.Value);
                aTeacher.Name = teachernameTextBox.Value.ToString();
                aTeacher.Address = teacheraddressTextBox.Value.ToString();
                aTeacher.Age = teacherageTextBox.Value.ToString();
                aTeacher.Subject = teachersubjectTextBox.Value.ToString();
                aTeacher.Phone = teacherphoneTextBox.Value.ToString();
                aTeacher.Department = teacherdepartmentTextBox.Value.ToString();
                aTeacher.DateOfJoin = teacherdateofjoinTextBox.Value.ToString();

                string message = aManager.SavTeacher(aTeacher);
            if (message == "Data hass been saved.")
            {
                saveLabel.Text = message;
            }
                else
            {
                deletLabel.Text=message;
               
            }
          
            GridView();
            ClearAllInput();
        }

        protected void teacherUpdate_click(object sender, EventArgs e)
        {
            ClearAllLabel();
            Student_management.Models.Teacher aTeacher = new Student_management.Models.Teacher();

            aTeacher.Id = Convert.ToInt32(teacheridTextBox.Value);
            aTeacher.Name = teachernameTextBox.Value.ToString();
            aTeacher.Address = teacheraddressTextBox.Value.ToString();
            aTeacher.Age = teacherageTextBox.Value.ToString();
            aTeacher.Subject = teachersubjectTextBox.Value.ToString();
            aTeacher.Phone = teacherphoneTextBox.Value.ToString();
            aTeacher.Department = teacherdepartmentTextBox.Value.ToString();
            aTeacher.DateOfJoin = teacherdateofjoinTextBox.Value.ToString();

            TeacherManager aManager = new TeacherManager();
            string message = aManager.UpdatTeacher(aTeacher);
            saveLabel.Text = message;

            GridView();
            ClearAllInput();
        }

        protected void teacherDelete_click(object sender, EventArgs e)
        {
            ClearAllLabel();
            Student_management.Models.Teacher aTeacher = new Student_management.Models.Teacher();
            aTeacher.Id = Convert.ToInt32(teacheridTextBox.Value.ToString());

            // DepartmentManager aManager = new DepartmentManager();
            string message = aManager.DeletTeacher(aTeacher);
            saveLabel.Text = message;
            GridView();
            ClearAllInput();
        }

        protected void downloadpdf_click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_manegment;Integrated Security=True");
            con.Open();
            string query = "select * from Teacher";


            SqlDataAdapter Sqladtr = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            Sqladtr.Fill(ds);


            Crystal_Report.CrystalReportTeacher crpt = new Crystal_Report.CrystalReportTeacher();
            crpt.Load(Server.MapPath("CrystalReportTeacher.rpt"));
            crpt.SetDataSource(ds.Tables["Students"]);

            CrystalReportViewerTeacher.ReportSource = crpt;
            crpt.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, false, "Student Info Report");

            con.Close();
        }

        protected void EditFrid_click(object sender, EventArgs e)
        {
            Response.Redirect("Teacher_Edit.aspx");
        }
    }
}