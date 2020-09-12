using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using prjFNN.classes;
using MySql.Data.MySqlClient;
using System.IO;

namespace prjFNN
{
    public partial class teste : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //int qtd = 0;

            //clsNoticia noticia = new clsNoticia();
            //List<string> codigosNoticias = new List<string>();

            //string categoriaEspecifica = "";

            //if (Request["c"] != null)
            //{
            //    if (Request["c"].ToString() != "")
            //    {
            //        categoriaEspecifica = Request["c"].ToString();
            //    }
            //}

            //if (categoriaEspecifica == "")
            //{
            //    if (!noticia.listarCodigosNoticias(ref codigosNoticias))
            //    {
            //        return;
            //    }
            //}
            //else
            //{
            //    if (!noticia.listarCodigosNoticias(ref codigosNoticias, categoriaEspecifica))
            //    {
            //        return;
            //    }
            //}

            //for (int i = 0; i < codigosNoticias.Count; i++)
            //{
            //    //noticia.carregaNoticia(codigosNoticias[i]);

            //    #region Noticias Criadas Dinamicamente
            //    Label lblTituloNoticia = new Label();
            //    lblTituloNoticia.CssClass = "tituloNoticia";
            //    lblTituloNoticia.ID = "tituloNoticia_" + noticia.cd_noticia;
            //    lblTituloNoticia.Text = noticia.nm_titulo;

            //    Label lblLinhaFina = new Label();
            //    lblLinhaFina.CssClass = "linhaFina";
            //    lblLinhaFina.ID = "linhaFina_" + noticia.cd_noticia;
            //    lblLinhaFina.Text = noticia.nm_linha_fina;

            //    Panel pnlTituloNoticia = new Panel();
            //    pnlTituloNoticia.ID = "pnlTituloNoticia";
            //    pnlTituloNoticia.Controls.Add(lblTituloNoticia);

            //    Panel pnlLinhaFina = new Panel();
            //    pnlLinhaFina.ID = "pnlLinhaFina";
            //    pnlLinhaFina.Controls.Add(lblLinhaFina);

            //    Image img_noticia = new Image();
            //    if (noticia.ic_destaque)
            //    {
            //        img_noticia.CssClass = "col1Img";
            //    }
            //    else
            //    {
            //        if (qtd <= 2)
            //        {
            //            img_noticia.CssClass = "col2Img";
            //            qtd++;
            //        }
            //        else
            //        {
            //            img_noticia.CssClass = "col3Img";
            //            qtd++;

            //            if (qtd == 6)
            //            {
            //                qtd = 0;
            //            }
            //        }
            //    }

            //    if (File.Exists(Request.PhysicalApplicationPath + @"\images\noticias\" + noticia.cd_noticia + ".jpg"))
            //    {
            //        img_noticia.ImageUrl = "~/images/noticias/" + noticia.cd_noticia + ".jpg";
            //    }

            //    HyperLink lnkNoticia = new HyperLink();
            //    lnkNoticia.ID = "link_" + noticia.cd_noticia;
            //    lnkNoticia.CssClass = "linkPadrao";
            //    lnkNoticia.Controls.Add(img_noticia);
            //    lnkNoticia.Controls.Add(pnlTituloNoticia);
            //    lnkNoticia.Controls.Add(pnlLinhaFina);

            //    Panel pnlNoticia = new Panel();
            //    pnlNoticia.ID = "noticia_" + noticia.cd_noticia;

            //    if (noticia.ic_destaque)
            //    {
            //        pnlNoticia.CssClass = "col1";
            //    }
            //    else
            //    {
            //        if (qtd <= 2)
            //        {
            //            pnlNoticia.CssClass = "col2";
            //            pnlNoticia.CssClass = "fl";
            //        }
            //        else
            //        {
            //            pnlNoticia.CssClass = "col3Bloco";
            //            pnlNoticia.CssClass = "fl";

            //            if (qtd == 6)
            //            {
            //                qtd = 0;
            //            }
            //        }
            //    }

            //    pnlNoticia.Controls.Add(lnkNoticia);
            //    #endregion

            //    pnlNoticia.Controls.Add(pnlNoticia);
            //}

        }
    }
}