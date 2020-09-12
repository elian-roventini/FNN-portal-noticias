<%@ Page Title="" Language="C#" MasterPageFile="~/pagAdm/adm.Master" AutoEventWireup="true" CodeBehind="contasAdm.aspx.cs" Inherits="prjFNN.pagAdm.contasAdm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/estiloContas.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="principalContas">
        <div class="contas_box">
            <div class="contas_box--barraAdmin">Administrador Logado</div>
            <div class="contas_box--boxAdmin">
                <div class="admin">
                    <%--<div class="nomeAdmin">AAAAAAAAAAA</div>--%>
                    <asp:Panel ID="pnlNomes" runat="server">
                    </asp:Panel>
                    <%--<div class="nomeAdmin">AAAAAAAAAAA</div>
                    <div class="nomeAdmin">AAAAAAAAAAA</div>--%>
                </div>
            </div>
            <div class="contas_box--barraAutores">Autores</div>
            <div class="contas_box--boxAutores">

                <asp:Literal ID="litAutores" runat="server"></asp:Literal>
                
            </div>
        </div>
    </div>

</asp:Content>
