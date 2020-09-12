using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using prjFNN.classes;

namespace prjFNN.pagAdm
{
    public partial class loginAdm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login"] != null)
            {
                Session["login"] = "";
                Session["nome"] = "";
                Session.Abandon();
            }
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {

            #region Validar
            string LOGIN = "";
            string SENHA = "";

            txtUsuario.Text = txtUsuario.Text.Trim();

            if (txtUsuario.Text == "")
            {
                lblErro.Text = "Digite o login do usuário";
                txtUsuario.Focus();
                return;
            }

            txtSenha.Text = txtSenha.Text.Trim();

            if (txtSenha.Text == "")
            {
                lblErro.Text = "Digite a senha do usuário";
                txtSenha.Focus();
                return;
            }

            LOGIN = txtUsuario.Text;
            SENHA = txtSenha.Text;
            #endregion

            #region Entrando com o BD e Validando usuario e senha corretos
                string linhaConex = "SERVER=localhost;UID=root;PASSWORD=root;DATABASE=jornal";
                MySqlConnection conexao = new MySqlConnection(linhaConex);

                try
                {
                    conexao.Open();
                }
                catch
                {
                    lblErro.Text = "Falha na conexão ao Servidor";
                    return;
                }

                string comando = "Select * from usuario";
                MySqlCommand cSQL = new MySqlCommand(comando, conexao);
                MySqlDataReader dados = cSQL.ExecuteReader();

                if (dados.HasRows)
                {
                    bool achaste = false;

                    while (dados.Read())
                    {
                        if (LOGIN == dados["nm_login"].ToString() && SENHA == dados["nm_senha"].ToString())
                        {
                            achaste = true;
                            break;
                        }
                    }

                    if (achaste)
                    {
                        Session["login"] = LOGIN;
                        Session["nome"] = dados["nm_usuario"].ToString();
                        Response.Redirect("inicialAdm.aspx");
                    }
                    else
                    {
                        lblErro.Text = "Usuário e Senha Inválidos";
                        txtUsuario.Text = "";
                        txtSenha.Text = "";
                    }
                }

                if (!dados.IsClosed) { dados.Close(); }

                if (conexao.State == System.Data.ConnectionState.Open) { conexao.Close(); }
            #endregion

            //#region Var criated
            //    string usuarioValid = "";
            //    string senhaValid = "";
            //    bool existUsuario = false;
            //    bool existSenha = false;
            //    bool deu = false;
            //#endregion

            //#region Validação se está digitado
            //    txtUsuario.Text.Trim();
            //    if (txtUsuario.Text == "")
            //    {
            //        lblErro.Text = "Digite o usuário.";
            //        txtUsuario.Focus();
            //        return;
            //    }
            //    usuarioValid = txtUsuario.Text;
            //    txtSenha.Text.Trim();
            //    if (txtSenha.Text == "")
            //    {
            //        lblErro.Text = "Digite a senha.";
            //        txtSenha.Focus();
            //        return;
            //    }
            //    senhaValid = txtSenha.Text;
            //#endregion

            //#region Validação de usuário existente no banco
            //    clsBD banco = new clsBD();

            //    MySqlDataReader dados = null;

            //    if (!banco.Consultar("Select nm_login from usuario;", ref dados))
            //    {
            //        banco.Close();
            //        return;
            //    }
            //    if (dados.HasRows)
            //    {
            //        while (dados.Read())
            //        {
            //            if (usuarioValid == dados["nm_login"].ToString())
            //            {
            //                existUsuario = true;
            //                break;
            //            }
            //            else
            //            {
            //                lblErro.Text = "Usuário e/ou senha incorretos.";
            //                txtUsuario.Focus();
            //                txtUsuario.Text = "";
            //            }
            //        }
            //    }
            //    if (!dados.IsClosed) { dados.Close(); }
            //    banco.Close();
            //#endregion

            //#region Validação de senha correta
            //    if (!banco.Consultar("Select nm_senha from usuario;", ref dados))
            //    {
            //        banco.Close();
            //        return;
            //    }
            //    if (dados.HasRows)
            //    {
            //        while (dados.Read())
            //        {
            //            if (banco.Consultar("Select nm_senha from usuario where nm_login = " + validUser.ToString() + ";", ref dados))
            //            {
            //                dados.Read();
            //                if (senhaValid == dados["nm_senha"].ToString())
            //                {
            //                    existSenha = true;
            //                    deu = true;
            //                    break;
            //                }
            //                else
            //                {
            //                    lblErro.Text = "Usuário e/ou senha incorretos.";
            //                    txtUsuario.Focus();
            //                    txtUsuario.Text = "";
            //                    txtSenha.Text = "";
            //                }

            //            }

            //        }
            //    }
            //    if (!dados.IsClosed) { dados.Close(); }
            //    banco.Close();
            //#endregion

            //#region Certificando que deu certo para dar o acesso
            //        if (deu == true)
            //        {
            //            if (!banco.Consultar("Select * from usuario where nm_login = " + usuarioValid.ToString() + " and nm_senha = " + senhaValid.ToString() + ";", ref dados))
            //            {
            //                banco.Close();
            //                return;
            //            }
            //            if (dados.HasRows)
            //            {
            //                dados.Read();
            //                Session["usuario"] = dados["nm_usuario"].ToString();
            //                Session["nivelUsuario"] = dados["cd_tipo_usuario"].ToString();
            //                Response.Redirect("../teste.aspx");

            //            }
            //        }
            //        if (!dados.IsClosed) { dados.Close(); }
            //        banco.Close();
            //    #endregion
        }
    }
}