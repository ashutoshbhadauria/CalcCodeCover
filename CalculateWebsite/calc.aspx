<%@ Page Language="C#" AutoEventWireup="true" CodeFile="calc.aspx.cs" Inherits="calc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <div>
        <asp:TextBox runat="server" id="input1"/>
        <asp:DropDownList runat="server" ID="ddlOps">
            <asp:ListItem>+</asp:ListItem>
            <asp:ListItem>/</asp:ListItem>
            <asp:ListItem>-</asp:ListItem>
            <asp:ListItem>*</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox runat="server" id="input2"/>
        <asp:Button ID="btnDone" runat="server" Text="Calculate" OnClick="btnDone_Click" />
        <br />
        <asp:Label ID="lblResult" runat="server" />
    </div>
    </form>
</body>
</html>
