<%@ Page Title="" Language="C#" MasterPageFile="~/pagAdm/adm.Master" AutoEventWireup="true" CodeBehind="alterarSenha.aspx.cs" Inherits="prjFNN.pagAdm.alterarSenha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/estiloAlterarSenha.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="principalSenha">
    	<div class="alterarSenha">
    		<div class="alterarSenha_box">
    			<form>
    				<label>
    					<p>Coloque sua senha atual:</p>
    		<div class="alterarSenha_barra">
    			Alterar Senha
    		</div>
    				</label>
    				<%--<input type="password" name="senhaAtual">--%>
                    <asp:TextBox ID="txtSenhaAtual" runat="server" type="password"></asp:TextBox>

    				<label>
    					<p>Coloque sua nova senha:</p>
    				</label>
    				<%--<input type="password" name="senhaNova"><br>--%>
                        <asp:TextBox ID="txtSenhaNova" runat="server" type="password"></asp:TextBox><br />

    				<%--<input type="submit" name="Alterar">--%>
                    <asp:Button ID="btnAlterar" runat="server" Text="Alterar" />

                    <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
    			</form>
    		</div>
    	</div>
    </div>

</asp:Content>
