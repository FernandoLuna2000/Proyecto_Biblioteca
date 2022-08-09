using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Acceso_Datos
    {
        private string Conexion;
        public Acceso_Datos(string connection)
        {
            Conexion = connection;
        }
        public SqlConnection ConnectionEstablecida(ref string mensajeC)
        {
            SqlConnection puerto = new SqlConnection();
            puerto.ConnectionString = Conexion;
            try
            {
                puerto.Open();
                mensajeC = "Connexion Establecida";
            }
            catch (Exception e)
            {
                mensajeC = "Error: " + e;
                puerto = null;
            }
            return puerto;
        }
        public DataSet LecturaSet(string comandoSql, SqlConnection conAbierta, ref string mensaje, string etiqueta)
        {
            SqlCommand comando = null;
            DataSet dataSet = null;
            SqlDataAdapter dataAdapter = null;

            if (conAbierta == null)
            {
                dataSet = null;
            }
            else
            {
                using (comando = new SqlCommand(comandoSql, conAbierta))
                {
                    using (dataAdapter = new SqlDataAdapter())
                    {
                        dataSet = new DataSet();
                        dataAdapter.SelectCommand = comando;
                        try
                        {
                            dataAdapter.Fill(dataSet, etiqueta);
                            mensaje = "Recuperacion Correcta";
                        }
                        catch (Exception e)
                        {
                            mensaje = "Lo siento: " + e.Message;
                            dataSet = null;
                        }
                    }
                }
            }
            return dataSet;
        }
    }
}
