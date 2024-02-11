using Student_management.Models;
using Student_management.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Web;

namespace Student_management.Gateway
{
    public class MarkAddGateway
    {
        public Student_management.Models.Student dptSearchId(string Roll)
        {

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_manegment;Integrated Security=True");
            con.Open();
            string query = "select Roll,Name,Course from Students where Roll='"+Roll+"' ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            Student_management.Models.Student aStudent = new Student_management.Models.Student();

            while (dr.Read())
            {
                aStudent.Roll = dr["Roll"].ToString();
                aStudent.Name = dr["Name"].ToString();
                aStudent.Course = dr["Course"].ToString();
                //aCourse.Id = Convert.ToInt32(dr["Id"].ToString());
                //aCourse.Name = dr["CourseName"].ToString();
                //aCourse.Duration = dr["Duration"].ToString();

            }
            con.Close();
            return aStudent;

        }
        public int Exist(Mark aMark)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_manegment;Integrated Security=True");
            con.Open();
            string query = "select * from Course where Id ='" + aMark.Student_Roll + "'";
            SqlDataAdapter sqlda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            return dt.Rows.Count;
        }
        Mark aMark = new Mark();
        public int SavMark(Student_management.Models.Mark aMark)
        {

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_manegment;Integrated Security=True");
            con.Open();
            string query = "insert into Marks_sit values (@Roll,@Course,@mark,@OutOfMark)";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Roll", aMark.Student_Roll);
            cmd.Parameters.AddWithValue("@Course", aMark.Course_Name);
            cmd.Parameters.AddWithValue("@mark", aMark.Marks);
            cmd.Parameters.AddWithValue("@OutOfMark", aMark.OutOfMarks);

            int rows = cmd.ExecuteNonQuery();
            con.Close();
            return rows;

        }
        public int UpdatMark(Mark aMark)
        {

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_manegment;Integrated Security=True");
            con.Open();
            string query = "update Marks_sit set Marks=@mark,Course_Name=@Course,OutOfMarks=@OutOfMark  where Student_Roll=@Roll";
            SqlCommand cmd = new SqlCommand(query, con);


            cmd.Parameters.AddWithValue("@Roll",aMark.Student_Roll);
            cmd.Parameters.AddWithValue("@Course", aMark.Course_Name);
            cmd.Parameters.AddWithValue("@mark",aMark.Marks);
            cmd.Parameters.AddWithValue("@OutOfMark", aMark.OutOfMarks);

            int rows = cmd.ExecuteNonQuery();
            con.Close();
            return rows;

        }
        public int DeletMark(Mark aMark)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_manegment;Integrated Security=True");
            con.Open();
            string query = "delete from Marks_sit where Student_Roll=@Roll";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Roll", aMark.Student_Roll);

            int rows = cmd.ExecuteNonQuery();
            con.Close();
            return rows;
        }



    }
}