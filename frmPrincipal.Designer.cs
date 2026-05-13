namespace pryBarbero_BDAcces
{
    partial class frmPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnAbrirBD = new System.Windows.Forms.Button();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblCantidadTablas = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblEstadoTitulo = new System.Windows.Forms.Label();
            this.btnCerrarConexion = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.cmbTablas = new System.Windows.Forms.ComboBox();
            this.lblTablas = new System.Windows.Forms.Label();
            this.lblPanelTablas = new System.Windows.Forms.Label();
            this.lblRuta = new System.Windows.Forms.Label();
            this.lblArchivoTitulo = new System.Windows.Forms.Label();
            this.lblPanelArchivo = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.pnlResumen = new System.Windows.Forms.Panel();
            this.lblCantidadColumnas = new System.Windows.Forms.Label();
            this.lblCantidadRegistros = new System.Windows.Forms.Label();
            this.lblTablaActual = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.pnlResumen.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(52)))), ((int)(((byte)(78)))));
            this.pnlHeader.Controls.Add(this.btnAbrirBD);
            this.pnlHeader.Controls.Add(this.lblSubtitulo);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1050, 76);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnAbrirBD
            // 
            this.btnAbrirBD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbrirBD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            this.btnAbrirBD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirBD.FlatAppearance.BorderSize = 0;
            this.btnAbrirBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirBD.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAbrirBD.ForeColor = System.Drawing.Color.White;
            this.btnAbrirBD.Location = new System.Drawing.Point(850, 19);
            this.btnAbrirBD.Name = "btnAbrirBD";
            this.btnAbrirBD.Size = new System.Drawing.Size(170, 38);
            this.btnAbrirBD.TabIndex = 0;
            this.btnAbrirBD.Text = "Abrir base de datos";
            this.btnAbrirBD.UseVisualStyleBackColor = false;
            this.btnAbrirBD.Click += new System.EventHandler(this.btnAbrirBD_Click);
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(30, 46);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(361, 17);
            this.lblSubtitulo.TabIndex = 2;
            this.lblSubtitulo.Text = "Visualizador profesional para archivos Access .accdb y .mdb";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(27, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(223, 31);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "BD Access Manager";
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlSidebar.Controls.Add(this.lblCantidadTablas);
            this.pnlSidebar.Controls.Add(this.lblEstado);
            this.pnlSidebar.Controls.Add(this.lblEstadoTitulo);
            this.pnlSidebar.Controls.Add(this.btnCerrarConexion);
            this.pnlSidebar.Controls.Add(this.btnActualizar);
            this.pnlSidebar.Controls.Add(this.cmbTablas);
            this.pnlSidebar.Controls.Add(this.lblTablas);
            this.pnlSidebar.Controls.Add(this.lblPanelTablas);
            this.pnlSidebar.Controls.Add(this.lblRuta);
            this.pnlSidebar.Controls.Add(this.lblArchivoTitulo);
            this.pnlSidebar.Controls.Add(this.lblPanelArchivo);
            this.pnlSidebar.Location = new System.Drawing.Point(0, 76);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(285, 564);
            this.pnlSidebar.TabIndex = 1;
            // 
            // lblCantidadTablas
            // 
            this.lblCantidadTablas.AutoSize = true;
            this.lblCantidadTablas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCantidadTablas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblCantidadTablas.Location = new System.Drawing.Point(24, 250);
            this.lblCantidadTablas.Name = "lblCantidadTablas";
            this.lblCantidadTablas.Size = new System.Drawing.Size(53, 15);
            this.lblCantidadTablas.TabIndex = 10;
            this.lblCantidadTablas.Text = "Tablas: 0";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblEstado.Location = new System.Drawing.Point(24, 428);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(94, 19);
            this.lblEstado.TabIndex = 9;
            this.lblEstado.Text = "Sin conexión";
            // 
            // lblEstadoTitulo
            // 
            this.lblEstadoTitulo.AutoSize = true;
            this.lblEstadoTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEstadoTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblEstadoTitulo.Location = new System.Drawing.Point(23, 397);
            this.lblEstadoTitulo.Name = "lblEstadoTitulo";
            this.lblEstadoTitulo.Size = new System.Drawing.Size(139, 19);
            this.lblEstadoTitulo.TabIndex = 8;
            this.lblEstadoTitulo.Text = "Estado de conexión";
            // 
            // btnCerrarConexion
            // 
            this.btnCerrarConexion.BackColor = System.Drawing.Color.White;
            this.btnCerrarConexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarConexion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnCerrarConexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarConexion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCerrarConexion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnCerrarConexion.Location = new System.Drawing.Point(24, 327);
            this.btnCerrarConexion.Name = "btnCerrarConexion";
            this.btnCerrarConexion.Size = new System.Drawing.Size(237, 34);
            this.btnCerrarConexion.TabIndex = 4;
            this.btnCerrarConexion.Text = "Cerrar conexión";
            this.btnCerrarConexion.UseVisualStyleBackColor = false;
            this.btnCerrarConexion.Click += new System.EventHandler(this.btnCerrarConexion_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(24, 285);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(237, 34);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar tablas";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // cmbTablas
            // 
            this.cmbTablas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTablas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTablas.FormattingEnabled = true;
            this.cmbTablas.Location = new System.Drawing.Point(24, 211);
            this.cmbTablas.Name = "cmbTablas";
            this.cmbTablas.Size = new System.Drawing.Size(237, 25);
            this.cmbTablas.TabIndex = 2;
            this.cmbTablas.SelectedIndexChanged += new System.EventHandler(this.cmbTablas_SelectedIndexChanged);
            // 
            // lblTablas
            // 
            this.lblTablas.AutoSize = true;
            this.lblTablas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTablas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblTablas.Location = new System.Drawing.Point(24, 188);
            this.lblTablas.Name = "lblTablas";
            this.lblTablas.Size = new System.Drawing.Size(173, 15);
            this.lblTablas.TabIndex = 5;
            this.lblTablas.Text = "Seleccionar tabla para visualizar";
            // 
            // lblPanelTablas
            // 
            this.lblPanelTablas.AutoSize = true;
            this.lblPanelTablas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPanelTablas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblPanelTablas.Location = new System.Drawing.Point(20, 150);
            this.lblPanelTablas.Name = "lblPanelTablas";
            this.lblPanelTablas.Size = new System.Drawing.Size(145, 21);
            this.lblPanelTablas.TabIndex = 4;
            this.lblPanelTablas.Text = "Tablas detectadas";
            // 
            // lblRuta
            // 
            this.lblRuta.AutoEllipsis = true;
            this.lblRuta.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblRuta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblRuta.Location = new System.Drawing.Point(24, 73);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(237, 52);
            this.lblRuta.TabIndex = 2;
            this.lblRuta.Text = "Ningún archivo seleccionado";
            // 
            // lblArchivoTitulo
            // 
            this.lblArchivoTitulo.AutoSize = true;
            this.lblArchivoTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblArchivoTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblArchivoTitulo.Location = new System.Drawing.Point(24, 50);
            this.lblArchivoTitulo.Name = "lblArchivoTitulo";
            this.lblArchivoTitulo.Size = new System.Drawing.Size(97, 15);
            this.lblArchivoTitulo.TabIndex = 1;
            this.lblArchivoTitulo.Text = "Archivo cargado";
            // 
            // lblPanelArchivo
            // 
            this.lblPanelArchivo.AutoSize = true;
            this.lblPanelArchivo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPanelArchivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblPanelArchivo.Location = new System.Drawing.Point(20, 18);
            this.lblPanelArchivo.Name = "lblPanelArchivo";
            this.lblPanelArchivo.Size = new System.Drawing.Size(148, 21);
            this.lblPanelArchivo.TabIndex = 0;
            this.lblPanelArchivo.Text = "Base seleccionada";
            // 
            // pnlContent
            // 
            this.pnlContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Controls.Add(this.dgvDatos);
            this.pnlContent.Controls.Add(this.pnlResumen);
            this.pnlContent.Location = new System.Drawing.Point(285, 76);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(765, 564);
            this.pnlContent.TabIndex = 2;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.White;
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDatos.ColumnHeadersHeight = 34;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDatos.EnableHeadersVisualStyles = false;
            this.dgvDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgvDatos.Location = new System.Drawing.Point(24, 100);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.RowTemplate.Height = 28;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(717, 440);
            this.dgvDatos.TabIndex = 5;
            // 
            // pnlResumen
            // 
            this.pnlResumen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlResumen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlResumen.Controls.Add(this.lblCantidadColumnas);
            this.pnlResumen.Controls.Add(this.lblCantidadRegistros);
            this.pnlResumen.Controls.Add(this.lblTablaActual);
            this.pnlResumen.Location = new System.Drawing.Point(24, 22);
            this.pnlResumen.Name = "pnlResumen";
            this.pnlResumen.Size = new System.Drawing.Size(717, 58);
            this.pnlResumen.TabIndex = 0;
            // 
            // lblCantidadColumnas
            // 
            this.lblCantidadColumnas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantidadColumnas.AutoSize = true;
            this.lblCantidadColumnas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCantidadColumnas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblCantidadColumnas.Location = new System.Drawing.Point(596, 22);
            this.lblCantidadColumnas.Name = "lblCantidadColumnas";
            this.lblCantidadColumnas.Size = new System.Drawing.Size(73, 15);
            this.lblCantidadColumnas.TabIndex = 2;
            this.lblCantidadColumnas.Text = "Columnas: 0";
            // 
            // lblCantidadRegistros
            // 
            this.lblCantidadRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantidadRegistros.AutoSize = true;
            this.lblCantidadRegistros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCantidadRegistros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblCantidadRegistros.Location = new System.Drawing.Point(481, 22);
            this.lblCantidadRegistros.Name = "lblCantidadRegistros";
            this.lblCantidadRegistros.Size = new System.Drawing.Size(72, 15);
            this.lblCantidadRegistros.TabIndex = 1;
            this.lblCantidadRegistros.Text = "Registros: 0";
            // 
            // lblTablaActual
            // 
            this.lblTablaActual.AutoEllipsis = true;
            this.lblTablaActual.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTablaActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTablaActual.Location = new System.Drawing.Point(22, 18);
            this.lblTablaActual.Name = "lblTablaActual";
            this.lblTablaActual.Size = new System.Drawing.Size(400, 22);
            this.lblTablaActual.TabIndex = 0;
            this.lblTablaActual.Text = "Tabla actual: ninguna";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 640);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(920, 560);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pryBarbero-BDAcces - Visor de Base de Datos Access";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.pnlResumen.ResumeLayout(false);
            this.pnlResumen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnAbrirBD;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblPanelArchivo;
        private System.Windows.Forms.Label lblArchivoTitulo;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Label lblPanelTablas;
        private System.Windows.Forms.Label lblTablas;
        private System.Windows.Forms.ComboBox cmbTablas;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCerrarConexion;
        private System.Windows.Forms.Label lblEstadoTitulo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCantidadTablas;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlResumen;
        private System.Windows.Forms.Label lblTablaActual;
        private System.Windows.Forms.Label lblCantidadRegistros;
        private System.Windows.Forms.Label lblCantidadColumnas;
        private System.Windows.Forms.DataGridView dgvDatos;
    }
}
