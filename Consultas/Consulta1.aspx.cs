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
        //en la base de datos las tablas (Usuarios, Consultas y Publicaciones) estan conectadas 
        //La problematica nos presenta "Al seleccionar a un usuario queremos que nos muestre las consultas que ha echo"
        //Por esa razon tomamos estas tres tablas (listas) ya que vamos a hacer un recorrido entre tablas de usuarios hasta publicaciones

        //Para una consulta en LINQ primero debemos colocar las listas que vamos a ocupar 
        Logica_Negocio LN = null;
        List<Usuarios> Lista_Usuarios = new List<Usuarios>();
        List<Consulta> Lista_Consulta = new List<Consulta>();
        List<Publicaciones> Lista_Publicaciones = new List<Publicaciones>();

        string msj = "", msjc = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            //Al momento de cargar la pagina lo que quiero que haga es que recupere la lista de usuarios 
            if (!IsPostBack)
            {
                LN = new Logica_Negocio(ConfigurationManager.ConnectionStrings["BibliotecaBD"].ConnectionString);
                Session["negocioServer"] = LN;
                Lista_Usuarios = LN.L_Usuarios(ref msj, ref msjc);
                DropDownList1.Items.Add("");//ya que al momento de seleccionar en el dropdown nos van a estar apareciendo los nombres que tine esa tabla(lista)
                for (int i = 0; i < Lista_Usuarios.Count; i++)
                {
                    DropDownList1.Items.Add(Lista_Usuarios[i].Nombre);//esta linea de codigo determina que es lo que vamos a recuperar de la lista, en este caso el nombre
                }
            }
            else
            {
                LN = (Logica_Negocio)Session["negocioServer"];
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();//Limpiamos el lisbox

            string msj = "", msjc="",consult="", publi="", numin=""; //colocamos variables que vayamos a utilizar
            int users;// esta variable se coloco para que en "IdUsuario" no se tenga que poner el.ToString

            numin = DropDownList1.SelectedItem.Text;//El numin es la variable que utilizaremos para que lo que se seleccione en el drop se almacene en esta variable 

            //Lenamos las listas
            Lista_Consulta = LN.L_Consulta(ref msj, ref msjc);
            Lista_Publicaciones = LN.L_Publicaciones(ref msj, ref msjc);
            Lista_Usuarios = LN.L_Usuarios(ref msj, ref msjc);

            //Aqui queremos que users sea igual a la lista de usuarios mientras que sea igual al nombre de lo que traigo en numin
            //es decir que lo que traiga de numin que es la seleccion del drop empate con lo que estoy buscando en la consulta 
            //para que en "FirstOrDefault" pueda traer o recuperar el ID del usuario 
            users = Lista_Usuarios.Where(x => x.Nombre == numin).FirstOrDefault().IdUsuario;//aqui se esta ocupando la tabla de usuarios

            //Label segunda consulta sera parecida a la primera con la diferencia de que lo voy a comparar con lo que traiga la variable "consult"
            //que en este caso esa variable trae el id del usuario
            //para que en "FirstOrDefault" pueda traer o recuperar el ID de la publicacion
            consult = Lista_Consulta.Where(x => x.IdUsuario == users).FirstOrDefault().IdPublicacion.ToString();//aqui se esta ocupando la tabla de consultas

            //Para terminar se va a hacer el mismo procedimiento que en las consultas anteriores pero ahora con la tabla de publicaciones 
            //en este caso lo vamos a comprarar con la variable consult que empare con el id de publicaciones 
            //para que en "FirstOrDefault" pueda traer o recuperar el titulo de la publicacion
            publi = Lista_Publicaciones.Where(x => x.IdPublicacion.ToString() == consult).FirstOrDefault().Titulo;//aqui se esta ocupando la tabla de consultas

            //ultimo pasoen el listbox es lo que queremos mostrar 
            //en este caso queremos mostrar que consulta o que libro consulto el usuario 
            //por esa razon la variable public que es la que trae el titulo del libro es la que colocaremos
            ListBox1.Items.Add("Su consulta fue de = " + publi );

            //al momento de ejecutar el programa se podra mostrar lo que se necesita 
        }
    }
}