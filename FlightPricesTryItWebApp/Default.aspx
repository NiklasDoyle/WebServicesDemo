<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FlightPricesTryItWebApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Flight Prices TryIt:<br />
            Description: Takes two airport codes and a date and returns data about the flight proces between those two locations.<br />
            Web Service URL: <a href="http://webstrar22.fulton.asu.edu/page7/Service.svc/">http://webstrar22.fulton.asu.edu/page7/Service.svc/</a><br />
            Methods:<br />
&nbsp;&nbsp;&nbsp; Prices getPrices(string locA, string locB, string date);<br />
&nbsp;&nbsp;&nbsp; <a href="http://webstrar22.fulton.asu.edu/page7/Service.svc/">http://webstrar22.fulton.asu.edu/page7/Service.svc/</a>getPrices/{locA}/{locB}/{date}<br />
            <br />
            Choose your airports (Enter 3 letter airport code, Ex: PHX, DEN, ect.)<br />
            <br />
            Airport 1:&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp; Airport 2:&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter the date you want to check (Use the format: &quot;yyy-mm-dd&quot;)<br />
            <br />
            Date:&nbsp;
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
            <br />
            <br />
            Flight Prices:<br />
&nbsp;&nbsp;&nbsp; Highest Price:
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
&nbsp;&nbsp;&nbsp; Lowest Price:
            <asp:Label ID="Label2" runat="server"></asp:Label>
            <br />
&nbsp;&nbsp;&nbsp; Average Price:
            <asp:Label ID="Label3" runat="server"></asp:Label>
            <br />
&nbsp;&nbsp;&nbsp; All Prices:
            <asp:Label ID="Label4" runat="server"></asp:Label>
            <br />
&nbsp;<asp:TextBox ID="TextBox4" runat="server" Height="28px" Width="602px"></asp:TextBox>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
