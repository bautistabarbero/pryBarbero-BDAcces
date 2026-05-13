using System;
using System.Data.OleDb;
using System.IO;

namespace pryBarbero_BDAcces
{  
    /// Gestiona la conexión a una base de datos Access seleccionada por el usuario.
    /// Admite archivos .accdb y .mdb.
    public class ConexionDB
    {
        public string RutaArchivo { get; private set; }
        public string CadenaConexion { get; private set; }
        public bool EstaConectado { get; private set; }

        public void Conectar(string rutaArchivo)
        {
            if (string.IsNullOrWhiteSpace(rutaArchivo))
            {
                throw new ArgumentException("La ruta del archivo no puede estar vacía.");
            }

            rutaArchivo = Path.GetFullPath(rutaArchivo);

            if (!File.Exists(rutaArchivo))
            {
                throw new FileNotFoundException("No se encontró la base de datos seleccionada.", rutaArchivo);
            }

            RutaArchivo = rutaArchivo;
            CadenaConexion = ConstruirCadenaConexion(RutaArchivo);
            EstaConectado = true;
        }

        private string ConstruirCadenaConexion(string rutaArchivo)
        {
            string extension = Path.GetExtension(rutaArchivo).ToLowerInvariant();

            switch (extension)
            {
                case ".accdb":
                    return $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={rutaArchivo};Persist Security Info=False;";

                case ".mdb":
                    return $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={rutaArchivo};Persist Security Info=False;";

                default:
                    throw new NotSupportedException("Solo se permiten bases de datos Access con extensión .accdb o .mdb.");
            }
        }

        public OleDbConnection CrearConexion()
        {
            if (!EstaConectado || string.IsNullOrWhiteSpace(CadenaConexion))
            {
                throw new InvalidOperationException("No hay una conexión activa con la base de datos.");
            }

            return new OleDbConnection(CadenaConexion);
        }

        public void Desconectar()
        {
            RutaArchivo = null;
            CadenaConexion = null;
            EstaConectado = false;
        }
    }
}
