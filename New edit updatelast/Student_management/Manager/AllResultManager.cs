using Student_management.Gateway;
using Student_management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Student_management.Manager
{
    public class AllResultManager
    {
        AllResultGatway aGateway = new AllResultGatway();

        public StudentResult SearchReesult(string StudentRoll)
        {
            return aGateway.SearchReesult(StudentRoll);
        }
        public StudentDetils SearchStudent(string StudentRoll)
        {
            return aGateway.SearchStudent(StudentRoll);
        }
        public TeacherDetils SearchTeacher(string teName)
        {
            return aGateway.SearchTeacher(teName);
           
        }

    }
}
//AllResultGatway aGateway = new AllResultGatway();
//public StudentResult SearchReesult(string StudentRoll)
//{
//    return aGateway.SearchReesult(StudentRoll);
//    {