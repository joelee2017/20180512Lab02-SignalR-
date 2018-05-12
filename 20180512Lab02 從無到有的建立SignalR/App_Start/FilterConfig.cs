using System.Web;
using System.Web.Mvc;

namespace _20180512Lab02_從無到有的建立SignalR
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
