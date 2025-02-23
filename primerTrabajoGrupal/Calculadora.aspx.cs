using System;
using System.Collections.Generic;
using System.Linq;
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
			double a = Double.Parse(txtA.Text);
            double b = Double.Parse(txtB.Text);
            double c = Double.Parse(txtC.Text);


            double discriminante = (b * b) - (4 * a * c);

            if (discriminante > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
                lblResultado.Text = $"Las soluciones son: x1 = {x1}, x2 = {x2}";
            }
            else if (discriminante == 0)
            {
                double x = -b / (2 * a);
                lblResultado.Text = $"Hay una única solución: x = {x}";
            }
            else
            {
                lblResultado.Text = "No hay soluciones reales, solo soluciones complejas.";
            }


            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
        }
    }
}