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
    public partial class contasAdm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login"] == null)
            {
                Response.Redirect("loginAdm.aspx");
            }

            #region Administrador Logado
                Label lblNome = new Label();
                lblNome.CssClass = "nomeAdmin";
                lblNome.ID = "nomeAdmin";
                lblNome.Text = Session["nome"].ToString();

                Panel pnlNome = new Panel();
                pnlNome.ID = "pnlNome";
                pnlNome.Controls.Add(lblNome);

                pnlNomes.Controls.Add(pnlNome);
            #endregion

            #region Mostrando Autores
                List<string> autores = new List<string>();
                clsNoticia noticia = new clsNoticia();

                if (!noticia.listarAutores(ref autores))
                {
                    return;
                }

                for (int i = 0; i < autores.Count; i++)
                {
                    litAutores.Text = "<p>" + autores[i] + "</p>";
                }
            #endregion


        }
    }
}