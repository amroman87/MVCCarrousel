using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Carrousel1.Controllers;
using Carrousel1.Services;
using Moq;
using NUnit.Framework;

namespace Carrousel1.Test
{
    [TestFixture]
    public class HomeControllerTest
    {

        private HomeController _homeController;
        private Mock<IGetImagesService> _mockService;
        private List<Image> _images;

        public HomeControllerTest()
        {

        }
        [SetUp]
        public void SetUp()
        {
            _images = new List<Image>();
            _images.Add(new Image() { Id = 0 , OriginalUri = "https://url.com"});

            _mockService = new Mock<IGetImagesService>();
            _mockService
                .Setup(m => m.getImages())
                .Returns(_images);

            _homeController = new HomeController(_mockService.Object);
        }


        [Test]
        public void HomeController_Index_should_return_Images()
        {

            var result = _homeController.Index() as ViewResult;
            List<Image> model = (List<Image>)result.Model;

            Assert.IsNotNull(model);
            Assert.IsTrue(model.Count > 0);
        }

        [Test]
        public void HomeController_OriginalImageURL_should_return_string_empty()
        {
            var result = _homeController.OriginalImageURL(0);

            Assert.IsNotEmpty(result.Data.ToString ());
           
        }
    }
}
