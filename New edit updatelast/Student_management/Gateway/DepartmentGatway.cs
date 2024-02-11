using Student_management.Models;
using Student_management.UI;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
//using Department= Student_management.UI.Department;

namespace Student_management.Gateway
{
    public class DepartmentGatway
    {
        public bool Exist(int Id) 
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_manegment;Integrated Security=True");
            con.Open();
            string query = "select * from Department where Id='" + Id + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Student_management.Models.Department dptSearchId(int Id)
        {

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_manegment;Integrated Security=True");
            con.Open();
            string query = "select * from Department where Id='" + Id + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            Student_management.Models.Department aDepartment = new Student_management.Models.Department();

            while (dr.Read())
            {
                aDepartment.Id = Convert.ToInt32(dr["Id"].ToString());
                aDepartment.Name = dr["Name"].ToString();
                aDepartment.HeadOfDepartment = dr["HeadOfDepartment"].ToString();
                aDepartment.Phone = dr["Phone"].ToString();

            }
            con.Close();
            return aDepartment;

        }

        public int SavDepartment(Student_management.Models.Department aDepartment)
        {

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_manegment;Integrated Security=True");
            con.Open();
            string query = "insert into Department(Id,Name,HeadOfDepartment,Phone)values(@Id,@Name,@HeadOfDepartment,@Phone)";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Id", aDepartment.Id);
            cmd.Parameters.AddWithValue("@Name", aDepartment.Name);
            cmd.Parameters.AddWithValue("@HeadOfDepartment", aDepartment.HeadOfDepartment);
            cmd.Parameters.AddWithValue("@Phone", aDepartment.Phone);

            int rows = cmd.ExecuteNonQuery();
            con.Close();
            return rows;

        }

        public int UpdatDepartment(Student_management.Models.Department aDepartment)
        {

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_manegment;Integrated Security=True");
            con.Open();
            string query = "update Department set Name=@Name,HeadOfDepartment=@HeadOfDepartment,Phone=@Phone where Id=@Id";
            SqlCommand cmd = new SqlCommand(query, con);


            cmd.Parameters.AddWithValue("@Id", aDepartment.Id);
            cmd.Parameters.AddWithValue("@Name", aDepartment.Name);
            cmd.Parameters.AddWithValue("@HeadOfDepartment", aDepartment.HeadOfDepartment);
            cmd.Parameters.AddWithValue("@Phone", aDepartment.Phone);

            int rows = cmd.ExecuteNonQuery();
            con.Close();
            return rows;

        }

        public int DeletDepartment(Student_management.Models.Department aDepartment)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_manegment;Integrated Security=True");
            con.Open();
            string query = "delete from Department where ID=@Id";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Id", aDepartment.Id);

            int rows = cmd.ExecuteNonQuery();
            con.Close();
            return rows;
        }


    }
}