using System.Web.Mvc;
using System.Web.Routing;

namespace Hoa_Chat_Thi_Nghiem_ASP_NET_MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "Product-details",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Products", action = "ProductDetails", id = UrlParameter.Optional }
           );

            routes.MapRoute(
                name: "List-products",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Products", action = "ListProducts", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Shopping-Cart",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Cart", action = "ShoppingCart", id = UrlParameter.Optional }
            );

        }
    }
}
