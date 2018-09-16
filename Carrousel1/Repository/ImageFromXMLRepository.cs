using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace Carrousel1.Repository
{
    public class ImageFromXMLRepository : IGetImagesRepository
    {
        public List<Image> ReadImages()
        {
            ImageList result = null;

            XmlSerializer serializer = new XmlSerializer(typeof(ImageList));

            var xml = GetType().Module.Assembly.GetManifestResourceStream("Carrousel1.Resources.XML.Images.xml");

            using (StreamReader reader = new StreamReader(xml))
            {
                result = (ImageList)serializer.Deserialize(reader);
            }
            
            return result.Images ;
        }

        
    }
}