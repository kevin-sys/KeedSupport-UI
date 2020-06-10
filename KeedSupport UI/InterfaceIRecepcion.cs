using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using BLL;

namespace KeedSupport_UI
{
    public interface InterfaceIRecepcion
    {
        void Recibir(Cliente cliente);
        void RecibirProducto(Producto producto);
    }
}
