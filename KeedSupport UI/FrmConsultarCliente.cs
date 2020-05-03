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

namespace KeedSupport_UI
{
    public partial class FrmConsultarCliente : Form
    {
        ClienteService service = new ClienteService();
        public FrmConsultarCliente()
        {
            InitializeComponent();
        }

        List<Cliente> clientes = new List<Cliente>();
        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            DtgConsultarCliente.DataSource = null;
            clientes.Clear();
            clientes = service.Consultar();
            DtgConsultarCliente.DataSource = clientes;
        }

        private void FrmConsultarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
