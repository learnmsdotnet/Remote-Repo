<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My First ASP.Net Page</title>
    <style>
			#header{
				background-color: white;
                border: dotted 1px grey;
				width:100%;
				height:40px;
				text-align: center;
			}

			#sidebar-left{
				float:left;
				width:15%;
				background-color: white;
                border: dotted 1px grey;
			}

			#main{
				float:left;
				width:84.70%;
				background-color: white;
                border: dotted 1px grey;
			}

			#sidebar-right{
				float:left;
				width:15%;
				background-color: white;
                border: dotted 1px grey;
			}

			#footer{
				clear:both;
				height: 25px;
				width: 100%;
				text-align: center;
				background-color: white;
                border: dotted 1px grey;
			}

			#sidebar-left, #main, #sidebar-right{
				/*min-height: 100px;*/
                min-height: 100%;
			}

            #sidebar-left, #main, #sidebar-right, #footer, #header{
				font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
                font-size: 12px;
			}

		</style>
</head>
<body>
    <form id="frmDefault" runat="server">
        <div id="header">Header</div>
		<div id="sidebar-left">Left</div>
		<div id="main">Main</div>
		<%--<div id="sidebar-right">Right</div>--%>
		<div id="footer">Footer</div>
    </form>
</body>
</html>
