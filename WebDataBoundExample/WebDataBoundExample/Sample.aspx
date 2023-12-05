<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sample.aspx.cs" Inherits="WebDataBoundExample.Sample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 908px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          <table align="center" class="auto-style1" border="1">
            <asp:Repeater ID="Repeater1" runat="server">
                <HeaderTemplate>
                        <tr>
                            <th>EmpId</th>
                            <th>Ename</th>
                            <th>Designation</th>
                            <th>DOJ</th>
                            <th>Salary</th>
                            <th>Deptno</th>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("EmpId") %></td>
                        <td><%#Eval("Ename") %></td>
                        <td><%#Eval("Designation") %></td>
                        <td><%#Eval("DOJ") %></td>
                        <td><%#Eval("Salary") %></td>
                        <td><%#Eval("Deptno") %></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
          </table>
        </div>
    </form>
</body>
</html>
