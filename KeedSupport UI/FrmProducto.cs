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

        private Producto Mapear()
        {
            Producto = new Producto();
            Producto.NombreProducto = TxtServicioProducto.Text.Trim();
            Producto.CodigoProducto = TxtCodigoProducto.Text.Trim();
            Producto.Descripcion = TxtDescripcion.Text.Trim();
            Producto.Precio =float.Parse(TxtPrecio.Text);
            return Producto;
        }
        public FrmProducto()
        {
            InitializeComponent();
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            service = new ProductoService(connectionString);
        }

        private void BtnGuardarReparacion_Click(object sender, EventArgs e)
        {
            Producto producto = Mapear();
            string mensaje = service.Guardar(producto);
            MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

        }
    }
}
