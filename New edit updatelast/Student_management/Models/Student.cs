using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Student_management.Models
{
  
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Age { get; set; }
        public string Roll { get; set; }
        public string Phone { get; set; }
        public string RegNo { get; set; }
        public string Session { get; set; }
        public string Department { get; set; }
        public string Course { get; set; }
    }

    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string HeadOfDepartment { get; set; }
        public string Phone { get; set; }
    }
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Duration { get; set; }

    }
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Age { get; set; }
        public string Subject { get; set; }
        public string Phone { get; set; }
        public string Department { get; set; }
        public string DateOfJoin { get; set; }
       
    }
    public class message
    {
        public string black { get; set; }
        public string success { get; set; }
        public string info { get; set; }
        public string denger { get; set; }
    }
    public class Mark 
    {
        public string Student_Roll { get; set; }
        public string Course_Name { get; set; }
        public string Marks { get; set; }
        public string OutOfMarks { get; set; }
    }
    public class StudentResult
    {
        public string StudentName { get; set; }
        public string StudentRoll { get; set; }
        public string StudentReg { get; set; }
        public string TeacherName { get; set; }
        public string Department { get; set; }
        public string Course { get; set; }
        public string Result { get; set; }

    }
    public class StudentDetils
    {
        public string StudentName { get; set; }
        public string StudentAddress { get; set; }
        public string StudentPhone { get; set; }
        public string StudentRoll { get; set; }
        public string StudentReg { get; set; }
        public string StudentSession { get; set; }
        public string StudentDepartment { get; set; }
        public string StudentCourse { get; set; }
        public string StudentAge { get; set; }
        public string DipartmentHead { get; set; }
        public string CourseTeacher { get; set; }
    }
    public class TeacherDetils
    {
        public string TeacherName { get; set; }
        public string TeacherAddress { get; set; }
        public string TeacherPhone { get; set; }
        public string TeacherDepartment { get; set; }
        public string TeacherSubject { get; set; }
        public string TeacherAge { get; set; }
        public string DepartmentHead { get; set; }
        public string DepartmentHeadPhone { get; set; }
    }

}