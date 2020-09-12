using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using prjFNN.classes;

namespace prjFNN
{
    public partial class fnn : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<string> codigos = new List<string>();
            List<string> nomes = new List<string>();
            clsNoticia noticia = new clsNoticia();

            #region Menu com Base nas Categorias do DataBase
                if (!noticia.buscarCategorias(ref codigos, ref nomes))
                {
                    return;
                }

                for (int i = 0; i < nomes.Count; i++)
                {
                    litItens.Text += "<p><a class='linkHeader' href='index.aspx?c=" + codigos[i] + "'>" + nomes[i] + "</a></p>";
                }
            #endregion
        }
    }
}