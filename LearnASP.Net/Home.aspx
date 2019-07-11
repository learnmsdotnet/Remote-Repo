<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Learning ASP.Net web application development</title>
</head>
<body>
    <form id="frmHome" runat="server">
        <div>
            <asp:Button ID="btnGetDatabaseInformation" runat="server" 
                Text="Get Database Information" OnClick="btnGetDatabaseInformation_Click" 
                Font-Names="Tahoma" Font-Size="10pt" />
            <br />
            <br />
            <asp:TextBox ID="txtStudentInformation" runat="server" 
                TextMode="MultiLine" Height="100" Width="250" 
                Font-Names="Tahoma" Font-Size="10pt"></asp:TextBox>
        </div>
    </form>
</body>
</html>
