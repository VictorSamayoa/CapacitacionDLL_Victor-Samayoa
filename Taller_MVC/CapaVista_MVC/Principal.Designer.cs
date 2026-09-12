namespace CapaVista_MVC
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblEstudiante = new System.Windows.Forms.Label();
            this.lblCombo = new System.Windows.Forms.Label();
            this.comboI1 = new Capa_Vista_DLL.ComboI();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgbConsultaTabla = new System.Windows.Forms.DataGridView();
            this.panIngresoDatos = new System.Windows.Forms.Panel();
            this.lblIdProveedor = new System.Windows.Forms.Label();
            this.txtIdProveedor = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblIdDireccion = new System.Windows.Forms.Label();
            this.txtIdDireccion = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgbConsultaTabla)).BeginInit();
            this.panIngresoDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblTitulo.Location = new System.Drawing.Point(20, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(520, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "TALLER DE DLL EN C# - MANTENIMIENTO PROVEEDORES";
            // 
            // lblEstudiante
            // 
            this.lblEstudiante.AutoSize = true;
            this.lblEstudiante.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstudiante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblEstudiante.Location = new System.Drawing.Point(22, 43);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(430, 15);
            this.lblEstudiante.TabIndex = 1;
            this.lblEstudiante.Text = "Victor Samayoa | Carnet: 0901-23-3424 | Microcasos PopFlix | DSN: capacitacion-MVC";
            // 
            // lblCombo
            // 
            this.lblCombo.AutoSize = true;
            this.lblCombo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombo.Location = new System.Drawing.Point(22, 70);
            this.lblCombo.Name = "lblCombo";
            this.lblCombo.Size = new System.Drawing.Size(262, 15);
            this.lblCombo.TabIndex = 2;
            this.lblCombo.Text = "ComboBox Inteligente (Capa_Vista_ComboI.dll):";
            // 
            // comboI1
            // 
            this.comboI1.Location = new System.Drawing.Point(25, 90);
            this.comboI1.Name = "comboI1";
            this.comboI1.Size = new System.Drawing.Size(580, 28);
            this.comboI1.TabIndex = 3;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(22, 128);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(46, 15);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Buscar:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSearch.Location = new System.Drawing.Point(74, 124);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(430, 24);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(510, 122);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 28);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgbConsultaTabla
            // 
            this.dgbConsultaTabla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgbConsultaTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgbConsultaTabla.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgbConsultaTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbConsultaTabla.Location = new System.Drawing.Point(25, 160);
            this.dgbConsultaTabla.Name = "dgbConsultaTabla";
            this.dgbConsultaTabla.ReadOnly = true;
            this.dgbConsultaTabla.RowHeadersWidth = 30;
            this.dgbConsultaTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgbConsultaTabla.Size = new System.Drawing.Size(580, 290);
            this.dgbConsultaTabla.TabIndex = 7;
            // 
            // panIngresoDatos
            // 
            this.panIngresoDatos.BackColor = System.Drawing.Color.White;
            this.panIngresoDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panIngresoDatos.Controls.Add(this.btnGrabar);
            this.panIngresoDatos.Controls.Add(this.txtIdDireccion);
            this.panIngresoDatos.Controls.Add(this.lblIdDireccion);
            this.panIngresoDatos.Controls.Add(this.txtTelefono);
            this.panIngresoDatos.Controls.Add(this.lblTelefono);
            this.panIngresoDatos.Controls.Add(this.txtNombre);
            this.panIngresoDatos.Controls.Add(this.lblNombre);
            this.panIngresoDatos.Controls.Add(this.txtIdProveedor);
            this.panIngresoDatos.Controls.Add(this.lblIdProveedor);
            this.panIngresoDatos.Location = new System.Drawing.Point(625, 90);
            this.panIngresoDatos.Name = "panIngresoDatos";
            this.panIngresoDatos.Size = new System.Drawing.Size(325, 360);
            this.panIngresoDatos.TabIndex = 8;
            // 
            // lblIdProveedor
            // 
            this.lblIdProveedor.AutoSize = true;
            this.lblIdProveedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIdProveedor.Location = new System.Drawing.Point(20, 20);
            this.lblIdProveedor.Name = "lblIdProveedor";
            this.lblIdProveedor.Size = new System.Drawing.Size(84, 15);
            this.lblIdProveedor.TabIndex = 0;
            this.lblIdProveedor.Text = "ID Proveedor:";
            // 
            // txtIdProveedor
            // 
            this.txtIdProveedor.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtIdProveedor.Location = new System.Drawing.Point(23, 40);
            this.txtIdProveedor.Name = "txtIdProveedor";
            this.txtIdProveedor.ReadOnly = true;
            this.txtIdProveedor.Size = new System.Drawing.Size(280, 24);
            this.txtIdProveedor.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(20, 80);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 15);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNombre.Location = new System.Drawing.Point(23, 100);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(280, 24);
            this.txtNombre.TabIndex = 3;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTelefono.Location = new System.Drawing.Point(20, 140);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(59, 15);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTelefono.Location = new System.Drawing.Point(23, 160);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(280, 24);
            this.txtTelefono.TabIndex = 5;
            // 
            // lblIdDireccion
            // 
            this.lblIdDireccion.AutoSize = true;
            this.lblIdDireccion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIdDireccion.Location = new System.Drawing.Point(20, 200);
            this.lblIdDireccion.Name = "lblIdDireccion";
            this.lblIdDireccion.Size = new System.Drawing.Size(81, 15);
            this.lblIdDireccion.TabIndex = 6;
            this.lblIdDireccion.Text = "ID Dirección:";
            // 
            // txtIdDireccion
            // 
            this.txtIdDireccion.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtIdDireccion.Location = new System.Drawing.Point(23, 220);
            this.txtIdDireccion.Name = "txtIdDireccion";
            this.txtIdDireccion.Size = new System.Drawing.Size(280, 24);
            this.txtIdDireccion.TabIndex = 7;
            this.txtIdDireccion.Text = "1";
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnGrabar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGrabar.ForeColor = System.Drawing.Color.White;
            this.btnGrabar.Location = new System.Drawing.Point(23, 275);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(280, 42);
            this.btnGrabar.TabIndex = 8;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(25, 465);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(120, 35);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Location = new System.Drawing.Point(160, 465);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(120, 35);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(295, 465);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(120, 35);
            this.btnBorrar.TabIndex = 11;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(430, 465);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(120, 35);
            this.btnConsultar.TabIndex = 12;
            this.btnConsultar.Text = "Refrescar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(975, 520);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.panIngresoDatos);
            this.Controls.Add(this.dgbConsultaTabla);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.comboI1);
            this.Controls.Add(this.lblCombo);
            this.Controls.Add(this.lblEstudiante);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capa Vista - Taller DLL C# - Victor Samayoa (0901-23-3424)";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbConsultaTabla)).EndInit();
            this.panIngresoDatos.ResumeLayout(false);
            this.panIngresoDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblEstudiante;
        private System.Windows.Forms.Label lblCombo;
        private Capa_Vista_DLL.ComboI comboI1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgbConsultaTabla;
        private System.Windows.Forms.Panel panIngresoDatos;
        private System.Windows.Forms.Label lblIdProveedor;
        private System.Windows.Forms.TextBox txtIdProveedor;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblIdDireccion;
        private System.Windows.Forms.TextBox txtIdDireccion;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnConsultar;
    }
}
