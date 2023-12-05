<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Example5.aspx.cs" Inherits="DataList.Example5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DataList ID="DataList1" runat="server" Height="274px" Width="909px" CellPadding="4" ForeColor="#333333" OnItemCommand="DataList1_ItemCommand">
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <HeaderTemplate>
                    EmpId EName Designation DOJ Salary DeptNo
                </HeaderTemplate>
                <ItemStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <ItemTemplate>
                    <%#Eval("EmpId") %>
                    <%#Eval("EName") %>
                    <%#Eval("Designation") %>
                    <%#Eval("DOJ") %>
                    <%#Eval("Salary") %>
                    <%#Eval("DeptNo") %>
                </ItemTemplate>
                <AlternatingItemStyle BackColor="White" />
                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <FooterTemplate>
                    <asp:TextBox ID="txtEmpId" runat="server" Width="70" ></asp:TextBox>
                    <asp:TextBox ID="txtEName" runat="server" Width="70" ></asp:TextBox>
                    <asp:TextBox ID="txtDesignation" runat="server" Width="70" ></asp:TextBox>
                    <asp:TextBox ID="txtDOJ" runat="server" Width="70" ></asp:TextBox>
                    <asp:TextBox ID="txtSalary" runat="server" Width="70" ></asp:TextBox>
                    <asp:TextBox ID="txtDeptNo" runat="server" Width="70" ></asp:TextBox>
                    <asp:Button ID="btnAdd" runat="server" Width="70" Text="Add" />
                </FooterTemplate>
                <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            </asp:DataList>
        </div>
    </form>
</body>
</html>
