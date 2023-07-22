using CQRS_Casgem.CQRSPattern.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_Casgem.Controllers
{
    public class DefaultController : Controller
    {
        private readonly GetProductQueryHandler _getProductQueryHandler;
        public DefaultController(GetProductQueryHandler getProductQueryHandler)
        {
            _getProductQueryHandler = getProductQueryHandler;
        }
        public IActionResult Index()
        {
            var values = _getProductQueryHandler.Handle();
            return View(values);
        }
    }
}
