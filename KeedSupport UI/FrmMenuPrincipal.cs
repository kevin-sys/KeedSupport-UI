﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeedSupport_UI
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            hideSubMenu();
        }

      

        private void hideSubMenu()
        {
            PanelRegistrar.Visible = false;
            PanelConsultar.Visible = false;
            PanelGestion.Visible = false;
        }
        private void ValidarPaneles()
        {
            if (PanelRegistrar.Visible==true)
           
                PanelRegistrar.Visible = false; 
            
            if (PanelConsultar.Visible == true)
            
                PanelConsultar.Visible = false; 
            
            if (PanelGestion.Visible == true)
            
                PanelGestion.Visible = false;
            
        }

        private void showSubMenu(Panel Submenu)
        {
            if (Submenu.Visible==false)
            {
                hideSubMenu();
                Submenu.Visible = true;
            }
            else
            {
                Submenu.Visible = false;
            }
        }

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelRegistrar);

        }



        

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelConsultar);
        }

        private void BtnGestion_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelGestion);
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelConsultar.Controls.Add(childForm);
            PanelConsultar.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void BtnConsultar_Click_1(object sender, EventArgs e)
        {
            showSubMenu(PanelConsultar);
        }

        private void BtnGestion_Click_1(object sender, EventArgs e)
        {
            showSubMenu(PanelGestion);
        }

        private void BtnRegistrarOrden_Click(object sender, EventArgs e)
        {
          
            FrmOrdenServicio frmOrden = new FrmOrdenServicio();
            frmOrden.Show();
            hideSubMenu();
        }

        private void PanelCentral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnRegistrarCliente_Click(object sender, EventArgs e)
        {
            FrmCliente cliente = new FrmCliente();
            cliente.Show();
            hideSubMenu();

        }

        private void BtnReparacion_Click(object sender, EventArgs e)
        {
            FrmReparacion frmReparacion = new FrmReparacion();
            frmReparacion.Show();
            hideSubMenu();

        }

        private void BtnConsultarOrden_Click(object sender, EventArgs e)
        {
            FrmGenerarInforme frmGenerar = new FrmGenerarInforme();
            frmGenerar.Show();
            hideSubMenu();
        }

        private void BtnConsultaCliente_Click(object sender, EventArgs e)
        {
            FrmConsultarCliente frmConsultarCliente = new FrmConsultarCliente();
            frmConsultarCliente.Show();
            hideSubMenu();

        }

        private void BtnEntregarEquipo_Click(object sender, EventArgs e)
        {
            FrmEntrega entrega = new FrmEntrega();
            entrega.Show();
            hideSubMenu();

        }

        private void BtnCrearCupon_Click(object sender, EventArgs e)
        {
            FrmCupon frmCupon = new FrmCupon();
            frmCupon.Show();
            hideSubMenu();

        }

        private void BtnBaseFalla_Click(object sender, EventArgs e)
        {
            FrmBaseDeFallas deFallas = new FrmBaseDeFallas();
            deFallas.Show();
            hideSubMenu();

        }

        private void BtnEstadisticas_Click(object sender, EventArgs e)
        {
            FrmEstadistica estadistica = new FrmEstadistica();
            estadistica.Show();
            hideSubMenu();
        }

        private void Bntproducto_Click(object sender, EventArgs e)
        {
            FrmProducto producto = new FrmProducto();
            producto.Show();
            hideSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmReparacion reparacion = new FrmReparacion();
            reparacion.Show();
            hideSubMenu();
        }

        private void BtnConsultaEntregas_Click(object sender, EventArgs e)
        {
            FrmEntrega entrega = new FrmEntrega();
            entrega.Show();
            hideSubMenu();
        }
    }
}
