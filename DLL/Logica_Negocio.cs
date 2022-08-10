using DAL;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class Logica_Negocio
    {
        private Acceso_Datos AC = null;

        private Visualizar READ = null;
        private Insertar CREATE = null;
        private Actualizar UPDATE = null;
        private Eliminar DELETE = null;
        public Logica_Negocio(string connection)
        {
            AC = new Acceso_Datos(connection);
            READ = new Visualizar(connection);
            CREATE = new Insertar(connection);
            UPDATE = new Actualizar(connection);
            DELETE = new Eliminar(connection);
        }

        public List<Consulta> L_Consulta(ref string mensaje, ref string mensajeC)
        {
            return READ.ListaConsulta(ref mensaje, ref mensajeC);
        }
        public List<Monografias> L_Monografias(ref string mensaje, ref string mensajeC)
        {
            return READ.ListaMonograficas(ref mensaje, ref mensajeC);
        }
        public List<Prestamo> L_Prestamo(ref string mensaje, ref string mensajeC)
        {
            return READ.ListaPrestamo(ref mensaje, ref mensajeC);
        }
        public List<Publicaciones> L_Publicaciones(ref string mensaje, ref string mensajeC)
        {
            return READ.ListaPublicaciones(ref mensaje, ref mensajeC);
        }
        public List<Revistas> L_Revistas(ref string mensaje, ref string mensajeC)
        {
            return READ.ListaRevistas(ref mensaje, ref mensajeC);
        }
        public List<Textos> L_Textos(ref string mensaje, ref string mensajeC)
        {
            return READ.ListaTextos(ref mensaje, ref mensajeC);
        }
        public List<Usuarios> L_Usuarios(ref string mensaje, ref string mensajeC)
        {
            return READ.ListaUsuarios(ref mensaje, ref mensajeC);
        }

        public DataTable tablaConsulta(ref string mensaje, ref string mensajeC)
        {
            string comandoMySql = "select * from consulta;", etiqueta = "Biblioteca3";
            DataSet dataSet = null;
            DataTable dataTable = null;


            dataSet = AC.LecturaSet(comandoMySql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);
            if (dataSet != null)
            {
                dataTable = dataSet.Tables[0];
            }
            return dataTable;
        }
        public DataTable tablaMonografica(ref string mensaje, ref string mensajeC)
        {
            string comandoMySql = "select * from monografia;", etiqueta = "Biblioteca3";
            DataSet dataSet = null;
            DataTable dataTable = null;


            dataSet = AC.LecturaSet(comandoMySql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);
            if (dataSet != null)
            {
                dataTable = dataSet.Tables[0];
            }
            return dataTable;
        }

        public string Insert_Consulta(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            string resp = "";
            if (!CREATE.InsertarConsulta(nuevoDatos, ref mensaje, ref mensajeC))
            {
                resp = "Error";

            }
            else
            {
                resp = "Insercion Exitosa";
            }
            return resp;
        }
        public string Insert_Monografias(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            string resp = "";
            if (!CREATE.InsertarMonografias(nuevoDatos, ref mensaje, ref mensajeC))
            {
                resp = "Error";

            }
            else
            {
                resp = "Insercion Exitosa";
            }
            return resp;
        }
        public string Insert_Prestamo(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            string resp = "";
            if (!CREATE.InsertarPrestamo(nuevoDatos, ref mensaje, ref mensajeC))
            {
                resp = "Error";

            }
            else
            {
                resp = "Insercion Exitosa";
            }
            return resp;
        }
        public string Insert_Publicaciones(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            string resp = "";
            if (!CREATE.InsertarPublicaciones(nuevoDatos, ref mensaje, ref mensajeC))
            {
                resp = "Error";

            }
            else
            {
                resp = "Insercion Exitosa";
            }
            return resp;
        }
        public string Insert_Revistas(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            string resp = "";
            if (!CREATE.InsertarRevistas(nuevoDatos, ref mensaje, ref mensajeC))
            {
                resp = "Error";

            }
            else
            {
                resp = "Insercion Exitosa";
            }
            return resp;
        }
        public string Insert_Textos(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            string resp = "";
            if (!CREATE.InsertarTextos(nuevoDatos, ref mensaje, ref mensajeC))
            {
                resp = "Error";

            }
            else
            {
                resp = "Insercion Exitosa";
            }
            return resp;
        }
        public string Insert_Usuarios(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            string resp = "";
            if (!CREATE.InsertarUsuarios(nuevoDatos, ref mensaje, ref mensajeC))
            {
                resp = "Error";

            }
            else
            {
                resp = "Insercion Exitosa";
            }
            return resp;
        }

        public string Act_Consulta(string[] nuevoDatos, ref string mensaje, ref string mensajeC, int id)
        {
            string resp = "";
            if (!UPDATE.ActualizarConsulta(nuevoDatos, ref mensaje, ref mensajeC, id))
            {
                resp = "Error";

            }
            else
            {
                resp = "Actualizacion Exitosa";
            }
            return resp;
        }
        public string Act_Monografias(string[] nuevoDatos, ref string mensaje, ref string mensajeC, int id)
        {
            string resp = "";
            if (!UPDATE.ActualizarMonografias(nuevoDatos, ref mensaje, ref mensajeC, id))
            {
                resp = "Error";

            }
            else
            {
                resp = "Actualizacion Exitosa";
            }
            return resp;
        }
        public string Act_Prestamo(string[] nuevoDatos, ref string mensaje, ref string mensajeC, int id)
        {
            string resp = "";
            if (!UPDATE.ActualizarPrestamo(nuevoDatos, ref mensaje, ref mensajeC, id))
            {
                resp = "Error";

            }
            else
            {
                resp = "Actualizacion Exitosa";
            }
            return resp;
        }
        public string Act_Publicaciones(string[] nuevoDatos, ref string mensaje, ref string mensajeC, int id)
        {
            string resp = "";
            if (!UPDATE.ActualizarPublicaciones(nuevoDatos, ref mensaje, ref mensajeC, id))
            {
                resp = "Error";

            }
            else
            {
                resp = "Actualizacion Exitosa";
            }
            return resp;
        }
        public string Act_Revistas(string[] nuevoDatos, ref string mensaje, ref string mensajeC, int id)
        {
            string resp = "";
            if (!UPDATE.ActualizarRevistas(nuevoDatos, ref mensaje, ref mensajeC, id))
            {
                resp = "Error";

            }
            else
            {
                resp = "Actualizacion Exitosa";
            }
            return resp;
        }
        public string Act_Textos(string[] nuevoDatos, ref string mensaje, ref string mensajeC, int id)
        {
            string resp = "";
            if (!UPDATE.ActualizarTextos(nuevoDatos, ref mensaje, ref mensajeC, id))
            {
                resp = "Error";

            }
            else
            {
                resp = "Actualizacion Exitosa";
            }
            return resp;
        }
        public string Act_Usuarios(string[] nuevoDatos, ref string mensaje, ref string mensajeC, int id)
        {
            string resp = "";
            if (!UPDATE.ActualizarUsuarios(nuevoDatos, ref mensaje, ref mensajeC, id))
            {
                resp = "Error";

            }
            else
            {
                resp = "Actualizacion Exitosa";
            }
            return resp;
        }

        public string Elim_Consulta(ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!DELETE.EliminarConsulta(ref Mensaje, ref MensajeC, ID))
            {
                resp = "Error";

            }
            else
            {
                resp = "Eliminacion Exitosa";
            }
            return resp;
        }
        public string Elim_Monografia(ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!DELETE.EliminarMonografias(ref Mensaje, ref MensajeC, ID))
            {
                resp = "Error";

            }
            else
            {
                resp = "Eliminacion Exitosa";
            }
            return resp;
        }
        public string Elim_Prestamo(ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!DELETE.EliminarPrestamo(ref Mensaje, ref MensajeC, ID))
            {
                resp = "Error";

            }
            else
            {
                resp = "Eliminacion Exitosa";
            }
            return resp;
        }
        public string Elim_Publicaciones(ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!DELETE.EliminarPublicaciones(ref Mensaje, ref MensajeC, ID))
            {
                resp = "Error";

            }
            else
            {
                resp = "Eliminacion Exitosa";
            }
            return resp;
        }
        public string Elim_Revistas(ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!DELETE.EliminarRevistas(ref Mensaje, ref MensajeC, ID))
            {
                resp = "Error";

            }
            else
            {
                resp = "Eliminacion Exitosa";
            }
            return resp;
        }
        public string Elim_Textos(ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!DELETE.EliminarTextos(ref Mensaje, ref MensajeC, ID))
            {
                resp = "Error";

            }
            else
            {
                resp = "Eliminacion Exitosa";
            }
            return resp;
        }
        public string Elim_Usuarios(ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!DELETE.EliminarUsuarios(ref Mensaje, ref MensajeC, ID))
            {
                resp = "Error";

            }
            else
            {
                resp = "Eliminacion Exitosa";
            }
            return resp;
        }

        
    }
}
