namespace Carrousel1.Services
{
    public interface IGetImagesService
    {
        ImageList getImages();
        Image getImageById(int id);
    }
}