<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="RPG_Euphoria.Usuarios.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>RPG- Euphoria</title>
</head>
<body>
  <table>
  <tr>
  <td>Usuário: <asp:TextBox runat="server" ID="txtUsuario" placeholder="Digite aqui o usuario"></asp:TextBox></td>
  </tr>
  <tr>
  <td>Senha: <asp:TextBox runat="server" ID="txtSenha" type="password" placeholder="Digite aqui a senha"></asp:TextBox></td>
  </tr>
  <tr>
  <td><asp:Button runat="server" ID="btnLogin" type="submit" 
          onclick="btnLogin_Click" /></td>
  </tr>
  <tr><td> <asp:Label runat="server" ID="lblMensagemErro"></asp:Label>
  </td>
  </tr>
  </table>
</body>
</html>
