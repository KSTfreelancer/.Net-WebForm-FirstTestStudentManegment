using Student_management.Gateway;
using Student_management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Student_management.Manager
{
    public class TeacherManager
    {

        TeacherGetway aGateway = new TeacherGetway();

        public Teacher dptSearchId(int Id)
        {
            return aGateway.dptSearchId(Id);
        }

        public string SavTeacher(Teacher aTeacher)
        {
            message amessage = new message();
            if(aGateway.Exist(aTeacher) > 0)
            {
                amessage.denger = aTeacher.Id + " ID Already Exist!";
                return amessage.denger;
            }
            int rowcount = aGateway.SavTeacher(aTeacher);
            if (rowcount > 0)
            {
                amessage.success = "Data hass been saved.";
                return amessage.success;
            }
            else
            {
                amessage.denger = "Data Not Updat";
                return amessage.denger; ;
            }
        }

        public string UpdatTeacher(Teacher aTeacher)
        {
            int rowcount = aGateway.UpdatTeacher(aTeacher);
            message amessage = new message();
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

        public string DeletTeacher(Teacher aTeacher)
        {
            int rowcount = aGateway.DeletTeacher(aTeacher);
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