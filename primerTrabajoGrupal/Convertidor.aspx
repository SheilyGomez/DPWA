<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Convertidor.aspx.cs" Inherits="primerTrabajoGrupal.Convertidor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container mt-2">
        <h1 class="text-center mb-5">Convertidor de Criptomonedas</h1>

        <div class="row">
            <div class="col-md-3 mb-3">
                <img src="https://www.openaccessgovernment.org/wp-content/uploads/2018/02/what-is-bitcoin-cryptocurrency-001.jpg"  alt="Bitcoin" class="img-fluid rounded shadow" />
            </div>
            <div class="col-md-3 mb-3">
                <img src="https://bitcoinist.com/wp-content/uploads/2022/12/Ethereum.jpeg" alt="Ethereum"  class="img-fluid rounded shadow" />
            </div>
            <div class="col-md-3 mb-3">
                <img src="https://u.today/sites/default/files/styles/736/public/2025-01/234124124123.jpg" alt="Ripple" class="img-fluid rounded shadow" />
            </div>
            <div class="col-md-3 mb-3">
                <img src="https://coingape.com/wp-content/uploads/2024/03/dogecoin-price5.jpg"  alt="Dogecoin" class="img-fluid rounded shadow" />
            </div>
        </div>


        <style>
            .row img {
                width: 100%;
                height: 150px;
                object-fit: cover; 
            }
        </style>

        <div class="row justify-content-center">
            <div class="col-md-8">
                <div class="card shadow">
                    <div class="card-body">
                        <div class="form-group row mb-3">
                            <div class="col-md-5">
                                <label for="txtAmount" class="form-label">Valor a Convertir</label>
                                <asp:TextBox ID="txtAmount" runat="server" CssClass="form-control" placeholder="Ingresa el valor" oninput="validarNumero()"/>     

                            </div>
                            <div class="col-md-7">
                                <label for="txtResultado" class="form-label">Valor Convertido</label>
                                <asp:TextBox ID="txtResultado" Enabled="false" runat="server"  CssClass="form-control" placeholder="0.00" />
                            </div>
                        </div>
                        <div class="form-group row mb-3">
                            <div class="col-md-5">
                                <label for="cmbConvertir" class="form-label">De</label>
                                <asp:DropDownList ID="cmbConvertir" runat="server" CssClass="form-select">
                                    <asp:ListItem Text="Bitcoin" Value="BTC" />
                                    <asp:ListItem Text="Ethereum" Value="ETH" />
                                    <asp:ListItem Text="Ripple" Value="XRP" />
                                    <asp:ListItem Text="Dogecoin" Value="DOGE" />
                                    <asp:ListItem Text="Dolar" Value="USD" />
                                </asp:DropDownList>
                            </div>
                            <div class="col-md-5">
                                <label for="cmbValorConversion" class="form-label">A</label>
                                <asp:DropDownList ID="cmbValorConversion" runat="server" CssClass="form-select">
                                    <asp:ListItem Text="Bitcoin" Value="BTC" />
                                    <asp:ListItem Text="Ethereum" Value="ETH" />
                                    <asp:ListItem Text="Ripple" Value="XRP" />
                                    <asp:ListItem Text="Dogecoin" Value="DOGE" />
                                    <asp:ListItem Text="Dolar" Value="USD" />
                                </asp:DropDownList>
                            </div>
                            <div class="col-md-2 d-flex align-items-end">
                                <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary w-100" Text="Convertir" OnClick="Button1_Click" />
                            </div>

          

                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <script type="text/javascript">

        // Validando que lo que se envie sea numero
        function validarNumero() { 
            var input = document.getElementById('<%= txtAmount.ClientID %>');
            
            input.value = input.value.replace(/[^0-9.]/g, '');
        }

    </script>



</asp:Content>
