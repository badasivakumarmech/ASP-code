<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebApplication.aspx.cs" Inherits="WebAppDBComponent.WebApplication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 49%;
        }
        .auto-style2 {
            width: 780px;
        }
        .auto-style3 {
            width: 670px;
        }
        .auto-style4 {
            width: 670px;
            height: 53px;
        }
        .auto-style5 {
            width: 780px;
            height: 53px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1" align="center">
                <tr>
                    <td class="auto-style3" align="right">
                        <asp:Label ID="Label1" runat="server" Font-Size="Large" Text="Enter EmpId" ></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtEmpId" runat="server" Font-Size="Large"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3" align="right">
                        <asp:Label ID="Label2" runat="server" Font-Size="Large" Text="Enter EName"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtEName" runat="server" Font-Size="Large"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3" align="right">
                        <asp:Label ID="Label3" runat="server" Font-Size="Large" Text="Enter Designation"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtDesignation" runat="server" Font-Size="Large"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3" align="right">
                        <asp:Label ID="Label4" runat="server" Font-Size="Large" Text="Enter DOJ"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtDOJ" runat="server" Font-Size="Large"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3" align="right">
                        <asp:Label ID="Label5" runat="server" Font-Size="Large" Text="Enter Salary"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtSalary" runat="server" Font-Size="Large"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3" align="right">
                        <asp:Label ID="Label6" runat="server" Font-Size="Large" Text="Enter DeptNo"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtDeptNo" runat="server" Font-Size="Large"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3" align="right">
                        <asp:Button ID="btnInsert" runat="server" Font-Size="Large" Text="Insert" OnClick="btnInsert_Click" />
                    </td>
                    <td class="auto-style2">
                        <asp:Button ID="btnFind" runat="server" Font-Size="Large" Text="Find" OnClick="btnFind_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3" align="right">
                        <asp:Button ID="btnUpdate" runat="server" Font-Size="Large" Text="Update" OnClick="btnUpdate_Click" />
                    </td>
                    <td class="auto-style2">
                        <asp:Button ID="btnDelete" runat="server" Font-Size="Large" Text="Delete" OnClick="btnDelete_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style5">
                        <asp:Label ID="lblDisplay" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
