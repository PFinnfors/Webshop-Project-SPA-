using System.Web.Mvc;
using System.Web.Routing;
using ShopAPI.Controllers;

namespace WebshopProject.Controllers
{
    public class ApiControllerFactory : DefaultControllerFactory
    {
        public override IController CreateController(RequestContext requestContext, string controllerName)
        {
            CartController controller = new CartController();
            return controller;
        }

        public override void ReleaseController(IController controller)
        {
            
        }
    }
}