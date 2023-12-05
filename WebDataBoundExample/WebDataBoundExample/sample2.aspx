<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sample2.aspx.cs" Inherits="WebDataBoundExample.sample2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DataList ID="DataList1" runat="server">
                <HeaderTemplate>
                    EmpId Ename Designatio DOJ Salary Deptno
                </HeaderTemplate>
                <ItemTemplate>
                    <%#Eval("EmpId") %>
                    <%#Eval("Ename") %>
                    <%#Eval("Designatio") %>
                    <%#Eval("DOJ") %>
                    <%#Eval("Salary") %>
                    <%#Eval("Deptno") %>
                </ItemTemplate>
            </asp:DataList>
        </div>
    </form>
</body>
</html>
