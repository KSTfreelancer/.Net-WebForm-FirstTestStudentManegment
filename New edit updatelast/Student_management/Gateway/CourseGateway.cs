using Student_management.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Student_management.Gateway
{
    public class CourseGateway
    {
        public Student_management.Models.Course dptSearchId(int Id)
        {

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_manegment;Integrated Security=True");
            con.Open();
            string query = "select * from Course where Id='" + Id + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            Student_management.Models.Course aCourse = new Student_management.Models.Course();

            while (dr.Read())
            {
                aCourse.Id = Convert.ToInt32(dr["Id"].ToString());
                aCourse.Name = dr["CourseName"].ToString();
                aCourse.Duration = dr["Duration"].ToString();

            }
            con.Close();
            return aCourse;

        }
        public int Exist(Course aCourse)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_manegment;Integrated Security=True");
            con.Open();
            string query = "select * from Course where Id ='"+aCourse.Id+"'";
            SqlDataAdapter sqlda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            return dt.Rows.Count;
        }
        //Student_management.Models.Course aCourse = new Student_management.Models.Course();
        public int SavCourse(Student_management.Models.Course aCourse)
        {

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_manegment;Integrated Security=True");
            con.Open();
            string query = "insert into Course(Id,CourseName,Duration)values(@Id,@CourseName,@Duration)";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Id", aCourse.Id);
            cmd.Parameters.AddWithValue("@CourseName", aCourse.Name);
            cmd.Parameters.AddWithValue("@Duration", aCourse.Duration);

            int rows = cmd.ExecuteNonQuery();
            con.Close();
            return rows;

        }

        public int UpdatCourse(Student_management.Models.Course aCourse)
        {

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_manegment;Integrated Security=True");
            con.Open();
            string query = "update Course set CourseName=@Name,Duration=@Duration where Id=@Id";
            SqlCommand cmd = new SqlCommand(query, con);


            cmd.Parameters.AddWithValue("@Id", aCourse.Id);
            cmd.Parameters.AddWithValue("@Name", aCourse.Name);
            cmd.Parameters.AddWithValue("@Duration", aCourse.Duration);

            int rows = cmd.ExecuteNonQuery();
            con.Close();
            return rows;

        }

        public int DeletCourse(Student_management.Models.Course aCourse)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_manegment;Integrated Security=True");
            con.Open();
            string query = "delete from Course where ID=@Id";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Id", aCourse.Id);

            int rows = cmd.ExecuteNonQuery();
            con.Close();
            return rows;
        }
    }
}