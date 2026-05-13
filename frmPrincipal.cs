using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace pryBarbero_BDAcces
{
    public partial class frmPrincipal : Form
    {
        private readonly ConexionDB conexionDB;
        private readonly TablaService tablaService;

        public frmPrincipal()
        {
            InitializeComponent();

            conexionDB = new ConexionDB();
            tablaService = new TablaService(conexionDB);

            ActualizarEstado(false, "Sin conexión");
        }

        private void btnAbrirBD_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Seleccionar base de datos Access";
                ofd.Filter = "Base de datos Access (*.accdb;*.mdb)|*.accdb;*.mdb";
                ofd.Multiselect = false;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    AbrirBaseDeDatos(ofd.FileName);
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!conexionDB.EstaConectado)
            {
                MessageBox.Show("Primero debe abrir una base de datos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            CargarTablas();
        }

        private void btnCerrarConexion_Click(object sender, EventArgs e)
        {
            conexionDB.Desconectar();
            cmbTablas.Items.Clear();
            dgvDatos.DataSource = null;
            lblRuta.Text = "Ningún archivo seleccionado";
            lblCantidadRegistros.Text = "Registros: 0";
            lblCantidadColumnas.Text = "Columnas: 0";
            ActualizarEstado(false, "Sin conexión");
        }

        private void cmbTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTablas.SelectedItem != null)
            {
                MostrarDatosDeTabla(cmbTablas.SelectedItem.ToString());
            }
        }

        private void AbrirBaseDeDatos(string rutaArchivo)
        {
            try
            {
                conexionDB.Conectar(rutaArchivo);

                lblRuta.Text = rutaArchivo;
                CargarTablas();
                ActualizarEstado(true, "Conexión exitosa");
            }
            catch (Exception ex)
            {
                conexionDB.Desconectar();
                dgvDatos.DataSource = null;
                cmbTablas.Items.Clear();
                ActualizarEstado(false, "Error de conexión");

                MessageBox.Show(
                    "Error al abrir la base de datos:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void CargarTablas()
        {
            try
            {
                List<string> tablas = tablaService.ObtenerNombresDeTablas();

                cmbTablas.Items.Clear();
                cmbTablas.Items.AddRange(tablas.ToArray());

                lblCantidadTablas.Text = "Tablas: " + tablas.Count;

                if (cmbTablas.Items.Count > 0)
                {
                    cmbTablas.SelectedIndex = 0;
                }
                else
                {
                    dgvDatos.DataSource = null;
                    lblCantidadRegistros.Text = "Registros: 0";
                    lblCantidadColumnas.Text = "Columnas: 0";
                    MessageBox.Show("La base de datos no contiene tablas visibles.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar las tablas:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void MostrarDatosDeTabla(string nombreTabla)
        {
            try
            {
                DataTable datos = tablaService.ObtenerDatosDeTabla(nombreTabla);
                dgvDatos.DataSource = datos;

                lblTablaActual.Text = "Tabla actual: " + nombreTabla;
                lblCantidadRegistros.Text = "Registros: " + datos.Rows.Count;
                lblCantidadColumnas.Text = "Columnas: " + datos.Columns.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al mostrar datos:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void ActualizarEstado(bool conectado, string mensaje)
        {
            lblEstado.Text = mensaje;
            lblEstado.ForeColor = conectado ? Color.FromArgb(22, 163, 74) : Color.FromArgb(220, 38, 38);
        }
    }
}
