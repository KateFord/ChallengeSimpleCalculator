<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeSimpleCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Simple Calculator</title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <h1 class="auto-style1">Simple Calculator</h1>
    <div>
    
        <asp:Label ID="firstValueLabel" runat="server" Text="First Value:" OnDataBinding="Page_Load" OnLoad="Page_Load"></asp:Label>
&nbsp;<asp:TextBox ID="firstValueTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="secondValueLabel" runat="server" Text="Second Value:"></asp:Label>
&nbsp;<asp:TextBox ID="secondValueTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="addButton" runat="server" Text="+" OnClick="addButton_Click" />
&nbsp;
        <asp:Button ID="subtractButton" runat="server" Text="-" OnClick="subtractButton_Click" />
&nbsp;
        <asp:Button ID="multiplyButton" runat="server" Text="*" OnClick="multiplyButton_Click" />
&nbsp;
        <asp:Button ID="divisionButton" runat="server" Text="/" OnClick="divisionButton_Click" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server" BackColor="#6699FF" Font-Bold="True"></asp:Label>
    
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
