<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <title></title>
 <link rel="stylesheet" href="jquery.mobile-1.0rc1.min.css"
     <link rel="stylesheet" href="jquery-ui.css">
  <script src="jquery-1.9.1.js"></script>
  <script src="jquery-ui.js"></script>
     <script>
         $(document).on("mobileinit", function () {
             $.mobile.ajaxEnabled = false;
             $.mobile.loadingMessage = false;
         });
    </script>
    <script type="text/javascript" src="jquery.mobile-1.0rc1.min.js"></script>
      <style type="text/css">
          #Select1 {
              width: 143px;
          }
      </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <span class="fileinput-button" data-role="button" data-icon="plus">
    <span>Upload</span>&nbsp;
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Price"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Location"></asp:Label>
        &nbsp;<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Comment"></asp:Label>
        &nbsp;
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Tag"></asp:Label>
        


        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Value="Birthday"></asp:ListItem>
            <asp:ListItem Value="Graduation"></asp:ListItem>
            <asp:ListItem Value="Wedding"></asp:ListItem>
        </asp:DropDownList>
        


        <br />
       
</span>
      
         <asp:Button ID="Button1" datainline="true" runat="server" OnClick="Button1_Click" Text="Upload" Width="179px" />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
      <span class="fileinput-button" data-role="button" data-icon="plus">
        <asp:Label ID="Label7" runat="server" Text="Tag"></asp:Label>
        


      
    </div>
    </form>
</body>
</html>
