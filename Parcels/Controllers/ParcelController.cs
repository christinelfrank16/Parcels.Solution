using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Parcels.Models;

namespace Parcels.Controllers
{
    public class ParcelController : Controller
    {

			[HttpGet("/parcel")]
    public ActionResult Ship()
    {
      List<Parcel> allParcels = Parcel.GetAll();
      return View(allParcels);
    }

    [HttpGet("/parcel/new")]
    public ActionResult Form()
    {
      return View();
    }

    [HttpPost("/parcel")]
    public ActionResult Create(string description, int xDim, int yDim, int zDim, double weight)
    {
      Parcel myParcels = new Parcel(description, xDim, yDim, zDim, weight);
      return RedirectToAction("Ship");
    }

    }
}