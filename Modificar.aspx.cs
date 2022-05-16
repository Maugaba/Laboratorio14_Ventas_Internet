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
    public partial class About : Page
    {
        List<Libros> libros = new List<Libros>();
        string codigo;
        protected void Page_Load(object sender, EventArgs e)
        {
            string archivo = Server.MapPath("Productos.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            libros = JsonConvert.DeserializeObject<List<Libros>>(json);
        }

        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            codigo = TextBoxCodigo.Text;
            bool encontrado = false;
            foreach (var a in libros)
            {
                if (a.Codigo_del_producto == codigo)
                {
                    TextBoxnombre.Text = a.Nombre_del_producto;
                    TextBoxdescripcion.Text = a.Descripcion_del_producto;
                    TextBoxprecioC.Text = a.Precio_de_compra;
                    TextBoxprecioV.Text = a.Precio_de_venta;
                    TextBoxEditorial.Text = a.Editorial;
                    TextBoxCat.Text = a.Categoria;
                    TextBoxAutor.Text = a.Autor;
                    encontrado = true;
                }

            }
            if (!encontrado)
            {
                Response.Write("<script>alert('No se encontro ese Producto en el sistema')</script>");
                codigo = "";
                TextBoxCodigo.Text = "";
                TextBoxnombre.Text = "";
                TextBoxdescripcion.Text = "";
                TextBoxprecioC.Text = "";
                TextBoxprecioV.Text = "";
                TextBoxEditorial.Text = "";
                TextBoxCat.Text = "";
                TextBoxAutor.Text = "";
            }
        }

        protected void ButtonModificar_Click(object sender, EventArgs e)
        {
            foreach (var a in libros)
            {
                codigo = TextBoxCodigo.Text;

                if (a.Codigo_del_producto == codigo)
                {
                    a.Nombre_del_producto = TextBoxCodigo.Text;
                    a.Descripcion_del_producto = TextBoxdescripcion.Text;
                    a.Precio_de_compra = TextBoxprecioC.Text;
                    a.Precio_de_venta = TextBoxprecioV.Text;
                    a.Editorial = TextBoxEditorial.Text;
                    a.Categoria = TextBoxCat.Text;
                    a.Autor = TextBoxAutor.Text;

                    Guardar();
                    Response.Write("<script>alert('El libro fue correctamente modificado')</script>");
                    codigo = "";
                    TextBoxCodigo.Text = "";
                    TextBoxnombre.Text = "";
                    TextBoxdescripcion.Text = "";
                    TextBoxprecioC.Text = "";
                    TextBoxprecioV.Text = "";
                    TextBoxEditorial.Text = "";
                    TextBoxCat.Text = "";
                    TextBoxAutor.Text = "";
                }
            }
        }

        void Guardar()
        {
            string json = JsonConvert.SerializeObject(libros);
            string archivo = Server.MapPath("Productos.json");
            File.WriteAllText(archivo, json);
        }
    }
}