using Student_management.Gateway;
using Student_management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Student_management.Manager
{
    public class MarkAddManager
    {
        MarkAddGateway aGateway = new MarkAddGateway();

        public Student_management.Models.Student dptSearchRoll(string Roll)
        {
            return aGateway.dptSearchId(Roll);
        }
        public string SavCourse(Mark aMark)
        {

            message amessage = new message();
            if (aGateway.Exist(aMark) > 0)
            {
                amessage.denger = aMark.Student_Roll + " Student Roll Already Exist!";
                return amessage.denger;
            }

            int rowcount = aGateway.SavMark(aMark);
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
        public string UpdatMark(Mark aMark)
        {

            message amessage = new message();
           
            int rowcount = aGateway.UpdatMark(aMark);
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
        public string DeletCourse(Mark aMark)
        {
            int rowcount = aGateway.DeletMark(aMark);
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