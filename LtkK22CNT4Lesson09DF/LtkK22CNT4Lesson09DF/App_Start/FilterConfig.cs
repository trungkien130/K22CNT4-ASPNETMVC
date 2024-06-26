using System.Web;
using System.Web.Mvc;

namespace LtkK22CNT4Lesson09DF
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
