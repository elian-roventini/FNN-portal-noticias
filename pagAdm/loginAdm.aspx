<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginAdm.aspx.cs" Inherits="prjFNN.pagAdm.loginAdm" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Login Admin</title>
    <meta charset="utf-8" />
    <link href="../css/estiloLogin.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="principal">
		    <div class="contPrincipal">
			    <table border="1" align="center" class="tabela">
				    <tr>
					    <td colspan="2" class="nomeTabela">Login</td>
				    </tr>

				    <tr>
					    <td>Usuário: </td>
					    <td>
						    <%--<input type="text" name="login" placeholder="Digite o login aqui..." />--%>
                            <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
					    </td>
				    </tr>

				    <tr>
					    <td>Senha: </td>
					    <td>
						    <%--<input type="password" name="senha" placeholder="Digite a senha...">--%>
                            <asp:TextBox ID="txtSenha" runat="server" type="password"></asp:TextBox>
					    </td>
				    </tr>
						
				    <tr>
					    <td colspan="2">
						    <%--<input type="submit" name="Entrar" id="btnEnviar">--%>
                            <asp:Button ID="btnEnviar" runat="server" Text="Entrar" onclick="btnEnviar_Click" />
					    </td>
				    </tr>

			    </table>
                <asp:Label ID="lblErro" runat="server" Text=""></asp:Label>
		    </div>
	    </div>
    </form>
</body>
</html>
