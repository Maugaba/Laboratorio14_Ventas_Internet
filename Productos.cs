using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio14_Ventas_Internet
{
    public class Productos
    {
        public string Codigo_del_producto { get; set; }
        public string Nombre_del_producto { set; get; }
        public string Descripcion_del_producto { set; get; }
        public string Precio_de_compra { get; set; }
        public string Precio_de_venta { get; set; }

    }
}