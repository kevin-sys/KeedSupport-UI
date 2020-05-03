namespace KeedSupport_UI
{
    partial class FrmCliente
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
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtPrimerNombre = new System.Windows.Forms.TextBox();
            this.TxtSegundoNombre = new System.Windows.Forms.TextBox();
            this.TxtPrimerApellido = new System.Windows.Forms.TextBox();
            this.TxtSegundoApellido = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtCiudad = new System.Windows.Forms.TextBox();
            this.DtaFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.DtaFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardar.Location = new System.Drawing.Point(394, 342);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(146, 54);
            this.BtnGuardar.TabIndex = 0;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtPrimerNombre
            // 
            this.TxtPrimerNombre.Location = new System.Drawing.Point(80, 73);
            this.TxtPrimerNombre.Multiline = true;
            this.TxtPrimerNombre.Name = "TxtPrimerNombre";
            this.TxtPrimerNombre.Size = new System.Drawing.Size(148, 28);
            this.TxtPrimerNombre.TabIndex = 1;
            this.TxtPrimerNombre.TextChanged += new System.EventHandler(this.TxtPrimerNombre_TextChanged);
            this.TxtPrimerNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrimerNombre_KeyPress);
            // 
            // TxtSegundoNombre
            // 
            this.TxtSegundoNombre.Location = new System.Drawing.Point(239, 73);
            this.TxtSegundoNombre.Multiline = true;
            this.TxtSegundoNombre.Name = "TxtSegundoNombre";
            this.TxtSegundoNombre.Size = new System.Drawing.Size(148, 28);
            this.TxtSegundoNombre.TabIndex = 2;
            this.TxtSegundoNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSegundoNombre_KeyPress);
            // 
            // TxtPrimerApellido
            // 
            this.TxtPrimerApellido.Location = new System.Drawing.Point(80, 115);
            this.TxtPrimerApellido.Multiline = true;
            this.TxtPrimerApellido.Name = "TxtPrimerApellido";
            this.TxtPrimerApellido.Size = new System.Drawing.Size(148, 28);
            this.TxtPrimerApellido.TabIndex = 3;
            this.TxtPrimerApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrimerApellido_KeyPress);
            // 
            // TxtSegundoApellido
            // 
            this.TxtSegundoApellido.Location = new System.Drawing.Point(237, 115);
            this.TxtSegundoApellido.Multiline = true;
            this.TxtSegundoApellido.Name = "TxtSegundoApellido";
            this.TxtSegundoApellido.Size = new System.Drawing.Size(148, 28);
            this.TxtSegundoApellido.TabIndex = 4;
            this.TxtSegundoApellido.TextChanged += new System.EventHandler(this.TxtSegundoApellido_TextChanged);
            this.TxtSegundoApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSegundoApellido_KeyPress);
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(78, 230);
            this.TxtTelefono.Multiline = true;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(148, 28);
            this.TxtTelefono.TabIndex = 5;
            this.TxtTelefono.TextChanged += new System.EventHandler(this.TxtTelefono_TextChanged);
            this.TxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefono_KeyPress);
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(240, 272);
            this.TxtDireccion.Multiline = true;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(148, 28);
            this.TxtDireccion.TabIndex = 7;
            this.TxtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDireccion_KeyPress);
            // 
            // TxtCiudad
            // 
            this.TxtCiudad.Location = new System.Drawing.Point(78, 273);
            this.TxtCiudad.Multiline = true;
            this.TxtCiudad.Name = "TxtCiudad";
            this.TxtCiudad.Size = new System.Drawing.Size(148, 28);
            this.TxtCiudad.TabIndex = 8;
            this.TxtCiudad.TextChanged += new System.EventHandler(this.TxtCiudad_TextChanged);
            this.TxtCiudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCiudad_KeyPress);
            // 
            // DtaFechaRegistro
            // 
            this.DtaFechaRegistro.Location = new System.Drawing.Point(90, 341);
            this.DtaFechaRegistro.Name = "DtaFechaRegistro";
            this.DtaFechaRegistro.Size = new System.Drawing.Size(200, 20);
            this.DtaFechaRegistro.TabIndex = 9;
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Location = new System.Drawing.Point(273, 230);
            this.TxtCorreo.Multiline = true;
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(148, 28);
            this.TxtCorreo.TabIndex = 10;
            this.TxtCorreo.TextChanged += new System.EventHandler(this.TxtCorreo_TextChanged);
            this.TxtCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCorreo_KeyPress);
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.BackColor = System.Drawing.SystemColors.Window;
            this.TxtIdentificacion.Location = new System.Drawing.Point(80, 28);
            this.TxtIdentificacion.Multiline = true;
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(148, 28);
            this.TxtIdentificacion.TabIndex = 11;
            this.TxtIdentificacion.TextChanged += new System.EventHandler(this.TxtIdentificacion_TextChanged);
            this.TxtIdentificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIdentificacion_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(100, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Identificación ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(98, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(249, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Segundo Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(93, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Primer Apellido";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(246, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Segundo Apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(93, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Telefono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(254, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Direccion";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label9.Location = new System.Drawing.Point(92, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Ciudad ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Silver;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(50, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Fecha de Registro";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label11.Location = new System.Drawing.Point(286, 233);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Correo";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(80, 320);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 57);
            this.panel2.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(98, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "Fecha de nacimiento ";
            // 
            // DtaFechaNacimiento
            // 
            this.DtaFechaNacimiento.Location = new System.Drawing.Point(86, 186);
            this.DtaFechaNacimiento.Name = "DtaFechaNacimiento";
            this.DtaFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.DtaFechaNacimiento.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(76, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 57);
            this.panel1.TabIndex = 36;
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = global::KeedSupport_UI.Properties.Resources.calendario;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Location = new System.Drawing.Point(42, 173);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(30, 26);
            this.panel7.TabIndex = 37;
            // 
            // panel11
            // 
            this.panel11.BackgroundImage = global::KeedSupport_UI.Properties.Resources.calendario;
            this.panel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel11.Location = new System.Drawing.Point(44, 335);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(30, 26);
            this.panel11.TabIndex = 33;
            // 
            // panel10
            // 
            this.panel10.BackgroundImage = global::KeedSupport_UI.Properties.Resources.correo;
            this.panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel10.Location = new System.Drawing.Point(237, 230);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(30, 26);
            this.panel10.TabIndex = 32;
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = global::KeedSupport_UI.Properties.Resources.telefono;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Location = new System.Drawing.Point(42, 230);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(30, 26);
            this.panel8.TabIndex = 30;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::KeedSupport_UI.Properties.Resources.alfiler;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Location = new System.Drawing.Point(42, 274);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(30, 26);
            this.panel6.TabIndex = 29;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::KeedSupport_UI.Properties.Resources.nombre1;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(42, 121);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(30, 26);
            this.panel5.TabIndex = 27;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::KeedSupport_UI.Properties.Resources.nombre1;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(44, 76);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(30, 26);
            this.panel4.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::KeedSupport_UI.Properties.Resources.huella_dactilar;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(42, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(30, 26);
            this.panel3.TabIndex = 25;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(559, 419);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DtaFechaNacimiento);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DtaFechaRegistro);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtIdentificacion);
            this.Controls.Add(this.TxtCorreo);
            this.Controls.Add(this.TxtCiudad);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.TxtSegundoApellido);
            this.Controls.Add(this.TxtPrimerApellido);
            this.Controls.Add(this.TxtSegundoNombre);
            this.Controls.Add(this.TxtPrimerNombre);
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar cliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TxtPrimerNombre;
        private System.Windows.Forms.TextBox TxtSegundoNombre;
        private System.Windows.Forms.TextBox TxtPrimerApellido;
        private System.Windows.Forms.TextBox TxtSegundoApellido;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtCiudad;
        private System.Windows.Forms.DateTimePicker DtaFechaRegistro;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.TextBox TxtIdentificacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DtaFechaNacimiento;
        private System.Windows.Forms.Panel panel1;
    }
}

