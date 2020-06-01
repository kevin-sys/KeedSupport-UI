using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using System.Configuration;
using BLL;

namespace KeedSupport_UI
{
    public partial class FrmCliente : Form
    {
        Cliente cliente;
        ClienteService clienteService;
        public FrmCliente()
        {
            InitializeComponent();
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            clienteService = new ClienteService(connectionString);
        }

        private Cliente MapearCliente()
        {
            cliente = new Cliente();
            cliente.Identificacion = TxtIdentificacion.Text.Trim();
            cliente.PrimerNombre = TxtPrimerNombre.Text.Trim();
            cliente.SegundoNombre = TxtSegundoNombre.Text.Trim();
            cliente.PrimerApellido = TxtPrimerApellido.Text.Trim();
            cliente.SegundoApellido = TxtSegundoApellido.Text.Trim();
            cliente.Telefono = TxtTelefono.Text.Trim();
            cliente.FechaNacimiento = DtaFechaNacimiento.Value;
            cliente.Direccion = TxtDireccion.Text.Trim();
            cliente.Ciudad = TxtCiudad.Text.Trim();
            cliente.FechaRegistro = DtaFechaRegistro.Value;
            cliente.Correo = TxtCorreo.Text.Trim();
            return cliente;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            
        }

        private void TxtPrimerNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void TxtSegundoApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCiudad_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtIdentificacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            label1.Visible = false;
            if(TxtIdentificacion.Text == "")
            {
                label1.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void TxtPrimerNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            label2.Visible = false;
            if (TxtPrimerNombre.Text == "")
            {
                label2.Visible = true;
            }
        }

        private void TxtSegundoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            label3.Visible = false;
            if (TxtSegundoNombre.Text == "")
            {
                label3.Visible = true;
            }
        }

        private void TxtPrimerApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            label4.Visible = false;
            if (TxtPrimerApellido.Text == "")
            {
                label4.Visible = true;
            }
        }

        private void TxtSegundoApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            label5.Visible = false;
            if (TxtSegundoApellido.Text == "")
            {
                label5.Visible = true;
            }
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            label6.Visible = false;
            if (TxtTelefono.Text == "")
            {
                label6.Visible = true;
            }
        }

        private void TxtCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            label9.Visible = false;
            if (TxtCiudad.Text == "")
            {
                label9.Visible = true;
            }
        }

        private void TxtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            label8.Visible = false;
            if (TxtDireccion.Text == "")
            {
                label8.Visible = true;
            }
        }

        private void TxtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            label11.Visible = false;
            if (TxtCorreo.Text == "")
            {
                label11.Visible = true;
            }
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuardarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = MapearCliente();
            String mensaje = clienteService.Guardar(cliente);
            MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

        }
    }
}
