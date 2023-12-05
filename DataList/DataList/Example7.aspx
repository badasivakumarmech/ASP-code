<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Example7.aspx.cs" Inherits="DataList.Example7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DataList ID="DataList1" runat="server" CellPadding="4" ForeColor="#333333" Width="805px">
                <AlternatingItemStyle BackColor="White" />
                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <HeaderTemplate>
                    <asp:CheckBox ID="chkAll" runat="server" />
                    EmpId EName Designation DOJ Salary DeptNo 
                </HeaderTemplate>
                <ItemStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <ItemTemplate>
                    <asp:CheckBox ID="chkOne" runat="server" />
                    <asp:Label ID="lblEmpId" runat="server" Text='<%#Eval("EmpId") %>' ></asp:Label>
                    <%#Eval("EName") %>
                    <%#Eval("Designation") %>
                    <%#Eval("DOJ") %>
                    <%#Eval("Salary") %>
                    <%#Eval("DeptNo") %>
                </ItemTemplate>
                <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            </asp:DataList>
            <asp:Button ID="btnDelete" runat="server" Font-Size="Large" OnClick="btnDelete_Click" Text="Delete" />
        </div>
    </form>
</body>
</html>
