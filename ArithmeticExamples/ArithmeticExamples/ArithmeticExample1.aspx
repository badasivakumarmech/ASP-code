<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ArithmeticExample1.aspx.cs" Inherits="ArithmeticExamples.ArithmeticExample1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1" align="center">
            <tr>
                <td class="auto-style2" align="center">
                       
            <asp:Label ID="titlename0" runat="server" Text="Calculation part" Font-Bold="True" Font-Size="Large"></asp:Label>

                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2" align="right">
                    <asp:Label ID="Fname" runat="server" Text="Enter First Number" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtNum1" runat="server" Font-Size="Large"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" align="right">
                    <asp:Label ID="Sname" runat="server" Text="Secount Number" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtNum2" runat="server" Font-Size="Large"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" align="right">
                    <asp:Label ID="Rult" runat="server" Text="Result" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtResult" runat="server" Font-Size="Large"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" align="right">
                    <asp:Button ID="btnAdd" runat="server" OnClick="ButtonAdd_Click" Text="add" Font-Size="Large" CommandName="Add" />
                </td>
                <td class="auto-style3">
                    <asp:Button ID="btnSubstact" runat="server" Text="Substract" Font-Size="Large" CommandName="Substract" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2" align="right">
                    <asp:Button ID="btnMultiply" runat="server" Text="Multiple" Font-Size="Large" CommandName="Multiply" />
                </td>
                <td class="auto-style3">
                    <asp:Button ID="btnDivide" runat="server" Text="Divition" Font-Size="Large" CommandName="Divide" />
                </td>
            </tr>
        </table>
        </div>
    </form>
</body>
</html>
