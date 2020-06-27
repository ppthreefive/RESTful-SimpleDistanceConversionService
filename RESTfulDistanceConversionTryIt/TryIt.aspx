<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TryIt.aspx.cs" Inherits="TryIt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p style="font-weight: 700">
            RESTful Distance Conversion (Miles, Kilometers)</p>
        <p>
            This was made to test very basic distance conversion using RESTful service development.</p>
        <p>
            Convert Kilometers to Miles:</p>
        <p>
            <asp:TextBox ID="txtKilo" runat="server"></asp:TextBox>
            <asp:Button ID="btnConMiles" runat="server" OnClick="btnConMiles_Click" Text="Convert to Miles" />
            <asp:Label ID="lblMiles" runat="server"></asp:Label>
        </p>
        <p>
            Convert Miles to Kilometers:</p>
        <p>
            <asp:TextBox ID="txtMiles" runat="server"></asp:TextBox>
            <asp:Button ID="btnConKilo" runat="server" OnClick="btnConKilo_Click" Text="Convert to Kilometers" />
            <asp:Label ID="lblKilo" runat="server"></asp:Label>
        </p>
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="http://webstrar58.fulton.asu.edu/index.html">Go back</asp:HyperLink>
        </p>
        <p>
            Created by Phillip Pham for ASU course CSE445 with Dr. Yinong Chen, Summer 2020.</p>
    </form>
</body>
</html>
