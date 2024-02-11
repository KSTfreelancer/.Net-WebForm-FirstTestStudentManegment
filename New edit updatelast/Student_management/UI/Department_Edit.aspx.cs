using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Optimization;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Student_management.UI
{
    public partial class Department_Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                GridVew();
                GridView1.EditRowStyle.BackColor = System.Drawing.Color.Orange;
            }
        }

        protected void GridVew()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_manegment;Integrated Security=True");
            con.Open();
            string query = "select * from Department";
            SqlCommand cmd = new SqlCommand(query, con);
            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();
            //SqlDataReader sdr = cmd.ExecuteReader();
            //GridView1.AutoGenerateColumns = false;
            //GridView1.DataSource = sdr;
            //GridView1.DataBind();
            //con.Close();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex=e.NewEditIndex;
            GridVew();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int Id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            String DepartmentName = ((TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
            String HeadOfDepartment = ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text;
            String Phone = ((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text;

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_manegment;Integrated Security=True");
            con.Open();
            string query = "update Department set Name='"+ DepartmentName + "', HeadOfDepartment = '"+HeadOfDepartment+ "',Phone = '"+Phone+"' where Id='"+Id+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            int rows = cmd.ExecuteNonQuery();
            if(rows > 0)
            {
                Response.Write("<script>");
                Response.Write("alert('Update Complit Successfull.')");
                Response.Write("</script>");
               
            }
            else
            {
                Response.Write("<script>");
                Response.Write("alert('Not Update!')");
                Response.Write("</script>");
                GridView1.EditIndex = -1;
                GridVew();
            }
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GridVew();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {


            Response.Write("<script>");
            Response.Write("confirm('Delet Complit')");
            Response.Write("</script>");



            int Id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_manegment;Integrated Security=True");
            con.Open();
            string query = "delete from Department where Id='" + Id + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                //Response.Write("<script>");
                //Response.Write("confirm('Delet Complit')");
                //Response.Write("</script>");

                GridView1.EditIndex = -1;
                GridVew();
            }
            else
            {
                //Response.Write("<script>");
                //Response.Write("alert('Not Delete!')");
                //Response.Write("</script>");

                GridView1.EditIndex = -1;
                GridVew();
            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridVew();
        }
    }
}