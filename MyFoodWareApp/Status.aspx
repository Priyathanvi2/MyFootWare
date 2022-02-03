<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Status.aspx.cs" Inherits="MyFoodWareApp.Status" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <style>        
        body{
            background-color:thistle;
        }  
        h2{
            text-align:center;
            font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;           
        }
              
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Order Status</h2>
        <div>       
             <asp:GridView ID="GStatus" runat="server" CssClass="table table-hover"></asp:GridView>            
        </div>
    </form>
</body>
</html>
