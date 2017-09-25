using Markum.Cloud.Libraries.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markum.Cloud.Libraries.Hosting
{
    public class HostingBaseModel : ApiBaseModel
    {
        public string HostingUserName { get; set; }
        public string HostingPassword { get; set; }
        public string HostingEmail { get; set; }
        public string HostingIp { get; set; }
        public string HostingDomainName { get; set; }
        public string HostingPlanName { get; set; }

        public bool IsReseller { get; set; }
        public bool ResellerHasAccountCreationLimit { get; set; }
        public Int32 ResellerAccountCreationQuantityLimit { get; set; }
        public bool ResellerHasResourceLimit { get; set; }
        public Int32 ResellerBandWithLimit { get; set; }
        public Int32 ResellerDiskSpaceLimit { get; set; }


    }
}
