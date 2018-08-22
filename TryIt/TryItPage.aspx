<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TryItPage.aspx.cs" Inherits="TryIt.TryItPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Italic="False" Font-Names="Segoe UI Black" Font-Size="X-Large" ForeColor="#FF6699" Text="FileUpload Test"></asp:Label>
        <br />
        <br />
        <asp:FileUpload ID="FileUpload1" runat="server" Width="353px" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnFileUpload" runat="server" OnClick="btnFileUpload_Click" Text="Upload File" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="File stored at:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblFilePath" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Italic="False" Font-Names="Segoe UI Black" Font-Size="X-Large" ForeColor="#FF6699" Text="5 Day Weather Test"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Search News About (separate each keyword by a space):"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtKeyWords" runat="server" TextMode="MultiLine" Width="311px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblKeyWordValid" runat="server" ForeColor="#FF3300" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnGetLinks" runat="server" OnClick="btnGetLinks_Click" Text="Get Links" />
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="List of URLs:"></asp:Label>
        <br />
        <asp:TextBox ID="txtResultUrl" runat="server" Height="236px" TextMode="MultiLine" Width="905px"></asp:TextBox>
        <br />
    </form>
</body>
</html>
