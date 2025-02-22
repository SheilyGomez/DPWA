<%@ Page Title="Formulario" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="primerTrabajoGrupal.Formulario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Ingrese un texto</h2>

    <asp:TextBox ID="txtMensaje" runat="server" placeholder="Escriba algo aquí" CssClass="form-control"></asp:TextBox>
    <br />
    <asp:Button ID="btnMostrar" runat="server" Text="Mostrar Mensaje" OnClick="btnMostrar_Click" CssClass="btn btn-primary"/>

</asp:Content>
