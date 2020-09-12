<%@ Page Title="" Language="C#" MasterPageFile="~/pagAdm/adm.Master" AutoEventWireup="true" CodeBehind="publicarNoticias.aspx.cs" Inherits="prjFNN.pagAdm.publicarNoticias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/estiloPublicarNoticia.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="principalPN">
        <div class="contPrincipal">
            <div class="contNoticia">
                Publicar notícia
            </div>
            <form>
                <label><p>Título</p></label>
                <input type="text" name="titulo"><br>

                <label><p>Linha Fina</p></label>
                <textarea class="lfTextarea"></textarea>
                <br>

                <label><p>Nome do Autor</p></label>
                <select>
                    <option>Denzel</option>
                    <option>Felipe Mattos</option>
                    <option>Elian</option>
                </select><br>

                <label><p>Assunto</p></label>
                <select>
                    <option>Política</option>
                    <option>Entretenimento</option>
                    <option>Cultura</option>
                    <option>Esportes</option>
                    <option>Música</option>
                </select><br>

                <label><p>Noticia</p></label>
                <textarea class="nTextarea"></textarea>

                <input type="submit" name="Enviar" class="inputEnviar">
            </form>
        </div>
    </div>

</asp:Content>
