using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Eliminar
    {
        private Acceso_Datos AC = null;
        public Eliminar(string connection)
        {
            AC = new Acceso_Datos(connection);
        }

        public bool EliminarConsulta(ref string Mensaje, ref string MensajeC, int ID)
        {
            bool respuesta = false;

            string instruccion = "DELETE from consulta where num_inv = @num_inv";

            SqlParameter[] evaluacion = new SqlParameter[]
            {
                new SqlParameter("@num_inv",SqlDbType.Int)
            };

            evaluacion[0].Value = ID;

            respuesta = AC.BaseSegura(instruccion, AC.ConnectionEstablecida(ref MensajeC), ref Mensaje, evaluacion);

            return respuesta;
        }
        public bool EliminarMonografias(ref string Mensaje, ref string MensajeC, int ID)
        {
            bool respuesta = false;

            string instruccion = "DELETE from monografias where num_inv = @num_inv";

            SqlParameter[] evaluacion = new SqlParameter[]
            {
                new SqlParameter("@num_inv",SqlDbType.Int)
            };

            evaluacion[0].Value = ID;

            respuesta = AC.BaseSegura(instruccion, AC.ConnectionEstablecida(ref MensajeC), ref Mensaje, evaluacion);

            return respuesta;
        }
        public bool EliminarPrestamo(ref string Mensaje, ref string MensajeC, int ID)
        {
            bool respuesta = false;

            string instruccion = "DELETE from prestamo where num_inv = @num_inv";

            SqlParameter[] evaluacion = new SqlParameter[]
            {
                new SqlParameter("@num_inv",SqlDbType.Int)
            };

            evaluacion[0].Value = ID;

            respuesta = AC.BaseSegura(instruccion, AC.ConnectionEstablecida(ref MensajeC), ref Mensaje, evaluacion);

            return respuesta;
        }
        public bool EliminarPublicaciones(ref string Mensaje, ref string MensajeC, int ID)
        {
            bool respuesta = false;

            string instruccion = "DELETE from publicaciones where num_inv = @num_inv";

            SqlParameter[] evaluacion = new SqlParameter[]
            {
                new SqlParameter("@num_inv",SqlDbType.Int)
            };

            evaluacion[0].Value = ID;

            respuesta = AC.BaseSegura(instruccion, AC.ConnectionEstablecida(ref MensajeC), ref Mensaje, evaluacion);

            return respuesta;
        }
        public bool EliminarRevistas(ref string Mensaje, ref string MensajeC, int ID)
        {
            bool respuesta = false;

            string instruccion = "DELETE from revistas where num_inv = @num_inv";

            SqlParameter[] evaluacion = new SqlParameter[]
            {
                new SqlParameter("@num_inv",SqlDbType.Int)
            };

            evaluacion[0].Value = ID;

            respuesta = AC.BaseSegura(instruccion, AC.ConnectionEstablecida(ref MensajeC), ref Mensaje, evaluacion);

            return respuesta;
        }
        public bool EliminarTextos(ref string Mensaje, ref string MensajeC, int ID)
        {
            bool respuesta = false;

            string instruccion = "DELETE from textos where num_inv = @num_inv";

            SqlParameter[] evaluacion = new SqlParameter[]
            {
                new SqlParameter("@num_inv",SqlDbType.Int)
            };

            evaluacion[0].Value = ID;

            respuesta = AC.BaseSegura(instruccion, AC.ConnectionEstablecida(ref MensajeC), ref Mensaje, evaluacion);

            return respuesta;
        }
        public bool EliminarUsuarios(ref string Mensaje, ref string MensajeC, int ID)
        {
            bool respuesta = false;

            string instruccion = "DELETE from usuarios where num_inv = @num_inv";

            SqlParameter[] evaluacion = new SqlParameter[]
            {
                new SqlParameter("@num_inv",SqlDbType.Int)
            };

            evaluacion[0].Value = ID;

            respuesta = AC.BaseSegura(instruccion, AC.ConnectionEstablecida(ref MensajeC), ref Mensaje, evaluacion);

            return respuesta;
        }
    }
}
