<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Protecao.aspx.cs" Inherits="RPG_Euphoria.Protecao" %>

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
    <form id="form2" runat="server">
    <div class="header">
        <div class="menu">
            <ul class="nav nav-tabs">
                <li class="nav-item"><asp:HyperLink ID="btnHomePage" runat="server" 
                        CssClass="nav-link" NavigateUrl="~/Menu.aspx" Visible="True">Home Page</asp:HyperLink></li>
                <li class="nav-item"><asp:HyperLink ID="btnArmaMuni" CssClass="nav-link" runat="server" 
                        NavigateUrl="~/Armas.aspx" Visible="False">Armas</asp:HyperLink></li>
                <li class="nav-item"><asp:HyperLink ID="btnArmadura" CssClass="nav-link" runat="server" 
                        NavigateUrl="~/Protecao.aspx" Visible="False">Proteção</asp:HyperLink></li>
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
    <div class="title" style="display:inline;">Tipo de Armadura:<asp:DropDownList runat="server" ID="cbxTipoProtecao"></asp:DropDownList></div>    
    </div>
    <br />
    <div style="margin-left:0px; margin-top:5px; margin-bottom:5px;">
    <div class="title" style="display:inline;">Custo:<asp:TextBox runat="server" ID="txtCusto"></asp:TextBox></div>
    <div class="title" style="display:inline;margin-left: 55px;">CA:<asp:TextBox runat="server" ID="txtDadoDano"></asp:TextBox></div>
    <div class="title" style="display:inline;">Furtividade:<asp:DropDownList runat="server" ID="cbxFurtiv"></asp:DropDownList></asp:TextBox></div>    
    </div>
    <br />
    <div style="margin-left:0px; margin-top:5px; margin-bottom:15px;">
    <div class="title" style="display:inline;">Peso:<asp:TextBox runat="server" ID="txtPeso"></asp:TextBox></div>
    <div class="title" style="display:inline;margin-left: 8px;">Durabilidade:<asp:DropDownList runat="server" ID="cbxDurabilidade"></asp:DropDownList></div>
    </div>
    <div style="margin-left:0px; margin-top:5px; margin-bottom:15px;">
    <asp:Label runat="server" ID="lblMensagem"></asp:Label>
    </div>
    <center>
    <div style="margin-left:0px; margin-top:5px; margin-bottom:15px;">
    <div class="title" style="display:inline;"><asp:Button runat="server" 
            ID="btnAdiciona" Text="Adiciona Proteção" onclick="btnAdiciona_Click" /> </div>
    <div class="title" style="display:inline;">
        </div>
    <div class="title" style="display:inline;"><asp:Button runat="server" 
            ID="btnExcluir" Text="Excluir Proteção" onclick="btnExcluir_Click" /></div>
    <div class="title" style="display:inline;"><asp:Button runat="server" 
            ID="btnPesquisar" Text="Pesquisar Proteção" onclick="btnPesquisar_Click" /></div>
    </div>
    </center>
    </div>
    <br />
    <asp:GridView runat="server" ID="gridProtecao" CssClass="gridArmaMuni" 
    BackColor="WindowFrame" BorderStyle="Solid" BorderColor="Black" BorderWidth="2px" 
    Width="1500px"></asp:GridView>
    <br />
    </center>
    </form>
    </body>  
</html>
