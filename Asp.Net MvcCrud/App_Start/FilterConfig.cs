﻿using System.Web;
using System.Web.Mvc;

namespace Asp.Net_MvcCrud
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
