<%@ Page Title="" Language="C#" MasterPageFile="~/pagAdm/adm.Master" AutoEventWireup="true" CodeBehind="gerenciarNoticias.aspx.cs" Inherits="prjFNN.pagAdm.gerenciarNoticias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/estiloGerenciarNoticia.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="principalGN">
     	<div class="noticias">
     		<div class="barraNoticias">
     			Gerenciar Notícias
     		</div>
     		<div class="noticias_box">
     			<div class="noticias_box--opcoes">
     				<a href="publicarNoticias.aspx">
     					<p>Publicar</p>
     				</a>
     				<a href="#">
     					<p>Editar Notícias</p>
     				</a>
     				<a href="#">
     					<p>Excluir</p>
     				</a>
     			</div>
     		</div>
     	</div>
     </div>

</asp:Content>
