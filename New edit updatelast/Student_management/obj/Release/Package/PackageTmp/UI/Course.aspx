<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Course.aspx.cs" Inherits="Student_management.UI.Course" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="all">
   <div class="over_box">
    <div class="box mt-5 mb-5" style="background-color:rgba(100, 149, 237,.3)">
            <h2 class="text-center">Course</h2>
            
                 <asp:label runat="server" id="SearchLabel" class="text-end d-block labl"></asp:label>
                <asp:label runat="server" id="saveLabel"  class="text-end d-block text-success labl"></asp:label>
                <asp:label  runat="server" id="updateLabel" class="text-end d-block text-info labl"></asp:label>
                <asp:label  runat="server" id="deletLabel" class="text-end d-block text-danger labl"></asp:label>


                 <div class="form-group p-2">
                   <label class="joro">ID</label>
                   <input runat="server" type="text" class="form-control" id="courseidTextBox" placeholder="Enter Course ID" required>
                 </div>
                 <div class="row ">
                    <div class="col-md-3"></div>
                    <div class="col-md-3"></div>
                    <div class="col-md-3"></div>
                    <div class="col-md-3 "> <asp:button runat="server" id="studentSearch" OnClick="courseSearch_click" Class="btn btn-outline-light my-1 " Text="Search"/></div>
                 </div>
                 <div class="form-group p-2">
                   <label class="joro">Name</label>
                   <input runat="server" type="text" class="form-control" id="coursenameTextBox" placeholder="Enter Course Name">
                 </div>
                 <div class="form-group p-2">
                   <label class="joro">Duration</label>
                   <input runat="server" type="text" class="form-control" id="coursedurationTextBox" placeholder="Enter Course Address">
                 </div>
                <br />
                
                

                 <div class="row">
                    <div class="col-md-4">
                        <asp:button runat="server" id="studentSave" OnClick="courseSave_click" Class="btn btn-outline-success form-control my-1 " Text="Save"/>
                    </div>
                    <div class="col-md-4">
                        <asp:button runat="server" id="studentUpdate" OnClick="courseUpdate_click" Class="btn btn-outline-info form-control my-1 " Text="Update"/>
                    </div>
                    <div class="col-md-4">
                        <asp:button runat="server" id="studentDelete" OnClick="courseDelete_click" Class="btn btn-outline-danger form-control  my-1 " Text="Delete"/>
                    </div>
                </div>

           </div>
       </div>
       <%--=====================================================================================================--%>
   
    <div class="gritstyle container table-responsive mt-4 pt-3 rounded " >
        <div class="row">
            <div class="col-md-3"></div>
            <div class="col-md-3">
                <asp:button runat="server" id="downloadpdf" OnClick="downloadpdf_click" CssClass="btn btn-outline-primary form-control  my-1 " Text="Download PDF" formnovalidate="formnovalidate"/>
            </div>
            <div class="col-md-3">
                <asp:button runat="server" id="EditGrid" OnClick="EditGrid_click" CssClass="btn btn-outline-info form-control  my-1 " Text="Edit GridView" formnovalidate="formnovalidate"/>
            </div>
            <div class="col-md-3"></div>
        </div>

        <asp:GridView ID="GridView1" CssClass=" p table  table-bordered table-hover text-white " runat="server" >
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="true" /> 
                <asp:BoundField DataField="CourseName" HeaderText="Course Name"/> 
                <asp:BoundField DataField="Duration" HeaderText="Duration"/> 
            </Columns>
            <HeaderStyle HorizontalAlign="Center" CssClass="table table-primary text-dark" />
        </asp:GridView>
    </div>
        <div>
            <CR:CrystalReportViewer ID="CrystalReportViewerCourse" runat="server" AutoDataBind="true" />
        </div>
     </div>

</asp:Content>
