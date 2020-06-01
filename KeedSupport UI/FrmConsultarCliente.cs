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
       
        public FrmConsultarCliente()
        {
            InitializeComponent();
        }

        List<Cliente> clientes = new List<Cliente>();
        private void BtnConsultar_Click(object sender, EventArgs e)
        {
           
        }

        private void FrmConsultarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
