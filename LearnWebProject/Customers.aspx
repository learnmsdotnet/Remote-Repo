<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customers.aspx.cs" Inherits="LearnWebProject.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ABC Corporation | Customer Inventory Management</title>
    <style type="text/css">
        body {
            font-family: Arial;
            font-size: 10pt;            
        }
        table {
            border: 1px solid #ccc;
            border-collapse: collapse;
            background-color: #fff;
            /* the below two style will set the div to centre of page vertically and not horizontally */
            /* Ref: https://stackoverflow.com/questions/356809/best-way-to-center-a-div-on-a-page-vertically-and-horizontally */
            margin-left: auto; 
            margin-right: auto;
        }
        table th {
            background-color: #B8DBFD;
            color: #333;
            font-weight: bold;
        }
        table th, table td {
            padding: 5px;
            border: 1px solid #ccc;
        }
        table, table table td {
            border: 0px solid #ccc;
        }

        .alignSpace10 {
            height: 10px;
        }
    </style>
    <!-- Ref: https://www.dummies.com/web-design-development/html5-and-css3/how-to-use-an-external-style-sheet-for-html5-and-css3-programming/ -->
    
    
    
    <!-- Ref: https://isabelcastillo.com/error-info-messages-css -->

    <link rel="stylesheet" type="text/css" href="StyleSheet/MessageBoxCSSNoIcon.css" />
    <!--        
        Pure CSS Message Boxes With No Icons (MessageBoxCSSNoIcon.css)
        <div class="pp_info">Replace this text with your own INFO text.</div> 
        <div class="pp_success">Replace this text with your own SUCCESS text.</div>
        <div class="pp_warning">Replace this text with your own WARNING text.</div>
        <div class="pp_error">Replace this text with your own ERROR text.</div>
     -->
    <%--<link rel="stylesheet" type="text/css" href="StyleSheet/MessageBoxCSSIcon.css" />--%>
    <!--
        Message Boxes With Icons, Use CSS to Generate Icons (MessageBoxCSSIcon.css)
        <div class="pp_info">This is info text</div>
        <div class="pp_success">This is success text</div>
        <div class="pp_warning">This is warning text</div>
        <div class="pp_error">This is error text</div>
    -->
    <%--<link rel="stylesheet" type="text/css" href="StyleSheet/MessageBoxHTMLIcon.css" /> --%>
    <!-- 
        Message Boxes With Icons, Using The icon HTML Element (MessageBoxHTMLIcon.css)
        The blue info-message box:
        <div class="isa_info">
            <i class="fa fa-info-circle"></i>
            Replace this text with your own text.
        </div>

        The green success-message box:
        <div class="isa_success">
             <i class="fa fa-check"></i>
             Replace this text with your own text.
        </div>

        The yellow warning-message box:
        <div class="isa_warning">
             <i class="fa fa-warning"></i>
             Replace this text with your own text.
        </div>

        The red error-message box:
        <div class="isa_error">
           <i class="fa fa-times-circle"></i>
           Replace this text with your own text.
        </div>
    -->
</head>
<body>
    <form id="formCustomers" runat="server">
        <asp:ScriptManager ID="scriptManagerCustomers" runat="server" />
        <div id="divCustomers" style="padding: 10px; border: solid 1px red; align-items: center;">
            <asp:UpdatePanel runat="server" ID="updatePanelMessage" UpdateMode="Conditional">
               <ContentTemplate>
                   <div id="divMessage" runat="server" visible="false">
                        <asp:Label ID="labelMessage" runat="server" Font-Names="Arial" Font-Size="10pt" />
                    </div>
               </ContentTemplate>
           </asp:UpdatePanel>
            <asp:UpdatePanel ID="updatePanelCustomers" runat="server" UpdateMode="Always">
                <ContentTemplate>
                    <table border="1" style="border-collapse: collapse;">
                        <tr>
                            <td style="width: 75px; text-align: right;">Name:</td>
                            <td>
                                <asp:TextBox ID="textBoxInputName" runat ="server" width="100px" />
                            </td>
                            <td style="width: 75px; text-align: right;">Country:</td>
                            <td>
                                <asp:TextBox ID="textBoxInputCountry" runat="server" width="100px" />
                            </td>
                            <td style="width: 106px; text-align: center;">
                                <asp:Button ID="buttonCreateRecord" runat="server" Text="Create" OnClick="Insert" width="75px" />
                            </td>
                        </tr>
                    </table>
                    <div class="alignSpace10"></div>
                    <asp:GridView ID="gridViewCustomers" runat="server"
                        AutoGenerateColumns="False" 
                        AllowPaging="True" 
                        DataKeyNames="CustomerId" 
                        OnRowEditing="OnRowEditing"
                        OnRowDataBound="OnRowDataBound"
                        OnRowCancelingEdit="OnRowCancelingEdit"
                        OnPageIndexChanging="OnPaging" 
                        OnRowUpdating="OnRowUpdating"
                        OnRowDeleting="OnRowDeleting" 
                        OnSelectedIndexChanged = "OnSelectedIndexChanged"
                        EmptyDataText="No records has been added."
                        Width="70%">
                        <Columns>
                            <asp:TemplateField HeaderText="Name" HeaderStyle-Width="60%">
                                <EditItemTemplate>
                                    <asp:TextBox ID="textBoxName" runat="server" BorderStyle="Solid" BorderWidth="1px" Font-Names="Arial" Font-Size="10pt" Text='<%# Eval("Name") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="labelName" runat="server" Font-Names="Arial" Font-Size="10pt" Text='<%# Eval("Name") %>'></asp:Label>
                                </ItemTemplate>                               
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Country" HeaderStyle-Width="30%">
                                <EditItemTemplate>
                                    <asp:TextBox ID="textBoxCountry" runat="server" BorderStyle="Solid" BorderWidth="1px" Font-Names="Arial" Font-Size="10pt" Text='<%# Eval("Country") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="labelCountry" runat="server" Font-Names="Arial" Font-Size="10pt" Text='<%# Eval("Country") %>'></asp:Label>
                                </ItemTemplate>                                
                            </asp:TemplateField>
                            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" HeaderText="Action" HeaderStyle-Width="15%" />
                        </Columns>
                    </asp:GridView>                    
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
    <script type="text/javascript" src="Script/jquery.blockUI.js"></script>
    <script type="text/javascript">
        $(function () {
            BlockUI("divCustomers");
            $.blockUI.defaults.css = {};
        });
        function BlockUI(elementID) {
            var prm = Sys.WebForms.PageRequestManager.getInstance();
            prm.add_beginRequest(function () {
                $("#" + elementID).block({ message: '<div align = "center">' + '<img src="Images/loadingAnim.gif"/></div>',
                    css: {},
                    overlayCSS: { backgroundColor: '#000000', opacity: 0.6, border: '3px solid #63B2EB' }
                });
            });
            prm.add_endRequest(function () {
                $("#" + elementID).unblock();
            });
        };
    </script>
</body>
</html>
