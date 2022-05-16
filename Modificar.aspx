<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Modificar.aspx.cs" Inherits="Laboratorio14_Ventas_Internet.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1><%: Title %>Modificar Libros</h1>
            <p>
                Ingrese el codigo del Producto:
                <asp:TextBox ID="TextBoxCodigo" runat="server"></asp:TextBox>
                <asp:Button ID="ButtonBuscar" runat="server" OnClick="ButtonBuscar_Click" Text="Buscar Libro" />
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
                <asp:Button ID="ButtonModificar" runat="server" OnClick="ButtonModificar_Click" Text="Modificar Libro" />
    </p>
</asp:Content>
