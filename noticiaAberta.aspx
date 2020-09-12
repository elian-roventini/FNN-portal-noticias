<%@ Page Title="" Language="C#" MasterPageFile="~/fnn.Master" AutoEventWireup="true" CodeBehind="noticiaAberta.aspx.cs" Inherits="prjFNN.noticiaAberta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="css/estiloPaginaAberta.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="mainPA">
		<div class="col1">
			<h2 class="tituloNoticia">Trump diz que apoia Brasil na OCDE e vai discutir ação militar na Venezuela.</h2>
			<div class="mainContBloco">
					<img class="col1Img" src="images/noticias/1.jpg">
					<h3 class="linhaFina">Presidente americano também declarou apoio à entrada do Brasil na OCDE. Líderes tiveram encontro a portas fechadas na Casa Branca.</h3>
				</div>
			</div>

		<div class="boxNoticia">
			<p class="noticia">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis sit amet arcu sed turpis tempus feugiat ac eget odio. Quisque ut placerat velit, quis convallis ante. Curabitur pretium porttitor erat, quis aliquam neque commodo non. Nullam nibh arcu, pretium a gravida eget, condimentum quis nunc. Suspendisse potenti. Ut sit amet purus sem.<br><br>

			Mauris facilisis nulla sed tincidunt rutrum. Pellentesque lacus lorem, viverra sed leo eget, tristique aliquam nibh. Pellentesque bibendum dui at risus consequat facilisis. Phasellus id tellus et risus vestibulum placerat. In varius fringilla purus, ac facilisis diam viverra non. Etiam sit amet faucibus dolor, at pellentesque turpis. Nam mi eros, vestibulum vel rhoncus non, feugiat vitae dui.<br><br>

			Nulla facilisi. Morbi quis sollicitudin mi. Sed a pellentesque justo, sed interdum mi. In at vestibulum felis, sit amet porta arcu. Aliquam metus lectus, euismod in lectus id, facilisis faucibus metus. Nunc hendrerit vehicula velit. Vestibulum molestie sem id massa fermentum congue.<br><br></p>
		</div>

		<div class="col3">
				<div class="col3Bloco fl">
				<a href="noticiaAberta.aspx?n=2"><img class="col3Img" src="images/noticias/2.jpg"></a>
					<h3 class="tituloNoticia">Novo material pode substituir transplante de medula, diz estudo</h3>
					<p class="linhaFina">Russos desenvolveram revestimento capaz de restaurar estrutura interna de ossos.</p>
				</div>

				<div class="col3Bloco fl">
				<a href="noticiaAberta.aspx?n=3"><img class="col3Img" src="images/noticias/3.jpg"></a>
					<h3 class="tituloNoticia">Presidente do Cazaquistão renuncia após 30 anos no poder</h3>
					<p class="linhaFina">Nursultan Nazarbayev seguirá como líder do partido que domina o parlamento.</p>
				</div>

				<div class="col3Bloco fl">
				<a href="noticiaAberta.aspx?n=4"><img class="col3Img" src="images/noticias/4.jpg"></a>
					<h3 class="tituloNoticia">Após bater 100 mil pontos pela 1º vez ontem, Bolsa opera em queda</h3>
					<p class="linhaFina">Investidores aguardam envio da proposta de Previdência dos militares ao Congresso, previsto para amanhã.</p>
				</div>
			<div class="cls"></div>
		</div>
	</div>

</asp:Content>
