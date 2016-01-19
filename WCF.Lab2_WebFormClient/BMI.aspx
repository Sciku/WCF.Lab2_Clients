<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BMI.aspx.cs" Inherits="WCF.Lab2_WebFormClient.BMI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Räkna ut din BMI</h1>
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server" placeholder="Skriv in din längd"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" placeholder="Skriv in din vikt"></asp:TextBox>   
    </div>
        <asp:Button ID="Button1" runat="server" Text="Räkna ut din BMI" OnClick="Button1_Click" />
        <p>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </p>
    </form>
</body>
</html>
