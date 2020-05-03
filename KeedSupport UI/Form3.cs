using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (panel_menu.Visible == true)
            {
                panel_menu.Visible = false;
            }
            else
            {
                panel_menu.Visible = true;
            }
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void BtnOrden_Click(object sender, EventArgs e)
        {
            
            FrmCliente formCliente = new FrmCliente();
            formCliente.MdiParent = this;
            formCliente.Show();
            panel6.Visible = false;
        }

        private void BtnOrden_MouseHover(object sender, EventArgs e)
        {
            BtnOrden.Size = new Size(75, 67);
            label1.Visible = true;
        }

        private void BtnOrden_MouseLeave(object sender, EventArgs e)
        {
            BtnOrden.Size = new Size(70, 62);
            label1.Visible = false;
        }

        private void BtnVenta_MouseHover(object sender, EventArgs e)
        {
            BtnVenta.Size = new Size(75, 65);
            label2.Visible = true;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {

        }

        private void BtnVenta_MouseLeave(object sender, EventArgs e)
        {
            BtnVenta.Size = new Size(70, 60);
            label2.Visible = false;
        }

        private void BtnPresupuesto_Click(object sender, EventArgs e)
        {

        }

        private void BtnPresupuesto_MouseHover(object sender, EventArgs e)
        {
            BtnPresupuesto.Size = new Size(75, 67);
            label3.Visible = true;
        }

        private void BtnPresupuesto_MouseLeave(object sender, EventArgs e)
        {
            BtnPresupuesto.Size = new Size(70, 62);
            label3.Visible = false;
        }

        private void BrnBaseFallas_MouseHover(object sender, EventArgs e)
        {
            BrnBaseFallas.Size = new Size(75, 65);
            label4.Visible = true;
        }

        private void BrnBaseFallas_MouseLeave(object sender, EventArgs e)
        {
            BrnBaseFallas.Size = new Size(70, 60);
            label4.Visible = false;
        }
    }
}
