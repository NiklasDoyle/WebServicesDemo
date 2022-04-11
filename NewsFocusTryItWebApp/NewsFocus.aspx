<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewsFocus.aspx.cs" Inherits="NewsFocusTryItWebApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            NewsFocus TryIt:<br />
            Description: Takes in a location in the US and returns 10 URL of news articles about that location.<br />
            Web Service URL: <a href="http://webstrar22.fulton.asu.edu/Page9/Service.svc?wsdl">http://webstrar22.fulton.asu.edu/Page9/Service.svc?wsdl</a><br />
            Methods:<br />
&nbsp;&nbsp;&nbsp; string[] GetURLs(string top);<br />
            <br />
            Enter a place:<br />
            <asp:TextBox ID="TextBox1" runat="server" Width="199px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
            <br />
            <br />
            News Articles:<br />
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
            <asp:Label ID="Label8" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label9" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label10" runat="server"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
