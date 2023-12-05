<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sample9.aspx.cs" Inherits="GridViewSamples.Sample9" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" Height="271px" Width="994px" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:TemplateField>
                        <HeaderTemplate>EmpId</HeaderTemplate>
                        <ItemTemplate><%#Eval("EmpId") %></ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <HeaderTemplate>EName</HeaderTemplate>
                        <ItemTemplate><%#Eval("EName") %></ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                         <HeaderTemplate>Designation</HeaderTemplate>
                        <ItemTemplate><%#Eval("Designation") %></ItemTemplate>
                        
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <HeaderTemplate>DOJ</HeaderTemplate>
                        <ItemTemplate><%#Eval("DOJ") %></ItemTemplate>
                       
                    </asp:TemplateField>
                    <asp:TemplateField>
                         <HeaderTemplate>Salary</HeaderTemplate>
                        <ItemTemplate><%#Eval("Salary") %></ItemTemplate>
                       
                    </asp:TemplateField>
                    <asp:TemplateField>
                         <HeaderTemplate>DeptNo</HeaderTemplate>
                        <ItemTemplate><%#Eval("DeptNo") %></ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                <SortedAscendingCellStyle BackColor="#FDF5AC" />
                <SortedAscendingHeaderStyle BackColor="#4D0000" />
                <SortedDescendingCellStyle BackColor="#FCF6C0" />
                <SortedDescendingHeaderStyle BackColor="#820000" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
