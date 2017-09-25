using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markum.Cloud.Libraries.Server
{
    public class SolusCreateResponse : SolusResponseBase
    {
        [JsonProperty(PropertyName = "mainipaddress")]
        public string MainIpAddress { get; set; }

        [JsonProperty(PropertyName = "extraipaddress")]
        public string ExtraIpAddress { get; set; }

        [JsonProperty(PropertyName = "rootpassword")]
        public string RootPassword { get; set; }

        [JsonProperty(PropertyName = "vserverid")]
        public string VirtualServerId { get; set; }

        [JsonProperty(PropertyName = "consoleuser")]
        public string ConsoleUser { get; set; }

        [JsonProperty(PropertyName = "consolepassword")]
        public string ConsolePassword { get; set; }

        [JsonProperty(PropertyName = "hostname")]
        public string HostName { get; set; }

        [JsonProperty(PropertyName = "virtid")]
        public string VirtId { get; set; }

        [JsonProperty(PropertyName = "nodeid")]
        public int NodeId { get; set; }
    }
}
