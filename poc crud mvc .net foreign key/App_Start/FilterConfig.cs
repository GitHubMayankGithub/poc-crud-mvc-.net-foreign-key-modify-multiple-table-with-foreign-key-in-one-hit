using System.Web;
using System.Web.Mvc;

namespace poc_crud_mvc.net_foreign_key
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
