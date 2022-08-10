using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Insertar
    {
        private Acceso_Datos AC = null;
        public Insertar(string connection)
        {
            AC = new Acceso_Datos(connection);
        }

        public bool InsertarConsulta(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            bool respuesta = false;

            string instrccion = "INSERT INTO consulta(id_usuario, id_publicacion)" +
                "values (@id_usuario, @id_publicacion)";
            SqlParameter[] info = new SqlParameter[]
            {
                new SqlParameter("@id_usuario",SqlDbType.Int),
                new SqlParameter("@id_publicacion",SqlDbType.Int),
            };
            info[0].Value = Convert.ToInt32(nuevoDatos[0]);
            info[1].Value = Convert.ToInt32(nuevoDatos[1]);

            respuesta = AC.BaseSegura(instrccion, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, info);
            return respuesta;
        }
        public bool InsertarMonografias(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            bool respuesta = false;

            string instrccion = "INSERT INTO monografias(id_publicacion, nombre_mono)" +
                "values (@id_publicacion, @nombre_mono)";
            SqlParameter[] info = new SqlParameter[]
            {
                new SqlParameter("@id_publicacion",SqlDbType.Int),
                new SqlParameter("@nombre_mono",SqlDbType.VarChar, 10),
                
            };
            info[0].Value = Convert.ToInt32(nuevoDatos[0]);
            info[1].Value = nuevoDatos[1];

            respuesta = AC.BaseSegura(instrccion, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, info);
            return respuesta;
        }
        public bool InsertarPrestamo(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            bool respuesta = false;

            string instrccion = "INSERT INTO prestamo(fecha_inicio_prestamo, fecha_devolucion, id_usuario)" +
                "values (@fecha_inicio_prestamo, @fecha_devolucion, @id_usuario)";
            SqlParameter[] info = new SqlParameter[]
            {
                new SqlParameter("@fecha_inicio_prestamo",SqlDbType.DateTime),
                new SqlParameter("@fecha_devolucion",SqlDbType.DateTime),
                new SqlParameter("@id_usuario",SqlDbType.Int),
            };
            info[0].Value = Convert.ToDateTime(nuevoDatos[0]);
            info[1].Value = Convert.ToDateTime(nuevoDatos[1]);
            info[2].Value = Convert.ToInt32(nuevoDatos[2]);

            respuesta = AC.BaseSegura(instrccion, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, info);
            return respuesta;
        }
        public bool InsertarPublicaciones(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            bool respuesta = false;

            string instrccion = "INSERT INTO publicaciones(titulo, num_ejemplar)" +
                "values (@titulo, @num_ejemplar)";
            SqlParameter[] info = new SqlParameter[]
            {
                new SqlParameter("@num_scpu",SqlDbType.VarChar, 11),
                new SqlParameter("@id_cpug",SqlDbType.Int),
            };
            info[0].Value = nuevoDatos[0];
            info[1].Value = Convert.ToInt32(nuevoDatos[1]);

            respuesta = AC.BaseSegura(instrccion, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, info);
            return respuesta;
        }
        public bool InsertarRevistas(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            bool respuesta = false;

            string instrccion = "INSERT INTO revistas(num_articulos, pag_comienzo, pag_terminacion)" +
                "values (@num_articulos, @pag_comienzo, @pag_terminacion)";
            SqlParameter[] info = new SqlParameter[]
            {
                new SqlParameter("@id_cpug",SqlDbType.Int),
            };
            info[0].Value = Convert.ToInt32(nuevoDatos[0]);
            info[1].Value = Convert.ToInt32(nuevoDatos[1]);
            info[2].Value = Convert.ToInt32(nuevoDatos[2]);

            respuesta = AC.BaseSegura(instrccion, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, info);
            return respuesta;
        }
        public bool InsertarTextos(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            bool respuesta = false;

            string instrccion = "INSERT INTO textos(autor, editorial, num_paginas)" +
                "values (@autor, @editorial, @num_paginas)";
            SqlParameter[] info = new SqlParameter[]
            {
                new SqlParameter("@autor",SqlDbType.VarChar, 10),
                new SqlParameter("@editorial",SqlDbType.VarChar, 11),
                new SqlParameter("@num_paginas",SqlDbType.Int),
            };
            info[0].Value = nuevoDatos[0];
            info[1].Value = nuevoDatos[1];
            info[2].Value = Convert.ToInt32(nuevoDatos[2]);
            respuesta = AC.BaseSegura(instrccion, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, info);
            return respuesta;
        }
        public bool InsertarUsuarios(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            bool respuesta = false;

            string instrccion = "INSERT INTO usuarios(nombre, colonia, numero, cp, nom_centro Trabajo, telefono)" +
                "values (@nombre, @colonia, @numero, @cp, @nom_centro Trabajo, @telefono)";
            SqlParameter[] info = new SqlParameter[]
            {
                new SqlParameter("@nombre",SqlDbType.VarChar, 10),
                new SqlParameter("@colonia",SqlDbType.VarChar, 11),
                new SqlParameter("@numero",SqlDbType.Int),
                new SqlParameter("@cp",SqlDbType.Int),
                new SqlParameter("@nom_centro Trabajo",SqlDbType.VarChar, 11),
                new SqlParameter("@telefono",SqlDbType.VarChar, 11),
            };
            info[0].Value = nuevoDatos[0];
            info[1].Value = nuevoDatos[1];
            info[2].Value = Convert.ToInt32(nuevoDatos[2]);
            info[3].Value = Convert.ToInt32(nuevoDatos[3]);
            info[4].Value = nuevoDatos[4];
            info[5].Value = nuevoDatos[5];

            respuesta = AC.BaseSegura(instrccion, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, info);
            return respuesta;
        }
    }
}
