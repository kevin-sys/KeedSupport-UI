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
    public partial class FrmOrdenServicio : Form
    {
        public FrmOrdenServicio()
        {
            InitializeComponent();
        }
      
        private void FrmOrdenServicio_Load(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
         
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void BtnCrearCliente_Click(object sender, EventArgs e)
        {
            FrmCliente cliente = new FrmCliente();
            cliente.Show();
        }

        private void BtnCancelarOrden_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void TxtServicioProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCrearOrden_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
