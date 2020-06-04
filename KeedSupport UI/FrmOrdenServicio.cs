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
    public partial class FrmOrdenServicio : Form
    {

        OrdenDeServicio orden;
        private DetalleOrdenServicioService detalle;

        Producto producto;
        private ProductoService productoService;
        OrdenServicioService service;

        public FrmOrdenServicio()
        {
            InitializeComponent();
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            service = new OrdenServicioService(connectionString);
           productoService = new ProductoService(connectionString);
            detalle = new DetalleOrdenServicioService(connectionString);
            producto = null;

            DgvDetalleServicio.AllowUserToAddRows = false;
            DgvDetalleServicio.ColumnCount = 7;
            DgvDetalleServicio.Columns[0].Name = "CodigoProducto";
            DgvDetalleServicio.Columns[1].Name = "CodigoProducto";
            DgvDetalleServicio.Columns[2].Name = "CodigoProducto";
            DgvDetalleServicio.Columns[3].Name = "CodigoProducto";
            DgvDetalleServicio.Columns[4].Name = "CodigoProducto";
            DgvDetalleServicio.Columns[5].Name = "CodigoProducto";
            DgvDetalleServicio.Columns[6].Name = "CodigoProducto";

        }

        private void FrmOrdenServicio_Load(object sender, EventArgs e)
        {

        }

        private OrdenDeServicio MapearOrden()
        {
            orden = new OrdenDeServicio();
            
            orden.NumeroOrden = TxtNumeroOrden.Text.Trim();
            orden.FechaOrden = DtpFechaOrden.Value.Date;


            orden.equipo.Tipo = CmbTipoEquipo.Text.Trim();
            orden.equipo.Modelo = TxtModelo.Text.Trim();
            orden.equipo.Marca = TxtMarca.Text.Trim();
            orden.equipo.NumeroSerie = TxtNumeroSerie.Text.Trim();
            orden.equipo.Color = TxtColor.Text.Trim();
            orden.equipo.FallaReportada = TxtFalla.Text.Trim();
            orden.equipo.EstadoEquipo = TxtEstadoEquipo.Text.Trim();
            orden.equipo.Accesorios = TxtEstadoEquipo.Text.Trim();


            orden.cliente.PrimerNombre = TxtNombreCliente.Text.Trim();
            orden.cliente.Identificacion = TxtIentificacion.Text.Trim();
            orden.cliente.Telefono = TxtTelefono.Text.Trim();
            orden.cliente.Direccion = TxtDireccion.Text.Trim();
            orden.cliente.Correo = TxtCorreo.Text.Trim();


            orden.SubTotal = float.Parse(TxtSubTotalOrden.Text);
            orden.IVA = float.Parse(TxtIvaOrden.Text);
            orden.TotalOrden = float.Parse(TxtTotalOrden.Text);
            orden.Abono = float.Parse(TxtAbono.Text);
            orden.Vueltos = float.Parse(TxtVueltos.Text);
            orden.Deuda = float.Parse(TxtDeuda.Text);


            return orden;
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
            OrdenDeServicio ordenservicio = MapearOrden();
            String mensaje = service.Guardar(ordenservicio);
            MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

        }

        private void label14_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AddDetalle();
            GetDetalles();
        }
       private void AddDetalle()
        {

            producto = productoService.Buscar(TxtCodigoProducto.Text);
            if (producto!=null)
            {
                DetalleOrdenServicio detalleOrden = new DetalleOrdenServicio();
                detalleOrden.Producto = producto;
                detalleOrden.Cantidad = Convert.ToInt32(TxtCantidad.Text);
                detalleOrden.CodigoProducto = producto.CodigoProducto;
                detalleOrden.DescripcionProducto = producto.Descripcion;
                detalleOrden.ValorUnitario = producto.Precio;

                if (detalleOrden.Cantidad <= producto.Cantidad)
                {
                    detalle.AddDetalle(detalleOrden);

                }
                else
                {
                    MessageBox.Show("cantidad disponible" + producto.NombreProducto + "es" + producto.Cantidad);

                }

            }
        }

        private void GetDetalles()
        {
            DgvDetalleServicio.Rows.Clear();
            int n = 0;
            foreach (var item in detalle.ConsultarDetalle())
            {
                DgvDetalleServicio.Rows.Add();
                item.CalcularSubtotal(item.Cantidad);
                DgvDetalleServicio.Rows[n].Cells[0].Value = item.Producto.CodigoProducto;
                DgvDetalleServicio.Rows[n].Cells[1].Value = item.Producto.NombreProducto;
                DgvDetalleServicio.Rows[n].Cells[2].Value = item.Cantidad;
                DgvDetalleServicio.Rows[n].Cells[3].Value = item.Producto.Precio;
                DgvDetalleServicio.Rows[n].Cells[4].Value = item.Producto.Descripcion;
                DgvDetalleServicio.Rows[n].Cells[5].Value = item.Producto.PorcentajeIVA;
                DgvDetalleServicio.Rows[n].Cells[6].Value = item.Producto.Total;
                n++;
            }
        }

    }
}
