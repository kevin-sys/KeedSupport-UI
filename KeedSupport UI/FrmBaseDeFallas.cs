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
    public partial class FrmBaseDeFallas : Form
    {
        BaseDeFallas BDfallas;
        public FrmBaseDeFallas()
        {
            InitializeComponent();
            
        }

        private BaseDeFallas MapearBDfallas()
        {
            BDfallas = new BaseDeFallas();
            BDfallas.CodigoFalla = TxtCodigoFalla.Text.Trim();
            BDfallas.FechaRegistro = DtaFechaRegistro.Value;
            BDfallas.TipoEquipo = CmbTipoEquipo.Text.Trim();
            BDfallas.Marca = TxtMarca.Text.Trim();
            BDfallas.Modelo = TxtModelo.Text.Trim();
            BDfallas.Falla = TxtFalla.Text.Trim();
            BDfallas.Sintomas = TxtSintomas.Text.Trim();
            BDfallas.Solucion = TxtSolucion.Text.Trim();
            return BDfallas;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            BaseDeFallas BdFallas =  MapearBDfallas();
            BaseDeFallasService BdFallasService = new BaseDeFallasService();
            string mensaje = BdFallasService.Guardar(BdFallas);
            MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal form3 = new FrmMenuPrincipal();
            form3.Show();
        }

        private void FrmBaseDeFallas_Load(object sender, EventArgs e)
        {

        }
    }
}
