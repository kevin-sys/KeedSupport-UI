namespace KeedSupport_UI
{
    partial class FrmEstadistica
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.TxtCelular = new System.Windows.Forms.TextBox();
            this.TxtConsola = new System.Windows.Forms.TextBox();
            this.TxtImpresora = new System.Windows.Forms.TextBox();
            this.TxtPC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DgvEstadistica = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEstadistica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtCelular
            // 
            this.TxtCelular.Location = new System.Drawing.Point(169, 499);
            this.TxtCelular.Name = "TxtCelular";
            this.TxtCelular.ReadOnly = true;
            this.TxtCelular.Size = new System.Drawing.Size(100, 20);
            this.TxtCelular.TabIndex = 1;
            // 
            // TxtConsola
            // 
            this.TxtConsola.Location = new System.Drawing.Point(550, 499);
            this.TxtConsola.Name = "TxtConsola";
            this.TxtConsola.ReadOnly = true;
            this.TxtConsola.Size = new System.Drawing.Size(100, 20);
            this.TxtConsola.TabIndex = 2;
            // 
            // TxtImpresora
            // 
            this.TxtImpresora.Location = new System.Drawing.Point(423, 499);
            this.TxtImpresora.Name = "TxtImpresora";
            this.TxtImpresora.ReadOnly = true;
            this.TxtImpresora.Size = new System.Drawing.Size(100, 20);
            this.TxtImpresora.TabIndex = 3;
            // 
            // TxtPC
            // 
            this.TxtPC.Location = new System.Drawing.Point(296, 499);
            this.TxtPC.Name = "TxtPC";
            this.TxtPC.ReadOnly = true;
            this.TxtPC.Size = new System.Drawing.Size(100, 20);
            this.TxtPC.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 522);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Celular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 522);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Impresora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(547, 522);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Consola de videjuegos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 522);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "PC";
            // 
            // DgvEstadistica
            // 
            this.DgvEstadistica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEstadistica.Location = new System.Drawing.Point(12, 353);
            this.DgvEstadistica.Name = "DgvEstadistica";
            this.DgvEstadistica.ReadOnly = true;
            this.DgvEstadistica.Size = new System.Drawing.Size(801, 140);
            this.DgvEstadistica.TabIndex = 9;
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(801, 335);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "Equipos";
            // 
            // FrmEstadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 546);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.DgvEstadistica);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPC);
            this.Controls.Add(this.TxtImpresora);
            this.Controls.Add(this.TxtConsola);
            this.Controls.Add(this.TxtCelular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmEstadistica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.FrmEstadistica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvEstadistica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtCelular;
        private System.Windows.Forms.TextBox TxtConsola;
        private System.Windows.Forms.TextBox TxtImpresora;
        private System.Windows.Forms.TextBox TxtPC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DgvEstadistica;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}