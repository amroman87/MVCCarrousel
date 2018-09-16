using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.XPath;
using NUnit.Framework;
using XmlDiffLib;

namespace Carrousel1.Test
{
    [TestFixture ]
    public class XMlTest
    {
        [Test]
        public void XmlMatchFormat()
        {
            string originalXML;
            string controlXML;
            
            var xml = GetType().Module.Assembly.GetManifestResourceStream("Carrousel1.Test.Resources.XML.Images.xml");

            using (StreamReader reader = new StreamReader(xml))
            {
                originalXML = reader.ReadToEnd();
            }

            var xmlControl = GetType().Module.Assembly.GetManifestResourceStream("Carrousel1.Test.Resources.XML.ImageControl.xml");

            using (StreamReader reader = new StreamReader(xmlControl))
            {
                controlXML = reader.ReadToEnd();
            }

            XmlDiff diff = new XmlDiff(controlXML, originalXML);

            XmlDiffOptions options = new XmlDiffOptions();        

            var result = diff.CompareDocuments(options);

            Assert.IsTrue(diff.DiffNodeList.Count == 0);
            
        }
    }
}
