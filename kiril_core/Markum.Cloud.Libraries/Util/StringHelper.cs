using System.Collections.Generic;

namespace Markum.Cloud.Libraries.Util
{
    public static class StringHelper
    {
        public static string ToQueryString(this Dictionary<string, object> dic)
        {
            string queryStr = "";
            foreach (var item in dic)
            {
                queryStr += "&" + item.Key + "=" + item.Value;
            }

            return queryStr.Trim('&');
        }
    }
}
