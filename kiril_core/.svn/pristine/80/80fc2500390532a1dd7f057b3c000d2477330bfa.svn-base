using Markum.Cloud.BusinessObjects;
using Markum.Cloud.Libraries.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebsitePanel.EnterpriseServer;

namespace Markum.Cloud.Services.Interfaces
{
    public interface IHostingServiceWindowsPanel
    {
        int AddHosting(HostingPlanInfo planInfo, ApiBaseModel model, out string message);

        int UpdateServiceSettings(ApiBaseModel model, string serviceId, string wspIpAddressId, out string message);

        int AddUser(UserInfo userInfo, ApiBaseModel model, out string message);

        int AddPackageWithResources(ApiBaseModel model, int userId, int planId, string panelPlanName, string hostName,
            string domainName, out string message, int statusId = 1,
            bool sendLater = false, bool createResource = true, bool tempdomain = true,
            bool createWebSite = true, bool createFtpAccount = true, string ftpAccountName = null,
            bool createMailAccount = false);
    }
}
