using System.Web;
using System.Web.Mvc;

namespace Mattioli.Alessandro._5H.WebAccessDatabase
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
