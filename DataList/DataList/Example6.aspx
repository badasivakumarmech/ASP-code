<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Example6.aspx.cs" Inherits="DataList.Example6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:DataList ID="DataList1" runat="server" Width="803px" CellPadding="4" ForeColor="#333333" Height="272px">
                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <HeaderTemplate>
                    EmpId Ename Designation DOJ Salary DeptNo Edit
                </HeaderTemplate>
                <ItemStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <ItemTemplate>
                    <%#Eval("EmpId") %>
                    <%#Eval("Ename") %>
                    <%#Eval("Designation") %>
                    <%#Eval("DOJ") %>
                    <%#Eval("Salary") %>
                    <%#Eval("DeptNo") %>
                    <asp:Button ID="btnEdit" runat="server" Text="Edit" />
                </ItemTemplate>
                <AlternatingItemStyle BackColor="White" />
                <EditItemTemplate>
                    <asp:Label ID="lblEmpId" runat="server" Text='<%#Eval("EmpId") %>'></asp:Label>
                    <asp:TextBox ID="txtEName" runat="server" Text='<%#Eval("EName") %>'></asp:TextBox>
                    <asp:TextBox ID="txtDesignation" runat="server" Text='<%#Eval("Designation") %>'></asp:TextBox>
                    <asp:TextBox ID="txtDOJ" runat="server" Text='<%#Eval("DOJ") %>'></asp:TextBox>
                    <asp:TextBox ID="txtSalary" runat="server" Text='<%#Eval("Salary") %>'></asp:TextBox>
                    <asp:TextBox ID="txtDeptNo" runat="server" Text='<%#Eval("DeptNo") %>'></asp:TextBox>
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" />
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
                </EditItemTemplate>
                <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            </asp:DataList>
        </div>
    </form>
</body>
</html>
