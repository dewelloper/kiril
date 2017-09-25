using Markum.Cloud.Api.Controllers;
using Markum.Cloud.BusinessObjects;
using Markum.Cloud.Libraries.LibraryObjects;
using Markum.Cloud.Services.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebsitePanel.EnterpriseServer;
using Markum.Cloud.Libraries.Util;
using Markum.Cloud.Libraries.Hosting;

namespace Markum.Cloud.Api.Tests
{
    [TestClass]
    public class HostingTest
    {
        #region For windows Hosting
         
        string apiUser = "serveradmin";

        //Bayi olmayan
        string url = "http://178.210.175.10:9002";
        string pwd = "bEtQmI4UNJyI+SuEhYGBW+VUsFE/C4zZpP3OnZx0XzQ=";
        string key = "r8yncy8b7ezb67q0ekdd";
        bool _isReseller = true;

        public HostingTest()
        {
            if(_isReseller)
            {
                url = "http://wsptest.markum.net:9002"; // api 9002 panel 9001
                key = "r8yncy8b7ezb67q0ekdd";
                pwd = CryptoUtils.Decrypt("bEtQmI4UNJyI+SuEhYGBW+VUsFE/C4zZpP3OnZx0XzQ=", key);
            }
        }

        //string parola = "aK2d2aS1a6sRt21";
        string targetDomainName = "yenisitex.com";

        [TestMethod]
        public void Add_Hosting()
        {
            var controller = new HostingWindowsController(new HostingServiceWindowsPanel());
            HostingPlanInfo hpi = new HostingPlanInfo()
            {
                UserId = 2,
                PlanId = 0,
                IsAddon = false,
                PlanName = "varsayilan-plan-markumdestek",
                PlanDescription = null,
                Available = true,
                SetupPrice = 0,
                RecurringPrice = 0,
                RecurrenceLength = 1,
                RecurrenceUnit = 2,
                PackageId = 2,
                ServerId = 0,
            };
            hpi.Groups = new HostingPlanGroupInfo[] {
                new HostingPlanGroupInfo() { CalculateBandwidth=true, CalculateDiskSpace = true, GroupId = 1},
                new HostingPlanGroupInfo() { CalculateBandwidth=true, CalculateDiskSpace = true, GroupId = 2},
                new HostingPlanGroupInfo() { CalculateBandwidth=true, CalculateDiskSpace = true, GroupId = 3},
                new HostingPlanGroupInfo() { CalculateBandwidth=true, CalculateDiskSpace = true, GroupId = 11},
                new HostingPlanGroupInfo() { CalculateBandwidth=true, CalculateDiskSpace = true, GroupId = 7},
                new HostingPlanGroupInfo() { CalculateBandwidth=true, CalculateDiskSpace = true, GroupId = 8},
                new HostingPlanGroupInfo() { CalculateBandwidth=true, CalculateDiskSpace = true, GroupId = 22},
            };
            hpi.Quotas = new HostingPlanQuotaInfo[] {
                new HostingPlanQuotaInfo() { QuotaId=70, QuotaValue=1},
                new HostingPlanQuotaInfo() { QuotaId=106, QuotaValue=250},
                new HostingPlanQuotaInfo() { QuotaId=107, QuotaValue=1},
                new HostingPlanQuotaInfo() { QuotaId=108, QuotaValue=1},
                new HostingPlanQuotaInfo() { QuotaId=211, QuotaValue=2},
                new HostingPlanQuotaInfo() { QuotaId=212, QuotaValue=2},
                new HostingPlanQuotaInfo() { QuotaId=213, QuotaValue=50},
                new HostingPlanQuotaInfo() { QuotaId=214, QuotaValue=1},
                new HostingPlanQuotaInfo() { QuotaId=215, QuotaValue=1},
                new HostingPlanQuotaInfo() { QuotaId=216, QuotaValue=1},
                new HostingPlanQuotaInfo() { QuotaId=217, QuotaValue=20},
            };

            string message = "";
            ApiBaseModel model = new ApiBaseModel() { PanelApiUsername = apiUser, PanelApiCryptokey = key, PanelApiPassword = pwd, PanelApiUrl = url };
            var result = controller.AddHosting(hpi, model, out message);

            Assert.IsNotNull(result);
            Assert.AreEqual(result.ToString(), "1");
        }

        [TestMethod]
        public void Update_Hosting()
        {
            var controller = new HostingWindowsController(new HostingServiceWindowsPanel());
            string serviceId = "2";
            string wspipaddressid = "";

            string message = "";
            ApiBaseModel model = new ApiBaseModel() { PanelApiUsername = apiUser, PanelApiCryptokey = key, PanelApiPassword = pwd, PanelApiUrl = url };
            var result = controller.UpdateServiceSettings(model, serviceId, wspipaddressid, out message);

            Assert.IsNotNull(result);
            Assert.AreEqual(result.ToString(), "1");
        }

        [TestMethod]
        public void AddUser_Hosting()
        {
            var controller = new HostingWindowsController(new HostingServiceWindowsPanel());
            UserInfo user = new UserInfo();
            user.UserId = 0;
            user.Role = UserRole.User;
            user.StatusId = 1;
            user.OwnerId = 2;
            user.IsDemo = false;
            user.IsPeer = false;
            user.FirstName = "firstNamexzxz";
            user.LastName = "lastNamexzxz";
            user.Email = "emailzaza@zaza.com";
            user.Username = "userName";
            user.Password = "bXZJV55N69r";

            string message = "";
            ApiBaseModel model = new ApiBaseModel() { PanelApiUsername = apiUser, PanelApiCryptokey = key, PanelApiPassword = pwd, PanelApiUrl = url };
            var result = controller.AddUser(user, model, out message);

            Assert.IsNotNull(result);
            Assert.AreEqual(result.ToString(), "1");
        }

        [TestMethod]
        public void AddPackage_Hosting()
        {
            var controller = new HostingWindowsController(new HostingServiceWindowsPanel());

            string message = "";
            ApiBaseModel model = new ApiBaseModel() { PanelApiUsername = apiUser, PanelApiCryptokey = key, PanelApiPassword = pwd, PanelApiUrl = url };
            var result = controller.AddPackageWithResources(model, 986, 6, targetDomainName, targetDomainName, out message);

            Assert.IsNotNull(result);
            Assert.AreEqual(result.ToString(), "1");
            
        }

        [TestMethod]
        public void EmulateHostingCreating()
        {
            ApiBaseModel model = new ApiBaseModel() { PanelApiUsername = apiUser, PanelApiCryptokey = key, PanelApiPassword = pwd, PanelApiUrl = url };
            // validation will be implemented before service call in panel and core projects
            if (_isReseller)
            {
                var controller = new HostingWindowsController(new HostingServiceWindowsPanel());
                HostingPlanInfo hpi = new HostingPlanInfo()
                {
                    UserId = 1,
                    PlanId = 0,
                    IsAddon = false,
                    PlanName = "Standart Plan",
                    PlanDescription = "",
                    Available = true,
                    SetupPrice = 0,
                    RecurringPrice = 0,
                    RecurrenceLength = 1,
                    RecurrenceUnit = 2,
                    PackageId = 808,
                    ServerId = 0,
                };
                hpi.Groups = new HostingPlanGroupInfo[] {
                new HostingPlanGroupInfo() { CalculateBandwidth=true, CalculateDiskSpace = true, GroupId = 1},
                new HostingPlanGroupInfo() { CalculateBandwidth=true, CalculateDiskSpace = true, GroupId = 2},
                new HostingPlanGroupInfo() { CalculateBandwidth=true, CalculateDiskSpace = true, GroupId = 3},
                new HostingPlanGroupInfo() { CalculateBandwidth=true, CalculateDiskSpace = true, GroupId = 11},
                new HostingPlanGroupInfo() { CalculateBandwidth=true, CalculateDiskSpace = true, GroupId = 7},
                new HostingPlanGroupInfo() { CalculateBandwidth=true, CalculateDiskSpace = true, GroupId = 8},
                new HostingPlanGroupInfo() { CalculateBandwidth=true, CalculateDiskSpace = true, GroupId = 22},
            };
                hpi.Quotas = new HostingPlanQuotaInfo[] {
                new HostingPlanQuotaInfo() { QuotaId=70, QuotaValue=1},
                new HostingPlanQuotaInfo() { QuotaId=106, QuotaValue=250},
                new HostingPlanQuotaInfo() { QuotaId=107, QuotaValue=1},
                new HostingPlanQuotaInfo() { QuotaId=108, QuotaValue=1},
                new HostingPlanQuotaInfo() { QuotaId=211, QuotaValue=2},
                new HostingPlanQuotaInfo() { QuotaId=212, QuotaValue=2},
                new HostingPlanQuotaInfo() { QuotaId=213, QuotaValue=50},
                new HostingPlanQuotaInfo() { QuotaId=214, QuotaValue=1},
                new HostingPlanQuotaInfo() { QuotaId=215, QuotaValue=1},
                new HostingPlanQuotaInfo() { QuotaId=216, QuotaValue=1},
                new HostingPlanQuotaInfo() { QuotaId=217, QuotaValue=20},
            };

                string message = "";
                var result = controller.AddHosting(hpi, model, out message);
                //var result = controller.AddHosting(hpi, url, apiUser, parola, key, out message);
            }

            //s1-------------------------------------------
            var controller2 = new HostingWindowsController(new HostingServiceWindowsPanel());
            string serviceId = "2";
            string wspipaddressid = null;
            string message2 = "";
            if (wspipaddressid != null)
            {
                var result2 = controller2.UpdateServiceSettings(model, serviceId, wspipaddressid, out message2);
                //var result2 = controller2.UpdateServiceSettings(url, apiUser, parola, key, serviceId, wspipaddressid, out message2);
            }

            //s2--------------------

            var controller3 = new HostingWindowsController(new HostingServiceWindowsPanel());
            UserInfo user = new UserInfo();
            user.UserId = 0;
            user.Role = UserRole.User;
            user.StatusId = 1;
            user.OwnerId = 2;
            user.IsDemo = false;
            user.IsPeer = false;
            user.FirstName = "hamit";
            user.LastName = "yildirim";
            user.Email = "dewelloper@gmail.com";
            user.Username = "dewelloper";
            user.Password = "Dimple943";

            string message3 = "";
            var result3 = controller3.AddUser(user, model, out message3);
            //var result3 = controller3.AddUser(user, url, apiUser, parola, key, out message3);

            //s3 --------------------------------

            var controller4 = new HostingWindowsController(new HostingServiceWindowsPanel());

            string message4 = "";
            var result4 = controller4.AddPackageWithResources(model, 808, 808, "Standart Plan", targetDomainName, out message4);
            //var result4 = controller4.AddPackageWithResources(url, apiUser, parola, key, 986, 6, targetDomainName, out message4);
        }

        #endregion

        #region For CPanel Hosting
        [TestMethod]
        public void Add_Package()
        {
            var controller = new HostingCPanelController(new HostingServiceCPanel());
            
            string message = "";
            var result = controller.AddPackage(new Libraries.Hosting.CPanelHostingFeatureModel() {
                PanelApiCryptokey = "j0s8ldjc1b5afndflt31",
                PanelApiPassword = "KJfcdHxDsMKtziCPcij11GSQTkzsbbdtER8pa8CDKGU=",
                PanelApiUrl = "cp42.markum.net",
                PanelApiUsername = "markum",
                maxpop = "0",
                maxlst = "0",
                maxsub = "0",
                maxaddon = "0",
                MAX_EMAIL_PER_HOUR = "0",
                MAX_DEFER_FAIL_PERCENTAGE = "1",
                ip = "0",
                hasshell = "0",
                frontpage = "0",
                cgi = "0",
                digestauth = "0",
                cpmod = "paper_lantern",
                featurelist = "default",
                language = "en",
                maxpark = "99",
                quota = "unlimited",
                bwlimit = "52428",
                maxftp = "3",
                maxsql = "unlimited"
            }, "test package");

            Assert.IsNotNull(result);
            Assert.AreEqual(result.ToString(), "1");
        }

        [TestMethod]
        public void Create_Account()
        {
            var controller = new HostingCPanelController(new HostingServiceCPanel());

            var result = controller.CreateAccount(new Libraries.Hosting.CPanelHostingFeatureModel()
            {
                PanelApiCryptokey = "j0s8ldjc1b5afndflt31",
                PanelApiPassword = "OS4QR5NdweQf1igyTMoyS77uEyXc8E/nI6X3tZvKtHk=",
                PanelApiUrl = "cp16.markum.net",
                PanelApiUsername = "markum",
                HostingDomainName = "denemetestii.com",
                HostingEmail = "denemeeme@mama.com",
                HostingIp = "178.210.171.25",
                HostingPassword = "WwvGHHht67",
                HostingPlanName = "varsayilan-plan-markumdestek",
                HostingUserName = "daniellasvegas"
            });

            Assert.IsNotNull(result);
            Assert.AreEqual(result.ToString(), "true");
        }

        #endregion

    }



}
