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
    public partial class FrmGenerarInforme : Form
    {
        OrdenServicioService service;
        List<OrdenDeServicio> ordenes = new List<OrdenDeServicio>();
        public FrmGenerarInforme()
        {
            InitializeComponent();
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            service = new OrdenServicioService(connectionString);
            DgvOrden.DataSource = null;
            ordenes.Clear();
            ordenes = service.Consultar();
            DgvOrden.DataSource = ordenes;
        }

    }
}
