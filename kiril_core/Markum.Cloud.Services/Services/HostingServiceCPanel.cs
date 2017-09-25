using Markum.Cloud.Libraries.Hosting;
using Markum.Cloud.Libraries.LibraryObjects;
using Markum.Cloud.Libraries.Util;
using Markum.Cloud.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Markum.Cloud.Services.Services
{
    public class HostingServiceCPanel : HostingBase, IHostingServiceCPanel
    {

        public string AddPackage(HostingBaseModel model, string planName) // planName coming from CPanel API not from us
        {
            string message = "";
            try
            {
                CPanelXMLAPI xmlapi = new CPanelXMLAPI();
                xmlapi.Host = model.PanelApiUrl;
                xmlapi.Auth(model.PanelApiUsername,
                    CryptoUtils.Decrypt(model.PanelApiPassword, model.PanelApiCryptokey));

                string querystring = GetQueryStringFromModel(model);
                string r = xmlapi.AddPackage("planname", querystring);

                if (CPanelXMLHelper.GetStatus(r, out message) == false)
                    message = "ok";
            }
            catch(Exception ex)
            {

            }
            return message;
        }

        // this function creates cpanel account but full setting for reseller parts are never be working on 
        // live environment than we didnt got it them here
        public bool CreateAccount(HostingBaseModel model, out string message)
        {
            bool result = true;
            try
            {
                CPanelXMLAPI xmlapi = new CPanelXMLAPI();
                xmlapi.Host = model.PanelApiUrl;
                xmlapi.Auth(model.PanelApiUsername,
                    CryptoUtils.Decrypt(model.PanelApiPassword, model.PanelApiCryptokey));

                string r = xmlapi.CreateAccount(model.HostingUserName, model.HostingPassword, model.HostingEmail, model.IsReseller, model.HostingDomainName, model.HostingPlanName);
                message = "ok";

                if (model.IsReseller)
                {
                    #region Set reseller limits
                    try
                    {
                        r = xmlapi.SetResellerACLList(model.HostingUserName, model.HostingPlanName); // templatename is planname?
                        if (CPanelXMLHelper.GetStatus(r, out message))
                        {
                            r = xmlapi.SetResellerResourceLimits(model.HostingUserName,
                                                                model.ResellerHasAccountCreationLimit,
                                                                model.ResellerAccountCreationQuantityLimit,
                                                                model.ResellerHasAccountCreationLimit,
                                                                model.ResellerBandWithLimit,
                                                                model.ResellerDiskSpaceLimit);

                            if (!CPanelXMLHelper.GetStatus(r, out message))
                            {
                                try
                                {
                                    r = xmlapi.TerminateReseller(model.HostingUserName, true);
                                }
                                catch (Exception ex)
                                {
                                    message = ex.Message;
                                }

                                return false;
                            }
                        }
                        else
                        {
                            try
                            {
                                r = xmlapi.TerminateReseller(model.HostingUserName, true);
                            }
                            catch (HttpUnhandledException exx)
                            {
                                result = false;
                                message = exx.Message;
                            }
                            catch (Exception ex)
                            {
                                result = false;
                                message = ex.Message;
                            }

                            return false;
                        }
                    }
                    catch
                    {
                        try
                        {
                            r = xmlapi.TerminateReseller(model.HostingUserName, true);
                        }
                        catch (HttpUnhandledException exx)
                        {
                            result = false;
                            message = exx.Message;
                        }
                        catch (Exception ex)
                        {
                            result = false;
                            message = ex.Message;
                        }
                    }
                    #endregion
                }

                if (model.HostingIp != null) // default
                {
                    r = xmlapi.SetSiteIp(model.HostingDomainName, model.HostingIp);
                }
            }
            catch(Exception ex)
            {
                result = false;
                message = ex.Message;
            }

            return result;
        }

    }
}
