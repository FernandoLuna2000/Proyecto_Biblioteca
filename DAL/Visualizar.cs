using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Visualizar
    {
        private Acceso_Datos AC = null;
        public Visualizar(string connection)
        {
            AC = new Acceso_Datos(connection);
        }

        public List<Consulta> ListaConsulta(ref string mensaje, ref string mensajeC)//Metodo de la Lista Consulta
        {
            string comandoSql = "select * from consulta;", etiqueta = "Biblioteca3";//Variables y Utilidades
            DataSet dataSet = null;
            DataTable dataTable = null;

            List<Consulta> consulta = new List<Consulta>();//Creacion de una lista del tipo Actualizacion para trabajar

            dataSet = AC.LecturaSet(comandoSql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);//Se llena el DataSet con los datos de la BD
            if (dataSet != null)//Si e DataSet tiene datos entonces
            {
                dataTable = dataSet.Tables[0];//Se crea un DataTable y se llena con la informacion del DataSet
                consulta = dataTable.AsEnumerable().Select(row => new Consulta//El datatable es como un numerable y se hace una seleccion, cada row será igual a un nuevo objeto de a clase seleccionada
                {//Por cada iterancia vamos a pasar los parámetros de mi objeto
                    IdUsuario = row.Field<int>("id_usuario"),
                    IdPublicacion = row.Field<int>("id_publicacion"),
                }).ToList();//Se añade la información a la Lista
            }
            return consulta;//Se retorna la Lista 
        }
        public List<Monografias> ListaMonograficas(ref string mensaje, ref string mensajeC)//Metodo de la Lista Consulta
        {
            string comandoSql = "select * from monografias;", etiqueta = "Biblioteca3";//Variables y Utilidades
            DataSet dataSet = null;
            DataTable dataTable = null;

            List<Monografias> monografias = new List<Monografias>();//Creacion de una lista del tipo Actualizacion para trabajar

            dataSet = AC.LecturaSet(comandoSql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);//Se llena el DataSet con los datos de la BD
            if (dataSet != null)//Si e DataSet tiene datos entonces
            {
                dataTable = dataSet.Tables[0];//Se crea un DataTable y se llena con la informacion del DataSet
                monografias = dataTable.AsEnumerable().Select(row => new Monografias//El datatable es como un numerable y se hace una seleccion, cada row será igual a un nuevo objeto de a clase seleccionada
                {//Por cada iterancia vamos a pasar los parámetros de mi objeto
                    IdPublicacion = row.Field<int>("id_publicacion"),
                    NombreMono = row.Field<string>("nombre_mono"),
                }).ToList();//Se añade la información a la Lista
            }
            return monografias;//Se retorna la Lista 
        }
        public List<Prestamo> ListaPrestamo(ref string mensaje, ref string mensajeC)//Metodo de la Lista Consulta
        {
            string comandoSql = "select * from prestamo;", etiqueta = "Biblioteca3";//Variables y Utilidades
            DataSet dataSet = null;
            DataTable dataTable = null;

            List<Prestamo> prestamos = new List<Prestamo>();//Creacion de una lista del tipo Actualizacion para trabajar

            dataSet = AC.LecturaSet(comandoSql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);//Se llena el DataSet con los datos de la BD
            if (dataSet != null)//Si e DataSet tiene datos entonces
            {
                dataTable = dataSet.Tables[0];//Se crea un DataTable y se llena con la informacion del DataSet
                prestamos = dataTable.AsEnumerable().Select(row => new Prestamo//El datatable es como un numerable y se hace una seleccion, cada row será igual a un nuevo objeto de a clase seleccionada
                {//Por cada iterancia vamos a pasar los parámetros de mi objeto
                    IdPrestamo = row.Field<int>("id_prestamos"),
                    FechaInicioPrestamo = row.Field<DateTime>("fecha_inicio_prestamo"),
                    FechaDevolucion = row.Field<DateTime>("fecha_devolucion"),
                    IdUsuario = row.Field<int>("id_usuario"),
                }).ToList();//Se añade la información a la Lista
            }
            return prestamos;//Se retorna la Lista 
        }
        public List<Publicaciones> ListaPublicaciones(ref string mensaje, ref string mensajeC)//Metodo de la Lista Consulta
        {
            string comandoSql = "select * from publicaciones;", etiqueta = "Biblioteca3";//Variables y Utilidades
            DataSet dataSet = null;
            DataTable dataTable = null;

            List<Publicaciones> publicaciones = new List<Publicaciones>();//Creacion de una lista del tipo Actualizacion para trabajar

            dataSet = AC.LecturaSet(comandoSql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);//Se llena el DataSet con los datos de la BD
            if (dataSet != null)//Si e DataSet tiene datos entonces
            {
                dataTable = dataSet.Tables[0];//Se crea un DataTable y se llena con la informacion del DataSet
                publicaciones = dataTable.AsEnumerable().Select(row => new Publicaciones//El datatable es como un numerable y se hace una seleccion, cada row será igual a un nuevo objeto de a clase seleccionada
                {//Por cada iterancia vamos a pasar los parámetros de mi objeto
                    IdPublicacion = row.Field<int>("id_publicacion"),
                    Titulo = row.Field<string>("titulo"),
                    NumEjemplar = row.Field<int>("num_ejemplar"),
                }).ToList();//Se añade la información a la Lista
            }
            return publicaciones;//Se retorna la Lista 
        }
        public List<Revistas> ListaRevistas(ref string mensaje, ref string mensajeC)//Metodo de la Lista Consulta
        {
            string comandoSql = "select * from revistas;", etiqueta = "Biblioteca3";//Variables y Utilidades
            DataSet dataSet = null;
            DataTable dataTable = null;

            List<Revistas> revistas = new List<Revistas>();//Creacion de una lista del tipo Actualizacion para trabajar

            dataSet = AC.LecturaSet(comandoSql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);//Se llena el DataSet con los datos de la BD
            if (dataSet != null)//Si e DataSet tiene datos entonces
            {
                dataTable = dataSet.Tables[0];//Se crea un DataTable y se llena con la informacion del DataSet
                revistas = dataTable.AsEnumerable().Select(row => new Revistas//El datatable es como un numerable y se hace una seleccion, cada row será igual a un nuevo objeto de a clase seleccionada
                {//Por cada iterancia vamos a pasar los parámetros de mi objeto
                    IdPublicacion = row.Field<int>("id_publicacion"),
                    NumArticulos = row.Field<int>("num_articulos"),
                    PagComienzo = row.Field<int>("pag_comienzo"),
                    PagTerminacion = row.Field<int>("pag_terminacion"),
                }).ToList();//Se añade la información a la Lista
            }
            return revistas;//Se retorna la Lista 
        }
        public List<Textos> ListaTextos(ref string mensaje, ref string mensajeC)//Metodo de la Lista Consulta
        {
            string comandoSql = "select * from textos;", etiqueta = "Biblioteca3";//Variables y Utilidades
            DataSet dataSet = null;
            DataTable dataTable = null;

            List<Textos> textos = new List<Textos>();//Creacion de una lista del tipo Actualizacion para trabajar

            dataSet = AC.LecturaSet(comandoSql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);//Se llena el DataSet con los datos de la BD
            if (dataSet != null)//Si e DataSet tiene datos entonces
            {
                dataTable = dataSet.Tables[0];//Se crea un DataTable y se llena con la informacion del DataSet
                textos = dataTable.AsEnumerable().Select(row => new Textos//El datatable es como un numerable y se hace una seleccion, cada row será igual a un nuevo objeto de a clase seleccionada
                {//Por cada iterancia vamos a pasar los parámetros de mi objeto
                    IdPublicacion = row.Field<int>("id_publicacion"),
                    Autor = row.Field<string>("autor"),
                    Editorial = row.Field<string>("editorial"),
                    NumPaginas = row.Field<int>("num_paginas"),
                }).ToList();//Se añade la información a la Lista
            }
            return textos;//Se retorna la Lista 
        }
        public List<Usuarios> ListaUsuarios(ref string mensaje, ref string mensajeC)//Metodo de la Lista Consulta
        {
            string comandoSql = "select * from usuarios;", etiqueta = "Biblioteca3";//Variables y Utilidades
            DataSet dataSet = null;
            DataTable dataTable = null;

            List<Usuarios> usuarios = new List<Usuarios>();//Creacion de una lista del tipo Actualizacion para trabajar

            dataSet = AC.LecturaSet(comandoSql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);//Se llena el DataSet con los datos de la BD
            if (dataSet != null)//Si e DataSet tiene datos entonces
            {
                dataTable = dataSet.Tables[0];//Se crea un DataTable y se llena con la informacion del DataSet
                usuarios = dataTable.AsEnumerable().Select(row => new Usuarios//El datatable es como un numerable y se hace una seleccion, cada row será igual a un nuevo objeto de a clase seleccionada
                {//Por cada iterancia vamos a pasar los parámetros de mi objeto
                    IdUsuario = row.Field<int>("id_usuario"),
                    Nombre = row.Field<string>("nombre"),
                    Colonia = row.Field<string>("colonia"),
                    Cp = row.Field<int>("cp"),
                    //NomCentroTrabajo = row.Field<string>("nom_centro Trabajo"),
                    Telefono = row.Field<string>("telefono"),
                }).ToList();//Se añade la información a la Lista
            }
            return usuarios;//Se retorna la Lista 
        }
    }
}
