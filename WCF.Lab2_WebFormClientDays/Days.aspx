<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Days.aspx.cs" Inherits="WCF.Lab2_WebFormClientDays.Days" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Räkna ut din hur många dagar gammal du är!</h1>
    <div>
        <asp:Label ID="Label2" AssociatedControlID="TextBox1" runat="server" Text="Skriv in året du är född"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server" placeholder="Skriv in året du är född" Width="200"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" AssociatedControlID="TextBox2" runat="server" Text="Skriv in månaden du är född"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox2" runat="server" placeholder="Skriv in månaden du är född" Width="200"></asp:TextBox>  
        <br /> 
        <br />
        <asp:Label ID="Label4" AssociatedControlID="TextBox3" runat="server" Text="Skriv in dagen du är född"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox3" runat="server" placeholder="Skriv in dagen du är född" Width="200"></asp:TextBox>  
        <br /> 
        <br />
    </div>
        <asp:Button ID="Button1" runat="server" Text="Räkna ut!" Width="205" OnClick="Button1_Click" />
        <p>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </p>
    </form>
</body>
</html>
