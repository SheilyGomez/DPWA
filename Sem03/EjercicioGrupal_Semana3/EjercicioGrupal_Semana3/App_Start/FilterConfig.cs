using System.Web;
using System.Web.Mvc;

namespace EjercicioGrupal_Semana3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
