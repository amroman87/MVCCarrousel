using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace HeiswayiNrird.Utility.Common
{
    public static class XmlHelper
    {
        /// <summary>
        /// Deserialize XML string to an object.
        /// </summary>
        /// <typeparam name="T">Type of object</typeparam>
        /// <param name="xml">XML string</param>
        /// <returns>XML-deserialized object</returns>
        public static T DeserializeFromXmlString<T>(string xml) where T : new()
        {
            T xmlObject = new T();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            StringReader stringReader = new StringReader(xml);
            xmlObject = (T)xmlSerializer.Deserialize(stringReader);
            return xmlObject;
        }

        /// <summary>
        /// Deserialize XML string from XML file to an object.
        /// </summary>
        /// <typeparam name="T">Type of object</typeparam>
        /// <param name="filename">XML filename with .XML extension</param>
        /// <returns>XML-deserialized object</returns>
        public static T DeserializeFromXmlFile<T>(string filename) where T : new()
        {
            
            
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }

            return DeserializeFromXmlString<T>(File.ReadAllText(filename));
        }
        
    }
}