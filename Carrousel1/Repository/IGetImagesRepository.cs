using System.Collections.Generic;

namespace Carrousel1.Repository
{
    public interface IGetImagesRepository
    {
        List<Image> ReadImages();
    }
}
