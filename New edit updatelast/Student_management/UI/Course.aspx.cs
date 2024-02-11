using Student_management.Manager;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data;



namespace Student_management.UI
{
    public partial class Course : System.Web.UI.Page
    {
        private void GridView()
        {

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_manegment;Integrated Security=True");
            con.Open();
            string query = "select * from Course";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            GridView1.AutoGenerateColumns = false;
            GridView1.DataSource = sdr;
            GridView1.DataBind();
            con.Close();

        }
        private void ClearAllInput()
        {
            courseidTextBox.Value = "";
            coursenameTextBox.Value = "";
            coursedurationTextBox.Value = "";
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
        CourseManager aManager = new CourseManager();
        protected void courseSearch_click(object sender, EventArgs e)
        {
            ClearAllLabel();
            int Id = Convert.ToInt32(courseidTextBox.Value);
            Student_management.Models.Course aCourse = aManager.dptSearchId(Id);


            coursenameTextBox.Value = aCourse.Name;
            coursedurationTextBox.Value = aCourse.Duration;


            //=================================================================

            SearchLabel.Text = "";
            saveLabel.Text = "";
            updateLabel.Text = "";
            deletLabel.Text = "";
            GridView();
        }
        //Student_management.Models.Course aCourse = new Student_management.Models.Course();
        protected void courseSave_click(object sender, EventArgs e)
        {
            ClearAllLabel();
            Student_management.Models.Course aCourse = new Student_management.Models.Course();
                aCourse.Id = Convert.ToInt32(courseidTextBox.Value.ToString());
                aCourse.Name = coursenameTextBox.Value.ToString();
                aCourse.Duration = coursedurationTextBox.Value.ToString();

            CourseManager aManeger = new CourseManager();
            string message = aManager.SavCourse(aCourse);
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

        protected void courseUpdate_click(object sender, EventArgs e)
        {
            ClearAllLabel();
            Student_management.Models.Course aCourse = new Student_management.Models.Course();
            aCourse.Id = Convert.ToInt32(courseidTextBox.Value.ToString());
            aCourse.Name = coursenameTextBox.Value.ToString();
            aCourse.Duration = coursedurationTextBox.Value.ToString();


            
            string message = aManager.UpdatCourse(aCourse);
            saveLabel.Text = message;

            GridView();
            ClearAllInput();
        }

        protected void courseDelete_click(object sender, EventArgs e)
        {
            ClearAllLabel();
            Student_management.Models.Course aCourse = new Student_management.Models.Course();
            aCourse.Id = Convert.ToInt32(courseidTextBox.Value.ToString());

            // DepartmentManager aManager = new DepartmentManager();
            string message = aManager.DeletCourse(aCourse);
            saveLabel.Text = message;
            GridView();
            ClearAllInput();
        }

        protected void downloadpdf_click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_manegment;Integrated Security=True");
            con.Open();
            string query = "select * from Course";


            SqlDataAdapter Sqladtr = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            Sqladtr.Fill(ds);


            Crystal_Report.CrystalReportCourse crpt = new Crystal_Report.CrystalReportCourse();
            crpt.Load(Server.MapPath("CrystalReportCourse.rpt"));
            crpt.SetDataSource(ds.Tables["Students"]);

            CrystalReportViewerCourse.ReportSource = crpt;
            crpt.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, false, "Student Info Report");

            con.Close();
        }

        protected void EditGrid_click(object sender, EventArgs e)
        {
            Response.Redirect("Course_Edit.aspx");
        }
    }
}