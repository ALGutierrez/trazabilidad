﻿using System.Web;
using System.Web.Mvc;

namespace Sw_Trazabilidad
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
