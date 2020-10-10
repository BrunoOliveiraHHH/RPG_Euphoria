<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ArmasMuni.aspx.cs" Inherits="RPG_Euphoria.ArmasMuni" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta http-equiv="X-UA-Compatible" content="ie=edge" />
    <title>O Inicio do Fim</title>
    <link rel="stylesheet" href="assets/css/style.css" />
    <link rel="stylesheet" href="Assets/css/armaMuni.css" />
    <link rel="stylesheet" href="assets/css/bootstrap.css" />
    <link rel="stylesheet" href="assets/css/w3.css" />
    <link rel="shortcut icon" href="Assets/img/ico.png" type="image/x-icon" />
</head>
<body style="background-image: url('Assets/css/back.jpg'); background-repeat: no-repeat; background-attachment: fixed">
    <form id="form1" runat="server">
    <div class="header">
        <div class="menu">
            <ul class="nav nav-tabs">
                <li class="nav-item"><asp:HyperLink ID="btnHomePage" runat="server" 
                        CssClass="nav-link" NavigateUrl="~/Menu.aspx" Visible="True">Home Page</asp:HyperLink></li>
                <li class="nav-item"><asp:HyperLink ID="btnArmaMuni" CssClass="nav-link" runat="server" 
                        NavigateUrl="~/ArmasMuni.aspx" Visible="False">Armas e Munição</asp:HyperLink></li>
                <li class="nav-item"><asp:HyperLink ID="btnArmadura" CssClass="nav-link" runat="server" 
                        NavigateUrl="#" Visible="False">Proteção</asp:HyperLink></li>
                <li class="nav-item"><asp:HyperLink ID="btnVeiculo" CssClass="nav-link" runat="server" 
                        NavigateUrl="#" Visible="False">Veículos</asp:HyperLink></li>
                <li class="nav-item"><asp:HyperLink ID="btnItem" CssClass="nav-link" runat="server" 
                        NavigateUrl="#" Visible="False">Equipamentos e Ferramentas</asp:HyperLink></li>
                <li class="nav-item"><asp:HyperLink ID="btnMonstro" CssClass="nav-link" runat="server" 
                        NavigateUrl="#" Visible="False">Monstros</asp:HyperLink></li>
            </ul>
        </div>
    </div>
    <center>
    <div class="section" style="text-align:left;">
    <div style="margin-left:0px; margin-top:5px;">
    <div class="title" style="display:inline;">Nome:<asp:TextBox runat="server" ID="txtBoxNome"></asp:TextBox></div>    
    <div class="title" style="display:inline;">Propriedades:<asp:TextBox runat="server" ID="txtBoxPropriedade"></asp:TextBox></div>
    <div class="title" style="display:inline;">Tipo de Arma:<asp:DropDownList runat="server" ID="cbxTipoArma"></asp:DropDownList></div>    
    </div>
    <br />
    <div style="margin-left:0px; margin-top:5px; margin-bottom:5px;">
    <div class="title" style="display:inline;">Custo:<asp:TextBox runat="server" ID="txtCusto"></asp:TextBox></div>
    <div class="title" style="display:inline;">Dano:<asp:TextBox runat="server" ID="txtDadoDano"></asp:TextBox></div>
    <div class="title" style="display:inline;margin-left: 49px;">Tipo de Dano:<asp:TextBox runat="server" ID="txtTipoDano"></asp:TextBox></div>    
    </div>
    <br />
    <div style="margin-left:0px; margin-top:5px; margin-bottom:15px;">
    <div class="title" style="display:inline;">Peso:<asp:TextBox runat="server" ID="txtPeso"></asp:TextBox></div>
    <div class="title" style="display:inline;">Durabilidade:<asp:DropDownList runat="server" ID="cbxDurabilidade"></asp:DropDownList></div>
    <div class="title" style="display:inline;">Calibre:<asp:DropDownList runat="server" ID="cbxCalibreMunicao"></asp:DropDownList></div>
    </div>
    </div>
    <br />
    <asp:GridView runat="server" ID="gridArmaMuni" CssClass="gridArmaMuni" BackColor="WindowFrame" Width=1500px></asp:GridView>
    <br />
    </center>
    </form>
    </body>   
</html>
