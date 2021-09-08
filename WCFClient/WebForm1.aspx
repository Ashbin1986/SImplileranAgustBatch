<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WCFClient.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-1.3.1.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
    <td>
        Name:
    </td>
    <td>
        <asp:TextBox ID="txtName" runat="server" Text="" />
    </td>
</tr>
<tr>
    <td>
        Age:
    </td>
    <td>
        <asp:TextBox ID="txtAge" runat="server" Text="" />
    </td>
</tr>
<tr>
    <td>
        <asp:Button ID="btnSubmit" Text="Submit" runat="server" />
    </td>
</tr>
</table>
        
<script type="text/javascript">
$(function () {
    $("[id*=btnSubmit]").click(function () {
        var empid = $.trim($("[id*=txtName]").val());
        var empname = $.trim($("[id*=txtAge]").val());

        var obj = document.getElementById("txtName");
        debugger;

        $.ajax({
            type: "POST",
            url: "EmployeeService.asmx/GetEmployeeRecords",
            data: "{ empid: '" + empid + "', empname: " + empname + "}",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (r) {
                debugger;
                alert("Employee Id " + r.d[0].EmpId + "  " + "Employee Name :" + r.d[0].EmpName);
            },
            error: function (r) {
                alert(r.responseText);
            },
            failure: function (r) {
                alert(r.responseText);
            }
        });
        return false;
    });
});
</script>
    </form>
</body>
</html>
