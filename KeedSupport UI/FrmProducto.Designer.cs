﻿namespace KeedSupport_UI
{
    partial class FrmProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProducto));
            this.TxtCodigoProducto = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.TxtServicioProducto = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.BtnGuardarReparacion = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardarReparacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtCodigoProducto
            // 
            this.TxtCodigoProducto.Location = new System.Drawing.Point(324, 108);
            this.TxtCodigoProducto.Name = "TxtCodigoProducto";
            this.TxtCodigoProducto.Size = new System.Drawing.Size(60, 20);
            this.TxtCodigoProducto.TabIndex = 81;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(330, 92);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(46, 13);
            this.label34.TabIndex = 82;
            this.label34.Text = "Codigo";
            // 
            // TxtServicioProducto
            // 
            this.TxtServicioProducto.Location = new System.Drawing.Point(39, 108);
            this.TxtServicioProducto.Name = "TxtServicioProducto";
            this.TxtServicioProducto.Size = new System.Drawing.Size(121, 20);
            this.TxtServicioProducto.TabIndex = 75;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(42, 92);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 13);
            this.label15.TabIndex = 76;
            this.label15.Text = "Servicio o producto";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(407, 108);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(77, 20);
            this.TxtPrecio.TabIndex = 79;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(422, 92);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 80;
            this.label17.Text = "Precio";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(181, 108);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(121, 20);
            this.TxtDescripcion.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 84;
            this.label1.Text = "Descripción";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(420, 200);
            this.label29.Name = "label29";
            this.label29.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label29.Size = new System.Drawing.Size(64, 16);
            this.label29.TabIndex = 85;
            this.label29.Text = "Guardar";
            // 
            // BtnGuardarReparacion
            // 
            this.BtnGuardarReparacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BtnGuardarReparacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardarReparacion.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardarReparacion.Image")));
            this.BtnGuardarReparacion.Location = new System.Drawing.Point(429, 156);
            this.BtnGuardarReparacion.Name = "BtnGuardarReparacion";
            this.BtnGuardarReparacion.Size = new System.Drawing.Size(55, 41);
            this.BtnGuardarReparacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnGuardarReparacion.TabIndex = 86;
            this.BtnGuardarReparacion.TabStop = false;
            this.BtnGuardarReparacion.Click += new System.EventHandler(this.BtnGuardarReparacion_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 245);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 115);
            this.dataGridView1.TabIndex = 87;
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 388);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.BtnGuardarReparacion);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCodigoProducto);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.TxtServicioProducto);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.label17);
            this.Name = "FrmProducto";
            this.Text = "FrmProducto";
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardarReparacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCodigoProducto;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox TxtServicioProducto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.PictureBox BtnGuardarReparacion;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}