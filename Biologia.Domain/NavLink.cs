using System.Web.Routing;

namespace Biologia.Domain
{
    public class NavLink
    {
        public string Text { get; set; }
        public RouteValueDictionary RouteValue { get; set; }
        public bool IsSelected { get; set; }
    }
}