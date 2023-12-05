<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sample10.aspx.cs" Inherits="GridViewSamples.Sample10" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="EmpId" DataSourceID="SqlDataSource1" EmptyDataText="There are no data records to display." Height="527px" Width="1047px">
                <Columns>
                    <asp:BoundField DataField="EmpId" HeaderText="Employee Id" ReadOnly="True" SortExpression="EmpId" />
                    <asp:BoundField DataField="EName" HeaderText="Employee Name" SortExpression="EName" />
                    <asp:BoundField DataField="Designation" HeaderText="Employee Designation" SortExpression="Designation" />
                    <asp:BoundField DataField="DOJ" HeaderText="DOJ" SortExpression="DOJ" />
                    <asp:BoundField DataField="Salary" HeaderText="Employee Salary" SortExpression="Salary" />
                    <asp:BoundField DataField="DeptNo" HeaderText="DeptNo" SortExpression="DeptNo" />
                    <asp:BoundField DataField="EmpId" HeaderText="rrr" ReadOnly="True" SortExpression="EmpId" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:mkdbConnectionString1 %>" 
                DeleteCommand="DELETE FROM [EmpDetails] WHERE [EmpId] = @EmpId" 
                InsertCommand="INSERT INTO [EmpDetails] ([EmpId], [EName], [Designation], [DOJ], [Salary], [DeptNo]) 
                                VALUES (@EmpId, @EName, @Designation, @DOJ, @Salary, @DeptNo)" 
                ProviderName="<%$ ConnectionStrings:mkdbConnectionString1.ProviderName %>" 
                SelectCommand="SELECT [EmpId], [EName], [Designation], [DOJ], [Salary], [DeptNo] FROM [EmpDetails]" 
                UpdateCommand="UPDATE [EmpDetails] SET [EName] = @EName, [Designation] = @Designation, [DOJ] = @DOJ, [Salary] = @Salary, 
                                [DeptNo] = @DeptNo WHERE [EmpId] = @EmpId" >
                <DeleteParameters>
                    <asp:Parameter Name="EmpId" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="EmpId" Type="Int32" />
                    <asp:Parameter Name="EName" Type="String" />
                    <asp:Parameter Name="Designation" Type="String" />
                    <asp:Parameter DbType="Date" Name="DOJ" />
                    <asp:Parameter Name="Salary" Type="Decimal" />
                    <asp:Parameter Name="DeptNo" Type="Int32" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="EName" Type="String" />
                    <asp:Parameter Name="Designation" Type="String" />
                    <asp:Parameter DbType="Date" Name="DOJ" />
                    <asp:Parameter Name="Salary" Type="Decimal" />
                    <asp:Parameter Name="DeptNo" Type="Int32" />
                    <asp:Parameter Name="EmpId" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
