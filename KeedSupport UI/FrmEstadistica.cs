using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Entity;
using BLL;
using System.Windows.Forms.DataVisualization.Charting;


namespace KeedSupport_UI
{
    public partial class FrmEstadistica : Form
    {

        OrdenServicioService service;
        List<OrdenDeServicio> ordenes = new List<OrdenDeServicio>();
        public FrmEstadistica()
        {
            InitializeComponent();
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            service = new OrdenServicioService(connectionString);
            DgvEstadistica.DataSource = null;
            ordenes.Clear();
            ordenes = service.Consultar();
            DgvEstadistica.DataSource = ordenes;
            TxtCelular.Text = service.TotalizarCelular().ToString();
            TxtPC.Text = service.TotalizarPC().ToString();
            TxtImpresora.Text = service.TotalizarImpresora().ToString();
            TxtConsola.Text = service.TotalizarConsola().ToString();

        }

       

        private void FrmEstadistica_Load(object sender, EventArgs e)
        {
            int celular = int.Parse(TxtCelular.Text);
            int pc = int.Parse(TxtPC.Text);
            int impresora = int.Parse(TxtImpresora.Text);
            int consola = int.Parse(TxtConsola.Text);
            string[] series = { "Celular", "PC" ,"Impresora", "Consola de videjuegos"};
            int[] cantidad = { celular, pc, impresora,consola };
            chart1.Palette = ChartColorPalette.Bright;
            chart1.Titles.Add("Estadisticas de Equipos");
            for (int i = 0; i < series.Length; i++)
            {
                Series DATOS = chart1.Series.Add(series[i]);

                DATOS.Label = cantidad[i].ToString();

                DATOS.Points.Add(cantidad[i]);

            }
        }
    }
}
