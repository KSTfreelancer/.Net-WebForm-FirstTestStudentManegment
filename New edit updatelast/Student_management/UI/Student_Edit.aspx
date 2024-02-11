<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Student_Edit.aspx.cs" Inherits="Student_management.UI.Student_Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="all editInpit">
    <h1 class="text-center mt-5 " style="color:#144b91">Student Manegment System</h1>
    <h4 class="text-center">All Student's</h4>
        

        <%--##############################################--%>
       <%-- <<%--asp:TextBox ID="SearchOption" runat="server"></asp:TextBox>--%>
        <div class="row container">
        <div class="col-md-3"></div>
        <div class="col-md-4">
            <asp:TextBox ID="searchOptionTextBox" runat="server" class="form-control border border-primary py-1 my-2" placeholder="Enter Course ID" OnTextChanged="searchOptionTextBox_TextChanged"></asp:TextBox>
    <%--    <input runat="server" type="text" class="form-control border border-primary py-1 my-2" id="searchOption" placeholder="Enter Course ID" >--%>
        </div>
        <div class="col-md-2 text-center">
        <asp:button runat="server" id="serchOptionBtn"  Class="btn btn-outline-success  my-2 " Width="200px"  Text="Search" OnClick="serchOptionBtn_Click"/>
        </div>
        <div class="col-md-3"></div>
        </div>
        <%--##############################################--%>



    <div class=" gritstyle container table-responsive mt-4 pt-3 rounded ">
       <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" DataKeyNames="Id"
                Width="100%" CellPadding="3" CellSpacing="2" style="text-align: center" OnRowEditing="GridView1_RowEditing"
                CssClass="p table  table-bordered table-hover text-white" OnPageIndexChanging="GridView1_PageIndexChanging"
                AllowPaging="True" PageSize="10">
                <Columns >
                    
                <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" ReadOnly="True" >
                    <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Wrap="False" />
                    </asp:BoundField>
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" >
                    <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Wrap="False" />
                    </asp:BoundField>
                <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" >
                    <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Wrap="False" />
                    </asp:BoundField>
                <asp:BoundField DataField="Age" HeaderText="Age" SortExpression="Age" >
                    <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Wrap="False" />
                    </asp:BoundField>
                <asp:BoundField DataField="Roll" HeaderText="Roll" SortExpression="Roll" >
                    <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Wrap="False" />
                    </asp:BoundField>
                <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" >
                    <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Wrap="False" />
                    </asp:BoundField>
                <asp:BoundField DataField="RegNo" HeaderText="RegNo" SortExpression="RegNo" >
                    <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Wrap="False" />
                    </asp:BoundField>
                <asp:BoundField DataField="Session" HeaderText="Session" SortExpression="Session" >
                    <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Wrap="False" />
                    </asp:BoundField>
                <asp:BoundField DataField="Department" HeaderText="Department" SortExpression="Department" >
                    <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Wrap="False" />
                    </asp:BoundField>
                <asp:BoundField DataField="Course" HeaderText="Course" SortExpression="Course" >
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
               <PagerSettings  FirstPageText="First" LastPageText="Last" Mode="NumericFirstLast" NextPageText="Next" PageButtonCount="3" PreviousPageText="Back" />
                <PagerStyle   cssclass="myclass" Font-Names="Arial"  Font-Size="18px" Font-Underline="False" Wrap="False" />
                
            </asp:GridView>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="<%$ ConnectionStrings:Student_manegmentConnectionString %>"
            SelectCommand="SELECT * FROM [Students]" UpdateCommand="update Students set Name=@Name,Address=@Address,Age=@Age,Roll=@Roll,
            Phone=@Phone,RegNo=@RegNo,Session=@Session,Department=@Department,Course=@Course WHERE Id=@Id" 
            DeleteCommand="DELETE FROM Course WHERE  Id = @Id">

        </asp:SqlDataSource>

    </div>
</div>
    <br />
</asp:Content>

              <%--  <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                <asp:BoundField DataField="Age" HeaderText="Age" SortExpression="Age" />
                <asp:BoundField DataField="Roll" HeaderText="Roll" SortExpression="Roll" />
                <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
                <asp:BoundField DataField="RegNo" HeaderText="RegNo" SortExpression="RegNo" />
                <asp:BoundField DataField="Session" HeaderText="Session" SortExpression="Session" />
                <asp:BoundField DataField="Department" HeaderText="Department" SortExpression="Department" />
                <asp:BoundField DataField="Course" HeaderText="Course" SortExpression="Course" />--%>