<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderHere.aspx.cs" Inherits="MyFoodWareApp.OrderHere" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <style>
        h2{
            text-align:center;
            font-family:Algerian;
            background-color:seashell;
        }
        body{
            background-color:thistle;
            background-image:url(https://uniquekiosk.com/wp-content/uploads/2020/04/21-6-1024x682.jpg);
        }
        table{
            padding:20px;
            border:dotted;
            border-color:palevioletred;
            border-collapse: collapse;
            width: 30%;
        }
        button{
            align-content:center;
        }
       
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <header><h2>Order Here</h2></header>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="ProductCode"></asp:Label></td>
                    <td>:</td>
                    <td>
                        <asp:Label ID="lblcode" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Lable2" runat="server" Text="ProductName"></asp:Label></td>
                    <td>:</td>
                    <td>
                        <asp:Label ID="lblname" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Lable3" runat="server" Text="Price"></asp:Label></td>
                    <td>:</td>
                    <td>
                        <asp:Label ID="lblprice" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Quantity"></asp:Label></td>
                    <td>:</td>
                    <td>
                        <asp:TextBox ID="txtquantity" runat="server"></asp:TextBox></td>
                </tr>
                
            </table>
        </div>
        <div>
            <tb>
                <asp:Button ID="btnbill" runat="server" class="btn btn-dark" Text="Bill" OnClick="btnbil_Click" Width="95px" /></tb>
        </div>
        <table> 
            <tr>
            <td class="auto-style1"><asp:Label ID="Label2" runat="server" Text="Total"></asp:Label></td>
            <td>:</td>
            <td><asp:Label ID="lbltotal" runat="server" Text=""></asp:Label></td>
            <td><asp:Button ID="btnToalPayment" class="btn btn-dark" runat="server" Text="TotalPayment" OnClick="btnToalPayment_Click" /></td>
        </tr>
            </table>
        <div>
            <asp:Label ID="lblResult" runat="server"  Text="Result"></asp:Label>
        </div>
    </form>
</body>
</html>
