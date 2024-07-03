using System.Web;
using System.Web.Mvc;

namespace LtkK22Cnt4Lesson10Cb
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
