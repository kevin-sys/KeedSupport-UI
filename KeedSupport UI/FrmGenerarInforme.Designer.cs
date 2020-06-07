namespace KeedSupport_UI
{
    partial class FrmGenerarInforme
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
            this.TxtNumeroOrden = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvOrden = new System.Windows.Forms.DataGridView();
            this.DgvDetalle = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNumeroOrden
            // 
            this.TxtNumeroOrden.Location = new System.Drawing.Point(124, 26);
            this.TxtNumeroOrden.Name = "TxtNumeroOrden";
            this.TxtNumeroOrden.Size = new System.Drawing.Size(100, 20);
            this.TxtNumeroOrden.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite número orden";
            // 
            // DgvOrden
            // 
            this.DgvOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOrden.Location = new System.Drawing.Point(19, 61);
            this.DgvOrden.Name = "DgvOrden";
            this.DgvOrden.Size = new System.Drawing.Size(752, 150);
            this.DgvOrden.TabIndex = 2;
            // 
            // DgvDetalle
            // 
            this.DgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDetalle.Location = new System.Drawing.Point(19, 238);
            this.DgvDetalle.Name = "DgvDetalle";
            this.DgvDetalle.Size = new System.Drawing.Size(752, 150);
            this.DgvDetalle.TabIndex = 3;
            // 
            // FrmGenerarInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgvDetalle);
            this.Controls.Add(this.DgvOrden);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNumeroOrden);
            this.Name = "FrmGenerarInforme";
            this.Text = "FrmGenerarInforme";
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNumeroOrden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvOrden;
        private System.Windows.Forms.DataGridView DgvDetalle;
    }
}