using Student_management.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Student_management.Gateway
{
    public class TeacherGetway
    {
        public Student_management.Models.Teacher dptSearchId(int Id)
        {

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_manegment;Integrated Security=True");
            con.Open();
            string query = "select * from Teacher where Id='" + Id + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            Student_management.Models.Teacher aTeacher = new Student_management.Models.Teacher();

            while (dr.Read())
            {
                aTeacher.Id = Convert.ToInt32(dr["Id"].ToString());
                aTeacher.Name = dr["Name"].ToString();
                aTeacher.Address = dr["Address"].ToString();
                aTeacher.Age = dr["Age"].ToString();
                aTeacher.Subject = dr["Subject"].ToString();
                aTeacher.Phone = dr["Phone"].ToString();
                aTeacher.Department = dr["Department"].ToString();
                aTeacher.DateOfJoin = dr["DateOfJoin"].ToString();

            }
            con.Close();
            return aTeacher;

        }
        Student_management.Models.Teacher aTeacher = new Student_management.Models.Teacher();
        public int Exist(Teacher aTeacher)
        {

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_manegment;Integrated Security=True");
            con.Open();
            string query = "select * from Teacher where Id = '"+ aTeacher.Id + "'";
            SqlDataAdapter sqlda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            return dt.Rows.Count;
        }

        public int SavTeacher(Student_management.Models.Teacher aTeacher)
        {

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_manegment;Integrated Security=True");
            con.Open();
            string query = "insert into Teacher(Id,Name,Subject,Department,Address,Age,DateOfJoin,Phone)values(@Id,@Name,@Subject,@Department,@Address,@Age,@DateOfJoin,@Phone)";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Id", aTeacher.Id);
            cmd.Parameters.AddWithValue("@Name", aTeacher.Name);
            cmd.Parameters.AddWithValue("@Subject", aTeacher.Subject);
            cmd.Parameters.AddWithValue("@Department", aTeacher.Department);
            cmd.Parameters.AddWithValue("@Address", aTeacher.Address);
            cmd.Parameters.AddWithValue("@Age", aTeacher.Age);
            cmd.Parameters.AddWithValue("@DateOfJoin", aTeacher.DateOfJoin);
            cmd.Parameters.AddWithValue("@Phone", aTeacher.Phone);

            int rows = cmd.ExecuteNonQuery();
            con.Close();
            return rows;

        }

        public int UpdatTeacher(Student_management.Models.Teacher aTeacher)
        {

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_manegment;Integrated Security=True");
            con.Open();
            string query = "update Teacher set Name=@Name,Subject=@Subject,Department=@Department,Address=@Address,Age=@Age,DateOfJoin=@DateOfJoin,Phone=@Phone where Id=@Id";
            SqlCommand cmd = new SqlCommand(query, con);


            cmd.Parameters.AddWithValue("@Id", aTeacher.Id);
            cmd.Parameters.AddWithValue("@Name", aTeacher.Name);
            cmd.Parameters.AddWithValue("@Subject", aTeacher.Subject);
            cmd.Parameters.AddWithValue("@Department", aTeacher.Department);
            cmd.Parameters.AddWithValue("@Address", aTeacher.Address);
            cmd.Parameters.AddWithValue("@Age", aTeacher.Age);
            cmd.Parameters.AddWithValue("@DateOfJoin", aTeacher.DateOfJoin);
            cmd.Parameters.AddWithValue("@Phone", aTeacher.Phone);

            int rows = cmd.ExecuteNonQuery();
            con.Close();
            return rows;

        }

        public int DeletTeacher(Student_management.Models.Teacher aTeacher)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_manegment;Integrated Security=True");
            con.Open();
            string query = "delete from Teacher where ID=@Id";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Id", aTeacher.Id);

            int rows = cmd.ExecuteNonQuery();
            con.Close();
            return rows;
        }

    }
}