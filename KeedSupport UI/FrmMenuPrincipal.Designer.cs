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
            this.BtnMenu = new System.Windows.Forms.Button();
            this.BtnOrden = new System.Windows.Forms.Button();
            this.BtnPresupuesto = new System.Windows.Forms.Button();
            this.BrnBaseFallas = new System.Windows.Forms.Button();
            this.BtnVenta = new System.Windows.Forms.Button();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackgroundImage = global::KeedSupport_UI.Properties.Resources.Sin_título1;
            this.BtnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMenu.Location = new System.Drawing.Point(0, -2);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(98, 74);
            this.BtnMenu.TabIndex = 3;
            this.BtnMenu.UseVisualStyleBackColor = true;
            this.BtnMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnOrden
            // 
            this.BtnOrden.BackColor = System.Drawing.Color.Black;
            this.BtnOrden.BackgroundImage = global::KeedSupport_UI.Properties.Resources.orden;
            this.BtnOrden.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnOrden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOrden.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnOrden.Location = new System.Drawing.Point(12, 16);
            this.BtnOrden.Name = "BtnOrden";
            this.BtnOrden.Size = new System.Drawing.Size(70, 62);
            this.BtnOrden.TabIndex = 4;
            this.BtnOrden.UseVisualStyleBackColor = false;
            this.BtnOrden.Click += new System.EventHandler(this.BtnOrden_Click);
            this.BtnOrden.MouseLeave += new System.EventHandler(this.BtnOrden_MouseLeave);
            this.BtnOrden.MouseHover += new System.EventHandler(this.BtnOrden_MouseHover);
            // 
            // BtnPresupuesto
            // 
            this.BtnPresupuesto.BackColor = System.Drawing.Color.Black;
            this.BtnPresupuesto.BackgroundImage = global::KeedSupport_UI.Properties.Resources.presupuesto;
            this.BtnPresupuesto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPresupuesto.Location = new System.Drawing.Point(12, 250);
            this.BtnPresupuesto.Name = "BtnPresupuesto";
            this.BtnPresupuesto.Size = new System.Drawing.Size(70, 62);
            this.BtnPresupuesto.TabIndex = 5;
            this.BtnPresupuesto.UseVisualStyleBackColor = false;
            this.BtnPresupuesto.Click += new System.EventHandler(this.BtnPresupuesto_Click);
            this.BtnPresupuesto.MouseLeave += new System.EventHandler(this.BtnPresupuesto_MouseLeave);
            this.BtnPresupuesto.MouseHover += new System.EventHandler(this.BtnPresupuesto_MouseHover);
            // 
            // BrnBaseFallas
            // 
            this.BrnBaseFallas.BackColor = System.Drawing.Color.Black;
            this.BrnBaseFallas.BackgroundImage = global::KeedSupport_UI.Properties.Resources.ajustes;
            this.BrnBaseFallas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BrnBaseFallas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BrnBaseFallas.Location = new System.Drawing.Point(12, 372);
            this.BrnBaseFallas.Name = "BrnBaseFallas";
            this.BrnBaseFallas.Size = new System.Drawing.Size(70, 60);
            this.BrnBaseFallas.TabIndex = 6;
            this.BrnBaseFallas.UseVisualStyleBackColor = false;
            this.BrnBaseFallas.MouseLeave += new System.EventHandler(this.BrnBaseFallas_MouseLeave);
            this.BrnBaseFallas.MouseHover += new System.EventHandler(this.BrnBaseFallas_MouseHover);
            // 
            // BtnVenta
            // 
            this.BtnVenta.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnVenta.BackgroundImage = global::KeedSupport_UI.Properties.Resources.inmobiliaria;
            this.BtnVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnVenta.Location = new System.Drawing.Point(12, 141);
            this.BtnVenta.Name = "BtnVenta";
            this.BtnVenta.Size = new System.Drawing.Size(70, 60);
            this.BtnVenta.TabIndex = 7;
            this.BtnVenta.UseVisualStyleBackColor = false;
            this.BtnVenta.MouseLeave += new System.EventHandler(this.BtnVenta_MouseLeave);
            this.BtnVenta.MouseHover += new System.EventHandler(this.BtnVenta_MouseHover);
            // 
            // panel_menu
            // 
            this.panel_menu.BackgroundImage = global::KeedSupport_UI.Properties.Resources.negro;
            this.panel_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_menu.Controls.Add(this.BtnVenta);
            this.panel_menu.Controls.Add(this.BrnBaseFallas);
            this.panel_menu.Controls.Add(this.BtnPresupuesto);
            this.panel_menu.Controls.Add(this.BtnOrden);
            this.panel_menu.Location = new System.Drawing.Point(0, 71);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(98, 502);
            this.panel_menu.TabIndex = 0;
            this.panel_menu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Registrar cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(79, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Crear Orden";
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(83, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cotización";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(80, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Base de Fallas";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BackgroundImage = global::KeedSupport_UI.Properties.Resources.Sin_título;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Location = new System.Drawing.Point(262, 179);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(310, 232);
            this.panel6.TabIndex = 1;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KeedSupport_UI.Properties.Resources.sw;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(718, 566);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.panel_menu);
            this.IsMdiContainer = true;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.panel_menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Button BtnOrden;
        private System.Windows.Forms.Button BtnPresupuesto;
        private System.Windows.Forms.Button BrnBaseFallas;
        private System.Windows.Forms.Button BtnVenta;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
    }
}