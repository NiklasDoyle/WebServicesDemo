<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ServiceDirectory.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
        .auto-style2 {
            height: 23px;
            width: 128px;
        }
        .auto-style4 {
            height: 23px;
            width: 75px;
        }
        .auto-style6 {
            height: 23px;
            width: 287px;
        }
        .auto-style7 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <strong>Service Directroy</strong><br />
            <br />
            This project is developed by: <strong>Niklas Doyle</strong><br />
            <table class="auto-style7">
                <tr>
                    <td class="auto-style2"><strong>Service Name</strong></td>
                    <td class="auto-style4"><strong>TryIt Link</strong></td>
                    <td class="auto-style6"><strong>Service Description</strong></td>
                    <td class="auto-style1"><strong>APIs/Web Service Methods</strong></td>
                </tr>
                <tr>
                    <td class="auto-style2">News Focus<br />
                        (Required Service)</td>
                    <td class="auto-style4">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Try It" Width="70px" />
                    </td>
                    <td class="auto-style6"><span style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Takes in a location in the US and returns 10 URL of news articles about that location.</span></td>
                    <td class="auto-style1"><strong>Method:</strong> <span style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">
                        <br />
                        string[] GetURLs(string top);<br />
                        <strong>API Used:</strong>
                        <br />
                        https://newsapi.org/</span></td>
                </tr>
                <tr>
                    <td class="auto-style2">Weather Info<br />
                        (Elective 1)</td>
                    <td class="auto-style4">
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Try It" Width="70px" />
                    </td>
                    <td class="auto-style6"><span style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Takes in a location in the US and returns the forecast for the next 7 days.</span></td>
                    <td class="auto-style1"><strong>Method:</strong> <span style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">
                        <br />
                        string[] GetWeather(string location);<br />
                        <strong>API Used:</strong>
                        <br />
                        </span>http://api.positionstack.com</td>
                </tr>
                <tr>
                    <td class="auto-style2">Flight Prices<br />
                        (Elective 2)</td>
                    <td class="auto-style4">
                        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Try It" Width="70px" />
                    </td>
                    <td class="auto-style6"><span style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Takes two airport codes and a date and returns data about the flight proces between those two locations.</span></td>
                    <td class="auto-style1"><strong>Method:</strong>
                        <br />
                        <span style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Prices getPrices(string locA, string locB, string date);<br />
                        <strong>APIs Used:</strong>
                        <br />
                        </span>https://skyscanner44.p.rapidapi.com/</td>
                </tr>
            </table>
            <br />
        </div>
    </form>
</body>
</html>
