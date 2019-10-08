using Microsoft.AspNetCore.Mvc;

namespace Parcels.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Ship()
      {
        return View();
      }

    }
}