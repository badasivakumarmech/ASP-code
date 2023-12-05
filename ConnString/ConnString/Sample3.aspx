<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sample3.aspx.cs" Inherits="ConnString.Sample3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
        <div >                 
            <asp:Button ID="btnSubmit" runat="server" Font-Size="Large" Text="Submit" OnClick="btnSubmit_Click" />   
        <asp:GridView ID="GridView1" runat="server" Height="501px" Width="643px">
        </asp:GridView>
        </div>
        
    </form>
</body>
</html>
