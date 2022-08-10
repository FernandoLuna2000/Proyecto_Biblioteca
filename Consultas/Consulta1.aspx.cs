using DLL;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Biblioteca.Consultas
{
    public partial class Consulta1 : System.Web.UI.Page
    {
        Logica_Negocio LN = null;
        List<Usuarios> Lista_Usuarios = new List<Usuarios>();
        List<Consulta> Lista_Consulta = new List<Consulta>();
        List<Publicaciones> Lista_Publicaciones = new List<Publicaciones>();

        string msj = "", msjc = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LN = new Logica_Negocio(ConfigurationManager.ConnectionStrings["BibliotecaBD"].ConnectionString);
                Session["negocioServer"] = LN;
                Lista_Usuarios = LN.L_Usuarios(ref msj, ref msjc);
                DropDownList1.Items.Add("");
                for (int i = 0; i < Lista_Usuarios.Count; i++)
                {
                    DropDownList1.Items.Add(Lista_Usuarios[i].IdUsuario.ToString());
                }
            }
            else
            {
                LN = (Logica_Negocio)Session["negocioServer"];
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();

            string msj = "", msjc="", users="",consult="", publi="", numin="";

            Lista_Consulta = LN.L_Consulta(ref msj, ref msjc);
            Lista_Publicaciones = LN.L_Publicaciones(ref msj, ref msjc);
            Lista_Usuarios = LN.L_Usuarios(ref msj, ref msjc);

            users = Lista_Usuarios.Where(x => x.Nombre == numin).FirstOrDefault().Nombre;
            consult = Lista_Consulta.Where(x => x.IdUsuario.ToString() == users).FirstOrDefault().IdPublicacion.ToString();
            publi = Lista_Publicaciones.Where(x => x.IdPublicacion.ToString() == consult).FirstOrDefault().Titulo;

            ListBox1.Items.Add("Su consulta fue de = " + publi );
        }
    }
}