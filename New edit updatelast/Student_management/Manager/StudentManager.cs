using Student_management.Gateway;
using Student_management.Models;
using Student_management.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace Student_management.Manager
{
    public class StudentManager
    {
        StudentGateway aGateway=new StudentGateway();

        public Student SearchId(int Id)
        {
            return aGateway.SearchId(Id);
        }

        public string SaveStudent(Student aStudent)
        {
            message amessage = new message();
            int row = aGateway.Exist(aStudent);
           if (row > 0)
            {
                amessage.success = " ID or Roll Or RegNo Already Exist!";
                return amessage.success;
            }

            int rowcount = aGateway.SavStudent(aStudent);
            if (rowcount > 0)
            { 
                amessage.denger = "Data hass been saved.";
                return amessage.denger;
            }
            else
            {
                amessage.denger = "Data Not Updat";
                return amessage.denger;
            }
            
        }

        public string UpdateStudent(Student aStudent)
        {
            int rowcount = aGateway.UpdatStudent(aStudent);
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

        public string DeletStudent(Student aStudent)
        {
            int rowcount = aGateway.DeletStudent(aStudent);
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