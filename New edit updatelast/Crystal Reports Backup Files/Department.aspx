<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Department.aspx.cs" Inherits="Student_management.UI.Department" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="all">
    <div class="over_box">
        <div class="box mt-5 mb-5" style="background-color:rgba(100, 149, 237,.3)">
            <h2 class="text-center">Department</h2>
            
                <asp:label runat="server" id="SearchLabel" class="text-end d-block labl"></asp:label>
                <asp:label runat="server" id="saveLabel"  class="text-end d-block text-success labl"></asp:label>
                <asp:label  runat="server" id="updateLabel" class="text-end d-block text-info labl"></asp:label>
                <asp:label  runat="server" id="deletLabel" class="text-end d-block text-danger labl"></asp:label>

                 <div class="form-group p-2">
                   <label class="joro">ID</label>
                   <input runat="server" type="text" class="form-control" id="departmentidTextBox" placeholder="Enter Department ID" required>
                 </div>
                <div class="row ">
                    <div class="col-md-3"></div>
                    <div class="col-md-3"></div>
                    <div class="col-md-3"></div>
                    <div class="col-md-3 "><asp:button runat="server" id="studentSearch" OnClick="departmentSearch_click" Class="btn btn-outline-light my-1 " Text="Search"/></div>
                 </div>
                 <div class="form-group p-2">
                   <label class="joro">Name</label>
                   <input runat="server" type="text" class="form-control" id="departmentnameTextBox" placeholder="Enter Department Name">
                 </div>
                 <div class="form-group p-2">
                   <label class="joro">Head of Department</label>
                   <input runat="server" type="text" class="form-control" id="headofdepartmentTextBox" placeholder="Enter Department Address">
                 </div>
                 <div class="form-group p-2">
                   <label class="joro">Phone</label>
                   <input runat="server" type="number" class="form-control" id="departmentphoneTextBox" placeholder="Enter Department Age">
                 </div>
                 
                <br />

                

                 <div class="row">
                    <div class="col-md-4">
                        <asp:button runat="server" id="studentSave" OnClick="departmentSave_click" Class="btn btn-outline-success form-control my-1 " Text="Save"/>
                    </div>
                    <div class="col-md-4">
                        <asp:button runat="server" id="studentUpdate" OnClick="departmentUpdate_click" Class="btn btn-outline-info form-control my-1 " Text="Update"/>
                    </div>
                    <div class="col-md-4">
                        <asp:button runat="server" id="studentDelete" OnClick="departmentDelete_click" Class="btn btn-outline-danger form-control  my-1 " Text="Delete"/>
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
                <asp:button runat="server" id="GridEdit" OnClick="GridEdit_click" CssClass="btn btn-outline-info form-control  my-1 " Text="Edit Gridview" formnovalidate="formnovalidate"/>
            </div>
            <div class="col-md-3"></div>
        </div>
        <asp:GridView ID="GridView1" CssClass=" p table table-bordered table-hover text-white " runat="server" >
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="true" /> 
                <asp:BoundField DataField="Name" HeaderText="Department Name"/> 
                <asp:BoundField DataField="HeadOfDepartment" HeaderText="Head Of Department"/> 
                <asp:BoundField DataField="Phone" HeaderText="Phone"/> 
            </Columns>
            <HeaderStyle HorizontalAlign="Center" CssClass="table table-primary text-dark" />
        </asp:GridView>
    </div>
        <div>
            <CR:CrystalReportViewer ID="CrystalReportViewerDepartment" runat="server" AutoDataBind="true" />
        </div>
     </div>

</asp:Content>
