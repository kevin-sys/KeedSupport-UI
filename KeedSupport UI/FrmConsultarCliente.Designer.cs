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
            this.DgvConsultarCliente = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsultarCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvConsultarCliente
            // 
            this.DgvConsultarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvConsultarCliente.Location = new System.Drawing.Point(12, 102);
            this.DgvConsultarCliente.Name = "DgvConsultarCliente";
            this.DgvConsultarCliente.Size = new System.Drawing.Size(525, 150);
            this.DgvConsultarCliente.TabIndex = 0;
            this.DgvConsultarCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvConsultarCliente_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado de clientes";
            // 
            // FrmConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 304);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvConsultarCliente);
            this.Name = "FrmConsultarCliente";
            this.Text = "Listado de clientes";
            this.Load += new System.EventHandler(this.FrmConsultarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsultarCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvConsultarCliente;
        private System.Windows.Forms.Label label1;
    }
}