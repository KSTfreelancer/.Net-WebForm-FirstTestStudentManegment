using Student_management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI;
using Student_management.UI;

namespace Student_management.Gateway
{
    
    public class StudentGateway
    {

        Student aStudent = new Student();
        public Student SearchId(int Id)
        {

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_manegment;Integrated Security=True");
            con.Open();
            string query = "select * from Students where Id='"+Id+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                aStudent.Id= Convert.ToInt32(dr["Id"].ToString());
                aStudent.Name = dr["Name"].ToString();
                aStudent.Address = dr["Address"].ToString();
                aStudent.Age = dr["Age"].ToString();
                aStudent.Roll = dr["Roll"].ToString();
                aStudent.Phone = dr["Phone"].ToString();
                aStudent.RegNo = dr["RegNo"].ToString();
                aStudent.Session = dr["Session"].ToString();
                aStudent.Department = dr["Department"].ToString();
                aStudent.Course = dr["Course"].ToString();
            }
            con.Close();
            return aStudent;

        }
        public int Exist(Student astudent)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_manegment;Integrated Security=True");
            con.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("select * from Students where  Roll = '" + astudent.Roll + "' or Id ='" + astudent.Id + "' or RegNo = '" + astudent.RegNo + "'",con);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            return dt.Rows.Count;
            
        }
        public int SavStudent(Student astudent)
        {
           
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_manegment;Integrated Security=True");
                con.Open();
                string query = "insert into Students(Id,Name,Address,Age,Roll,Phone,RegNo,Session,Department,Course)values(@Id,@Name,@Address,@Age,@Roll,@Phone,@RegNo,@Session,@Department,@Course)";
                SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Id", astudent.Id);
            cmd.Parameters.AddWithValue("@Name", astudent.Name);
            cmd.Parameters.AddWithValue("@Address", astudent.Address);
            cmd.Parameters.AddWithValue("@Age", astudent.Age);
            cmd.Parameters.AddWithValue("@Roll", astudent.Roll);
            cmd.Parameters.AddWithValue("@Phone", astudent.Phone);
            cmd.Parameters.AddWithValue("@RegNo", astudent.RegNo);
            cmd.Parameters.AddWithValue("@Session", astudent.Session);
            cmd.Parameters.AddWithValue("@Department", astudent.Department);
            cmd.Parameters.AddWithValue("@Course", astudent.Course);

            int rows = cmd.ExecuteNonQuery();
                con.Close();
                return rows;

        }

        public int UpdatStudent(Student astudent)
        {

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_manegment;Integrated Security=True");
            con.Open();
            string query = "update Students set Name=@Name,Address=@Address,Age=@Age,Roll=@Roll,Phone=@Phone,RegNo=@RegNo,Session=@Session,Department=@Department,Course=@Course where Id=@Id";
            SqlCommand cmd = new SqlCommand(query, con);


            cmd.Parameters.AddWithValue("@Id", astudent.Id);
            cmd.Parameters.AddWithValue("@Name", astudent.Name);
            cmd.Parameters.AddWithValue("@Address", astudent.Address);
            cmd.Parameters.AddWithValue("@Age", astudent.Age);
            cmd.Parameters.AddWithValue("@Roll", astudent.Roll);
            cmd.Parameters.AddWithValue("@Phone", astudent.Phone);
            cmd.Parameters.AddWithValue("@RegNo", astudent.RegNo);
            cmd.Parameters.AddWithValue("@Session", astudent.Session);
            cmd.Parameters.AddWithValue("@Department", astudent.Department);
            cmd.Parameters.AddWithValue("@Course", astudent.Course);

            int rows = cmd.ExecuteNonQuery();
            con.Close();
            return rows;

        }

        public int DeletStudent(Student astudent)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_manegment;Integrated Security=True");
            con.Open();
            string query = "delete from Students where ID=@Id";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Id", astudent.Id);

            int rows = cmd.ExecuteNonQuery();
            con.Close();
            return rows;
        }


    }
}