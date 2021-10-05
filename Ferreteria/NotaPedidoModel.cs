using System;
using System.Collections.Generic;
using System.Text;

namespace Ferreteria
{
    class NotaPedidoModel
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public string DireccionCliente { get; set; }
        public string FormaPago { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int Envio { get; set; }
        public string Direccion { get; set; }
        public string Observaciones { get; set; }


    }
}
