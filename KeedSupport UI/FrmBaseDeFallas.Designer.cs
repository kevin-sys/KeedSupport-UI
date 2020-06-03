namespace KeedSupport_UI
{
    partial class FrmBaseDeFallas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaseDeFallas));
            this.TxtCodigoFalla = new System.Windows.Forms.TextBox();
            this.TxtMarca = new System.Windows.Forms.TextBox();
            this.TxtFalla = new System.Windows.Forms.RichTextBox();
            this.DtaFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.TxtModelo = new System.Windows.Forms.TextBox();
            this.TxtSintomas = new System.Windows.Forms.RichTextBox();
            this.TxtSolucion = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbTipoEquipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.BtnVolver = new System.Windows.Forms.PictureBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.PictureBox();
            this.BtnGuardarBaseFalla = new System.Windows.Forms.PictureBox();
            this.DgvBdFallas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardarBaseFalla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBdFallas)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtCodigoFalla
            // 
            this.TxtCodigoFalla.Location = new System.Drawing.Point(138, 76);
            this.TxtCodigoFalla.Name = "TxtCodigoFalla";
            this.TxtCodigoFalla.Size = new System.Drawing.Size(110, 20);
            this.TxtCodigoFalla.TabIndex = 1;
            // 
            // TxtMarca
            // 
            this.TxtMarca.Location = new System.Drawing.Point(138, 200);
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.Size = new System.Drawing.Size(110, 20);
            this.TxtMarca.TabIndex = 3;
            // 
            // TxtFalla
            // 
            this.TxtFalla.Location = new System.Drawing.Point(353, 79);
            this.TxtFalla.Name = "TxtFalla";
            this.TxtFalla.Size = new System.Drawing.Size(221, 73);
            this.TxtFalla.TabIndex = 4;
            this.TxtFalla.Text = "";
            // 
            // DtaFechaRegistro
            // 
            this.DtaFechaRegistro.Location = new System.Drawing.Point(138, 117);
            this.DtaFechaRegistro.Name = "DtaFechaRegistro";
            this.DtaFechaRegistro.Size = new System.Drawing.Size(200, 20);
            this.DtaFechaRegistro.TabIndex = 5;
            // 
            // TxtModelo
            // 
            this.TxtModelo.Location = new System.Drawing.Point(138, 241);
            this.TxtModelo.Name = "TxtModelo";
            this.TxtModelo.Size = new System.Drawing.Size(110, 20);
            this.TxtModelo.TabIndex = 6;
            // 
            // TxtSintomas
            // 
            this.TxtSintomas.Location = new System.Drawing.Point(353, 293);
            this.TxtSintomas.Name = "TxtSintomas";
            this.TxtSintomas.Size = new System.Drawing.Size(221, 73);
            this.TxtSintomas.TabIndex = 7;
            this.TxtSintomas.Text = "";
            // 
            // TxtSolucion
            // 
            this.TxtSolucion.Location = new System.Drawing.Point(353, 183);
            this.TxtSolucion.Name = "TxtSolucion";
            this.TxtSolucion.Size = new System.Drawing.Size(221, 73);
            this.TxtSolucion.TabIndex = 8;
            this.TxtSolucion.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Codigo de falla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Fecha de Registro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tipo de equipo";
            // 
            // CmbTipoEquipo
            // 
            this.CmbTipoEquipo.FormattingEnabled = true;
            this.CmbTipoEquipo.Items.AddRange(new object[] {
            "Seleccione",
            "Computador portatil",
            "Computador de mesa",
            "Celular",
            "Consola de video juegos"});
            this.CmbTipoEquipo.Location = new System.Drawing.Point(138, 158);
            this.CmbTipoEquipo.Name = "CmbTipoEquipo";
            this.CmbTipoEquipo.Size = new System.Drawing.Size(110, 21);
            this.CmbTipoEquipo.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Marca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(77, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Modelo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(358, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Falla";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(362, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Sintomas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(356, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Solución";
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(194, 9);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(198, 44);
            this.label24.TabIndex = 84;
            this.label24.Text = "Base de fallas";
            this.label24.Click += new System.EventHandler(this.label24_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(8, 348);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(111, 16);
            this.label33.TabIndex = 100;
            this.label33.Text = "Volver al menu";
            // 
            // BtnVolver
            // 
            this.BtnVolver.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BtnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVolver.Image = ((System.Drawing.Image)(resources.GetObject("BtnVolver.Image")));
            this.BtnVolver.Location = new System.Drawing.Point(28, 304);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(55, 41);
            this.BtnVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnVolver.TabIndex = 99;
            this.BtnVolver.TabStop = false;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(140, 348);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(70, 16);
            this.label31.TabIndex = 98;
            this.label31.Text = "Cancelar";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(247, 348);
            this.label29.Name = "label29";
            this.label29.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label29.Size = new System.Drawing.Size(64, 16);
            this.label29.TabIndex = 93;
            this.label29.Text = "Guardar";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.Image")));
            this.BtnCancelar.Location = new System.Drawing.Point(149, 304);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(55, 41);
            this.BtnCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCancelar.TabIndex = 96;
            this.BtnCancelar.TabStop = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGuardarBaseFalla
            // 
            this.BtnGuardarBaseFalla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BtnGuardarBaseFalla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardarBaseFalla.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardarBaseFalla.Image")));
            this.BtnGuardarBaseFalla.Location = new System.Drawing.Point(253, 304);
            this.BtnGuardarBaseFalla.Name = "BtnGuardarBaseFalla";
            this.BtnGuardarBaseFalla.Size = new System.Drawing.Size(55, 41);
            this.BtnGuardarBaseFalla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnGuardarBaseFalla.TabIndex = 94;
            this.BtnGuardarBaseFalla.TabStop = false;
            this.BtnGuardarBaseFalla.Click += new System.EventHandler(this.BtnGuardarBaseFalla_Click);
            // 
            // DgvBdFallas
            // 
            this.DgvBdFallas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBdFallas.Location = new System.Drawing.Point(12, 384);
            this.DgvBdFallas.Name = "DgvBdFallas";
            this.DgvBdFallas.Size = new System.Drawing.Size(562, 150);
            this.DgvBdFallas.TabIndex = 101;
            // 
            // FrmBaseDeFallas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(596, 546);
            this.Controls.Add(this.DgvBdFallas);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardarBaseFalla);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmbTipoEquipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSolucion);
            this.Controls.Add(this.TxtSintomas);
            this.Controls.Add(this.TxtModelo);
            this.Controls.Add(this.DtaFechaRegistro);
            this.Controls.Add(this.TxtFalla);
            this.Controls.Add(this.TxtMarca);
            this.Controls.Add(this.TxtCodigoFalla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmBaseDeFallas";
            this.Text = "FrmBaseDeFallas";
            this.Load += new System.EventHandler(this.FrmBaseDeFallas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnVolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardarBaseFalla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBdFallas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
       
        private System.Windows.Forms.TextBox TxtCodigoFalla;
        private System.Windows.Forms.TextBox TxtMarca;
        private System.Windows.Forms.RichTextBox TxtFalla;
        private System.Windows.Forms.DateTimePicker DtaFechaRegistro;
        private System.Windows.Forms.TextBox TxtModelo;
        private System.Windows.Forms.RichTextBox TxtSintomas;
        private System.Windows.Forms.RichTextBox TxtSolucion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbTipoEquipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.PictureBox BtnVolver;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.PictureBox BtnCancelar;
        private System.Windows.Forms.PictureBox BtnGuardarBaseFalla;
        private System.Windows.Forms.DataGridView DgvBdFallas;
    }
}