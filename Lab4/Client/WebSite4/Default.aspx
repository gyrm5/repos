<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
      <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button1_Click" Text="Sub" />
&nbsp;<asp:Button ID="Button3" runat="server" OnClick="Button1_Click" Text="Multi" />
&nbsp;<asp:Button ID="Button4" runat="server" OnClick="Button1_Click" Text="Div" />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
