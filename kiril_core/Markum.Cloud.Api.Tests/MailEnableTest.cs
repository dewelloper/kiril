using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Markum.Cloud.Api.Controllers;
using Markum.Cloud.Services.Services;

namespace Markum.Cloud.Api.Tests
{
    [TestClass]
    public class MailEnableTest
    {
        [TestMethod]
        public void AddPostOffice()
        {
            var controller = new MailController(new MailService());

            var result = controller.AddPostOffice("hamityildirim@markum.net");

            Assert.IsNotNull(result);
            Assert.AreEqual(((JSend.WebApi.Results.JSendCreatedResult<int>)result).StatusCode.ToString(), "Created");
        }

        [TestMethod]
        public void GetPostOffice()
        {
            var controller = new MailController(new MailService());

            var result = controller.GetPostOffice("hamityildirim@markum.net");

            Assert.IsNotNull(result);
        }

    }
}
