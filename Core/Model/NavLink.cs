using System.Web.Routing;

namespace Core.Model
{
    public class NavLink
    {
        public string Text { get; set; }
        public RouteValueDictionary RouteValue { get; set; }
        public bool IsSelected { get; set; }
    }
}
