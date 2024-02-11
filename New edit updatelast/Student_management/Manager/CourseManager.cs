using Student_management.Gateway;
using Student_management.Models;
using Student_management.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Student_management.Manager
{
    public class CourseManager
    {
        CourseGateway aGateway = new CourseGateway();

        public Student_management.Models.Course dptSearchId(int Id)
        {
            return aGateway.dptSearchId(Id);
        }

        public string SavCourse(Student_management.Models.Course aCourse)
        {
            
            message amessage = new message();
            if (aGateway.Exist(aCourse) > 0)
            {
                amessage.denger = aCourse.Id + " ID Already Exist!";
                return amessage.denger;
            }

            int rowcount = aGateway.SavCourse(aCourse);
            if (rowcount > 0)
            {
                amessage.success = "Data hass been saved.";
                return amessage.success;
            }
            else
            {
                amessage.denger = "Data Not Updat";
                return amessage.denger;
            }
        }

        public string UpdatCourse(Student_management.Models.Course aCourse)
        {

            message amessage = new message();
            //if (aGateway.Exist(aCourse.Id))
            //{
            //    amessage.denger =aCourse.Id+ " ID Already Exist!";
            //    return amessage.denger;
            //}
           
            int rowcount = aGateway.UpdatCourse(aCourse);
            if (rowcount > 0)
            {
                amessage.success = "Data hass been Update.";
                return amessage.success;
            }
            else
            {
                amessage.denger = "Data Not Updat!";
                return amessage.denger; ;
            }
        }

        public string DeletCourse(Student_management.Models.Course aCourse)
        {
            int rowcount = aGateway.DeletCourse(aCourse);
            message amessage = new message();
            if (rowcount > 0)
            {
                amessage.success = "Data hass been Deleted.";
                return amessage.success;
            }
            else
            {
                amessage.denger = "Data Not delet!";
                return amessage.denger; ;
            }
        }
    }
}