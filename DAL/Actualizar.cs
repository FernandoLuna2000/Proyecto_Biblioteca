using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Actualizar
    {
        private Acceso_Datos AC = null;
        public Actualizar(string connection)
        {
            AC = new Acceso_Datos(connection);
        }

        public bool ActualizarConsulta(string[] nuevoDatos, ref string Mensaje, ref string MensajeC, int ID)
        {
            bool respuesta = false;

            string instruccion = "UPDATE consulta " +
                "set num_scpu = @num_scpu, id_cpug = @id_cpug, num_steclado = @num_steclado, id_tecladog =  @id_tecladog, num_smonitor = @num_smonitor, id_mong = @id_mong, num_smouse = @num_smouse, id_mousg = @id_mousg, estado =@estado, id_Estatus = @id_Estatus  " +
                " where num_inv = @num_inv;";
            SqlParameter[] info = new SqlParameter[]
            {
                new SqlParameter("@id_usuario",SqlDbType.Int),
                new SqlParameter("@id_publicacion",SqlDbType.Int),
            };
            info[0].Value = Convert.ToInt32(nuevoDatos[0]);
            info[1].Value = Convert.ToInt32(nuevoDatos[1]);
            info[10].Value = ID;

            respuesta = AC.BaseSegura(instruccion, AC.ConnectionEstablecida(ref MensajeC), ref Mensaje, info);

            return respuesta;
        }
        public bool ActualizarMonografias(string[] nuevoDatos, ref string Mensaje, ref string MensajeC, int ID)
        {
            bool respuesta = false;

            string instruccion = "UPDATE monogafias " +
                "set num_scpu = @num_scpu,id_cpug = @id_cpug, num_steclado = @num_steclado, id_tecladog =  @id_tecladog, num_smonitor = @num_smonitor, id_mong = @id_mong, num_smouse = @num_smouse, id_mousg = @id_mousg, estado =@estado, id_Estatus = @id_Estatus  " +
                " where num_inv = @num_inv;";
            SqlParameter[] info = new SqlParameter[]
             {
                new SqlParameter("@id_publicacion",SqlDbType.Int),
                new SqlParameter("@nombre_mono",SqlDbType.VarChar, 10),

             };
            info[0].Value = Convert.ToInt32(nuevoDatos[0]);
            info[1].Value = nuevoDatos[1];
            info[10].Value = ID;

            respuesta = AC.BaseSegura(instruccion, AC.ConnectionEstablecida(ref MensajeC), ref Mensaje, info);

            return respuesta;
        }
        public bool ActualizarPrestamo(string[] nuevoDatos, ref string Mensaje, ref string MensajeC, int ID)
        {
            bool respuesta = false;

            string instruccion = "UPDATE prestamo " +
                "set num_scpu = @num_scpu,id_cpug = @id_cpug, num_steclado = @num_steclado, id_tecladog =  @id_tecladog, num_smonitor = @num_smonitor, id_mong = @id_mong, num_smouse = @num_smouse, id_mousg = @id_mousg, estado =@estado, id_Estatus = @id_Estatus  " +
                " where num_inv = @num_inv;";
            SqlParameter[] info = new SqlParameter[]
            {
                new SqlParameter("@fecha_inicio_prestamo",SqlDbType.DateTime),
                new SqlParameter("@fecha_devolucion",SqlDbType.DateTime),
                new SqlParameter("@id_usuario",SqlDbType.Int),
            };
            info[0].Value = Convert.ToDateTime(nuevoDatos[0]);
            info[1].Value = Convert.ToDateTime(nuevoDatos[1]);
            info[2].Value = Convert.ToInt32(nuevoDatos[2]);
            info[10].Value = ID;

            respuesta = AC.BaseSegura(instruccion, AC.ConnectionEstablecida(ref MensajeC), ref Mensaje, info);

            return respuesta;
        }
        public bool ActualizarPublicaciones(string[] nuevoDatos, ref string Mensaje, ref string MensajeC, int ID)
        {
            bool respuesta = false;

            string instruccion = "UPDATE publicaciones " +
                "set num_scpu = @num_scpu,id_cpug = @id_cpug, num_steclado = @num_steclado, id_tecladog =  @id_tecladog, num_smonitor = @num_smonitor, id_mong = @id_mong, num_smouse = @num_smouse, id_mousg = @id_mousg, estado =@estado, id_Estatus = @id_Estatus  " +
                " where num_inv = @num_inv;";
            SqlParameter[] info = new SqlParameter[]
           {
                new SqlParameter("@num_scpu",SqlDbType.VarChar, 11),
                new SqlParameter("@id_cpug",SqlDbType.Int),
           };
            info[0].Value = nuevoDatos[0];
            info[1].Value = Convert.ToInt32(nuevoDatos[1]);
            info[10].Value = ID;

            respuesta = AC.BaseSegura(instruccion, AC.ConnectionEstablecida(ref MensajeC), ref Mensaje, info);

            return respuesta;
        }
        public bool ActualizarRevistas(string[] nuevoDatos, ref string Mensaje, ref string MensajeC, int ID)
        {
            bool respuesta = false;

            string instruccion = "UPDATE revistas " +
                "set num_scpu = @num_scpu,id_cpug = @id_cpug, num_steclado = @num_steclado, id_tecladog =  @id_tecladog, num_smonitor = @num_smonitor, id_mong = @id_mong, num_smouse = @num_smouse, id_mousg = @id_mousg, estado =@estado, id_Estatus = @id_Estatus  " +
                " where num_inv = @num_inv;";
            SqlParameter[] info = new SqlParameter[]
            {
                new SqlParameter("@id_cpug",SqlDbType.Int),
            };
            info[0].Value = Convert.ToInt32(nuevoDatos[0]);
            info[1].Value = Convert.ToInt32(nuevoDatos[1]);
            info[2].Value = Convert.ToInt32(nuevoDatos[2]);
            info[10].Value = ID;

            respuesta = AC.BaseSegura(instruccion, AC.ConnectionEstablecida(ref MensajeC), ref Mensaje, info);

            return respuesta;
        }
        public bool ActualizarTextos(string[] nuevoDatos, ref string Mensaje, ref string MensajeC, int ID)
        {
            bool respuesta = false;

            string instruccion = "UPDATE computadorafinal " +
                "set num_scpu = @num_scpu,id_cpug = @id_cpug, num_steclado = @num_steclado, id_tecladog =  @id_tecladog, num_smonitor = @num_smonitor, id_mong = @id_mong, num_smouse = @num_smouse, id_mousg = @id_mousg, estado =@estado, id_Estatus = @id_Estatus  " +
                " where num_inv = @num_inv;";
            SqlParameter[] info = new SqlParameter[]
            {
                new SqlParameter("@autor",SqlDbType.VarChar, 10),
                new SqlParameter("@editorial",SqlDbType.VarChar, 11),
                new SqlParameter("@num_paginas",SqlDbType.Int),
            };
            info[0].Value = nuevoDatos[0];
            info[1].Value = nuevoDatos[1];
            info[2].Value = Convert.ToInt32(nuevoDatos[2]);
            info[10].Value = ID;

            respuesta = AC.BaseSegura(instruccion, AC.ConnectionEstablecida(ref MensajeC), ref Mensaje, info);

            return respuesta;
        }
        public bool ActualizarUsuarios(string[] nuevoDatos, ref string Mensaje, ref string MensajeC, int ID)
        {
            bool respuesta = false;

            string instruccion = "UPDATE computadorafinal " +
                "set num_scpu = @num_scpu,id_cpug = @id_cpug, num_steclado = @num_steclado, id_tecladog =  @id_tecladog, num_smonitor = @num_smonitor, id_mong = @id_mong, num_smouse = @num_smouse, id_mousg = @id_mousg, estado =@estado, id_Estatus = @id_Estatus  " +
                " where num_inv = @num_inv;";
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
            info[10].Value = ID;

            respuesta = AC.BaseSegura(instruccion, AC.ConnectionEstablecida(ref MensajeC), ref Mensaje, info);

            return respuesta;
        }

    }
}
