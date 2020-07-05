using System.Web;
using System.Web.Mvc;

namespace Miniproyecto_Bertoni_Solutions
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
