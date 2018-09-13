using Carrousel1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Carrousel1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Carrousel
        public ActionResult Index()
        {
            List<CarrouselModel> sliderimages = new List<CarrouselModel>();

            sliderimages.Add(new CarrouselModel()
                {
                FilePath = "http://media.tuicontent.nl/B03/B030D8D22F741C34B50CD268B317E33C.jpg" }
            );

            sliderimages.Add(new CarrouselModel(){ FilePath = "http://media.tuicontent.nl/B03/B030D8D22F741C34B50CD268B317E33C.jpg" });

            sliderimages.Add(new CarrouselModel(){ FilePath = "http://media.tuicontent.nl/B03/B030D8D22F741C34B50CD268B317E33C.jpg" });
            return View(sliderimages);

          
        }
    }
}