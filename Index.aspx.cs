using DLL;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Biblioteca
{
    public partial class Index : System.Web.UI.Page
    {
        Logica_Negocio LN = null;
        string mensaje = "", mensajeC = "";
        List<Consulta> Lista_Consultas = new List<Consulta>();
        List<Monografias> Lista_Monografias = new List<Monografias>();
        List<Prestamo> Lista_Prestamo = new List<Prestamo>();
        List<Publicaciones> Lista_Publicaciones = new List<Publicaciones>();
        List<Revistas> Lista_Revistas = new List<Revistas>();
        List<Textos> Lista_Textos = new List<Textos>();
        List<Usuarios> Lista_Usuarios = new List<Usuarios>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LN = new Logica_Negocio(ConfigurationManager.ConnectionStrings["BibliotecaBD"].ConnectionString);
                Session["negocioServer"] = LN;
            }
            else
            {
                LN = (Logica_Negocio)Session["negocioServer"];
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Lista_Consultas = LN.L_Consulta(ref mensaje, ref mensajeC);
            for (int i = 0; i < Lista_Consultas.Count(); i++)
            {
                ListBox1.Items.Add(Lista_Consultas[i].IdUsuario.ToString());
                ListBox1.Items.Add(Lista_Consultas[i].IdPublicacion.ToString());
            }

            Lista_Monografias = LN.L_Monografias(ref mensaje, ref mensajeC);
            for (int i = 0; i < Lista_Monografias.Count(); i++)
            {
                ListBox2.Items.Add(Lista_Monografias[i].IdPublicacion.ToString());
                ListBox2.Items.Add(Lista_Monografias[i].NombreMono.ToString());
                
            }

            //Lista_Actualizacion = LN.L_Actualizacion(ref mensaje, ref mensajeC);
            //for (int i = 0; i < Lista_Actualizacion.Count(); i++)
            //{
            //    ListBox2.Items.Add(Lista_Actualizacion[i].IdAct.ToString());
            //    ListBox2.Items.Add(Lista_Actualizacion[i].NumInv.ToString());
            //    ListBox2.Items.Add(Lista_Actualizacion[i].NumSerie.ToString());
            //    ListBox2.Items.Add(Lista_Actualizacion[i].Descripcion.ToString());
            //    ListBox2.Items.Add(Lista_Actualizacion[i].Fecha.ToString());
            //}

            //Lista_Actualizacion = LN.L_Actualizacion(ref mensaje, ref mensajeC);
            //for (int i = 0; i < Lista_Actualizacion.Count(); i++)
            //{
            //    ListBox2.Items.Add(Lista_Actualizacion[i].IdAct.ToString());
            //    ListBox2.Items.Add(Lista_Actualizacion[i].NumInv.ToString());
            //    ListBox2.Items.Add(Lista_Actualizacion[i].NumSerie.ToString());
            //    ListBox2.Items.Add(Lista_Actualizacion[i].Descripcion.ToString());
            //    ListBox2.Items.Add(Lista_Actualizacion[i].Fecha.ToString());
            //}

            //Lista_Actualizacion = LN.L_Actualizacion(ref mensaje, ref mensajeC);
            //for (int i = 0; i < Lista_Actualizacion.Count(); i++)
            //{
            //    ListBox2.Items.Add(Lista_Actualizacion[i].IdAct.ToString());
            //    ListBox2.Items.Add(Lista_Actualizacion[i].NumInv.ToString());
            //    ListBox2.Items.Add(Lista_Actualizacion[i].NumSerie.ToString());
            //    ListBox2.Items.Add(Lista_Actualizacion[i].Descripcion.ToString());
            //    ListBox2.Items.Add(Lista_Actualizacion[i].Fecha.ToString());
            //}

            //Lista_Actualizacion = LN.L_Actualizacion(ref mensaje, ref mensajeC);
            //for (int i = 0; i < Lista_Actualizacion.Count(); i++)
            //{
            //    ListBox2.Items.Add(Lista_Actualizacion[i].IdAct.ToString());
            //    ListBox2.Items.Add(Lista_Actualizacion[i].NumInv.ToString());
            //    ListBox2.Items.Add(Lista_Actualizacion[i].NumSerie.ToString());
            //    ListBox2.Items.Add(Lista_Actualizacion[i].Descripcion.ToString());
            //    ListBox2.Items.Add(Lista_Actualizacion[i].Fecha.ToString());
            //}

            //Lista_Actualizacion = LN.L_Actualizacion(ref mensaje, ref mensajeC);
            //for (int i = 0; i < Lista_Actualizacion.Count(); i++)
            //{
            //    ListBox2.Items.Add(Lista_Actualizacion[i].IdAct.ToString());
            //    ListBox2.Items.Add(Lista_Actualizacion[i].NumInv.ToString());
            //    ListBox2.Items.Add(Lista_Actualizacion[i].NumSerie.ToString());
            //    ListBox2.Items.Add(Lista_Actualizacion[i].Descripcion.ToString());
            //    ListBox2.Items.Add(Lista_Actualizacion[i].Fecha.ToString());
            //}

            GridView1.DataSource = LN.tablaConsulta(ref mensaje, ref mensajeC);
            GridView1.DataBind();

            GridView2.DataSource = LN.tablaMonografica(ref mensaje, ref mensajeC);
            GridView2.DataBind();
        }
    }
}