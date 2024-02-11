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
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_manegment;Integrated Security=True");
            con.Open();
            string query = "select * from stLogin where userName='" + loginnameTextBox.Value + "' and userPassword='" + loginpasswordTextBox.Value + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            loginError.Text = "";


            if (dt.Rows.Count == 1)
            {
                Response.Redirect("Home.html");
            }
            else
            {

                loginError.Text = "Your Loging Information is Incarect!";
                loginnameTextBox.Value = "";
                loginpasswordTextBox.Value = "";


            }

            //SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_manegment;Integrated Security=True");
            //con.Open();
            //string query = "select * from stLogin where Id ='" + loginnameTextBox.Value + "' and '" + loginpasswordTextBox.Value + "'";
            //SqlDataAdapter sda = new SqlDataAdapter();
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //con.Close();
            //loginError.Text = "";
            //if (dt.Rows.Count == 1)
            //{
            //    Response.Redirect("Home.html");
            //}
            //else
            //{

            //    loginError.Text = "Your Loging Information is Incarect!";
            //    loginnameTextBox.Value = "";
            //    loginpasswordTextBox.Value = "";
            //}



        } 
    }
}