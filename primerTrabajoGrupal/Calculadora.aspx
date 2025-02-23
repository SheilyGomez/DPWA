<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Calculadora.aspx.cs" Inherits="primerTrabajoGrupal.Calculadora" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Calculadora  AX2 + BX + C = 0</h2><br />

    <asp:Label ID="lblA" runat="server" Text="Ingresa el valor de A: "></asp:Label>
    <asp:TextBox ID="txtA" runat="server"></asp:TextBox><br /><br />

    <asp:Label ID="lblB" runat="server" Text="Ingresa el valor de B: "></asp:Label>
    <asp:TextBox ID="txtB" runat="server"></asp:TextBox><br /><br />

    <asp:Label ID="lblC" runat="server" Text="Ingresa el valor de C: "></asp:Label>
    <asp:TextBox ID="txtC" runat="server"></asp:TextBox><br /><br />

    <asp:Button ID="btnCalcular" runat="server" Text="Calcular" OnClick="btnCalcular_Click" />
    <br /><br />

    <asp:Label ID="lblResultado" runat="server" Text=""></asp:Label>

</asp:Content>
