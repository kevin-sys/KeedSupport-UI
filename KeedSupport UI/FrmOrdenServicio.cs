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
    public partial class FrmOrdenServicio : Form, InterfaceIRecepcion
    {


        DetalleOrdenServicio detalleOrden;
        OrdenDeServicio orden;
        private Producto producto;
        private OrdenDeServicio servi;
        

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
            servi = new OrdenDeServicio();
            producto = new Producto();
            detalleOrden = new DetalleOrdenServicio();
            orden = new OrdenDeServicio();
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

        public void Recibir(Cliente cliente)
        {
            if (cliente != null)
            {
                TxtNombreCliente.Text = cliente.PrimerNombre.Trim();
                TxtIentificacion.Text = cliente.Identificacion.Trim();
                TxtTelefono.Text = cliente.Telefono.Trim();
                TxtDireccion.Text = cliente.Direccion.Trim();
                TxtCorreo.Text = cliente.Correo.Trim();

            }
        }
        public void RecibirProducto(Producto producto)
        {
            if (producto != null)
            {
                TxtServicioProducto.Text = producto.NombreProducto.Trim();
                TxtCodigoProducto.Text = producto.CodigoProducto.Trim();
                TxtPrecio.Text = producto.Precio.ToString();
                TxtIva.Text = producto.PorcentajeIVA.ToString();

            }
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
            orden.equipo.Accesorios = TxtAccesorios.Text.Trim();


            orden.cliente.PrimerNombre = TxtNombreCliente.Text.Trim();
            orden.cliente.Identificacion = TxtIentificacion.Text.Trim();
            orden.cliente.Telefono = TxtTelefono.Text.Trim();
            orden.cliente.Direccion = TxtDireccion.Text.Trim();
            orden.cliente.Correo = TxtCorreo.Text.Trim();
            orden.SubTotal = float.Parse(TxtSubTotalOrden.Text);
            orden.TotalOrden = float.Parse(TxtTotalOrden.Text);
            orden.Abono = float.Parse(TxtAbono.Text);
            orden.Vueltos = float.Parse(TxtVueltos.Text);
            orden.Deuda = orden.CalcularDeuda();
            orden.Vueltos = orden.CalcularVueltos();
            TxtDeuda.Text = orden.Deuda.ToString();
            TxtVueltos.Text = orden.Vueltos.ToString();
            return orden;
        }

        private DetalleOrdenServicio MapearDetalles()
        {
            detalleOrden = new DetalleOrdenServicio();

            detalleOrden.Producto = producto;
            detalleOrden.OrdenDeServicio = servi;
            detalleOrden.CodigoDetalle = TxtCodigoDetalle.Text.Trim();
            detalleOrden.OrdenDeServicio.NumeroOrden = TxtNumeroOrden.Text.Trim();
            detalleOrden.Producto.CodigoProducto = TxtCodigoProducto.Text;
            detalleOrden.Producto.NombreProducto = TxtServicioProducto.Text;
            detalleOrden.ValorUnitario = float.Parse(TxtPrecio.Text);
            detalleOrden.Cantidad = float.Parse(TxtCantidad.Text);
            detalleOrden.SubTotal = detalleOrden.CalcularSubtotal();
            detalleOrden.Producto.PorcentajeIVA = float.Parse(TxtIva.Text);
            detalleOrden.Total = detalleOrden.Calculartotal();
            TxtTotal.Text = detalleOrden.Total.ToString();
            TxtSubTotal.Text = detalleOrden.SubTotal.ToString();

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
            detalleService.EliminarTxt();

            var respuesta = MessageBox.Show("Se perderan todos los cambios, ¿esta seguro?", "Mensaje de alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                 detalleService.EliminarTxt();

                LimpiarCajas();
                this.Dispose();
            }
        }

        private void TxtServicioProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCrearOrden_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("¿Está seguro de crear la orden", "Mensaje de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                OrdenDeServicio ordenservicio = MapearOrden();

                String mensaje = service.Guardar(ordenservicio);
                detalleService.GuardarDetalleBD();
                MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                LimpiarCajas();
                detalleService.EliminarTxt();

            }


        }

        private void label14_Click(object sender, EventArgs e)
        {
            FrmProducto consulta = new FrmProducto(this);
            consulta.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DetalleOrdenServicioService service = new DetalleOrdenServicioService();
            DetalleOrdenServicio detalle = MapearDetalles();
            AñadirATabla();
            string mensaje = service.GuardarArchivo(detalle);
            MessageBox.Show(mensaje, "Mensaje de confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            LimpiarCajas();
            double total = 0;
            double subtotal = 0;
            foreach (DataGridViewRow row in DgvDetalleServicio.Rows)
            {
                total += Convert.ToDouble(row.Cells["Total"].Value);
                subtotal += Convert.ToDouble(row.Cells["SubTotal"].Value);

            }
            TxtTotalOrden.Text = Convert.ToString(total);
            TxtSubTotalOrden.Text = Convert.ToString(subtotal);

            TxtDeuda.Text = Convert.ToString(total);
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
                var respuesta = MessageBox.Show("¿Está seguro de eliminar el producto", "Mensaje de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    string mensaje = detalleService.Eliminar(codigoDetalle);
                    MessageBox.Show(mensaje, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DgvDetalleServicio.Rows.Remove(DgvDetalleServicio.CurrentRow);
                    double total = 0;
                    double subtotal = 0;

                    foreach (DataGridViewRow row in DgvDetalleServicio.Rows)
                    {
                        total += Convert.ToDouble(row.Cells["Total"].Value);
                        subtotal += Convert.ToDouble(row.Cells["SubTotal"].Value);

                    }
                    TxtTotalOrden.Text = Convert.ToString(total);
                    TxtSubTotalOrden.Text = Convert.ToString(subtotal);
                    LimpiarCajas();
                }

            }
            else
            {
                MessageBox.Show("Por favor digite el codigo de detalle", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DgvDetalleServicio_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void DgvDetalleServicio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }
        private void Actualizar()
        {
            var respuesta = MessageBox.Show("¿Está seguro de actualizar el producto?", "Mensaje de actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                DetalleOrdenServicio detalle = MapearDetalles();
                string mensaje = detalleService.Modificar(detalle);
                MessageBox.Show(mensaje, "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DgvDetalleServicio.Rows.Remove(DgvDetalleServicio.CurrentRow);
                AñadirATabla();
                double total = 0;
                double subtotal = 0;

                foreach (DataGridViewRow row in DgvDetalleServicio.Rows)
                {
                    total += Convert.ToDouble(row.Cells["Total"].Value);
                    subtotal += Convert.ToDouble(row.Cells["SubTotal"].Value);

                }
                TxtTotalOrden.Text = Convert.ToString(total);
                TxtSubTotalOrden.Text = Convert.ToString(subtotal);
                LimpiarCajas();
            }
        }

        private void AñadirATabla()
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
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            FrmConsultarCliente consulta = new FrmConsultarCliente(this);
            consulta.Show();

        }

        private void BtnImprimirOrden_Click(object sender, EventArgs e)
        {
        

            
        }

        private void TxtAccesorios_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
