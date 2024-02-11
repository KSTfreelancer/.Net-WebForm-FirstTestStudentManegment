<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Course_Edit.aspx.cs" Inherits="Student_management.UI.Course_Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        
        .popUp {
    background: none;
    background-color: rgba(0,0,0,0.5);
    backdrop-filter: blur(5px);
    position: absolute;
    top: 0px;
    left: 0px;
    height: 100vh;
    position:fixed;
   /* visibility:hidden;*/
}
    </style>
    <div class="all editInpit" style="position:relative">
        <h1 class="text-center pt-5 " style="color:#144b91">Student Manegment System</h1>
         <h4 class="text-center">All Course's</h4>
    <div class=" gritstyle container table-responsive mt-4 pt-3 rounded ">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" DataKeyNames="Id"
                Width="100%" CellPadding="3" CellSpacing="2" style="text-align: center" OnRowEditing="GridView1_RowEditing"
                CssClass="p table  table-bordered table-hover text-white" AllowPaging="True" PageSize="10" ShowFooter="false">
                <Columns >
                    
                    <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" ReadOnly="true" >
                    <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Wrap="False" />
                    </asp:BoundField>
                    <asp:BoundField DataField="CourseName" HeaderText="CourseName" SortExpression="CourseName" >
                    <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Wrap="False" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Duration" HeaderText="Duration" SortExpression="Duration" >
                    <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Wrap="False" />
                    </asp:BoundField>
                    <asp:TemplateField HeaderText="Options" ShowHeader="False">
                        <EditItemTemplate>
                            <asp:Button CssClass="btn btn-info" ID="Button1" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                            &nbsp;<asp:Button CssClass="btn btn-light" ID="Button2" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Button CssClass="btn btn-primary" ID="Button1" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit" />
                            &nbsp;<asp:Button CssClass="btn btn-danger" ID="Button2" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" />
                        </ItemTemplate>
                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Wrap="False" />
                    </asp:TemplateField>
                </Columns>
                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" CssClass=" table-primary text-dark" />
               
                <PagerSettings FirstPageText="Frist" LastPageText="Last" Mode="NumericFirstLast" />
                <PagerSettings  FirstPageText="First" LastPageText="Last" Mode="NumericFirstLast" NextPageText="Next" PageButtonCount="3" PreviousPageText="Back" />
                <PagerStyle   cssclass="myclass" Font-Names="Arial"  Font-Size="18px" Font-Underline="False" Wrap="False" />
                
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="<%$ ConnectionStrings:Student_manegmentConnectionString %>"
                SelectCommand="SELECT * FROM [Course] ORDER BY Id"
                UpdateCommand="update Course set CourseName = @CourseName, Duration=@Duration where Id = @Id"
                DeleteCommand="DELETE FROM Course WHERE  Id = @Id"></asp:SqlDataSource>

            <br />
        <div class=" col-md-3 ">
            <asp:button runat="server" OnClick="Showinsert_click" id="popbtn"  Class="btn popbtn btn-outline-info form-control  my-1 " Text="Insert"/>
        </div>

            <br />
            <br />
        </div>

         <%--++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++--%>
       <div class="over_box popUp" id="popUp" runat="server">
    <div class="box position-relative mt-5 mb-5" style="background-color:rgba(100, 149, 237,.3)">
          <asp:Button ID="Clogeinsert" OnClick="Clogeinsert_click" class="position-absolute top-0 left-0 text-danger"  runat="server" Text="X" />
       <%-- <i class="fa-solid fa-xmark position-absolute text-danger clogPop" style="top:20px;right:20px;cursor:pointer;font-size:22px"></i>--%>
            <h2 class="text-center">Course</h2>
            
                 <asp:label runat="server" id="SearchLabel" class="text-end d-block labl"></asp:label>
                <asp:label runat="server" id="saveLabel"  class="text-end d-block text-success labl"></asp:label>
                <asp:label  runat="server" id="updateLabel" class="text-end d-block text-info labl"></asp:label>
                <asp:label  runat="server" id="deletLabel" class="text-end d-block text-danger labl"></asp:label>


                 <div class="form-group p-2">
                   <label class="joro">ID</label>
                   <input runat="server" type="text" class="form-control" id="courseidTextBox" placeholder="Enter Course ID" >
                 </div>
                 <div class="row ">
                    <div class="col-md-3"></div>
                    <div class="col-md-3"></div>
                    <div class="col-md-3"></div>
                    <div class="col-md-3 "> <asp:button runat="server" id="studentSearch" OnClick="courseSearch_click" Class="btn btn-outline-light my-1 studentSearch" Text="Search"/></div>
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
    <%--++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++--%>


</div>




<%--    <script   type="text/javascript" >
        var popbtn = document.querySelector(".popbtn");
        var popUp = document.querySelector(".popUp");
        var clogPop = document.querySelector(".clogPop");
         //============================================================
        var serch = document.querySelector(".studentSearch");
        var insert = document.querySelector("#studentSave");
        var update = document.querySelector("#studentUpdate");
        var delet = document.querySelector("#studentDelete");
         //============================================================
     /*   console.log(popUp);*/
        popbtn.addEventListener('click', function(event) {
            popUp.style.visibility = 'visible';
            event.preventDefault();
        });
        //serch.addEventListener('click', function (event) {
        //    popUp.style.visibility = 'visible';
        //    event.preventDefault();
        //});

        function stt() {
            popUp.style.visibility = 'visible';
            event.preventDefault();
        }

        //============================================================
        //serch.addEventListener('click', function (event) {
        //    popUp.style.visibility = 'visible';
        //    event.preventDefault();
        //    console.log("Click it");
        //});
        //insert.addEventListener('click', function (event) {
        //    popUp.style.visibility = 'visible';
        //    event.preventDefault();
        //});
        //update.addEventListener('click', function (event) {
        //    popUp.style.visibility = 'visible';
        //    event.preventDefault();
        //});
        //delet.addEventListener('click', function (event) {
        //    popUp.style.visibility = 'visible';
        //    event.preventDefault();
        //});
        //============================================================


        clogPop.addEventListener('click', function (event) {
            popUp.style.visibility = 'hidden';
            event.preventDefault();
        })
        
    </script>--%>

</asp:Content>
 