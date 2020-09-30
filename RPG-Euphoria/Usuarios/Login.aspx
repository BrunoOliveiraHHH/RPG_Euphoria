<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="RPG_Euphoria.Usuarios.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>RPG- Euphoria</title>
</head>
<body>
    <form id="form1" runat="server">
    Usuário:
    <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
&nbsp;Senha:
    <asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox>
&nbsp;&nbsp;
    <asp:Button runat="server" ID="btnLogin" type="submit" OnClick="btnLogin_Click" 
        Text="Login" />
    
    </form>
</body>
</html>
    <asp:Label ID="lblMensagemErro" runat="server"></asp:Label>
