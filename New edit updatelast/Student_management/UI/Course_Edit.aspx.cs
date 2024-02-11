using CrystalDecisions.Shared;
using Student_management.Manager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Student_management.UI
{
    public partial class Course_Edit : System.Web.UI.Page
    {
        CourseManager aManager = new CourseManager();
        //private void GridView()
        //{

        //    SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_manegment;Integrated Security=True");
        //    con.Open();
        //    string query = "select * from Course";
        //    SqlCommand cmd = new SqlCommand(query, con);
        //    SqlDataReader sdr = cmd.ExecuteReader();
        //    GridView1.AutoGenerateColumns = false;
        //    GridView1.DataSource = sdr;
        //    GridView1.DataBind();
        //    con.Close();

        //}
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
            
            if (!IsPostBack) 
            {
                GridView1.EditRowStyle.BackColor = System.Drawing.Color.Orange;
                popUp.Visible = false;

            }
            
        }
       
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
           
        }
        protected void Showinsert_click(object sender, EventArgs e)
        {
            popUp.Visible = true;
        }
        protected void Clogeinsert_click(object sender, EventArgs e)
        {
            popUp.Visible = false;
            Response.Redirect("Course_Edit.aspx", true);

        }
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
            //GridView();
            //Response.Redirect("Course_Edit.aspx");
            //ScriptManager.RegisterClientScriptBlock(this, GetType(), "mykey", "stt();",true);
            

        }
        //Student_management.Models.Course aCourse = new Student_management.Models.Course();
        protected void courseSave_click(object sender, EventArgs e)
        {
            
                ClearAllLabel();
                Student_management.Models.Course aCourse = new Student_management.Models.Course();
                aCourse.Id = Convert.ToInt32(courseidTextBox.Value.ToString());
                aCourse.Name = coursenameTextBox.Value.ToString();
                aCourse.Duration = coursedurationTextBox.Value.ToString();


                string message = aManager.SavCourse(aCourse);
                if (message == "Data hass been saved.")
                {
                    saveLabel.Text = message;
                }
                else
                {
                    deletLabel.Text = message;
                }

                //GridView();
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

            //GridView();
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
            //GridView();
            ClearAllInput();
        }

        
       
    }
}