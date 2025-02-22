using System;
using System.Web.UI;

namespace primerTrabajoGrupal
{
    public partial class Formulario : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            string mensaje = txtMensaje.Text;

            if (!string.IsNullOrEmpty(mensaje))
            {
               
                string script = $@"
                    Swal.fire({{
                        title: 'Mensaje',
                        text: '{mensaje}',
                        icon: 'success'
                    }});";

                
                ScriptManager.RegisterStartupScript(this, GetType(), "SweetAlert", script, true);
            }
        }
    }
}
