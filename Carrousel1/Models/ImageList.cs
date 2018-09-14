using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace Carrousel1
{

    [XmlRoot("images")]
    public class ImageList
    {
        [XmlElement("image")]
        public List<Image> Images { get; set; }
    }

    public class Image
    {
        [XmlElement ("id")]
        public int Id { get; set; }

        #region small
        [XmlIgnore]
        private Uri Small { get; set; }

        [XmlAttribute("small")]
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public string SmallUri
        {
            get { return Small == null ? null : Small.ToString(); }
            set { Small = value == null ? null : new Uri(value); }
        }
        #endregion

        #region medium
        [XmlIgnore]
        private Uri Medium { get; set; }

        [XmlAttribute("medium")]
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public string MediumUri
        {
            get { return Medium == null ? null : Medium.ToString(); }
            set { Medium = value == null ? null : new Uri(value); }
        }

        #endregion

        #region Large
        [XmlIgnore]
        private Uri Large { get; set; }

        [XmlAttribute("large")]
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public string LargeUri
        {
            get { return Large == null ? null : Large.ToString(); }
            set { Large = value == null ? null : new Uri(value); }
        }
        #endregion

        #region Original

        [XmlIgnore]
        private Uri  Original { get; set; }

        [XmlAttribute("original")]
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public string OriginalUri
        {
            get { return Original == null ? null : Original.ToString(); }
            set { Original = value == null ? null : new Uri(value); }
        }

        #endregion 
    }

    
}