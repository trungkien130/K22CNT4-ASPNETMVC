using System.Web;
using System.Web.Mvc;

namespace LeTrungKien_2210900034
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
