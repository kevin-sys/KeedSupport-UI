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
using BLL;
using System.Configuration;


namespace KeedSupport_UI
{
    public partial class FrmConsultarCliente : Form
    {
        InterfaceIRecepcion FrmRecepcion;
        ClienteService service;
        List<Cliente> clientes = new List<Cliente>();
        public FrmConsultarCliente()
        {
            InitializeComponent();
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            service = new ClienteService(connectionString);
            DgvConsultarCliente.DataSource = null;
            clientes.Clear();
            clientes = service.Consultar();
            DgvConsultarCliente.DataSource = clientes;
        }
        public FrmConsultarCliente(InterfaceIRecepcion recepcion)
        {
            InitializeComponent();
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            service = new ClienteService(connectionString);
            FrmRecepcion = recepcion;
            DgvConsultarCliente.DataSource = null;
            clientes.Clear();
            clientes = service.Consultar();
            DgvConsultarCliente.DataSource = clientes;
        }
        private void BtnConsultar_Click(object sender, EventArgs e)
        {
           
        }

        private void FrmConsultarCliente_Load(object sender, EventArgs e)
        {

        }

        private void DgvConsultarCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (FrmRecepcion!=null)
            {
                Cliente cliente = (Cliente)DgvConsultarCliente.CurrentRow.DataBoundItem;
                FrmRecepcion.Recibir(cliente);
                this.Hide();
            }
        }
    }
}
