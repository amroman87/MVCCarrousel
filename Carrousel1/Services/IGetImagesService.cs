using System.Collections.Generic;

namespace Carrousel1.Services
{
    public interface IGetImagesService
    {
        List<Image> getImages();
        Image getImageById(int id);
    }
}