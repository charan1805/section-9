using System.Web;
using System.Web.Mvc;

namespace URICustomization_EFIntegration
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
