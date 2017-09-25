using Markum.Cloud.Api.Controllers;
using Markum.Cloud.Services.Interfaces;
using Markum.Cloud.Services.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Markum.Cloud.Api.Tests
{
    [TestClass]
    public class ServerTest
    {
        string apiUrl = "";
        string apiId = "";
        string apiKey = "";

        public ServerTest()
        {
            apiUrl = System.Configuration.ConfigurationManager.AppSettings["ApiURL"];
            apiId = System.Configuration.ConfigurationManager.AppSettings["ApiId"];
            apiKey = System.Configuration.ConfigurationManager.AppSettings["ApiKey"];
        }

        [TestMethod]
        public void Create_Server()
        {
            var controller = new ServerController(new SolusVmService());

            var result = controller.Post(new Libraries.Server.ServerCreateModel()
            {
                CustomBandwidth = "",
                CustomCPU = "",
                CustomDiskspace = "",
                CustomExtraIPs = 0,
                CustomMemory = "",
                Hostname = "ugurrr.markum.net",
                Hvmt = 0,
                InternalIP = "0",
                Ips = 1,
                issuelicense = 0,
                Node = "testnode",
                NodeGroup = 0,
                Password = "123456",
                Plan = "test_plan",
                ServerType = "kvm",
                Template = "windows2012",
                UserName = "ugurkizilkaya",
            });

            Assert.IsNotNull(result);
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void Remove_Server()
        {
            // read from config file
            string apiUrl = System.Configuration.ConfigurationManager.AppSettings["ApiURL"];
            string apiId = System.Configuration.ConfigurationManager.AppSettings["ApiId"];
            string apiKey = System.Configuration.ConfigurationManager.AppSettings["ApiKey"];

            var controller = new ServerController(new SolusVmService());
            var result = controller.Delete(new Libraries.Server.ServerRemoveModel()
            {
                VirtualServerId = 47
            });


            Assert.IsNotNull(result);
            //Assert.AreEqual(((JSend.WebApi.Results.JSendResult<IHttpActionResult>)result).Respons, "success");
        }

        [TestMethod]
        public void Change_Server_Memory_Size()
        {
            // read from config file
            string apiUrl = System.Configuration.ConfigurationManager.AppSettings["ApiURL"];
            string apiId = System.Configuration.ConfigurationManager.AppSettings["ApiId"];
            string apiKey = System.Configuration.ConfigurationManager.AppSettings["ApiKey"];

            var controller = new ServerController(new SolusVmService());
            var result = controller.ChangeMemorySize(new Libraries.Server.ServerChangeMemoryModel()
            {
                //    ApiId = apiId,
                //    ApiKey = apiKey,
                //Action = "vserver-change-memory",
                //ApiUrl = apiUrl,
                VirtualServerId = 16,
                MemorySize = 1024
            });

            Assert.IsNotNull(result);
            Assert.AreEqual(result, true);
        }
    }
}
