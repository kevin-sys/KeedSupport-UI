namespace KeedSupport_UI
{
    partial class FrmConsultarCliente
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
            this.DtgConsultarCliente = new System.Windows.Forms.DataGridView();
            this.BtnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtgConsultarCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgConsultarCliente
            // 
            this.DtgConsultarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgConsultarCliente.Location = new System.Drawing.Point(24, 139);
            this.DtgConsultarCliente.Name = "DtgConsultarCliente";
            this.DtgConsultarCliente.Size = new System.Drawing.Size(764, 150);
            this.DtgConsultarCliente.TabIndex = 0;
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(498, 352);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(75, 23);
            this.BtnConsultar.TabIndex = 1;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // FrmConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.DtgConsultarCliente);
            this.Name = "FrmConsultarCliente";
            this.Text = "FrmConsultarCliente";
            this.Load += new System.EventHandler(this.FrmConsultarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgConsultarCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgConsultarCliente;
        private System.Windows.Forms.Button BtnConsultar;
    }
}