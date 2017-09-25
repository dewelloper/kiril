using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace panel
{
    public partial class design : System.Web.UI.MasterPage
    {

        public string _accessToken;
        protected string _accessUrl = "http://beta.core.markum.net/api/customeraccount";
        protected string _currUser;

        protected string _uiconfig = "http://beta.core.markum.net/api/userinterfaceconfig";
        public string _language;
        public string _title;
        public string _logo;
        public string _companyname;
        public string _footers;
        public string _trackingcodeGoogle;
         

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["acc"] != null)
            {
                _accessToken = Request.QueryString["acc"].ToString();
                Session["_accessToken"] = _accessToken;
            }

            if (HttpContext.Current.Request.IsLocal)
            {
                Session["_accessToken"] = "RB0U42bFcJcXTfkePIAf278vwoTrLacrpq9qquNtkS06rRvLvToTyrsV_3UOaOIh8BxEo5dArm5BJEI_leSy5EyYsemW0lsgfeOXCOXxz31M_RIUWg34Ory5HcQsKO7JLjhqeor2ZLI6k9Z4E5svebT1kDblz5dbtOQFRpQAY7QxmYAcfFU0byLn_UiLiwTyzSGl1boabm8Q_N7uPGcdILMHgmlDZFr611ojvnhuabeGMs_ZQ2SVelLB4k3w0EC-8FL7pA3yI8nJi2D4RpcVZ7LforVINSaKge9wNT0GlnSfDWGEQhbWIpVw28I7kA43fXY3_UCuNoy1kBWiF38wNg";
                _accessToken = Session["_accessToken"].ToString();
            }

            if (!IsAccessTokenOk())
            {
                Response.Redirect("http://beta.markum.net/Account/Login");
            }
            else
            {
                //GetUserInterfaceConfig();
            }
        }


        private bool IsAccessTokenOk()
        {
            using (var httpClient = new HttpClient())
            {
                if (Session["_accessToken"] == null)
                    return false;

                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Session["_accessToken"].ToString());

                var response = httpClient.GetAsync(_accessUrl).Result;

                if (response.StatusCode.ToString() == "Unauthorized")
                    return false;

                var res = JsonConvert.DeserializeObject<dynamic>(response.Content.ReadAsStringAsync().Result);

                _currUser = res.data.Name + ' ' + res.data.Surname;
            }

            return true;
        }

        private bool GetUserInterfaceConfig()
        {
            using (var httpClient = new HttpClient())
            {
                var response = httpClient.GetAsync(_uiconfig).Result;
                var res = JsonConvert.DeserializeObject<dynamic>(response.Content.ReadAsStringAsync().Result);

                _language = res.data.language;
                _title = res.data.title;
                _logo = res.data.logo;
                _companyname = res.data.companyname;
                _footers = res.data.footers;
                _trackingcodeGoogle = res.data.trackingcodeGoogle;
            }

            return true;
        }

    }
}