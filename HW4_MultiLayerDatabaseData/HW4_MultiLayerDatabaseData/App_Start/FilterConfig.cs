using System.Web;
using System.Web.Mvc;

namespace HW4_MultiLayerDatabaseData
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
