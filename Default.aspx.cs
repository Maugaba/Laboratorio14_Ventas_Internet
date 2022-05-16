using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio14_Ventas_Internet
{
    public partial class _Default : Page
    {
        List<Libros> libros = new List<Libros>();
        protected void Page_Load(object sender, EventArgs e)
        {
            string archivo = Server.MapPath("Productos.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();

            if (json.Length > 0)
            {
                libros = JsonConvert.DeserializeObject<List<Libros>>(json);
            }
        }

        protected void ButtonLib_Click(object sender, EventArgs e)
        {
            Libros lib = new Libros();
            lib.Codigo_del_producto = TextBoxCodigo.Text;
            lib.Nombre_del_producto = TextBoxnombre.Text;
            lib.Descripcion_del_producto = TextBoxdescripcion.Text;
            lib.Precio_de_compra = TextBoxprecioC.Text;
            lib.Precio_de_venta = TextBoxprecioV.Text;
            lib.Editorial = TextBoxEditorial.Text;
            lib.Categoria = TextBoxCat.Text;
            lib.Autor = TextBoxAutor.Text;
            libros.Add(lib);
            Guardar_Json();
            TextBoxCodigo.Text = "";
            TextBoxnombre.Text = "";
            TextBoxdescripcion.Text = "";
            TextBoxprecioC.Text = "";
            TextBoxprecioV.Text = "";
            TextBoxEditorial.Text = "";
            TextBoxCat.Text = "";
            TextBoxAutor.Text = "";
        }

        void Guardar_Json()
        {
            string json = JsonConvert.SerializeObject(libros);
            string archivo = Server.MapPath("Productos.json");
            File.WriteAllText(archivo, json);
        }

        protected void Buttonlibvisualizar_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = libros;
            GridView1.DataBind();
        }
    }
}