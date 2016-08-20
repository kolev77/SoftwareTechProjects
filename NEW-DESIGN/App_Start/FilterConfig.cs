using System.Web;
using System.Web.Mvc;

namespace MY_DEMO_BLOG
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
