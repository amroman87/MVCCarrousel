using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Carrousel1.Models
{
    public class CarrouselModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? FileSize { get; set; }
        public string FilePath { get; set; }

    }
}