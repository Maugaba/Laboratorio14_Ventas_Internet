using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio14_Ventas_Internet
{
    public class Libros : Productos
    {
        public string Editorial { get; set; }
        public string Categoria { get; set; }   
        public string Autor { get; set; }

    }
}