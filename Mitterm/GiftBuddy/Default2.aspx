<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="http://code.jquery.com/jquery-1.10.1.min.js"></script>
    <script src="http://code.jquery.com/jquery-1.10.1.min.js"></script>
   <script> src= " http://code.jquery.com/ui/1.10.3/themes/smoothness/jquery-ui.css" </script>
<script src="http://code.jquery.com/jquery-migrate-1.2.1.min.js"></script>
  <script> src= "http://code.jquery.com/jquery-1.9.1.js"</script>
     <script src="http://ajax.aspnetcdn.com/ajax/jquery/jquery-1.9.0.min.js"></script>  
        <script>

            // Fallback to loading jQuery from a local path if the CDN is unavailable  
            (window.jQuery || document.write('<script src="/scripts/jquery-1.9.0.min.js"><\/script>'));
        </script>  
        
    <script>cancelAnimationFrame
        $(function ()
        {
            $(".datepick").datepicker();
        }
        );
  </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="EventName" runat="server" Text="EventName"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 29px"></asp:TextBox>
        <br />
            <asp:Label ID="Label1" runat="server" Text="EventDate"></asp:Label>
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <input type="text" id="datepicker" class="datepick" runat="server" />
        
        <br />
        <asp:Label ID="EventTime" runat="server" Text="EventTime"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox5" runat="server" style="margin-left: 25px"></asp:TextBox>
        <br />
        <asp:Label ID="EventLocation" runat="server" Text="EventLocation"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 29px"></asp:TextBox>
        <br />
        <asp:Label ID="EventDescription" runat="server" Text="EventType"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Value="Birthday"></asp:ListItem>
            <asp:ListItem Value="Graduation"></asp:ListItem>
            <asp:ListItem Value="Wedding"></asp:ListItem>
        </asp:DropDownList>
        


        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        


        <br />
       
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
       
        <br />
    
    </div>
    </form>
    <script> src = "http://code.jquery.com/jquery-1.9.1.js"</script>
     <script src="http://ajax.aspnetcdn.com/ajax/jquery/jquery-1.9.0.min.js"></script>  
</body>
</html>
