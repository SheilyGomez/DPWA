using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace primerTrabajoGrupal
{
	public partial class Calculadora : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

            lblResultado.Text = "";
        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            try{ 

                double a = Double.Parse(txtA.Text);
                double b = Double.Parse(txtB.Text);
                double c = Double.Parse(txtC.Text);
                string mensaje = "";

                double discriminante = (b * b) - (4 * a * c);
            

                if (discriminante > 0)
                {
                    double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
                    mensaje = $"Las soluciones son: x1 = {x1}, x2 = {x2}";
                    //lblResultado.Text = $"Las soluciones son: x1 = {x1}, x2 = {x2}";
                }
                else if (discriminante == 0)
                {
                    double x = -b / (2 * a);
                    mensaje = $"Hay una única solución: x = {x}";
                    //lblResultado.Text = $"Hay una única solución: x = {x}";
                }
                else
                {
                    mensaje = "No hay soluciones reales, solo soluciones complejas.";
                    //lblResultado.Text = "No hay soluciones reales, solo soluciones complejas.";
                }

                string mensajeSeguro = HttpUtility.JavaScriptStringEncode(mensaje);

                txtA.Text = " ";
                txtB.Text = " ";
                txtC.Text = " ";

                string script = $@"
                swal.fire({{
                    title:'Resultado',
                    text:'{mensajeSeguro}',
                    icon:'info'
                }});";

                ScriptManager.RegisterStartupScript(this, GetType(), "SweetAlert", script, true);
            }
            catch (Exception)
            {
                string scriptError = $@"
                    Swal.fire({{
                        title: 'Error',
                        text: 'Por favor, ingrese valores numéricos válidos.',
                        icon: 'error'
                    }});";

                ScriptManager.RegisterStartupScript(this, GetType(), "SweetAlertError", scriptError, true);
            }
        }
    }
}