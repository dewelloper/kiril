using Markum.Cloud.Libraries.Attributes;
using System.Collections.Generic;

namespace Markum.Cloud.Libraries.Server
{
    public class ServerCreateModel : ServerBaseModel
    {
        //[openvz|xen|xen hvm|kvm]

        [SolusVmQuery(name: "type")]
        public string ServerType { get; set; } = "kvm";

        [SolusVmQuery(name: "node")]
        public string Node { get; set; } = "";

        [SolusVmQuery(name: "nodegroup")]
        public int NodeGroup { get; set; } = 0;

        [SolusVmQuery(name: "hostname")]
        public string Hostname { get; set; } = "";

        [SolusVmQuery(name: "password")]
        public string Password { get; set; } = "";

        [SolusVmQuery(name: "username")]
        public string UserName { get; set; } = "";

        [SolusVmQuery(name: "plan")]
        public string Plan { get; set; } = "";

        [SolusVmQuery(name: "template")]
        public string Template { get; set; } = "";

        //public List<string> Ips { get; set; }

        [SolusVmQuery(name: "ips")]
        public int Ips { get; set; } = 1;


        [SolusVmQuery(name: "Hvmt")]
        public int Hvmt { get; set; } = 0;

        [SolusVmQuery(name: "custommemory")]
        public string CustomMemory { get; set; } = "";

        [SolusVmQuery(name: "customdiskspace")]
        public string CustomDiskspace { get; set; } = "";

        [SolusVmQuery(name: "custombandwidth")]
        public string CustomBandwidth { get; set; } = "";

        [SolusVmQuery(name: "customcpu")]
        public string CustomCPU { get; set; } = "";
        //public List<string> CustomExtraIPs { get; set; }

        [SolusVmQuery(name: "customextraip")]
        public int CustomExtraIPs { get; set; } = 0;

        //[SolusVmQuery(name: "customextraip")]
        //public string CustomExtraIPsWithComma
        //{
        //    get { return string.Join(",", CustomExtraIPs); }
        //}

        [SolusVmQuery(name: "issuelicense")]
        public int issuelicense { get; set; } = 0;

        [SolusVmQuery(name: "internalip")]
        public string InternalIP { get; set; } = "0";
    }
}
