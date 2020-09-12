using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace prjFNN.classes
{
    public class clsNoticia:clsBD
    {
        public int cd_noticia { get; set; }
        public string nm_titulo { get; set; }
        public string nm_linha_fina { get; set; }
        public bool ic_destaque { get; set; }
        public string dt_noticia { get; set; }
        public string hr_noticia { get; set; }
        public string ds_noticia { get; set; }
        public int cd_autor { get; set; }
        public string nm_autor { get; set; }

        #region Construtores
            public clsNoticia():base()
            {
            }

            public clsNoticia(string s, string u, string sn, string db)
                : base(s, u, sn, db)
            {
            }
        #endregion

        #region Buscar as categorias
            public bool buscarCategorias(ref List<string> codigos, ref List<string> nomes)
            {
                bool deu = true;
                MySqlDataReader dados = null;
                if (!Consultar("Select * from categoria", ref dados))
                {
                    deu = false;
                }
                else
                {
                    codigos.Clear();
                    nomes.Clear();
                    if (dados.HasRows)
                    {
                        while (dados.Read())
                        {
                            codigos.Add(dados["cd_categoria"].ToString());
                            nomes.Add(dados["nm_categoria"].ToString());
                        }
                    }

                    if (!dados.IsClosed) { dados.Close(); }
                    Close();
                }

                return deu;
            }
        #endregion

        #region Cria uma lista com os codigos das noticias
            public bool listarCodigosNoticias(ref List<string> codigos)
            {
                string comando = "Select cd_noticia from noticia";
                MySqlDataReader dados = null;

                if (!Consultar(comando, ref dados))
                {
                    Close();
                    return false;
                }

                codigos.Clear();

                if (dados.HasRows)
                {
                    while (dados.Read())
                    {
                        codigos.Add(dados["cd_noticia"].ToString());
                    }
                }

                if (!dados.IsClosed) { dados.Close(); }

                Close();
                return true;
            }

            public bool listarCodigosNoticias(ref List<string> codigos, string categoria)
            {
                string comando = "Select cd_noticia from noticia";
                comando += " where cd_categoria = " + categoria;
                
                MySqlDataReader dados = null;

                if (!Consultar(comando, ref dados))
                {
                    Close();
                    return false;
                }

                codigos.Clear();

                if (dados.HasRows)
                {
                    while (dados.Read())
                    {
                        codigos.Add(dados["cd_noticia"].ToString());
                    }
                }

                if (!dados.IsClosed) { dados.Close(); }

                Close();
                return true;
            }
        #endregion

        #region Carregar noticia
            public bool carregaNoticia(string qual)
            {
                string comandoNoticia = "Select cd_noticia, nm_titulo, nm_linha_fina, ic_destaque";
                comandoNoticia += " from noticia where cd_noticia = " + qual;
                MySqlDataReader dados = null;

                if (!Consultar(comandoNoticia, ref dados))
                {
                    return false;
                }

                if (dados.HasRows)
                {
                    if (dados.Read())
                    {
                        cd_noticia = int.Parse(dados["cd_noticia"].ToString());
                        nm_titulo = dados["nm_titulo"].ToString();
                        nm_linha_fina = dados["nm_linha_fina"].ToString();
                        ic_destaque = bool.Parse(dados["ic_destaque"].ToString());
                    }
                }

                if (!dados.IsClosed) { dados.Close(); }

                Close();
                return true;
            }
        #endregion

            #region Cria uma lista com os nomes do autores
                public bool listarAutores(ref List<string> autores)
                {
                    string comando = "Select nm_autor from autor";
                    MySqlDataReader dados = null;

                    if (!Consultar(comando, ref dados))
                    {
                        Close();
                        return false;
                    }

                    autores.Clear();

                    if (dados.HasRows)
                    {
                        while (dados.Read())
                        {
                            autores.Add(dados["nm_autor"].ToString());
                        }
                    }

                    if (!dados.IsClosed) { dados.Close(); }

                    Close();
                    return true;
                }
            #endregion
    }
}