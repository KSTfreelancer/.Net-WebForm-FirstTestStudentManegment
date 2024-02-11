using Student_management.Manager;
using Student_management.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Student_management.UI
{
    public partial class MarkAdd : System.Web.UI.Page
    {
        private void GridView()
        {

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_manegment;Integrated Security=True");
            con.Open();
            string query = "select ma.Student_Roll,st.Name,ma.Course_Name,ma.Marks,ma.OutOfMarks from Marks_sit as ma inner join Students as st on st.Roll=ma.Student_Roll";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            GridView1.AutoGenerateColumns = false;
            GridView1.DataSource = sdr;
            GridView1.DataBind();
            con.Close();

        }
        private void ClearAllInput()
        {
            markStudentRollTextBox.Value = "";
            studentNameTextBox.Value = "";
            markCourseNameTextBox.Value = "";
            markAddTextBox.Value = "";
            outOfMarkTextBox.Value = "";
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
        MarkAddManager aManager = new MarkAddManager();
        protected void markSearch_click(object sender, EventArgs e)
        {
            ClearAllLabel();
            string Roll = markStudentRollTextBox.Value;
            Student_management.Models.Student aStudent = aManager.dptSearchRoll(Roll);


            studentNameTextBox.Value = aStudent.Name;
            markCourseNameTextBox.Value = aStudent.Course;
            //if (markCourseNameTextBox.Value=="100") 
            //{
            //    outOfMarkTextBox.Value = "50";
            //}
            //else
            //{
                outOfMarkTextBox.Value = "100";
            //}
            
            //coursedurationTextBox.Value = aCourse.Duration;


            //=================================================================

            SearchLabel.Text = "";
            saveLabel.Text = "";
            updateLabel.Text = "";
            deletLabel.Text = "";
            GridView();
        }

        protected void markSave_click(object sender, EventArgs e)
        {
            ClearAllLabel();
            Mark aMark = new Mark();

            aMark.Student_Roll = markStudentRollTextBox.Value;
            aMark.Course_Name = markCourseNameTextBox.Value;
            aMark.Marks= markAddTextBox.Value;
            aMark.OutOfMarks= outOfMarkTextBox.Value;
           

            MarkAddManager aManeger = new MarkAddManager();
            string message = aManager.SavCourse(aMark);
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

        protected void markUpdate_click(object sender, EventArgs e)
        {
            ClearAllLabel();
            Mark aMark = new Mark();
            aMark.Student_Roll = markStudentRollTextBox.Value;
            aMark.Course_Name = markCourseNameTextBox.Value;
            aMark.Marks = markAddTextBox.Value;
            aMark.OutOfMarks = outOfMarkTextBox.Value;


            string message = aManager.UpdatMark(aMark);
            saveLabel.Text = message;

            GridView();
            ClearAllInput();
        }

        protected void markDelete_click(object sender, EventArgs e)
        {
            ClearAllLabel();
            Mark aMark = new Mark();
            aMark.Student_Roll = markStudentRollTextBox.Value;

            // DepartmentManager aManager = new DepartmentManager();
            string message = aManager.DeletCourse(aMark);
            saveLabel.Text = message;
            GridView();
            ClearAllInput();
        }
    }
}