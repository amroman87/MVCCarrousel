using Carrousel1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Carrousel1.Services
{
    public class GetImageService : IGetImagesService
    {
        private IGetImagesService _dataAccesService;

        public GetImageService(IGetImagesService dataAccessService)
        {
            this._dataAccesService = dataAccessService;
        }
        public void getImageById(int id)
        {
            throw new NotImplementedException();
        }

        public void getImages()
        {
            throw new NotImplementedException();
        }
    }
}