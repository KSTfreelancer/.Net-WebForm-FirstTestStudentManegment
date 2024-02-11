using Student_management.Manager;
using Student_management.Models;
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
    public partial class Department : System.Web.UI.Page
    {
        private void GridView()
        {

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_manegment;Integrated Security=True");
            con.Open();
            string query = "select * from Department";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            GridView1.AutoGenerateColumns = false;
            GridView1.DataSource = sdr;
            GridView1.DataBind();
            con.Close();

        }
        private void ClearAllInput()
        {
            departmentidTextBox.Value = "";
            departmentnameTextBox.Value = "";
            headofdepartmentTextBox.Value = "";
            departmentphoneTextBox.Value = "";
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

        DepartmentManager aManager = new DepartmentManager();
        protected void departmentSearch_click(object sender, EventArgs e)
        {
            ClearAllLabel();
            int Id = Convert.ToInt32(departmentidTextBox.Value);
            Student_management.Models.Department aDepartment = aManager.dptSearchId(Id);


            departmentnameTextBox.Value = aDepartment.Name;
            headofdepartmentTextBox.Value = aDepartment.HeadOfDepartment;
            departmentphoneTextBox.Value = aDepartment.Phone;


            //=================================================================

            SearchLabel.Text = "";
            saveLabel.Text = "";
            updateLabel.Text = "";
            deletLabel.Text = "";
            GridView();
        }

        protected void departmentSave_click(object sender, EventArgs e)
        {
            ClearAllLabel();
                Student_management.Models.Department aDepartment = new Student_management.Models.Department();
                aDepartment.Id = Convert.ToInt32(departmentidTextBox.Value.ToString());
                aDepartment.Name = departmentnameTextBox.Value.ToString();
                aDepartment.HeadOfDepartment = headofdepartmentTextBox.Value.ToString();
                aDepartment.Phone = departmentphoneTextBox.Value.ToString();

                string message = aManager.SavDepartment(aDepartment);
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

        protected void departmentUpdate_click(object sender, EventArgs e)
        {
            ClearAllLabel();
            Student_management.Models.Department aDepartment = new Student_management.Models.Department();
            aDepartment.Id = Convert.ToInt32(departmentidTextBox.Value.ToString());
            aDepartment.Name = departmentnameTextBox.Value.ToString();
            aDepartment.HeadOfDepartment = headofdepartmentTextBox.Value.ToString();
            aDepartment.Phone = departmentphoneTextBox.Value.ToString();


            DepartmentManager aManager = new DepartmentManager();
            string message = aManager.UpdateDepartmenr(aDepartment);
            updateLabel.Text = message;
            
            GridView();
            ClearAllInput();
        }

        protected void departmentDelete_click(object sender, EventArgs e)
        {
            ClearAllLabel();
            Student_management.Models.Department aDepartment = new Student_management.Models.Department();
            aDepartment.Id = Convert.ToInt32(departmentidTextBox.Value.ToString());

           // DepartmentManager aManager = new DepartmentManager();
            string message = aManager.DeletDepartment(aDepartment);
            saveLabel.Text = message;
            GridView();
            ClearAllInput();
        }

        protected void downloadpdf_click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_manegment;Integrated Security=True");
            con.Open();
            string query = "select * from Department";


            SqlDataAdapter Sqladtr = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            Sqladtr.Fill(ds);


            Crystal_Report.CrystalReportDepartment crpt = new Crystal_Report.CrystalReportDepartment();
            crpt.Load(Server.MapPath("CrystalReportDepartment.rpt"));
            crpt.SetDataSource(ds.Tables["Students"]);

            CrystalReportViewerDepartment.ReportSource = crpt;
            crpt.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, false, "Student Info Report");

            con.Close();
        }

        protected void GridEdit_click(object sender, EventArgs e)
        {
            Response.Redirect("Department_Edit.aspx");
        }
    }
}