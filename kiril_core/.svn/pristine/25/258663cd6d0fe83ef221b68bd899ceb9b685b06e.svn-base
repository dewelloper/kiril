using Markum.Cloud.BusinessObjects;
using Markum.Cloud.Libraries.Hosting;
using Markum.Cloud.Libraries.Util;
using Markum.Cloud.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebsitePanel.EnterpriseServer;



namespace Markum.Cloud.Services.Services
{
    public class HostingServiceWindowsPanel : IHostingServiceWindowsPanel
    {

        public int AddHosting(HostingPlanInfo planInfo, ApiBaseModel model, out string message)
        {
            int planId = -1;
            try
            {
                esPackages packageservice = new esPackages();
                esHelper.SetConnection(packageservice, model.PanelApiUrl, model.PanelApiUsername,
                    CryptoUtils.Decrypt(model.PanelApiPassword, model.PanelApiCryptokey)
                    //panelApiPwd
                    );
                planId = packageservice.AddHostingPlan(planInfo);
                if (planId < 0)
                {
                    message = esHelper.GetMessage(planId);
                    return planId;
                }
                message = "ok";
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }

            return planId;
        }

        public int UpdateServiceSettings(ApiBaseModel model, string serviceId, string wspIpAddressId, out string message)
        {
            int serviceSettingsId = -1;
            try
            {
                esServers ess = new esServers();
                esHelper.SetConnection(ess, model.PanelApiUrl, model.PanelApiUsername,
                    CryptoUtils.Decrypt(model.PanelApiPassword, model.PanelApiCryptokey)
                    );

                serviceSettingsId = ess.UpdateServiceSettings(Convert.ToInt32(serviceId),
                    new[] { "SharedIP=" + wspIpAddressId });
                message = "ok";
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }

            return serviceSettingsId;
        }

        public int AddUser(UserInfo userInfo, ApiBaseModel model, out string message)
        {
            int userid = -1;
            try
            {
                esUsers esu = new esUsers();
                esHelper.SetConnection(esu, model.PanelApiUrl, model.PanelApiUsername,
                    CryptoUtils.Decrypt(model.PanelApiPassword, model.PanelApiCryptokey)
                    //panelApiPwd
                    );

                userid = esu.AddUser(userInfo, false);
                if (userid < 0)
                {
                    message = esHelper.GetMessage(userid);
                }
                message = "realuserid";
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }

            return userid;
        }

        public int AddPackageWithResources(ApiBaseModel model, int userId, int planId, string panelPlanName, string hostName,
            string domainName, out string message, int statusId =1,
            bool sendLater=false, bool createResource=true, bool tempdomain=true,
            bool createWebSite=true, bool createFtpAccount=true, string ftpAccountName=null, 
            bool createMailAccount=false)
        {
            int serverDomainID = -1;
            try
            {
                esPackages esp = new esPackages();
                esHelper.SetConnection(esp, model.PanelApiUrl, model.PanelApiUsername,
                    CryptoUtils.Decrypt(model.PanelApiPassword, model.PanelApiCryptokey)
                    //panelApiPwd
                    );

                // hostName parametresi websitepanel 2.0 ile geldi
                PackageResult pr = esp.AddPackageWithResources(userId, planId, panelPlanName, statusId, sendLater, createResource, domainName, tempdomain,
                    createWebSite, createFtpAccount, ftpAccountName, createMailAccount, hostName);

                if (pr.Result < 0)
                {
                    message = esHelper.GetMessage(pr.Result);

                    // IIS de domaine ait websitesi olup, websitepanelde kayıtlı değilse bu hatayı döndürüyor
                    // Kurulum esnasında hata oluşursa (örneğin applicationHost.config dosyasına yazamaması) websitepanel siteyi silmiyor ya da silemiyor
                    // Birkaç kurulum denemesinden sonra bu hata oluşuyor
                    if (pr.Result == -999)
                        message = "Teknik bir sorundan ötürü işleminize devam edemiyorum. Lütfen ticket açınız";

                    //try to delete user
                    try
                    {
                        esUsers esu = new esUsers();
                        int tmp = esu.DeleteUser(userId);
                    }
                    catch (Exception ex)
                    {
                        //InsertLog(ex);
                        message = ex.Message;
                    }
                }

                int serverSoldPlanID = pr.Result;

                esServers ess = new esServers();
                esHelper.SetConnection(ess, model.PanelApiUrl, model.PanelApiUsername,
                    CryptoUtils.Decrypt(model.PanelApiPassword, model.PanelApiCryptokey)
                    //panelApiPwd
                    );
                WebsitePanel.EnterpriseServer.DomainInfo[] mydomains = ess.GetMyDomains(pr.Result);
                serverDomainID = mydomains[0].DomainId;
                message = "ok";
            }
            catch (Exception ez)
            {
                //try to delete user
                try
                {
                    esUsers esu = new esUsers();
                    int tmp = esu.DeleteUser(userId);
                }
                catch (Exception ex)
                {
                    //InsertLog(ex);
                    message = ex.Message;
                }

                //InsertLog(ex);
                message = ez.Message;
            }

            return serverDomainID;
        }



    }

}
