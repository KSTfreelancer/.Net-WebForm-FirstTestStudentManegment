<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Department_Edit.aspx.cs" Inherits="Student_management.UI.Department_Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="all editInpit">
         <h1 class="text-center mt-5 " style="color:#144b91">Student Manegment System</h1>
         <h4 class="text-center">All Department's</h4>
    <div class=" gritstyle container table-responsive mt-4 pt-3 rounded ">
    <asp:GridView ID="GridView1" runat="server" CellPadding="4" Width="100%"
        DataKeyNames="Id" AutoGenerateColumns="False"  OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" 
        OnRowUpdating="GridView1_RowUpdating" OnRowDeleting="GridView1_RowDeleting" CellSpacing="2" ForeColor="Black"
        CssClass="p table  table-bordered table-hover text-white" OnPageIndexChanging="GridView1_PageIndexChanging"
        AllowPaging="True" PageSize="10">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" >
            <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Wrap="False" />
            </asp:BoundField>
            <asp:BoundField DataField="Name" HeaderText="Name" >
            <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Wrap="False" />
            </asp:BoundField>
            <asp:BoundField DataField="HeadOfDepartment" HeaderText="Head Of Department" >
            <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Wrap="False" />
            </asp:BoundField>
            <asp:BoundField DataField="Phone" HeaderText="Phone" >
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
                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Wrap="False" />
           </asp:TemplateField>

        </Columns>

        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" CssClass=" table-primary text-dark" />
        <PagerSettings  FirstPageText="First" LastPageText="Last" Mode="NumericFirstLast" NextPageText="Next" PageButtonCount="3" PreviousPageText="Back" />
        <PagerStyle   cssclass="myclass" Font-Names="Arial"  Font-Size="18px" Font-Underline="False" Wrap="False" />
                
      
    </asp:GridView>

          <%--<asp:DataPager runat="server"
              PagedControlID="GridView1" PageSize="3" >
              <Fields>
                  <asp:NextPreviousPagerField ButtonType="Link" ShowFirstPageButton="true" ShowPreviousPageButton="true"
                      ShowNextPageButton="false"/>
                  <asp:NumericPagerField ButtonType="Button"  />
                  <asp:NextPreviousPagerField ButtonType="Link" ShowNextPageButton="true" ShowLastPageButton="true" 
                      ShowPreviousPageButton="false"/>
              </Fields>

          </asp:DataPager>--%>

        </div>
</div>

</asp:Content>
