using Student_management.Manager;
using Student_management.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Student_management.UI
{
    public partial class AllResult : System.Web.UI.Page
    {
        public void EmptyStudentDetils()
        {
            sdStudentNameTextBox.Value = "";
            sdStudentAddressTextBox.Value = "";
            sdStudentPhoneTextBox.Value = "";
            sdStudentRollTextBox.Value = "";
            sdStudentRegTextBox.Value = "";
            sdStudentSessionTextBox.Value = "";
            sdStudentDepartmentTextBox.Value = "";
            sdStudentcourseTextBox.Value = "";
            sdStudentAgeTextBox.Value = "";
            sddepartmentHeadTextBox.Value = "";
            sdcourseTeacherTextBox.Value = "";
        }
        public void EmptyStudentResult()
        {
            rs_st_naTextBox.Value = "";
            rs_st_roTextBox.Value = "";
            rs_st_reTextBox.Value = "";
            rs_te_naTextBox.Value = "";
            rs_de_naTextBox.Value = "";
            rs_co_naTextBox.Value = "";
            ResualtMarkTextBox.Value = "";
        }
        public void EmptyTeacherDetils()
        {
            teNameTextBox.Value = "";
            teAddressTextBox.Value = "";
            tePhoneTextBox.Value = "";
            teDepartmentTextBox.Value = "";
            teSubjectTextBox.Value = "";
            teAgeTextBox.Value = "";
            dpHeadNameTextBox.Value = "";
            dpHeadPhoneTextBox.Value = "";
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HidthStudentRsult.Visible = false;
                HidthStudentDetails.Visible = false;
                HidthTeacherDetails.Visible = false;

            }
        }
        protected void ClgeTeacher_click(object sender, EventArgs e)
        {
            HidthTeacherDetails.Visible = false;
        }
        protected void ClgeStudent_click(object sender, EventArgs e)
        {
            HidthStudentDetails.Visible = false;
        }
        protected void ClgeSResult_click(object sender, EventArgs e)
        {
            HidthStudentRsult.Visible = false;
        }

        AllResultManager aManager = new AllResultManager();
        protected void st_reSearch_click(object sender, EventArgs e)
        {
            Label5.Text = "";
            if (SelectOptions.Value == "Student Details")
            {
                EmptyStudentResult();
                EmptyStudentDetils();
                EmptyTeacherDetils();
                HidthStudentRsult.Visible = false;
                HidthTeacherDetails.Visible = false;
                HidthStudentDetails.Visible = true;
                string StudentRoll = SearchStudentResualtTextBox.Value;
                StudentDetils aStudent = aManager.SearchStudent(StudentRoll);

                
                sdStudentNameTextBox.Value = aStudent.StudentName;
                sdStudentAddressTextBox.Value = aStudent.StudentAddress;
                sdStudentPhoneTextBox.Value = aStudent.StudentPhone;
                sdStudentRollTextBox.Value = aStudent.StudentRoll;
                sdStudentRegTextBox.Value = aStudent.StudentReg;
                sdStudentSessionTextBox.Value = aStudent.StudentSession;
                sdStudentDepartmentTextBox.Value = aStudent.StudentDepartment;
                sdStudentcourseTextBox.Value = aStudent.StudentCourse;
                sdStudentAgeTextBox.Value = aStudent.StudentAge;
                sddepartmentHeadTextBox.Value = aStudent.DipartmentHead;
                sdcourseTeacherTextBox.Value = aStudent.CourseTeacher;


            }

            else if (SelectOptions.Value == "Student Resualt")
            {
                EmptyStudentResult();
                EmptyStudentDetils();
                EmptyTeacherDetils();
                HidthStudentDetails.Visible = false;
                HidthTeacherDetails.Visible = false;
                HidthStudentRsult.Visible = true;
                string StudentRoll = SearchStudentResualtTextBox.Value;
                StudentResult aResult = aManager.SearchReesult(StudentRoll);

                rs_st_naTextBox.Value = aResult.StudentName;
                rs_st_roTextBox.Value = aResult.StudentRoll;
                rs_st_reTextBox.Value = aResult.StudentReg;
                rs_te_naTextBox.Value = aResult.TeacherName;
                rs_de_naTextBox.Value = aResult.Department;
                rs_co_naTextBox.Value = aResult.Course;
                ResualtMarkTextBox.Value = aResult.Result;

                float gred = float.Parse(ResualtMarkTextBox.Value);
               
                if (gred <= 32 && gred >= 0)
                {
                    resualtGreadTextBox.Value = "Grade is F";
                }
                else if (gred >= 33 && gred <= 39)
                {
                    resualtGreadTextBox.Value = "Grade is D";
                }
                else if (gred >= 40 && gred <= 49)
                {
                    resualtGreadTextBox.Value = "Grade is C";
                }
                else if (gred >= 50 && gred <= 59)
                {
                    resualtGreadTextBox.Value ="Grade is B";
                }
                else if (gred >= 60 && gred <= 69)
                {
                    resualtGreadTextBox.Value ="Grade is A-";
                }
                else if (gred >= 70 && gred <= 79)
                {
                    resualtGreadTextBox.Value ="Grade is A";
                }
                else if (gred >= 80 && gred <= 100)
                {
                    resualtGreadTextBox.Value ="Grade is A+";
                }
                else
                {
                    resualtGreadTextBox.Value = "Panding.......";

                }



            }
            else if (SelectOptions.Value == "Teacher Details")
            {
                EmptyStudentResult();
                EmptyStudentDetils();
                EmptyTeacherDetils();
                HidthStudentRsult.Visible = false;
                HidthStudentDetails.Visible = false;
                HidthTeacherDetails.Visible = true;
                string teName = SearchStudentResualtTextBox.Value;
                TeacherDetils teDetils = aManager.SearchTeacher(teName);

                if (teDetils.TeacherAddress != null)
                { 
                teNameTextBox.Value = teDetils.TeacherName;
                teAddressTextBox.Value = teDetils.TeacherAddress;
                tePhoneTextBox.Value = teDetils.TeacherPhone;
                teDepartmentTextBox.Value = teDetils.TeacherDepartment;
                teSubjectTextBox.Value = teDetils.TeacherSubject;
                teAgeTextBox.Value = teDetils.TeacherAge;
                dpHeadNameTextBox.Value = teDetils.DepartmentHead;
                dpHeadPhoneTextBox.Value = teDetils.DepartmentHeadPhone;
                }
                else 
                {
                    Label5.Text = "Increct Teacher Name";
                }

            }
            else
            {
                Label5.Text = "Select Option";
            }
        }
    }
}