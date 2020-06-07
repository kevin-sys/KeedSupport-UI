namespace KeedSupport_UI
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.PanelMenuLateral = new System.Windows.Forms.Panel();
            this.PanelGestion = new System.Windows.Forms.Panel();
            this.BtnBaseFalla = new System.Windows.Forms.Button();
            this.BtnCrearCupon = new System.Windows.Forms.Button();
            this.BtnEntregarEquipo = new System.Windows.Forms.Button();
            this.BtnGestion = new System.Windows.Forms.Button();
            this.PanelConsultar = new System.Windows.Forms.Panel();
            this.BtnConsultaEntregas = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnConsultaCliente = new System.Windows.Forms.Button();
            this.BtnConsultarOrden = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.PanelRegistrar = new System.Windows.Forms.Panel();
            this.BtnReparacion = new System.Windows.Forms.Button();
            this.BtnRegistrarCliente = new System.Windows.Forms.Button();
            this.BtnRegistrarOrden = new System.Windows.Forms.Button();
            this.BtnRegistro = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PanelCentral = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnEstadisticas = new System.Windows.Forms.Button();
            this.PanelMenuLateral.SuspendLayout();
            this.PanelGestion.SuspendLayout();
            this.PanelConsultar.SuspendLayout();
            this.PanelRegistrar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.PanelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenuLateral
            // 
            this.PanelMenuLateral.AutoScroll = true;
            this.PanelMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.PanelMenuLateral.Controls.Add(this.PanelGestion);
            this.PanelMenuLateral.Controls.Add(this.BtnGestion);
            this.PanelMenuLateral.Controls.Add(this.PanelConsultar);
            this.PanelMenuLateral.Controls.Add(this.BtnConsultar);
            this.PanelMenuLateral.Controls.Add(this.PanelRegistrar);
            this.PanelMenuLateral.Controls.Add(this.BtnRegistro);
            this.PanelMenuLateral.Controls.Add(this.panel1);
            this.PanelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.PanelMenuLateral.Name = "PanelMenuLateral";
            this.PanelMenuLateral.Size = new System.Drawing.Size(217, 749);
            this.PanelMenuLateral.TabIndex = 0;
            // 
            // PanelGestion
            // 
            this.PanelGestion.BackColor = System.Drawing.Color.DimGray;
            this.PanelGestion.Controls.Add(this.BtnEstadisticas);
            this.PanelGestion.Controls.Add(this.BtnBaseFalla);
            this.PanelGestion.Controls.Add(this.BtnCrearCupon);
            this.PanelGestion.Controls.Add(this.BtnEntregarEquipo);
            this.PanelGestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelGestion.Location = new System.Drawing.Point(0, 505);
            this.PanelGestion.Name = "PanelGestion";
            this.PanelGestion.Size = new System.Drawing.Size(217, 158);
            this.PanelGestion.TabIndex = 6;
            // 
            // BtnBaseFalla
            // 
            this.BtnBaseFalla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBaseFalla.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnBaseFalla.FlatAppearance.BorderSize = 0;
            this.BtnBaseFalla.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BtnBaseFalla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnBaseFalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBaseFalla.Location = new System.Drawing.Point(0, 74);
            this.BtnBaseFalla.Name = "BtnBaseFalla";
            this.BtnBaseFalla.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnBaseFalla.Size = new System.Drawing.Size(217, 37);
            this.BtnBaseFalla.TabIndex = 2;
            this.BtnBaseFalla.Text = "Base de fallas";
            this.BtnBaseFalla.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBaseFalla.UseVisualStyleBackColor = true;
            this.BtnBaseFalla.Click += new System.EventHandler(this.BtnBaseFalla_Click);
            // 
            // BtnCrearCupon
            // 
            this.BtnCrearCupon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCrearCupon.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCrearCupon.FlatAppearance.BorderSize = 0;
            this.BtnCrearCupon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrearCupon.Location = new System.Drawing.Point(0, 37);
            this.BtnCrearCupon.Name = "BtnCrearCupon";
            this.BtnCrearCupon.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnCrearCupon.Size = new System.Drawing.Size(217, 37);
            this.BtnCrearCupon.TabIndex = 1;
            this.BtnCrearCupon.Text = "Cupón de descuento";
            this.BtnCrearCupon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCrearCupon.UseVisualStyleBackColor = true;
            this.BtnCrearCupon.Click += new System.EventHandler(this.BtnCrearCupon_Click);
            // 
            // BtnEntregarEquipo
            // 
            this.BtnEntregarEquipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEntregarEquipo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEntregarEquipo.FlatAppearance.BorderSize = 0;
            this.BtnEntregarEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntregarEquipo.Location = new System.Drawing.Point(0, 0);
            this.BtnEntregarEquipo.Name = "BtnEntregarEquipo";
            this.BtnEntregarEquipo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnEntregarEquipo.Size = new System.Drawing.Size(217, 37);
            this.BtnEntregarEquipo.TabIndex = 0;
            this.BtnEntregarEquipo.Text = "Entregar equipo";
            this.BtnEntregarEquipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEntregarEquipo.UseVisualStyleBackColor = true;
            this.BtnEntregarEquipo.Click += new System.EventHandler(this.BtnEntregarEquipo_Click);
            // 
            // BtnGestion
            // 
            this.BtnGestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnGestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGestion.Location = new System.Drawing.Point(0, 460);
            this.BtnGestion.Name = "BtnGestion";
            this.BtnGestion.Size = new System.Drawing.Size(217, 45);
            this.BtnGestion.TabIndex = 5;
            this.BtnGestion.Text = "GESTIÓN";
            this.BtnGestion.UseVisualStyleBackColor = true;
            this.BtnGestion.Click += new System.EventHandler(this.BtnGestion_Click_1);
            // 
            // PanelConsultar
            // 
            this.PanelConsultar.BackColor = System.Drawing.Color.DimGray;
            this.PanelConsultar.Controls.Add(this.BtnConsultaEntregas);
            this.PanelConsultar.Controls.Add(this.button2);
            this.PanelConsultar.Controls.Add(this.BtnConsultaCliente);
            this.PanelConsultar.Controls.Add(this.BtnConsultarOrden);
            this.PanelConsultar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelConsultar.Location = new System.Drawing.Point(0, 303);
            this.PanelConsultar.Name = "PanelConsultar";
            this.PanelConsultar.Size = new System.Drawing.Size(217, 157);
            this.PanelConsultar.TabIndex = 4;
            // 
            // BtnConsultaEntregas
            // 
            this.BtnConsultaEntregas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConsultaEntregas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnConsultaEntregas.FlatAppearance.BorderSize = 0;
            this.BtnConsultaEntregas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultaEntregas.Location = new System.Drawing.Point(0, 111);
            this.BtnConsultaEntregas.Name = "BtnConsultaEntregas";
            this.BtnConsultaEntregas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnConsultaEntregas.Size = new System.Drawing.Size(217, 37);
            this.BtnConsultaEntregas.TabIndex = 2;
            this.BtnConsultaEntregas.Text = "Listado de entregas";
            this.BtnConsultaEntregas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultaEntregas.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 74);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(217, 37);
            this.button2.TabIndex = 0;
            this.button2.Text = "Listado de reparaciones";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BtnConsultaCliente
            // 
            this.BtnConsultaCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConsultaCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnConsultaCliente.FlatAppearance.BorderSize = 0;
            this.BtnConsultaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultaCliente.Location = new System.Drawing.Point(0, 37);
            this.BtnConsultaCliente.Name = "BtnConsultaCliente";
            this.BtnConsultaCliente.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnConsultaCliente.Size = new System.Drawing.Size(217, 37);
            this.BtnConsultaCliente.TabIndex = 1;
            this.BtnConsultaCliente.Text = "Listado de clientes";
            this.BtnConsultaCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultaCliente.UseVisualStyleBackColor = true;
            this.BtnConsultaCliente.Click += new System.EventHandler(this.BtnConsultaCliente_Click);
            // 
            // BtnConsultarOrden
            // 
            this.BtnConsultarOrden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConsultarOrden.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnConsultarOrden.FlatAppearance.BorderSize = 0;
            this.BtnConsultarOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultarOrden.Location = new System.Drawing.Point(0, 0);
            this.BtnConsultarOrden.Name = "BtnConsultarOrden";
            this.BtnConsultarOrden.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnConsultarOrden.Size = new System.Drawing.Size(217, 37);
            this.BtnConsultarOrden.TabIndex = 0;
            this.BtnConsultarOrden.Text = "Listado de ordenes";
            this.BtnConsultarOrden.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultarOrden.UseVisualStyleBackColor = true;
            this.BtnConsultarOrden.Click += new System.EventHandler(this.BtnConsultarOrden_Click);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConsultar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultar.Location = new System.Drawing.Point(0, 258);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(217, 45);
            this.BtnConsultar.TabIndex = 3;
            this.BtnConsultar.Text = "CONSULTAS";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click_1);
            // 
            // PanelRegistrar
            // 
            this.PanelRegistrar.BackColor = System.Drawing.Color.DimGray;
            this.PanelRegistrar.Controls.Add(this.BtnReparacion);
            this.PanelRegistrar.Controls.Add(this.BtnRegistrarCliente);
            this.PanelRegistrar.Controls.Add(this.BtnRegistrarOrden);
            this.PanelRegistrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelRegistrar.Location = new System.Drawing.Point(0, 139);
            this.PanelRegistrar.Name = "PanelRegistrar";
            this.PanelRegistrar.Size = new System.Drawing.Size(217, 119);
            this.PanelRegistrar.TabIndex = 2;
            // 
            // BtnReparacion
            // 
            this.BtnReparacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReparacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnReparacion.FlatAppearance.BorderSize = 0;
            this.BtnReparacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReparacion.Location = new System.Drawing.Point(0, 74);
            this.BtnReparacion.Name = "BtnReparacion";
            this.BtnReparacion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnReparacion.Size = new System.Drawing.Size(217, 37);
            this.BtnReparacion.TabIndex = 2;
            this.BtnReparacion.Text = "Registrar reparacion";
            this.BtnReparacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReparacion.UseVisualStyleBackColor = true;
            this.BtnReparacion.Click += new System.EventHandler(this.BtnReparacion_Click);
            // 
            // BtnRegistrarCliente
            // 
            this.BtnRegistrarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegistrarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRegistrarCliente.FlatAppearance.BorderSize = 0;
            this.BtnRegistrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrarCliente.Location = new System.Drawing.Point(0, 37);
            this.BtnRegistrarCliente.Name = "BtnRegistrarCliente";
            this.BtnRegistrarCliente.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnRegistrarCliente.Size = new System.Drawing.Size(217, 37);
            this.BtnRegistrarCliente.TabIndex = 1;
            this.BtnRegistrarCliente.Text = "Registrar cliente";
            this.BtnRegistrarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistrarCliente.UseVisualStyleBackColor = true;
            this.BtnRegistrarCliente.Click += new System.EventHandler(this.BtnRegistrarCliente_Click);
            // 
            // BtnRegistrarOrden
            // 
            this.BtnRegistrarOrden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegistrarOrden.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRegistrarOrden.FlatAppearance.BorderSize = 0;
            this.BtnRegistrarOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrarOrden.Location = new System.Drawing.Point(0, 0);
            this.BtnRegistrarOrden.Name = "BtnRegistrarOrden";
            this.BtnRegistrarOrden.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnRegistrarOrden.Size = new System.Drawing.Size(217, 37);
            this.BtnRegistrarOrden.TabIndex = 0;
            this.BtnRegistrarOrden.Text = "Registrar una Orden";
            this.BtnRegistrarOrden.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistrarOrden.UseVisualStyleBackColor = true;
            this.BtnRegistrarOrden.Click += new System.EventHandler(this.BtnRegistrarOrden_Click);
            // 
            // BtnRegistro
            // 
            this.BtnRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRegistro.FlatAppearance.BorderSize = 0;
            this.BtnRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistro.Location = new System.Drawing.Point(0, 94);
            this.BtnRegistro.Name = "BtnRegistro";
            this.BtnRegistro.Size = new System.Drawing.Size(217, 45);
            this.BtnRegistro.TabIndex = 1;
            this.BtnRegistro.Text = "REGISTROS";
            this.BtnRegistro.UseVisualStyleBackColor = true;
            this.BtnRegistro.Click += new System.EventHandler(this.BtnRegistro_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 94);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(217, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // PanelCentral
            // 
            this.PanelCentral.BackColor = System.Drawing.Color.White;
            this.PanelCentral.Controls.Add(this.pictureBox1);
            this.PanelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCentral.Location = new System.Drawing.Point(217, 0);
            this.PanelCentral.Name = "PanelCentral";
            this.PanelCentral.Size = new System.Drawing.Size(958, 749);
            this.PanelCentral.TabIndex = 1;
            this.PanelCentral.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelCentral_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::KeedSupport_UI.Properties.Resources.KeD_Support1;
            this.pictureBox1.Location = new System.Drawing.Point(300, 223);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(367, 279);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnEstadisticas
            // 
            this.BtnEstadisticas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEstadisticas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEstadisticas.FlatAppearance.BorderSize = 0;
            this.BtnEstadisticas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BtnEstadisticas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnEstadisticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEstadisticas.Location = new System.Drawing.Point(0, 111);
            this.BtnEstadisticas.Name = "BtnEstadisticas";
            this.BtnEstadisticas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnEstadisticas.Size = new System.Drawing.Size(217, 37);
            this.BtnEstadisticas.TabIndex = 3;
            this.BtnEstadisticas.Text = "Estadisticas";
            this.BtnEstadisticas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEstadisticas.UseVisualStyleBackColor = true;
            this.BtnEstadisticas.Click += new System.EventHandler(this.BtnEstadisticas_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 749);
            this.Controls.Add(this.PanelCentral);
            this.Controls.Add(this.PanelMenuLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(1060, 539);
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.PanelMenuLateral.ResumeLayout(false);
            this.PanelGestion.ResumeLayout(false);
            this.PanelConsultar.ResumeLayout(false);
            this.PanelRegistrar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.PanelCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenuLateral;
        private System.Windows.Forms.Panel PanelRegistrar;
        private System.Windows.Forms.Button BtnRegistrarOrden;
        private System.Windows.Forms.Button BtnRegistro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelGestion;
        private System.Windows.Forms.Button BtnEntregarEquipo;
        private System.Windows.Forms.Button BtnGestion;
        private System.Windows.Forms.Panel PanelConsultar;
        private System.Windows.Forms.Button BtnConsultarOrden;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Panel PanelCentral;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnCrearCupon;
        private System.Windows.Forms.Button BtnConsultaEntregas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnConsultaCliente;
        private System.Windows.Forms.Button BtnReparacion;
        private System.Windows.Forms.Button BtnRegistrarCliente;
        private System.Windows.Forms.Button BtnBaseFalla;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnEstadisticas;
    }
}