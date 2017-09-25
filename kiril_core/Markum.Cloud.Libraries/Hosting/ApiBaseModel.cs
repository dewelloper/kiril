using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markum.Cloud.Libraries.Hosting
{
    public class ApiBaseModel
    {
        public string PanelApiUrl { get; set; }
        public string PanelApiUsername { get; set; }
        public string PanelApiPassword { get; set; }
        public string PanelApiCryptokey { get; set; }
    }
}
