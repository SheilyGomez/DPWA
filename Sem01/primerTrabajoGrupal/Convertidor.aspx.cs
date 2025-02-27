using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace primerTrabajoGrupal
{
	public partial class Convertidor : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void Button1_Click(object sender, EventArgs e)
        {

            // Verificar si el campo está vacío
            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                // Generar alerta utilizando SweetAlert
                ClientScript.RegisterStartupScript(this.GetType(),
                    "alert",
                    "Swal.fire({ title: '¡Campo Vacio!', " +
                    "text: 'Debe ingresar un valor en el campo de valor.', " +
                    "icon: 'warning', " +
                    "confirmButtonText: 'Aceptar' });", true);
            }

            else
            {

                // Convertir el valor ingresado a double
                decimal valor = Convert.ToDecimal(txtAmount.Text);
                decimal resultado = 0.0m;

                string moneda_valor = cmbConvertir.SelectedValue;
                string moneda_conversion = cmbValorConversion.SelectedValue;


                // Diccionario con todos los valores de conversion de las monedas crypto y usd
                var tasasDeConversion = new Dictionary<(string, string), decimal>
                {
                    // Valores tomados segun 21 de febrero de 2025
                    // De BTC a otras monedas
                    { ("BTC", "ETH"), 35.95m },      // 1 BTC ≈ 35.95 ETH
                    { ("BTC", "XRP"), 37376.19m },   // 1 BTC ≈ 37,376.19 XRP
                    { ("BTC", "DOGE"), 397614.31m }, // 1 BTC ≈ 397,614.31 DOGE
                    { ("BTC", "USD"), 96242.14m },   // 1 BTC ≈ 96,242.14 USD 

                    // De ETH a otras monedas
                    { ("ETH", "BTC"), 0.028m },     // 1 ETH ≈ 0.028 BTC
                    { ("ETH", "XRP"), 1041.12m },   // 1 ETH ≈ 1,041.12 XRP
                    { ("ETH", "DOGE"), 11099.76m }, // 1 ETH ≈ 11,099.76 DOGE
                    { ("ETH", "USD"), 2681.73m },   // 1 ETH ≈ 2,681.73 USD

                    // De XRP a otras monedas
                    { ("XRP", "BTC"), 0.000027m },  // 1 XRP ≈ 0.000027 BTC
                    { ("XRP", "ETH"), 0.00096m },   // 1 XRP ≈ 0.00096 ETH
                    { ("XRP", "DOGE"), 10.66m },    // 1 XRP ≈ 10.66 DOGE
                    { ("XRP", "USD"), 2.57m },      // 1 XRP ≈ 2.57 USD

                    // De DOGE a otras monedas
                    { ("DOGE", "BTC"), 0.0000025m },// 1 DOGE ≈ 0.0000025 BTC
                    { ("DOGE", "ETH"), 0.000090m }, // 1 DOGE ≈ 0.000090 ETH
                    { ("DOGE", "XRP"), 0.094m },    // 1 DOGE ≈ 0.094 XRP
                    { ("DOGE", "USD"), 0.24m },     // 1 DOGE ≈ 0.24 USD

                    // De USD a otras monedas
                    { ("USD", "BTC"), 0.00001039m }, // 1 USD ≈ 0.00001039 BTC
                    { ("USD", "ETH"), 0.00037m },    // 1 USD ≈ 0.00037 ETH
                    { ("USD", "XRP"), 0.39m },       // 1 USD ≈ 0.39 XRP
                    { ("USD", "DOGE"), 4.14m }       // 1 USD ≈ 4.14 DOGE
                };



                if (moneda_valor == moneda_conversion)
                {
                    resultado = valor;
                }
                else if (tasasDeConversion.TryGetValue((moneda_valor, moneda_conversion), out decimal tasa))
                {
                    resultado = valor * tasa;
                }

                txtResultado.Text = resultado.ToString("N8");
            }
        }
    }
}