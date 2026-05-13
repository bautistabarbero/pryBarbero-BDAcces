using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace pryBarbero_BDAcces
{
    /// <summary>
    /// Provee operaciones de lectura sobre la base de datos Access:
    /// obtener tablas y mostrar los registros de la tabla seleccionada.
    /// </summary>
    public class TablaService
    {
        private readonly ConexionDB _conexionDB;

        public TablaService(ConexionDB conexionDB)
        {
            _conexionDB = conexionDB ?? throw new ArgumentNullException(nameof(conexionDB));
        }

        public List<string> ObtenerNombresDeTablas()
        {
            if (!_conexionDB.EstaConectado)
            {
                throw new InvalidOperationException("No hay una conexión activa con la base de datos.");
            }

            List<string> tablas = new List<string>();

            using (OleDbConnection conexion = _conexionDB.CrearConexion())
            {
                conexion.Open();

                DataTable esquema = conexion.GetSchema("Tables");

                foreach (DataRow fila in esquema.Rows)
                {
                    string nombre = fila["TABLE_NAME"].ToString();
                    string tipo = fila["TABLE_TYPE"].ToString();

                    if (tipo == "TABLE" && !nombre.StartsWith("MSys", StringComparison.OrdinalIgnoreCase))
                    {
                        tablas.Add(nombre);
                    }
                }
            }

            tablas.Sort();
            return tablas;
        }

        public DataTable ObtenerDatosDeTabla(string nombreTabla)
        {
            if (!_conexionDB.EstaConectado)
            {
                throw new InvalidOperationException("No hay una conexión activa con la base de datos.");
            }

            if (string.IsNullOrWhiteSpace(nombreTabla))
            {
                throw new ArgumentException("El nombre de la tabla no puede estar vacío.");
            }

            string tablaSegura = nombreTabla.Replace("]", "]]");
            string consulta = $"SELECT * FROM [{tablaSegura}]";

            using (OleDbConnection conexion = _conexionDB.CrearConexion())
            using (OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, conexion))
            {
                DataTable datos = new DataTable();
                adaptador.Fill(datos);
                return datos;
            }
        }
    }
}
