using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio14_Ventas_Internet
{
    public class Alimentos : Productos
    {
        public DateTime Fecha_de_vencimiento { get; set; }
        public string Unidad_de_medida { get; set; }

    }
}