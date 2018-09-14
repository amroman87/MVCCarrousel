using Carrousel1.Models;
using Carrousel1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Carrousel1.Controllers
{
    public class HomeController : Controller
    {
        private IGetImagesService _getImagesService;
      
        public HomeController(IGetImagesService getImagesServices)
        {
            _getImagesService = getImagesServices;
        }
        // GET: Carrousel
        public ActionResult Index()
        {
           var imageList = _getImagesService.getImages();           
          
           return View(imageList.Images);

          
        }
    }
}