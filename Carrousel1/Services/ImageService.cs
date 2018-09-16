using Carrousel1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Carrousel1.Services
{
    public class GetImageService : IGetImagesService
    {
        private IGetImagesRepository _dataAccesService;

       
        public GetImageService(IGetImagesRepository dataAccessService)
        {
            this._dataAccesService = dataAccessService;
        }
        public Image getImageById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Image> getImages()
        {
            var imageList = _dataAccesService.ReadImages();
            return imageList;
        }
    }
}