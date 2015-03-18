<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Apple Orchard Farm</title>
    <style type="text/css">
        .auto-style4 {
            text-align: center;
            font-size: x-large;
        }
        .auto-style5 {
            font-size: large;
        }
        .auto-style6 {
            font-size: large;
            color: #FF0000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style4">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Apple.png" style="float: left" />
            <br />
            <br />
            <br />
            <br />
            <br />
            Apple Orchard Farm<br />
            <br />
            <span class="auto-style5"><em>Bowling Green, Kentucky</em></span><br />
            <br />
            <span class="auto-style5">270-555-5555</span><br />
            <br />
            <span class="auto-style6">Pick apples with us!</span></div>
     </form>
</body>
</html>
