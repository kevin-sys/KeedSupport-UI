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
            this.BtnGuardar = new System.Windows.Forms.Button();
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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(634, 115);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 0;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtCodigoFalla
            // 
            this.TxtCodigoFalla.Location = new System.Drawing.Point(57, 11);
            this.TxtCodigoFalla.Name = "TxtCodigoFalla";
            this.TxtCodigoFalla.Size = new System.Drawing.Size(100, 20);
            this.TxtCodigoFalla.TabIndex = 1;
            // 
            // TxtMarca
            // 
            this.TxtMarca.Location = new System.Drawing.Point(57, 131);
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.Size = new System.Drawing.Size(100, 20);
            this.TxtMarca.TabIndex = 3;
            // 
            // TxtFalla
            // 
            this.TxtFalla.Location = new System.Drawing.Point(44, 247);
            this.TxtFalla.Name = "TxtFalla";
            this.TxtFalla.Size = new System.Drawing.Size(229, 96);
            this.TxtFalla.TabIndex = 4;
            this.TxtFalla.Text = "";
            // 
            // DtaFechaRegistro
            // 
            this.DtaFechaRegistro.Location = new System.Drawing.Point(57, 43);
            this.DtaFechaRegistro.Name = "DtaFechaRegistro";
            this.DtaFechaRegistro.Size = new System.Drawing.Size(200, 20);
            this.DtaFechaRegistro.TabIndex = 5;
            // 
            // TxtModelo
            // 
            this.TxtModelo.Location = new System.Drawing.Point(57, 178);
            this.TxtModelo.Name = "TxtModelo";
            this.TxtModelo.Size = new System.Drawing.Size(100, 20);
            this.TxtModelo.TabIndex = 6;
            // 
            // TxtSintomas
            // 
            this.TxtSintomas.Location = new System.Drawing.Point(353, 247);
            this.TxtSintomas.Name = "TxtSintomas";
            this.TxtSintomas.Size = new System.Drawing.Size(229, 96);
            this.TxtSintomas.TabIndex = 7;
            this.TxtSintomas.Text = "";
            // 
            // TxtSolucion
            // 
            this.TxtSolucion.Location = new System.Drawing.Point(634, 247);
            this.TxtSolucion.Name = "TxtSolucion";
            this.TxtSolucion.Size = new System.Drawing.Size(229, 96);
            this.TxtSolucion.TabIndex = 8;
            this.TxtSolucion.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Codigo de falla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Fecha de Registro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
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
            this.CmbTipoEquipo.Location = new System.Drawing.Point(57, 88);
            this.CmbTipoEquipo.Name = "CmbTipoEquipo";
            this.CmbTipoEquipo.Size = new System.Drawing.Size(200, 21);
            this.CmbTipoEquipo.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Marca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Modelo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Falla";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(442, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Sintomas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(714, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Solución";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(576, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmBaseDeFallas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 415);
            this.Controls.Add(this.button1);
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
            this.Controls.Add(this.BtnGuardar);
            this.Name = "FrmBaseDeFallas";
            this.Text = "FrmBaseDeFallas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGuardar;
       
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
        private System.Windows.Forms.Button button1;
    }
}