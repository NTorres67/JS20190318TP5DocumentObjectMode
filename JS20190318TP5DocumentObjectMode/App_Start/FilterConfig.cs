﻿using System.Web;
using System.Web.Mvc;

namespace JS20190318TP5DocumentObjectMode
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
