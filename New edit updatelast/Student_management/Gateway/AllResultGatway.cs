using Student_management.Models;
using Student_management.UI;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Xml.Linq;

namespace Student_management.Gateway
{
    public class AllResultGatway
    {
        public StudentResult SearchReesult(string StudentRoll)
        {

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_manegment;Integrated Security=True");
            con.Open();
            string query = "select st.Name,st.Roll,st.RegNo,st.Department,st.Course,te.Name,ms.Marks from Students as st inner join Teacher as te on te.Subject = " +
                "st.Course inner join Course as co on st.Course = co.CourseName inner join Marks_sit as ms on st.Roll = ms.Student_Roll where Roll = @Roll; ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Roll", StudentRoll);
            SqlDataReader dr = cmd.ExecuteReader();

            StudentResult aResult = new StudentResult();

            while (dr.Read())
            {
                aResult.StudentName = dr["Name"].ToString();
                aResult.StudentRoll = dr["Roll"].ToString();
                aResult.StudentReg = dr["RegNo"].ToString();
                aResult.TeacherName = dr.GetString(5);
                aResult.Department = dr["Department"].ToString();
                aResult.Course = dr["Course"].ToString();
                aResult.Result = dr["Marks"].ToString();
                
            }
            con.Close();
            return aResult;

        }
        public StudentDetils SearchStudent(string StudentRoll)
        {

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_manegment;Integrated Security=True");
            con.Open();
            string query = "select st.Name,st.Address,st.Phone,st.Roll,st.RegNo,st.Department,st.Course,st.Session,st.Age,dp.HeadOfDepartment,te.Name " +
                "from Students as st inner join Teacher as te on te.Subject = st.Course inner join Course as co on st.Course = co.CourseName " +
                "inner join Department as dp on st.Department = dp.Name  where Roll = @Roll; ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Roll", StudentRoll);
            SqlDataReader dr = cmd.ExecuteReader();

            StudentDetils aSTdetils = new StudentDetils();

            while (dr.Read())
            {
                aSTdetils.StudentName = dr["Name"].ToString();
                aSTdetils.StudentAddress= dr["Address"].ToString();
                aSTdetils.StudentPhone= dr["Phone"].ToString();
                aSTdetils.StudentRoll= dr["Roll"].ToString();
                aSTdetils.StudentReg= dr["RegNo"].ToString();
                aSTdetils.StudentSession= dr["Session"].ToString();
                aSTdetils.StudentDepartment= dr["Department"].ToString();
                aSTdetils.StudentCourse= dr["Course"].ToString();
                aSTdetils.StudentAge= dr["Age"].ToString();
                aSTdetils.DipartmentHead= dr["HeadOfDepartment"].ToString();
                aSTdetils.CourseTeacher= dr.GetString(10);
                

            }
            con.Close();
            return aSTdetils;

        }
        public TeacherDetils SearchTeacher(string teName)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Student_manegment;Integrated Security=True");
            con.Open();
            string query = "select te.Name,te.Address,te.Phone,te.Department,te.Subject,te.Age,dp.HeadOfDepartment,dp.Phone from Teacher as te " +
                "inner join Department as dp on te.Department = dp.Name where te.Name like '%'+@TeacherName+'%'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@TeacherName", teName);
            SqlDataReader dr = cmd.ExecuteReader();

            TeacherDetils aTeacherDt = new TeacherDetils();

            while (dr.Read())
            {
                aTeacherDt.TeacherName = dr["Name"].ToString();
                aTeacherDt.TeacherAddress = dr["Address"].ToString();
                aTeacherDt.TeacherPhone = dr["Phone"].ToString();
                aTeacherDt.TeacherDepartment = dr["Department"].ToString();
                aTeacherDt.TeacherSubject = dr["Subject"].ToString();
                aTeacherDt.TeacherAge = dr["Age"].ToString();
                aTeacherDt.DepartmentHead = dr["HeadOfDepartment"].ToString();
                aTeacherDt.DepartmentHeadPhone = dr.GetString(7);


            }
            con.Close();
            return aTeacherDt;

        }



    }
}