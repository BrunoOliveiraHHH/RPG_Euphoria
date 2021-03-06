﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="RPG_Euphoria.Menu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" lang="pt-br">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta http-equiv="X-UA-Compatible" content="ie=edge" />
    <title>O Inicio do Fim</title>
    <link rel="stylesheet" href="assets/css/style.css" />
    <link rel="stylesheet" href="assets/css/main.css" />
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
    </form>
 </body>   
</html>
