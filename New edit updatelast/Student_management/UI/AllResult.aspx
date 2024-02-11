<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AllResult.aspx.cs" Inherits="Student_management.UI.AllResult" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <style>
        .hidth{
         min-height:100vh;
        }
        .topSearch{
            position:relative;
        }
        .StudentDetails{
            min-height:100vh;
            position:absolute;
            top:50px;
            
        }
        .StudentRsult{
            min-height:100vh;
             position:absolute;
             top:50px;
        }
        .TeacherDetails{
            min-height:100vh;
             position:absolute;
             top:50px;
        }
    </style>
    
    <div class="all hidth topSearch" style="background-color:sandybrown">
        <div class="over_box hidth" style="background-image:none;">
            <div class="box mt-5 mb-5 row" style="background-color:rgba(100, 149, 237,.3);max-width:100%">
                <asp:Label CssClass="text-danger text-center d-block"  ID="Label5" runat="server" Text=""></asp:Label>
                <div class="form-group p-2 col-md-4">
                    <%--<label for="inputState" class="form-label">State</label>--%>
                    <select id="SelectOptions" class="form-select" runat="server">
                      <option >Select Option</option>
                     <%-- <option selected>Select Option</option>--%>
                      <option>Student Details</option>
                      <option>Student Resualt</option>
                      <option>Teacher Details</option>
                    </select>
                </div>
                <div class="form-group p-2 col-md-8">
                   <%--<label class="joro">Student Roll</label>--%>
                   <input runat="server" type="text" class="form-control" id="SearchStudentResualtTextBox" placeholder="" >
                </div>
                <div class="col-md-9"></div>
                <div class="form-group p-2 col-md-3">
                    <%--<button class="btn btn-primary form-control">Search</button>--%>
                    <asp:button runat="server" OnClick="st_reSearch_click" id="st_reSearch"  Class="btn btn-primary form-control st_reSearch" Text="Search"/>
                </div>
            </div>
        </div>
    </div>

    <%--==============================================================--%>
    <div class="all hidth StudentRsult" runat="server" id="HidthStudentRsult">
   <div class="over_box hidth">
    <div class="box mt-5 mb-5" style="background-color:rgba(100, 149, 237,.3);max-width:100%">
        <asp:Button ID="ClgeSResulr" OnClick="ClgeSResult_click" class="position-absolute top-0 left-0 text-danger"  runat="server" Text="X" />
            <h2 class="text-center">All Result</h2>
            
        <div class="row">
                 <div class="form-group p-2">
                   <label class="joro">Student Name</label>
                   <input runat="server" type="text" class="form-control" id="rs_st_naTextBox" placeholder="" disabled >
                 </div>
                 
                 <div class="form-group p-2 col-md-6">
                   <label class="joro">Student Roll</label>
                   <input runat="server" type="text" class="form-control" id="rs_st_roTextBox" placeholder="" disabled>
                 </div>
                 <div class="form-group p-2 col-md-6">
                   <label class="joro">Student RegNo</label>
                   <input runat="server" type="text" class="form-control" id="rs_st_reTextBox" placeholder="" disabled>
                 </div>
                <div class="form-group p-2">
                   <label class="joro">Teacher Name</label>
                   <input runat="server" type="text" class="form-control" id="rs_te_naTextBox" placeholder=""  disabled>
                 </div>
                 
                 <div class="form-group p-2 col-md-6">
                   <label class="joro">Department Name</label>
                   <input runat="server" type="text" class="form-control" id="rs_de_naTextBox" placeholder="" disabled>
                 </div>
                 <div class="form-group p-2 col-md-6">
                   <label class="joro">Course Name</label>
                   <input runat="server" type="text" class="form-control" id="rs_co_naTextBox" placeholder="" disabled>
                 </div>
                <div class="form-group p-2 col-md-6">
                   <label class="joro">Total Mark Of Result</label>
                   <input runat="server" type="text" class="form-control" id="ResualtMarkTextBox" placeholder=""  disabled>
                 </div>
                <div class="form-group p-2 col-md-6">
                   <label class="joro">Gread Of Result</label>
                   <input runat="server" type="text" class="form-control" id="resualtGreadTextBox" placeholder=""  disabled>
               </div>
        </div>
                <br />
           </div>
       </div>
     </div>

<div class="all hidth StudentDetails" runat="server" id="HidthStudentDetails">
  <div class="over_box hidth">
    <div class="box mt-5 mb-5" style="background-color:rgba(100, 149, 237,.3);max-width:100%">
       <asp:Button ID="ClgeStudent" OnClick="ClgeStudent_click" class="position-absolute top-0 left-0 text-danger"  runat="server" Text="X" />
            <h2 class="text-center">Student Details</h2>
               
        <div class="row">
            <div class="form-group p-2">
                   <label class="joro">Student Name</label>
                   <input runat="server" type="text" class="form-control" id="sdStudentNameTextBox" placeholder="" disabled >
            </div>
            <div class="form-group p-2 col-md-6">
                   <label class="joro">Student Address</label>
                   <input runat="server" type="text" class="form-control" id="sdStudentAddressTextBox" placeholder="" disabled>
             </div>
             <div class="form-group p-2 col-md-6">
                   <label class="joro">Student Phone</label>
                   <input runat="server" type="text" class="form-control" id="sdStudentPhoneTextBox" placeholder="" disabled>
            </div>
            <div class="form-group p-2 col-md-4">
                   <label class="joro">Roll</label>
                   <input runat="server" type="text" class="form-control" id="sdStudentRollTextBox" placeholder="" disabled>
             </div>
             <div class="form-group p-2 col-md-4">
                   <label class="joro">RegNo</label>
                   <input runat="server" type="text" class="form-control" id="sdStudentRegTextBox" placeholder="" disabled>
            </div>
            <div class="form-group p-2 col-md-4">
                   <label class="joro">Session</label>
                   <input runat="server" type="text" class="form-control" id="sdStudentSessionTextBox" placeholder="" disabled>
            </div>
            <div class="form-group p-2 col-md-4">
                   <label class="joro">Department</label>
                   <input runat="server" type="text" class="form-control" id="sdStudentDepartmentTextBox" placeholder="" disabled>
             </div>
             <div class="form-group p-2 col-md-4">
                   <label class="joro">Course</label>
                   <input runat="server" type="text" class="form-control" id="sdStudentcourseTextBox" placeholder="" disabled>
            </div>
            <div class="form-group p-2 col-md-4">
                   <label class="joro">Age</label>
                   <input runat="server" type="text" class="form-control" id="sdStudentAgeTextBox" placeholder="" disabled>
            </div>
            <div class="form-group p-2 ">
                   <label class="joro">Dipartment Head Teacher Name</label>
                   <input runat="server" type="text" class="form-control" id="sddepartmentHeadTextBox" placeholder="" disabled>
            </div>
            <div class="form-group p-2 ">
                   <label class="joro">Course teacher Name</label>
                   <input runat="server" type="text" class="form-control" id="sdcourseTeacherTextBox" placeholder="" disabled>
            </div>
        </div>
     </div>
  </div>
</div>

<div class="all hidth TeacherDetails" runat="server" id="HidthTeacherDetails">
  <div class="over_box hidth">
    <div class="box mt-5 mb-5" style="background-color:rgba(100, 149, 237,.3);max-width:100%">
        <asp:Button ID="ClgeTeacher" OnClick="ClgeTeacher_click" class="position-absolute top-0 left-0 text-danger"  runat="server" Text="X" />
            <h2 class="text-center">Teacher Details</h2>
               
        <div class="row">
            <div class="form-group p-2">
                   <label class="joro">Teacher Name</label>
                   <input runat="server" type="text" class="form-control" id="teNameTextBox" placeholder="" disabled >
            </div>
            <div class="form-group p-2 col-md-6">
                   <label class="joro">Teacher Address</label>
                   <input runat="server" type="text" class="form-control" id="teAddressTextBox" placeholder="" disabled>
             </div>
             <div class="form-group p-2 col-md-6">
                   <label class="joro">Teacher Phone</label>
                   <input runat="server" type="text" class="form-control" id="tePhoneTextBox" placeholder="" disabled>
            </div>
            <div class="form-group p-2 col-md-4">
                   <label class="joro">Department</label>
                   <input runat="server" type="text" class="form-control" id="teDepartmentTextBox" placeholder="" disabled>
             </div>
             <div class="form-group p-2 col-md-4">
                   <label class="joro">Subject</label>
                   <input runat="server" type="text" class="form-control" id="teSubjectTextBox" placeholder="" disabled>
            </div>
            <div class="form-group p-2 col-md-4">
                   <label class="joro">Age</label>
                   <input runat="server" type="text" class="form-control" id="teAgeTextBox" placeholder="" disabled>
            </div>
            <div class="form-group p-2 col-md-6">
                   <label class="joro">Department Head Name</label>
                   <input runat="server" type="text" class="form-control" id="dpHeadNameTextBox" placeholder="" disabled>
             </div>
             <div class="form-group p-2 col-md-6">
                   <label class="joro">Department Head Phone</label>
                   <input runat="server" type="text" class="form-control" id="dpHeadPhoneTextBox" placeholder="" disabled>
            </div>
         </div>
    </div>
  </div>
</div>



   <%-- <script type="text/javascript">
        document.getElementById("MainContent_Hidth").style.visibility = "hidden";
        var clickBtn = document.getElementById("MainContent_st_reSearch");
        clickBtn.addEventListener("click",function(event)
        {
            var StudentResualt = document.getElementById("MainContent_Hidth");
            StudentResualt.style.visibility = "visible";
            event.preventDefault();
            return true;
            console.log(event)
            
        })

    </script>--%>

  <%--  <script type="text/javascript">
        var clogrPop = document.querySelector(".clogPop");
        var Pop = document.querySelector(".hidth");

        vi
        console.log(clogrPop);
        console.log(Pop);
        //clogrPop.addEventListener("Click", function () {
        //    pop.style.visibility = "hidden";
        //    console.log("Click end");
        //})
    </script>--%>

</asp:Content>
