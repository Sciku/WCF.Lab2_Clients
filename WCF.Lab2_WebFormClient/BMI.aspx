<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BMI.aspx.cs" Inherits="WCF.Lab2_WebFormClientBMI.BMI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Räkna ut din BMI</h1>
    <div>
        <asp:Label ID="Label2" AssociatedControlID="TextBox1" runat="server" Text="Skriv in din längd i centimeter"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server" placeholder="Skriv in din längd i centimeter" Width="200"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" AssociatedControlID="TextBox2" runat="server" Text="Skriv in din vikt i kilogram"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox2" runat="server" placeholder="Skriv in din vikt i kilogram" Width="200"></asp:TextBox>  
        <br /> 
        <br />
    </div>
        <asp:Button ID="Button1" runat="server" Text="Räkna ut din BMI" OnClick="Button1_Click" />
        <p>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </p>
    </form>
</body>
</html>
