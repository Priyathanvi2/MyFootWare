<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FootwareIndex.aspx.cs" Inherits="MyFoodWareApp.FootwareIndex" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>MyFootWareApplication</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <style>
        h2{
            text-align:center;
            font-family:Algerian;
            background-color:seashell;
        }
        body{
            background-color:thistle;
            background-image:url(https://thumbs.dreamstime.com/z/variety-leather-shoes-shop-colourfull-73432235.jpg);
            max-height:auto;
        }
        table{ 
            text-align:center;
            padding:20px;
            border:dotted;
            border-color:palevioletred;
            border-collapse: collapse;
            width: 100%;
        }
        button{
            align-content:center;
        }
        nav{
            float:left;
        }
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>            
            <header><h2>My Online Footware App</h2></header>  
                            
            <nav>
                <asp:DropDownList ID="Categorydd" runat="server">
                <asp:ListItem>Kids</asp:ListItem>
                <asp:ListItem>Mens</asp:ListItem>
                <asp:ListItem>Womens</asp:ListItem>
                 </asp:DropDownList>     
                <div>
                <asp:Button ID="btnview" runat="server" Text="View" OnClick="btnview_Click" />
                </div>
              </nav>
                
                
        </div>
        <div>
            <asp:GridView ID="GView" runat="server"></asp:GridView>
        </div>
        <div id="div1" runat="server">
            <asp:TextBox ID="txtCode" runat="server" placeholder="Enter ProductCode Here"></asp:TextBox>
            <asp:Button ID="btnOrder" runat="server" Text="Order" OnClick="btnOrder_Click" />
        </div>
        <div>            
        <asp:Button ID="btnStatus" runat="server" CssClass="btn btn-dark" Text="Order Status" OnClick="btnStatus_Click" />          
        </div>
        
    </form>
</body>
</html>
