<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio14_Ventas_Internet._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Ingreso de Productos(Libros)</h1>
    </div>

    <div class="row">
        <div class="col-md-4">
            <p>
                Codigo del Producto:
                <asp:TextBox ID="TextBoxCodigo" runat="server"></asp:TextBox>
            </p>
            <p>
                &nbsp;Nombre del Producto:
                <asp:TextBox ID="TextBoxnombre" runat="server"></asp:TextBox>
            </p>
            <p>
                Descripcion del Producto
                <asp:TextBox ID="TextBoxdescripcion" runat="server"></asp:TextBox>
            </p>
            <p>
                Precio de Compra:
                <asp:TextBox ID="TextBoxprecioC" runat="server"></asp:TextBox>
            </p>
            <p>
                Precio de Venta:
                <asp:TextBox ID="TextBoxprecioV" runat="server"></asp:TextBox>
            </p>
            <p>
                Editorial:
                <asp:TextBox ID="TextBoxEditorial" runat="server"></asp:TextBox>
            </p>
            <p>
                Categoria:
                <asp:TextBox ID="TextBoxCat" runat="server"></asp:TextBox>
            </p>
            <p>
                Autor:&nbsp;
                <asp:TextBox ID="TextBoxAutor" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="ButtonLib" runat="server" OnClick="ButtonLib_Click" Text="Ingresar Libro" />
            </p>
            <p>
                Mostrar Todos los libros Ingresados<asp:Button ID="Buttonlibvisualizar" runat="server" OnClick="Buttonlibvisualizar_Click" Text="Ver Libros" />
            </p>
            <p>
                <asp:GridView ID="GridView1" runat="server">
                </asp:GridView>
            </p>
        </div>
    </div>

</asp:Content>
