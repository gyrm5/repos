<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DisplayGifts.aspx.cs" Inherits="DisplayGifts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <asp:Label ID="Label7" runat="server" Text="Tag"></asp:Label>
        


        <asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem Value="Birthday"></asp:ListItem>
            <asp:ListItem Value="Graduation"></asp:ListItem>
            <asp:ListItem Value="Wedding"></asp:ListItem>
        </asp:DropDownList>
        


        &nbsp;&nbsp;
        
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="DisplayGifts" />
        
        <br />
                 <asp:Image ID="Image1" runat="server" Height="81px" Width="108px" />
        <br />
        <div id="imgurl" runat="server"></div>
        <br />       
        <br />
    </div>
    </form>
</body>
</html>
