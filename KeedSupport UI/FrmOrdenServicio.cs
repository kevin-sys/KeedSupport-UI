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


        DetalleOrdenServicio detalleOrden;
        List<DetalleOrdenServicio> detallesordenes = new List<DetalleOrdenServicio>();
        DetalleOrdenServicioService detalleService;

        private ProductoService productoService;
        OrdenServicioService service;

        public FrmOrdenServicio()
        {
            InitializeComponent();
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            service = new OrdenServicioService(connectionString);
            productoService = new ProductoService(connectionString);
            detalleService = new DetalleOrdenServicioService(connectionString);
            DgvDetalleServicio.AllowUserToAddRows = false;
            DgvDetalleServicio.ColumnCount = 8;
            DgvDetalleServicio.Columns[0].Name = "CodigoDetalle";
            DgvDetalleServicio.Columns[1].Name = "CodigoProducto";
            DgvDetalleServicio.Columns[2].Name = "Nombre";
            DgvDetalleServicio.Columns[3].Name = "Cantidad";
            DgvDetalleServicio.Columns[4].Name = "Precio";
            DgvDetalleServicio.Columns[5].Name = "SubTotal";
            DgvDetalleServicio.Columns[6].Name = "Porcentaje IVA";
            DgvDetalleServicio.Columns[7].Name = "Total";

        }

        private void FrmOrdenServicio_Load(object sender, EventArgs e)
        {
            
        }

        private OrdenDeServicio MapearOrden()
        {
            OrdenDeServicio orden = new OrdenDeServicio();
            
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

        private DetalleOrdenServicio MapearDetalles()
        {
            detalleOrden = new DetalleOrdenServicio();
            detalleOrden.CodigoDetalle = TxtCodigoDetalle.Text.Trim();
            detalleOrden.OrdenDeServicio.NumeroOrden = TxtNumeroOrden.Text.Trim();
            detalleOrden.Producto.CodigoProducto = TxtCodigoProducto.Text;
            detalleOrden.Producto.NombreProducto = TxtServicioProducto.Text;
            detalleOrden.Producto.Cantidad = float.Parse(TxtCantidad.Text);
            detalleOrden.Producto.Precio = float.Parse(TxtPrecio.Text);
            detalleOrden.Producto.SubTotal = float.Parse(TxtSubTotal.Text);
            detalleOrden.Producto.PorcentajeIVA = float.Parse(TxtIva.Text);
            detalleOrden.Producto.Total = float.Parse(TxtTotal.Text);
            return detalleOrden;

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

            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(DgvDetalleServicio);
            fila.Cells[0].Value = TxtCodigoDetalle.Text;
            fila.Cells[1].Value = TxtCodigoProducto.Text;
            fila.Cells[2].Value = TxtServicioProducto.Text;
            fila.Cells[3].Value = TxtCantidad.Text;
            fila.Cells[4].Value = TxtPrecio.Text;
            fila.Cells[5].Value = TxtSubTotal.Text;
            fila.Cells[6].Value = TxtIva.Text;
            fila.Cells[7].Value = TxtTotal.Text;
            DgvDetalleServicio.Rows.Add(fila);
            //ELIMINAR Y ACTUALIZAR CON CODIGODETALLE, AGREGAR A LA BD UN NUEVO ATRIBUTO 
            DetalleOrdenServicio detalle = MapearDetalles();
            string mensaje = detalleService.Guardar(detalle);
            if (detalleService.Guardar(detalle)!=null)
            {

            }
            MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            LimpiarCajas();
        }

        private void LimpiarCajas()
        {
            TxtCodigoProducto.Text = "";
            TxtServicioProducto.Text = "";
            TxtCantidad.Text = "";
            TxtPrecio.Text = "";
            TxtSubTotal.Text = "";
            TxtIva.Text = "";
            TxtTotal.Text = "";
            TxtCodigoDetalle.Text = "";
        }

      

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string codigoDetalle = TxtCodigoDetalle.Text;
            if (codigoDetalle != "")
            {
                var respuesta = MessageBox.Show("¿Está seguro de eliminar el registro?", "Mensaje de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    string mensaje = detalleService.Eliminar(codigoDetalle);
                    MessageBox.Show(mensaje, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  //  DgvDetalleServicio.Rows.Remove(DgvDetalleServicio.CurrentRow);

                }

            }
            else
            {
                MessageBox.Show("Por favor digite el codigo de detalle", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DgvDetalleServicio_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void DgvDetalleServicio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtCodigoDetalle.Text = DgvDetalleServicio.CurrentRow.Cells[0].Value.ToString();
                TxtCodigoProducto.Text = DgvDetalleServicio.CurrentRow.Cells[1].Value.ToString();
                TxtServicioProducto.Text = DgvDetalleServicio.CurrentRow.Cells[2].Value.ToString();
                TxtCantidad.Text = DgvDetalleServicio.CurrentRow.Cells[3].Value.ToString();
                TxtPrecio.Text = DgvDetalleServicio.CurrentRow.Cells[4].Value.ToString();
                TxtSubTotal.Text = DgvDetalleServicio.CurrentRow.Cells[5].Value.ToString();
                TxtIva.Text = DgvDetalleServicio.CurrentRow.Cells[6].Value.ToString();
                TxtTotal.Text = DgvDetalleServicio.CurrentRow.Cells[7].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
           
        }
    }
}
