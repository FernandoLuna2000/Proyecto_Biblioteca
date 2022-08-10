<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Proyecto_Biblioteca.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
            <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
            <asp:ListBox ID="ListBox2" runat="server"></asp:ListBox>
            <asp:ListBox ID="ListBox3" runat="server"></asp:ListBox>
            <asp:ListBox ID="ListBox4" runat="server"></asp:ListBox>
            <asp:ListBox ID="ListBox5" runat="server"></asp:ListBox>
            <asp:ListBox ID="ListBox6" runat="server"></asp:ListBox>
            <asp:ListBox ID="ListBox7" runat="server"></asp:ListBox>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <asp:GridView ID="GridView2" runat="server">
            </asp:GridView>     
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
