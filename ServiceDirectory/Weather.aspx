<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Weather.aspx.cs" Inherits="ServiceDirectory.Weather" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Weather TryIt:<br />
            Description: Takes in a location in the US and returns the forecast for the next 7 days.<br />
            Web Service URL: <a href="http://webstrar22.fulton.asu.edu/page8/Service.svc">http://webstrar22.fulton.asu.edu/page8/Service.svc</a><br />
            Methods:<br />
&nbsp;&nbsp;&nbsp; string[] GetWeather(string location);<br />
            <br />
            Enter a city in the US:
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Enter the State Abbreviation (Ex: AZ, CA, NY):<br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
            <br />
            <br />
            Weather Forecast:<br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label3" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label4" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label5" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label6" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label7" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Back" />
        </div>
    </form>
</body>
</html>
