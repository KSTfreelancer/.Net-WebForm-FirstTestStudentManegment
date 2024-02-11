 <%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Students.aspx.cs" Inherits="Student_management.UI.Students" %>
<%@ Register assembly="CrystalDecisions.Web, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="all">
    <div class="over_box">
        <div class="box" style="background-color:rgba(100, 149, 237,.3)">
            <h2 class="text-center">Student</h2>
           
               <asp:label runat="server" id="SearchLabel" class="text-end d-block labl"></asp:label>
                <asp:label runat="server" id="saveLabel"  class="text-end d-block text-success labl"></asp:label>
                <asp:label  runat="server" id="updateLabel" class="text-end d-block text-info labl"></asp:label>
                <asp:label  runat="server" id="deletLabel" class="text-end d-block text-danger labl"></asp:label>

                 <div class="form-group p-2">
                   <label class="joro">ID</label>
                   <input runat="server" type="text" class="form-control" id="studentidTextBox" placeholder="Enter Student ID" required>
                     <%--<asp:TextBox ID="studentidTextBox" runat="server" class="form-control" placeholder="Enter Student ID" ></asp:TextBox>--%>
                 </div>
                 <div class="row ">
                    <div class="col-md-3"></div>
                    <div class="col-md-3"></div>
                    <div class="col-md-3"></div>
                    <div class="col-md-3 "> <asp:button runat="server" id="Button1" OnClick="studentSearch_click" CssClass="btn btn-outline-light  my-1 " Text="Search"/></div>
                 </div>
                 <div class="form-group p-2">
                   <label class="joro">Name</label>
                   <input runat="server" type="text" class="form-control" id="studentnameTextBox" placeholder="Enter Student Name">
                     <%--<asp:TextBox ID="TextBox1" runat="server" class="form-control" placeholder="Enter Student ID" ></asp:TextBox>--%>
                 </div>
                 <div class="form-group p-2">
                   <label class="joro">Address</label>
                   <input type="text" class="form-control" id="studentaddressTextBox" placeholder="Enter Student Address" runat="server">
                     <%--<asp:TextBox ID="TextBox9" runat="server" class="form-control" placeholder="Enter Student ID" ></asp:TextBox>--%>
                 </div>
                 <div class="form-group p-2">
                   <label class="joro">Age</label>
                   <input type="number" class="form-control" id="studentageTextBox" placeholder="Enter Student Age" runat="server">
                     <%--<asp:TextBox ID="TextBox8" runat="server" class="form-control" placeholder="Enter Student ID" ></asp:TextBox>--%>
                 </div>
                 <div class="form-group p-2">
                   <label class="joro">Roll</label>
                   <input type="number" class="form-control" id="studentrollTextBox" placeholder="Enter Student Roll" runat="server">
                     <%--<asp:TextBox ID="TextBox7" runat="server" class="form-control" placeholder="Enter Student ID" ></asp:TextBox>--%>
                 </div>
                 <div class="form-group p-2">
                   <label class="joro">Phone</label>
                   <input type="number" class="form-control" id="studentphoneTextBox" placeholder="Enter Student Phone" runat="server">
                     <%--<asp:TextBox ID="TextBox6" runat="server" class="form-control" placeholder="Enter Student ID" ></asp:TextBox>--%>
                 </div>
                 <div class="form-group p-2">
                   <label class="joro">Reg.No</label>
                   <input type="number" class="form-control" id="studentregTextBox" placeholder="Enter Student Reg.No" runat="server">
                     <%--<asp:TextBox ID="TextBox5" runat="server" class="form-control" placeholder="Enter Student ID" ></asp:TextBox>--%>
                 </div>
                 <div class="form-group p-2">
                   <label class="joro">Session</label>
                   <input type="text" class="form-control" id="studentsessionTextBox" placeholder="Enter Student Session" runat="server">
                     <%--<asp:TextBox ID="TextBox4" runat="server" class="form-control" placeholder="Enter Student ID" ></asp:TextBox>--%>
                 </div>
                 <div class="form-group p-2">
                   <label class="joro">Department</label>
                   <input type="text" class="form-control" id="studentdepartmentTextBox" placeholder="Enter Student Department" runat="server">
                     <%--<asp:TextBox ID="TextBox3" runat="server" class="form-control" placeholder="Enter Student ID" ></asp:TextBox>--%>
                 </div>
                 <div class="form-group p-2">
                   <label class="joro">Course</label>
                   <input type="text" class="form-control" id="studentcourseTextBox" placeholder="Enter Student Course" runat="server">
                     <%--<asp:TextBox ID="TextBox2" runat="server" class="form-control" placeholder="Enter Student ID" ></asp:TextBox>--%>
                 </div>
                <br />

                

                <div class="row">
                    
                    <div class="col-md-4">
                        <asp:button runat="server" id="studentSave" OnClick="studentSave_click" CssClass="btn btn-outline-success form-control my-1 " Text="Save"/>
                    </div>
                    <div class="col-md-4">
                        <asp:button runat="server" id="studentUpdate" OnClick="studentUpdate_click" CssClass="btn btn-outline-info form-control my-1 " Text="Update"/>
                    </div>
                    <div class="col-md-4">
                        <asp:button runat="server" id="studentDelete" OnClick="studentDelete_click" CssClass="btn btn-outline-danger form-control  my-1 " Text="Delete"/>
                    </div>
                </div>

             
           </div>
     </div>
    <%--=====================================================================================================--%>
        
  

    <div class="gritstyle container table-responsive mt-4 rounded overflow-scroll" style="max-height:570px" >

        <div class="row mt-3">
            <div class="col-md-3"></div>
            <div class="col-md-3">
                <asp:button runat="server" id="downloadpdf" OnClick="downloadpdf_click" CssClass="btn btn-outline-primary form-control  my-1 " Text="Download PDF" formnovalidate="formnovalidate"/>
            </div>
            <div class="col-md-3">
                <asp:button runat="server" id="EditFrid" OnClick="EditFrid_click" CssClass="btn btn-outline-info form-control  my-1 " Text="Edit GridView" formnovalidate="formnovalidate"/>
            </div>
            <div class="col-md-3"></div>
        </div>

        <%--##############################################--%>
       <%-- <<%--asp:TextBox ID="SearchOption" runat="server"></asp:TextBox>--%>
        <div class="row container ">
        <div class="col-md-3"></div>
             
        <div class="col-md-4">
            <asp:TextBox ID="searchOptionTextBox" runat="server" class="form-control border border-primary py-1 my-2" placeholder="Enter Course ID"  formnovalidate="formnovalidate" ></asp:TextBox>
    
        </div>
        <div class="col-md-2 text-center">

        <asp:button runat="server" id="serchOptionBtn"   Class="btn btn-outline-primary  my-2 " Width="200px"  Text="Search" OnClick="serchOptionBtn_Click" formnovalidate="formnovalidate"  />
       
        </div>
         
        <div class="col-md-3"></div>
        </div>

        <%--##############################################--%>
        <style>
            .sticky-top th {

    position: sticky;
    top: 0px;
}
        </style>
          <%--<asp:ScriptManager ID="script1" runat="server"></asp:ScriptManager>
   <asp:UpdatePanel ID="panel1" runat="server"><ContentTemplate>--%>
        <asp:GridView ID="GridView1" CssClass=" p table table-bordered table-hover text-white sticky-top mt-1" runat="server" >
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="true" /> 
                <asp:BoundField DataField="Name" HeaderText="Name"/> 
                <asp:BoundField DataField="Address" HeaderText="Address"/> 
                <asp:BoundField DataField="Age" HeaderText="Age"/> 
                <asp:BoundField DataField="Roll" HeaderText="Roll"/> 
                <asp:BoundField DataField="Phone" HeaderText="Phone"/> 
                <asp:BoundField DataField="RegNo" HeaderText="RegNo"/> 
                <asp:BoundField DataField="Session" HeaderText="Session"/> 
                <asp:BoundField DataField="Department" HeaderText="Department"/> 
                <asp:BoundField DataField="Course" HeaderText="Course"/> 
            </Columns>
            <HeaderStyle HorizontalAlign="Center" CssClass="table table-primary text-dark   " /><%--sticky-top--%>
            <%-- </ContentTemplate></asp:UpdatePanel>--%>
        </asp:GridView>
    </div>

       

        <div>

            <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="true" />

        </div>
   
 </div>
</asp:Content>
