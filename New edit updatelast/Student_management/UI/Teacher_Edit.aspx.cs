using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Student_management.UI
{
    public partial class Teacher_Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.EditRowStyle.BackColor = System.Drawing.Color.Orange;
        }
    }
}