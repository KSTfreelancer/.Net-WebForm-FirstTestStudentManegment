using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Student_management.UI
{
    public partial class Student_Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

       

           GridView1.EditRowStyle.BackColor = System.Drawing.Color.Orange;
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex=e.NewPageIndex;
            this.DataBind();
        }

        protected void searchOptionTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void serchOptionBtn_Click(object sender, EventArgs e)
        {
            //SqlConnection cmd = new SqlConnection("Data Source=.;Initial Catalog=Student_manegment;Integrated Security=True");
            //cmd.Open();
            //string query = "select * from Students where Name = '" + searchOptionTextBox.Text + "'";
            //SqlCommand cmd2 = new SqlCommand(query, cmd);

            //var reader = cmd2.ExecuteReader();
            ////GridView1.Rows
            //while (reader.Read()) { }
            ////SqlDataAdapter adapter = new SqlDataAdapter(cmd2);
            ////DataTable dt = new DataTable();
            ////adapter.Fill(dt);
            ////GridView1.DataSource = dt;

            ////cmd.Close();
        }
    }
}