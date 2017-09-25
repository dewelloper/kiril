using Markum.Cloud.Libraries.Attributes;
using Markum.Cloud.Libraries.Server;
using Markum.Cloud.Libraries.Util;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net;
using System.Text;
//using System.Configuration;

namespace Markum.Cloud.Libraries.LibraryObjects
{
    public class SolusBase
    {
        private static void BypassCertificateError() //sertifika hatasını çözen method
        {
            ServicePointManager.ServerCertificateValidationCallback +=
                delegate { return true; };
        }

        protected T CreateRequest<T>(object obj, string actionType)
        {
            ServicePointManager.Expect100Continue = false;
            BypassCertificateError();
            //obj'yi convert et
            string solusApiUrl = ConfigurationManager.AppSettings["SolusApiURL"];
            string solusApiId = ConfigurationManager.AppSettings["SolusApiId"];
            string solusApiKey = ConfigurationManager.AppSettings["SolusApiKey"];

            Dictionary<string, object> result = obj.GetCustomAttributesWithValue<SolusVmQueryAttribute>(("Name"));
            var queryString = result.ToQueryString();
            HttpWebRequest request = (HttpWebRequest)
                    WebRequest.Create(solusApiUrl + "?" + queryString + "&rdtype=json&id=" + solusApiId + "&key=" + solusApiKey + "&action=" + actionType);

            request.Method = "POST";

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] buffer = encoding.GetBytes(request.Headers.ToString());
            using (Stream stream = request.GetRequestStream())
            {
                stream.Write(buffer, 0, buffer.Length);
            }

            ServicePointManager.Expect100Continue = false;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream receive = response.GetResponseStream();
            StreamReader sr = new StreamReader(receive);

            var jsonStr = sr.ReadToEnd();

            dynamic jResponse = JObject.Parse(jsonStr);

            if (jResponse.status == "error")
                throw new System.Exception(jResponse.statusmsg.Value);

            return JsonConvert.DeserializeObject<T>(jsonStr);
        }
    }
}
