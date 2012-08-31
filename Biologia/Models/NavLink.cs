using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace Biologia.Models
{
    public class NavLink
    {
        public string Text { get; set; }
        public RouteValueDictionary RouteValue { get; set; }
        public bool IsSelected { get; set; }
    }
}