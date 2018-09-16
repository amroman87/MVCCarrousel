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

        private List<Image> _imageList;

        public HomeController(IGetImagesService getImagesServices)
        {
            _getImagesService = getImagesServices;
        }
        // GET: Carrousel
        public ActionResult Index()
        {
            var imageList = GetImages();      
          
           return View(imageList);
                     
        }

       
        public JsonResult  OriginalImageURL(int id )
        {
            var idNum = Convert.ToInt32(id);

            var imageList = GetImages();

            var result = imageList.Where(x => x.Id == idNum).FirstOrDefault();
         

            return Json(result.OriginalUri, JsonRequestBehavior.AllowGet);
        }

        private List<Image> GetImages()
        {
            if (this._imageList == null)
            {
                _imageList = _getImagesService.getImages();
            }
            return _imageList ;
        }
    }
}