using Student_management.Gateway;
using Student_management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Student_management.Manager
{
    public class DepartmentManager
    {
        DepartmentGatway aGateway = new DepartmentGatway();

        public Department dptSearchId(int Id)
        {
            return aGateway.dptSearchId(Id);
        }

        public string SavDepartment(Department aDepartment)
        {
            

            message amessage = new message();

            if (aGateway.Exist(aDepartment.Id)) 
            {
                amessage.denger = aDepartment.Id+" ID Already Exist!";
                return amessage.denger;
            }
                int rowcount = aGateway.SavDepartment(aDepartment);
            
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

        public string UpdateDepartmenr(Department aDepartment)
        {
            int rowcount = aGateway.UpdatDepartment(aDepartment);
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

        public string DeletDepartment(Department aDepartment)
        {
            int rowcount = aGateway.DeletDepartment(aDepartment);
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