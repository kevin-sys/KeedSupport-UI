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
    public partial class FrmProducto : Form
    {
        Producto Producto;
        ProductoService service;
        List<Producto> productos = new List<Producto>();
        InterfaceIRecepcion FrmRecepcion;
        private Producto Mapear()
        {
            Producto = new Producto();
            Producto.NombreProducto = TxtServicioProducto.Text.Trim();
            Producto.CodigoProducto = TxtCodigoProducto.Text.Trim();
            Producto.Descripcion = TxtDescripcion.Text.Trim();
            Producto.Precio = float.Parse(TxtPrecio.Text);
            Producto.Cantidad = float.Parse(TxtCantidad.Text);
            Producto.FechaRegistro = DtpFecha.Value.Date;
            Producto.PorcentajeIVA = float.Parse(TxtIva.Text);

            return Producto;
        }
        public FrmProducto()
        {
            PrepararCadena();
            PrepararTabla();
        }

        private void PrepararCadena()
        {
            InitializeComponent();
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            service = new ProductoService(connectionString);
        }

        public FrmProducto(InterfaceIRecepcion recepcion)
        {
            PrepararCadena();
            FrmRecepcion = recepcion;
            PrepararTabla();
        }

        private void BtnGuardarReparacion_Click(object sender, EventArgs e)
        {
            Producto producto = Mapear();
            producto.CalcularSubTotal();
            producto.CalcularTotal();

            string mensaje = service.Guardar(producto);
            MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            PrepararTabla();
        }

        private void PrepararTabla()
        {
            DgvProducto.DataSource = null;
            productos.Clear();
            productos = service.Consultar();
            DgvProducto.DataSource = productos;
        }

        private void DgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (FrmRecepcion != null)
            {
                Producto producto = (Producto)DgvProducto.CurrentRow.DataBoundItem;
                FrmRecepcion.RecibirProducto(producto);
                this.Hide();
            }
        }
    }
}
