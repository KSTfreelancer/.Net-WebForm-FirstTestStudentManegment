<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Teacher_Edit.aspx.cs" Inherits="Student_management.UI.Teacher_Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="all editInpit">
        <h1 class="text-center mt-5 " style="color:#144b91">Student Manegment System</h1>
         <h4 class="text-center">All Teacher's</h4>
    <div class=" gritstyle container table-responsive mt-4 pt-3 rounded ">

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" Width="100%"
                CssClass="p table  table-bordered table-hover text-white" DataKeyNames="Id" AllowPaging="True" PageSize="10">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" ReadOnly="True" >
                        <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Wrap="False" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" >
                        <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Wrap="False" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Subject" HeaderText="Subject" SortExpression="Subject" >
                        <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Wrap="False" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Department" HeaderText="Department" SortExpression="Department" >
                        <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Wrap="False" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" >
                        <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Wrap="False" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Age" HeaderText="Age" SortExpression="Age" >
                        <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Wrap="False" />
                    </asp:BoundField>
                    <asp:BoundField DataField="DateOfJoin" HeaderText="DateOfJoin" SortExpression="DateOfJoin" DataFormatString = "{0:dd/MM/yyyy}">
                        <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Wrap="False" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" >
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

        </div>
    </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Student_manegmentConnectionString5 %>" 
        SelectCommand="SELECT * FROM [Teacher]"
        UpdateCommand="update Teacher set Name=@Name,Subject=@Subject,Department=@Department,Address=@Address,Age=@Age,DateOfJoin=@DateOfJoin,Phone=@Phone where Id=@Id"
        DeleteCommand="DELETE FROM Course WHERE  Id = @Id">

    </asp:SqlDataSource>
    <br />
    <br />
</asp:Content>
