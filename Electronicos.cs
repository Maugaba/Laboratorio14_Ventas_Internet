using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio14_Ventas_Internet
{
    public class Electronicos : Productos
    {
        public string Garantia { get; set; }
        public string Voltaje { get; set; }
    }
}