using Markum.Cloud.Libraries.Attributes;
using Markum.Cloud.Libraries.Hosting;
using Markum.Cloud.Libraries.LibraryObjects;
using Markum.Cloud.Libraries.Util;
using System.Collections.Generic;

namespace Markum.Cloud.Services.Services
{
    public class HostingBase
    {
        protected string GetQueryStringFromModel(HostingBaseModel obj)
        {
            Dictionary<string, object> result = obj.GetCustomAttributesWithValue<AnalyserAttribute>(("Name"));
            return result.ToQueryString();
        }
    }
}