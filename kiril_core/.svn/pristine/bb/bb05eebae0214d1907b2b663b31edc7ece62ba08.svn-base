using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;


//CCR67eKqE1kBndY24Y91EydW live api key for licensing
//ekxhlrz8qog0m72rCvHahRgK test api key for licensing

namespace Markum.Cloud.Libraries.Util
{
    public class Ports
    {
        public const int CPanelUnsecured = 2082;
        public const int CPanelSecured = 2083;
        public const int WHMUnsecured = 2086;
        public const int WHMSecured = 2087;
        public const int HTTPPort = 80;
    }

    public class Protocols
    {
        public const string HTTP = "http";
        public const string HTTPS = "https";
    }

    public enum OutputType
    {
        NONE = 0,
        XML,
        JSON
    }

    public struct KeyValue
    {
        public string Key;
        public string Value;
    }

    public class CPanelXMLAPI
    {
        private string _host;
        private string _user;
        private string _password;
        private int _port;
        private string _protocol;
        private OutputType _output;

        public string Host
        {
            get { return _host; }
            set { _host = value; }
        }

        public string User
        {
            get { return _user; }
            set { _user = value; }
        }

        public string Password
        {
            set { _password = value; }
        }

        public int Port
        {
            get { return _port; }
            set { _port = value; }
        }

        public string Protocol
        {
            get { return _protocol; }
            set { _protocol = value; }
        }

        public OutputType Output
        {
            get { return _output; }
            set { _output = value; }
        }

        public CPanelXMLAPI()
        {
            _port = Ports.WHMSecured;
            _protocol = Protocols.HTTPS;
            _output = OutputType.XML;
        }

        public CPanelXMLAPI(string host)
            : this()
        {
            _host = host;
        }

        public CPanelXMLAPI(string host, string user, string password)
            : this(host)
        {
            _user = user;
            _password = password;
        }

        public void Auth(string user, string password)
        {
            _user = user;
            _password = password;
        }

        public string XMLAPIQuery(string function, List<KeyValue> vars = null)
        {
            string args = HttpBuildQuery(vars);

            string querytype;
            if (_output == OutputType.XML)
                querytype = "xml-api";
            else
                querytype = "json-api";

            string url = string.Format("{0}://{1}:{2:d}/{3}/{4}", _protocol, _host, _port, querytype, function);

            string respose = RequestWeb(url, args);

            return respose;
        }

        public string XMLAPIQuery2(string url, List<KeyValue> vars = null)
        {
            string args = HttpBuildQuery(vars);

            string respose = RequestWeb2(url, args);

            return respose;
        }

        public string XMLAPIQuery(string function, string vars)
        {
            string args = vars;

            string querytype;
            if (_output == OutputType.XML)
                querytype = "xml-api";
            else
                querytype = "json-api";

            string url = string.Format("{0}://{1}:{2:d}/{3}/{4}", _protocol, _host, _port, querytype, function);

            string respose = RequestWeb(url, args);

            return respose;
        }

        private string HttpBuildQuery(List<KeyValue> vars)
        {
            if (vars == null)
                return string.Empty;
            return string.Join("&", vars.Select(k => string.Format("{0}={1}", k.Key, k.Value)));
        }

        private string RequestWeb(string url, string args)
        {

            ServicePointManager.Expect100Continue = false;

            string auth = "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes(_user + ":" + _password));
            byte[] data = Encoding.UTF8.GetBytes(args);

            HttpWebRequest req = WebRequest.Create(url) as HttpWebRequest;
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";
            req.Headers.Add("Authorization", auth);
            req.ContentLength = data.Length;

            // HACK: The underlying connection was closed: Could not establish trust relationship for the SSL/TLS secure channel
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

            Stream dataStream = null;
            WebResponse resp = null;
            StreamReader reader = null;

            try
            {
                dataStream = req.GetRequestStream();
                dataStream.Write(data, 0, data.Length);
                dataStream.Close();

                resp = req.GetResponse();
                dataStream = resp.GetResponseStream();
                reader = new StreamReader(dataStream, Encoding.UTF8);
                string content = reader.ReadToEnd();

                return content;
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (dataStream != null)
                    dataStream.Close();
                if (resp != null)
                    resp.Close();
            }
        }

        private string RequestWeb2(string url, string args)
        {
            byte[] data = Encoding.UTF8.GetBytes(args);

            HttpWebRequest req = WebRequest.Create(url) as HttpWebRequest;
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";
            req.ContentLength = data.Length;

            // HACK: The underlying connection was closed: Could not establish trust relationship for the SSL/TLS secure channel
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

            Stream dataStream = null;
            WebResponse resp = null;
            StreamReader reader = null;

            try
            {
                dataStream = req.GetRequestStream();
                dataStream.Write(data, 0, data.Length);
                dataStream.Close();

                resp = req.GetResponse();
                dataStream = resp.GetResponseStream();
                reader = new StreamReader(dataStream, Encoding.UTF8);
                string content = reader.ReadToEnd();

                return content;
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (dataStream != null)
                    dataStream.Close();
                if (resp != null)
                    resp.Close();
            }
        }

        public string API1Query(string user, string module, string function, List<KeyValue> vars)
        {
            string cpuser = "cpanel_xmlapi_user";
            string moduleType = "cpanel_xmlapi_module";
            string funcType = "cpanel_xmlapi_func";
            string apiType = "cpanel_xmlapi_apiversion";

            if (_output == OutputType.JSON)
            {
                cpuser = "cpanel_jsonapi_user";
                moduleType = "cpanel_jsonapi_module";
                funcType = "cpanel_jsonapi_func";
                apiType = "cpanel_jsonapi_apiversion";
            }

            KeyValue v1, v2, v3, v4;
            v1.Key = cpuser;
            v1.Value = user;
            v2.Key = moduleType;
            v2.Value = module;
            v3.Key = funcType;
            v3.Value = function;
            v4.Key = apiType;
            v4.Value = "1";

            List<KeyValue> vars2 = new List<KeyValue>(vars.Count + 4);

            for (int i = 0; i < vars.Count; i++)
            {
                KeyValue v;
                v.Key = "arg-" + i;
                v.Value = vars[i].Value;
                vars2.Add(v);
            }

            vars2.Add(v1);
            vars2.Add(v2);
            vars2.Add(v3);
            vars2.Add(v4);

            return XMLAPIQuery("cpanel", vars2);
        }

        public string API2Query(string user, string module, string function, List<KeyValue> vars)
        {
            string cpuser = "cpanel_xmlapi_user";
            string moduleType = "cpanel_xmlapi_module";
            string funcType = "cpanel_xmlapi_func";
            string apiType = "cpanel_xmlapi_apiversion";

            if (_output == OutputType.JSON)
            {
                cpuser = "cpanel_jsonapi_user";
                moduleType = "cpanel_jsonapi_module";
                funcType = "cpanel_jsonapi_func";
                apiType = "cpanel_jsonapi_apiversion";
            }

            KeyValue v1, v2, v3, v4;
            v1.Key = cpuser;
            v1.Value = user;
            v2.Key = moduleType;
            v2.Value = module;
            v3.Key = funcType;
            v3.Value = function;
            v4.Key = apiType;
            v4.Value = "2";

            vars.Add(v1);
            vars.Add(v2);
            vars.Add(v3);
            vars.Add(v4);

            return XMLAPIQuery("cpanel", vars);
        }

        public string ListApp()
        {
            return XMLAPIQuery("applist");
        }

        public string ListAccounts()
        {
            return XMLAPIQuery("listaccts");
        }

        public string ListResellers()
        {
            return XMLAPIQuery("listresellers");
        }

        public string ListPackages()
        {
            return XMLAPIQuery("listpkgs");
        }

        public string ChangePassword(string userName, string password, bool mysqlPassUpdate = true)
        {
            KeyValue v1, v2, v3;
            v1.Key = "user";
            v1.Value = userName;
            v2.Key = "pass";
            v2.Value = password;
            v3.Key = "db_pass_update";
            v3.Value = mysqlPassUpdate ? "1" : "0";

            return XMLAPIQuery("passwd", new List<KeyValue> { v1, v2, v3 });
        }

        public string CreateAccount(string userName, string domain)
        {
            KeyValue v1, v2;
            v1.Key = "username";
            v1.Value = userName;
            v2.Key = "domain";
            v2.Value = domain;

            return XMLAPIQuery("createacct", new List<KeyValue> { v1, v2 });
        }

        public string CreateAccount(string userName, string password, bool isReseller, string domain, string plan)
        {
            KeyValue v1, v2, v3, v4, v5;
            v1.Key = "username";
            v1.Value = userName;
            v2.Key = "password";
            v2.Value = password;
            v3.Key = "reseller";
            v3.Value = isReseller ? "1" : "0";
            v4.Key = "domain";
            v4.Value = domain;
            v5.Key = "plan";
            v5.Value = plan;

            return XMLAPIQuery("createacct", new List<KeyValue> { v1, v2, v3, v4, v5 });
        }

        public string CreateAccount(string userName, string password, string email, bool isReseller, string domain,
            string plan)
        {
            KeyValue v1, v2, v3, v4, v5, v6;
            v1.Key = "username";
            v1.Value = userName;
            v2.Key = "password";
            v2.Value = password;
            v3.Key = "contactemail";
            v3.Value = email;
            v4.Key = "reseller";
            v4.Value = isReseller ? "1" : "0";
            v5.Key = "domain";
            v5.Value = domain;
            v6.Key = "plan";
            v6.Value = plan;
            // v7.Key = "ip"; v7.Value = siteip;

            return XMLAPIQuery("createacct", new List<KeyValue> { v1, v2, v3, v4, v5, v6 });
        }

        public string CreateAccount(List<KeyValue> accountInfo)
        {
            if (!accountInfo.Exists(k => k.Key == "username") && !accountInfo.Exists(k => k.Key == "domain"))
                throw new Exception("Kullanici adi ve domain bilgisi eksik");

            return XMLAPIQuery("createacct", accountInfo);
        }

        public string TerminateAccount(string userName, int keepdns = 2)
        {
            KeyValue v1, v2;
            v1.Key = "user";
            v1.Value = userName;
            v2.Key = "keepdns";
            v2.Value = keepdns.ToString();

            return XMLAPIQuery("removeacct", new List<KeyValue> { v1, v2 });
        }

        public string TerminateReseller(string userName, bool terminateMainAccount)
        {
            string verify = "I understand this will irrevocably remove all the accounts owned by the reseller " + userName;

            KeyValue v1, v2, v3;
            v1.Key = "reseller";
            v1.Value = userName;
            v2.Key = "terminatereseller";
            v2.Value = terminateMainAccount ? "1" : "0";
            v3.Key = "verify";
            v3.Value = verify;

            return XMLAPIQuery("terminatereseller", new List<KeyValue> { v1, v2, v3 });
        }

        public string Stat(string userName, string[] statistics)
        {
            string display = String.Join("|", statistics);

            KeyValue v1;
            v1.Key = "display";
            v1.Value = display;

            return API2Query(userName, "StatsBar", "stat", new List<KeyValue> { v1 });
        }

        public string SetResellerACLList(string userName, string templateName)
        {
            KeyValue v1, v2;
            v1.Key = "reseller";
            v1.Value = userName;
            v2.Key = "acllist";
            v2.Value = templateName;

            return XMLAPIQuery("setacls", new List<KeyValue> { v1, v2 });
        }

        public string SetResellerACLList(string userName, List<KeyValue> ACLVariables)
        {
            KeyValue v1;
            v1.Key = "reseller";
            v1.Value = userName;

            ACLVariables.Add(v1);

            return XMLAPIQuery("setacls", ACLVariables);
        }

        public string DisableResellerACL(string userName)
        {
            KeyValue v1;
            v1.Key = "reseller";
            v1.Value = userName;

            return XMLAPIQuery("setacls", new List<KeyValue> { v1 });
        }

        public string SetResellerResourceLimits(string userName, bool enableAccountLimit, int accountLimit,
            bool enableResourceLimits, int bandwidthLimit, int diskSpaceLimit)
        {
            return SetResellerResourceLimits(userName, enableAccountLimit, accountLimit, enableResourceLimits,
                bandwidthLimit, diskSpaceLimit, false, false, false, false, false);
        }

        public string SetResellerResourceLimits(string userName, bool enableAccountLimit, int accountLimit,
            bool enableResourceLimits, int bandwidthLimit, int diskSpaceLimit, bool enableOverSelling,
            bool enableOverSellingBandwidth, bool enableOverSellingDiskSpace, bool enablePackageLimits,
            bool enablePackageLimitNumbers)
        {
            return XMLAPIQuery("setresellerlimits ", new List<KeyValue>
        {
            new KeyValue {Key = "user", Value = userName},
            new KeyValue {Key = "enable_account_limit", Value = enableAccountLimit ? "1" : "0"},
            new KeyValue {Key = "account_limit", Value = accountLimit.ToString()},
            new KeyValue {Key = "enable_resource_limits", Value = enableResourceLimits ? "1" : "0"},
            new KeyValue {Key = "bandwidth_limit", Value = bandwidthLimit.ToString()},
            new KeyValue {Key = "diskspace_limit", Value = diskSpaceLimit.ToString()},
            new KeyValue {Key = "enable_overselling", Value = enableOverSelling ? "1" : "0"},
            new KeyValue {Key = "enable_overselling_bandwidth", Value = enableOverSellingBandwidth ? "1" : "0"},
            new KeyValue {Key = "enable_overselling_diskspace", Value = enableOverSellingDiskSpace ? "1" : "0"},
            new KeyValue {Key = "enable_package_limits", Value = enablePackageLimits ? "1" : "0"},
            new KeyValue {Key = "enable_package_limit_numbers", Value = enablePackageLimitNumbers ? "1" : "0"},
        });
        }

        public string SuspendAccount(string userName)
        {
            KeyValue v1;
            v1.Key = "user";
            v1.Value = userName;

            return XMLAPIQuery("suspendacct", new List<KeyValue> { v1 });
        }

        public string SuspendAccount(string userName, string reason)
        {
            KeyValue v1, v2;
            v1.Key = "user";
            v1.Value = userName;
            v2.Key = "reason ";
            v2.Value = reason;

            return XMLAPIQuery("suspendacct", new List<KeyValue> { v1, v2 });
        }

        public string UnSuspendAccount(string userName)
        {
            KeyValue v1;
            v1.Key = "user";
            v1.Value = userName;

            return XMLAPIQuery("unsuspendacct", new List<KeyValue> { v1 });
        }

        public string SuspendReseller(string userName)
        {
            KeyValue v1;
            v1.Key = "user";
            v1.Value = userName;

            return XMLAPIQuery("suspendreseller", new List<KeyValue> { v1 });
        }

        public string SuspendReseller(string userName, string reason)
        {
            KeyValue v1, v2;
            v1.Key = "user";
            v1.Value = userName;
            v2.Key = "reason ";
            v2.Value = reason;

            return XMLAPIQuery("suspendreseller", new List<KeyValue> { v1, v2 });
        }

        public string UnSuspendReseller(string userName)
        {
            KeyValue v1;
            v1.Key = "user";
            v1.Value = userName;

            return XMLAPIQuery("unsuspendreseller", new List<KeyValue> { v1 });
        }

        public string GetAccountSummary(string userName)
        {
            KeyValue v1;
            v1.Key = "user";
            v1.Value = userName;

            return XMLAPIQuery("accountsummary", new List<KeyValue> { v1 });
        }

        public string ListPopsSingle(string userName)
        {
            return API2Query(userName, "Email", "listpopssingle", new List<KeyValue>());
        }

        public string ListPops(string userName, string regex)
        {
            KeyValue v1;
            v1.Key = "regex";
            v1.Value = regex;

            return API2Query(userName, "Email", "listpops", new List<KeyValue> { v1 });
        }

        public string ListPopsWithDisk(string userName, string domain, bool nearQuotaOnly, bool validate, string regex)
        {
            KeyValue v1, v2, v3, v4;
            v1.Key = "domain";
            v1.Value = domain;
            v2.Key = "nearquotaonly";
            v2.Value = nearQuotaOnly ? "1" : "0";
            v3.Key = "no_validate";
            v3.Value = validate ? "0" : "1";
            // assing '1' to this parameter will cause the function to only read data from your '.cpanel/email_accounts.yaml' file. This parameter is 'off' by default, causing the function to check the passwd file, quota files, etc. Theoretically, each of these files should contain identical values.
            v4.Key = "regex";
            v4.Value = "";

            return API2Query(userName, "Email", "listpopswithdisk", new List<KeyValue> { v1, v2, v3, v4 });
        }

        public string ListMailDomains(string userName, bool skipMain)
        {
            KeyValue v1;
            v1.Key = "skipmain";
            v1.Value = skipMain ? "1" : "0";

            return API2Query(userName, "Email", "listmaildomains", new List<KeyValue> { v1 });
        }

        public string ListForwards(string userName, string domain, string regex)
        {
            KeyValue v1, v2;
            v1.Key = "domain";
            v1.Value = domain;
            v2.Key = "regex";
            v2.Value = regex;

            return API2Query(userName, "Email", "listforwards", new List<KeyValue> { v1 });
        }

        public string FetchAutoResponder(string userName, string email)
        {
            KeyValue v1;
            v1.Key = "email";
            v1.Value = email;

            return API2Query(userName, "Email", "fetchautoresponder", new List<KeyValue> { v1 });
        }

        public string AddPackage(string name, string featureList, int diskSpace, bool dedicateIp, bool cgiAccess,
            bool frontpage, string defaultTheme, string language, int ftpAccount, int database, int mailAccount,
            int mailList, int subdomain, int parkedDomain, int addonDomain, bool hasShell, int bandwidth,
            int maxemailperhour, int maxdeferfailpercentage, bool digestauth)
        {
            List<KeyValue> list = new List<KeyValue>
        {
            new KeyValue {Key = "name", Value = name},
            new KeyValue {Key = "featurelist", Value = featureList},
            new KeyValue {Key = "quota", Value = diskSpace.ToString()},
            new KeyValue {Key = "ip", Value = dedicateIp ? "1" : "0"},
            new KeyValue {Key = "cgi", Value = cgiAccess ? "1" : "0"},
            new KeyValue {Key = "frontpage", Value = frontpage ? "1" : "0"},
            new KeyValue {Key = "cpmod", Value = defaultTheme},
            new KeyValue {Key = "language", Value = language},
            new KeyValue {Key = "maxftp", Value = ftpAccount.ToString()},
            new KeyValue {Key = "maxsql", Value = database.ToString()},
            new KeyValue {Key = "maxpop", Value = mailAccount.ToString()},
            new KeyValue {Key = "maxlists", Value = mailList.ToString()},
            new KeyValue {Key = "maxsub", Value = subdomain.ToString()},
            new KeyValue {Key = "maxpark", Value = parkedDomain.ToString()},
            new KeyValue {Key = "maxaddon", Value = addonDomain.ToString()},
            new KeyValue {Key = "hasshell", Value = hasShell.ToString()},
            new KeyValue {Key = "bwlimit", Value = bandwidth.ToString()},
            new KeyValue {Key = "MAX_EMAIL_PER_HOUR", Value = maxemailperhour.ToString()},
            new KeyValue {Key = "MAX_DEFER_FAIL_PERCENTAGE", Value = maxdeferfailpercentage.ToString()},
            new KeyValue {Key = "digestauth", Value = digestauth ? "1" : "0"}
        };

            return XMLAPIQuery("addpkg ", list);
        }

        public string EditPackage(string name, string featureList, int diskSpace, bool dedicateIp, bool cgiAccess,
            bool frontpage, string defaultTheme, string language, int ftpAccount, int database, int mailAccount,
            int mailList, int subdomain, int parkedDomain, int addonDomain, bool hasShell, int bandwidth,
            int maxemailperhour, int maxdeferfailpercentage, bool digestauth)
        {
            List<KeyValue> list = new List<KeyValue>
        {
            new KeyValue {Key = "name", Value = name},
            new KeyValue {Key = "featurelist", Value = featureList},
            new KeyValue {Key = "quota", Value = diskSpace.ToString()},
            new KeyValue {Key = "ip", Value = dedicateIp ? "1" : "0"},
            new KeyValue {Key = "cgi", Value = cgiAccess ? "1" : "0"},
            new KeyValue {Key = "frontpage", Value = frontpage ? "1" : "0"},
            new KeyValue {Key = "cpmod", Value = defaultTheme},
            new KeyValue {Key = "language", Value = language},
            new KeyValue {Key = "maxftp", Value = ftpAccount.ToString()},
            new KeyValue {Key = "maxsql", Value = database.ToString()},
            new KeyValue {Key = "maxpop", Value = mailAccount.ToString()},
            new KeyValue {Key = "maxlists", Value = mailList.ToString()},
            new KeyValue {Key = "maxsub", Value = subdomain.ToString()},
            new KeyValue {Key = "maxpark", Value = parkedDomain.ToString()},
            new KeyValue {Key = "maxaddon", Value = addonDomain.ToString()},
            new KeyValue {Key = "hasshell", Value = hasShell.ToString()},
            new KeyValue {Key = "bwlimit", Value = bandwidth.ToString()},
            new KeyValue {Key = "MAX_EMAIL_PER_HOUR", Value = maxemailperhour.ToString()},
            new KeyValue {Key = "MAX_DEFER_FAIL_PERCENTAGE", Value = maxdeferfailpercentage.ToString()},
            new KeyValue {Key = "digestauth", Value = digestauth ? "1" : "0"}
        };

            return XMLAPIQuery("editpkg ", list);
        }

        public string DeletePackage(string name)
        {
            KeyValue v1;
            v1.Key = "pkg";
            v1.Value = name;

            return XMLAPIQuery("killpkg", new List<KeyValue> { v1 });
        }

        public string GetFeautreList()
        {
            return XMLAPIQuery("getfeaturelist");
        }

        public string ChangeAccountPackage(string userName, string packageName)
        {
            KeyValue v1, v2;
            v1.Key = "user";
            v1.Value = userName;
            v2.Key = "pkg";
            v2.Value = packageName;

            return XMLAPIQuery("changepackage", new List<KeyValue> { v1, v2 });
        }

        public string AddPackage(string name, string values)
        {
            values = "name=" + name + "&" + values;

            return XMLAPIQuery("addpkg", values);
        }

        public string EditPackage(string name, string values)
        {
            values = "name=" + name + "&" + values;

            return XMLAPIQuery("editpkg", values);
        }

        public string ListDNSZone(string domain)
        {
            KeyValue v1;
            v1.Key = "domain";
            v1.Value = domain;

            return XMLAPIQuery("dumpzone", new List<KeyValue> { v1 });
        }

        public string AddDNSZoneRecord(string domain, string name, string type, string value, int mxpriority)
        {
            /*         
                Common record types and associated input variables
                For your reference when assembling the zone record to add, here are a few common record types and their associated input variables.
                Record type	Required variables	                        Optional variables
                A	        zone, address, type	                        class, ttl
                MX	        zone, name, exchange, priority, type	    class, ttl
                CNAME	    zone, cname, type	                        class, ttl
                NS	        zone, nsdname, type	                        class, ttl
                PTR	        zone, name, ptrdname, type	                ttl
                SRV 	    priority, weight, port, target 	            domain, name, type, ttl
            */

            KeyValue v1, v2, v3, v4, v5;
            v1.Key = "domain";
            v1.Value = domain;
            v2.Key = "name";
            v2.Value = name;
            v3.Key = "type";
            v3.Value = type;

            if (type == "A")
            {
                v4.Key = "address";
                v4.Value = value;
            }
            else if (type == "MX")
            {
                v4.Key = "exchange";
                v4.Value = value;
            }
            else if (type == "CNAME")
            {
                v4.Key = "cname";
                v4.Value = value;
            }
            else if (type == "TXT")
            {
                v4.Key = "txtdata";
                v4.Value = value;
            }
            else
            {
                throw new Exception("type desteklenmiyor");
            }

            v5.Key = "priority";
            v5.Value = mxpriority.ToString();

            List<KeyValue> list = new List<KeyValue>();
            list.Add(v1);
            list.Add(v2);
            list.Add(v3);
            list.Add(v4);
            if (type == "MX")
            {
                if (mxpriority < 0)
                {
                    throw new Exception("mxpriority 0 dan kucuk olamaz");
                }
                if (mxpriority > 65535)
                {
                    throw new Exception("mxpriority 65535 dan buyuk olamaz");
                }

                list.Add(v5);
            }

            return XMLAPIQuery("addzonerecord", list);
        }

        public string AddDNSZoneRecord(string domain, string name, string type, string value, int mxpriority, int preference)
        {
            /*         
                Common record types and associated input variables
                For your reference when assembling the zone record to add, here are a few common record types and their associated input variables.
                Record type	Required variables	                        Optional variables
                A	        zone, address, type	                        class, ttl
                MX	        zone, name, exchange, priority, type	    class, ttl
                CNAME	    zone, cname, type	                        class, ttl
                NS	        zone, nsdname, type	                        class, ttl
                PTR	        zone, name, ptrdname, type	                ttl
                SRV 	    priority, weight, port, target 	            domain, name, type, ttl
            */

            KeyValue v1, v2, v3, v4, v5, v6, v7, v8;
            v1.Key = "domain";
            v1.Value = domain;
            v2.Key = "name";
            v2.Value = name;
            v3.Key = "type";
            v3.Value = type;

            if (type == "A")
            {
                v4.Key = "address";
                v4.Value = value;
            }
            else if (type == "MX")
            {
                v4.Key = "exchange";
                v4.Value = value;
            }
            else if (type == "CNAME")
            {
                v4.Key = "cname";
                v4.Value = value;
            }
            else if (type == "TXT")
            {
                v4.Key = "txtdata";
                v4.Value = value;
            }
            else
            {
                throw new Exception("type desteklenmiyor");
            }

            v5.Key = "priority";
            v5.Value = mxpriority.ToString();

            List<KeyValue> list = new List<KeyValue>();
            list.Add(v1);
            list.Add(v2);
            list.Add(v3);
            list.Add(v4);
            if (type == "MX")
            {
                if (mxpriority < 0)
                {
                    throw new Exception("mxpriority 0 dan kucuk olamaz");
                }
                if (mxpriority > 65535)
                {
                    throw new Exception("mxpriority 65535 dan buyuk olamaz");
                }

                //v6.Key = "oldexchange";
                //v6.Value = "mx1";

                //v7.Key = "oldpreference";
                //v7.Value = "0";

                v6.Key = "preference";
                v6.Value = preference.ToString();

                list.Add(v5);
                list.Add(v6);
                //list.Add(v7);
                //list.Add(v8);
            }

            return XMLAPIQuery("addzonerecord", list);
        }

        public string EditDNSZoneRecord(string domain, int lineNumber, string name, string type, string value,
            int mxpriority)
        {
            /*
             * Common record types and associated input variables
             * For your reference when assembling the edited zone record, here are 4 common record types and their associated input variables.
             * Record type	Required variables	                        Optional variables
             * A	        name, address, type	                        class, ttl
             * MX	        name, name, exchange, preference, type	    class, ttl
             * CNAME	    name, cname, type	                        class, ttl
             * NS	        name, nsdname, type	                        class, ttl
            */

            KeyValue v1, v2, v3, v4, v5, v6;
            v1.Key = "domain";
            v1.Value = domain;
            v2.Key = "Line";
            v2.Value = lineNumber.ToString();
            v3.Key = "name";
            v3.Value = name;
            v4.Key = "type";
            v4.Value = type;

            if (type == "A")
            {
                v5.Key = "address";
                v5.Value = value;
            }
            else if (type == "MX")
            {
                v5.Key = "exchange";
                v5.Value = value;
            }
            else if (type == "CNAME")
            {
                v5.Key = "cname";
                v5.Value = value;
            }
            else if (type == "TXT")
            {
                v5.Key = "txtdata";
                v5.Value = value;
            }
            else
            {
                throw new Exception("type desteklenmiyor");
            }

            v6.Key = "preference";
            v6.Value = mxpriority.ToString();

            List<KeyValue> list = new List<KeyValue>();
            list.Add(v1);
            list.Add(v2);
            list.Add(v3);
            list.Add(v4);
            list.Add(v5);
            if (type == "MX")
            {
                if (mxpriority < 0)
                {
                    throw new Exception("mxpriority 0 dan kucuk olamaz");
                }
                if (mxpriority > 65535)
                {
                    throw new Exception("mxpriority 65535 dan buyuk olamaz");
                }

                list.Add(v6);
            }

            return XMLAPIQuery("editzonerecord", list);
        }

        public string GetDNSZoneRecord(string domain, int lineNumber)
        {
            KeyValue v1, v2;
            v1.Key = "domain";
            v1.Value = domain;
            v2.Key = "Line";
            v2.Value = lineNumber.ToString();

            return XMLAPIQuery("getzonerecord", new List<KeyValue> { v1, v2 });
        }

        public string RemoveDNSZoneRecord(string domain, int lineNumber)
        {
            KeyValue v1, v2;
            v1.Key = "zone";
            v1.Value = domain;
            v2.Key = "Line";
            v2.Value = lineNumber.ToString();

            return XMLAPIQuery("removezonerecord", new List<KeyValue> { v1, v2 });
        }

        public string SetSiteIp(string domain, string ipaddress)
        {
            KeyValue v1, v2;
            v1.Key = "domain";
            v1.Value = domain;
            v2.Key = "ip";
            v2.Value = ipaddress;

            return XMLAPIQuery("setsiteip", new List<KeyValue> { v1, v2 });
        }

        public string ChangeFtpPassword(string userName, string ftpUserName, string password)
        {
            KeyValue v1, v2;
            v1.Key = "user";
            v1.Value = ftpUserName;
            v2.Key = "passwd";
            v2.Value = password;

            return API1Query(userName, "Ftp", "passwdftp", new List<KeyValue> { v1, v2 });
        }

        public string ListDNSZones()
        {
            return XMLAPIQuery("listzones");
        }

        #region cPanel Licencing API Methods

        //public bool AddLicense(string ip, string groupid, string packageid, SoldPlan soldPlan, out string msg, out string xml, out string licenseid)
        //{
        //    DataTable dt = new ApiBLL().SelectByID((int)Enums.Api.cPanel);

        //    KeyValue v1, v2, v3, v4;

        //    v1.Key = "ip";
        //    v1.Value = ip;

        //    v2.Key = dt.Rows[0]["ApiUsername"].ToString();
        //    v2.Value = dt.Rows[0]["ApiPassword"].ToString();

        //    //1 ay -> 11921
        //    //1 yıl -> 1861

        //    v3.Key = "packageid";
        //    v3.Value = packageid;

        //    v4.Key = "groupid";
        //    v4.Value = groupid;

        //    List<KeyValue> vars2 = new List<KeyValue>(4);

        //    vars2.Add(v1);
        //    vars2.Add(v2);
        //    vars2.Add(v3);
        //    vars2.Add(v4);

        //    string _xml = XMLAPIQuery2("http://manage2.cpanel.net/XMLlicenseAdd.cgi", vars2);
        //    xml = _xml;

        //    StringReader theReader = new StringReader(_xml);
        //    DataSet ds = new DataSet();
        //    ds.ReadXml(theReader);

        //    if (ds.Tables[0].Rows[0]["status"].ToString() != "0")
        //        licenseid = ds.Tables[0].Rows[0]["licenseid"].ToString();
        //    else
        //        licenseid = "0";

        //    msg = ds.Tables[0].Rows[0]["reason"].ToString();

        //    return ds.Tables[0].Rows[0]["status"].ToString() != "0";

        //    //<XMLlicenseAdd licenseid="25583973" monthly_price="11.00" price="0.00" promoinfo="" reason="Activated MARKUM-INTERNAL-VPS license 25583973 on 178.210.170.17 in the 'MARKUM Bilisim Teknolojileri Ltd. Sti.' group." status="1" yearly="0" />

        //}

        //public bool CancelLicense(string licenseid, out string msg)
        //{
        //    DataTable dt = new ApiBLL().SelectByID((int)Enums.Api.cPanel);

        //    KeyValue v1, v2, v3, v4;

        //    v1.Key = dt.Rows[0]["ApiUsername"].ToString();
        //    v1.Value = dt.Rows[0]["ApiPassword"].ToString();

        //    v2.Key = "liscid";
        //    v2.Value = licenseid;

        //    v3.Key = "reason";
        //    v3.Value = "Other reason";

        //    v4.Key = "expcode";
        //    v4.Value = "chargeback";

        //    List<KeyValue> vars2 = new List<KeyValue>(4);

        //    vars2.Add(v1);
        //    vars2.Add(v2);
        //    vars2.Add(v3);
        //    vars2.Add(v4);

        //    string xml = XMLAPIQuery2("http://manage2.cpanel.net/XMLlicenseExpire.cgi", vars2);

        //    StringReader theReader = new StringReader(xml);
        //    DataSet ds = new DataSet();
        //    ds.ReadXml(theReader);

        //    msg = ds.Tables[0].Rows[0]["reason"].ToString();

        //    return ds.Tables[0].Rows[0]["status"].ToString() != "0";

        //    //<XMLlicenseExpire licenseid="25583973" reason="OK" result="Expired MARKUM-INTERNAL-VPS license 25583973 in the 'MARKUM Bilisim Teknolojileri Ltd. Sti.' group on 178.210.170.17 for reason: Customer reversed charged - Medium Security Risk: Other reason." status="1" />

        //}

        //public bool ChanceLicenseIP(string licenseid, string newip, out string msg)
        //{
        //    DataTable dt = new ApiBLL().SelectByID((int)Enums.Api.cPanel);

        //    KeyValue v1, v2, v3;

        //    v1.Key = dt.Rows[0]["ApiUsername"].ToString();
        //    v1.Value = dt.Rows[0]["ApiPassword"].ToString();

        //    v2.Key = "oldip";
        //    v2.Value = "178.210.170.18";

        //    v3.Key = "newip";
        //    v3.Value = newip;

        //    List<KeyValue> vars2 = new List<KeyValue>(3);

        //    vars2.Add(v1);
        //    vars2.Add(v2);
        //    vars2.Add(v3);

        //    string xml = XMLAPIQuery2("http://manage2.cpanel.net/XMLtransfer.cgi", vars2);

        //    StringReader theReader = new StringReader(xml);
        //    DataSet ds = new DataSet();
        //    ds.ReadXml(theReader);

        //    msg = ds.Tables[0].Rows[0]["reason"].ToString();

        //    return ds.Tables[0].Rows[0]["status"].ToString() != "0";
        //    //<XMLtransfer newip="178.210.170.19" oldip="178.210.170.18" reason="Transferred MARKUM-INTERNAL-VPS license 25600357 in the 'MARKUM Bilisim Teknolojileri Ltd. Sti.' group on 178.210.170.18 to 178.210.170.19." status="1" />

        //}

        //public bool ReactivateLicense(string licenseid, out string msg)
        //{
        //    DataTable dt = new ApiBLL().SelectByID((int)Enums.Api.cPanel);

        //    KeyValue v1, v2;

        //    v1.Key = dt.Rows[0]["ApiUsername"].ToString();
        //    v1.Value = dt.Rows[0]["ApiPassword"].ToString();

        //    v2.Key = "liscid";
        //    v2.Value = licenseid;

        //    List<KeyValue> vars2 = new List<KeyValue>(2);

        //    vars2.Add(v1);
        //    vars2.Add(v2);

        //    string xml = XMLAPIQuery2("http://manage2.cpanel.net/XMLlicenseReActivate.cgi", vars2);

        //    StringReader theReader = new StringReader(xml);
        //    DataSet ds = new DataSet();
        //    ds.ReadXml(theReader);

        //    msg = ds.Tables[0].Rows[0]["reason"].ToString();

        //    return ds.Tables[0].Rows[0]["status"].ToString() != "0";
        //}

        //public DataTable ListLicenses()
        //{
        //    DataTable dt = new ApiBLL().SelectByID((int)Enums.Api.cPanel);

        //    KeyValue v1, v2;

        //    v1.Key = dt.Rows[0]["ApiUsername"].ToString();
        //    v1.Value = dt.Rows[0]["ApiPassword"].ToString();

        //    v2.Key = "expired";
        //    v2.Value = "0";

        //    List<KeyValue> vars2 = new List<KeyValue>(2);

        //    vars2.Add(v1);
        //    vars2.Add(v2);

        //    string xml = XMLAPIQuery2("http://manage2.cpanel.net/XMLlicenseInfo.cgi", vars2);

        //    StringReader theReader = new StringReader(xml);
        //    DataSet ds = new DataSet();
        //    ds.ReadXml(theReader);
        //    return ds.Tables[1];
        //}

        //public DataTable ListLicense(string ip)
        //{
        //    DataTable dt = new ApiBLL().SelectByID((int)Enums.Api.cPanel);

        //    KeyValue v1, v2, v3;

        //    v1.Key = dt.Rows[0]["ApiUsername"].ToString();
        //    v1.Value = dt.Rows[0]["ApiPassword"].ToString();

        //    v2.Key = "ip";
        //    v2.Value = ip;

        //    v3.Key = "all";
        //    v3.Value = "1";

        //    List<KeyValue> vars2 = new List<KeyValue>(3);

        //    vars2.Add(v1);
        //    vars2.Add(v2);
        //    vars2.Add(v3);

        //    string xml = XMLAPIQuery2("http://manage2.cpanel.net/XMLRawlookup.cgi", vars2);

        //    StringReader theReader = new StringReader(xml);
        //    DataSet ds = new DataSet();
        //    ds.ReadXml(theReader);
        //    return ds.Tables[0].Rows[0]["status"].ToString() == "0" ? null : ds.Tables[1];
        //}

        //public string GetLicenceID(string ip)
        //{
        //    DataTable dt = new ApiBLL().SelectByID((int)Enums.Api.cPanel);

        //    KeyValue v1, v2, v3;

        //    v1.Key = dt.Rows[0]["ApiUsername"].ToString();
        //    v1.Value = dt.Rows[0]["ApiPassword"].ToString();

        //    v2.Key = "ip";
        //    v2.Value = ip;

        //    v3.Key = "all";
        //    v3.Value = "1";

        //    List<KeyValue> vars2 = new List<KeyValue>(3);

        //    vars2.Add(v1);
        //    vars2.Add(v2);
        //    vars2.Add(v3);

        //    string xml = XMLAPIQuery2("http://manage2.cpanel.net/XMLlookup.cgi", vars2);

        //    StringReader theReader = new StringReader(xml);
        //    DataSet ds = new DataSet();
        //    ds.ReadXml(theReader);
        //    return ds.Tables[0].Rows[0]["status"].ToString() == "0" ? "0" : ds.Tables[0].Rows[0]["licenseid"].ToString();
        //}
        #endregion
    }

    public class CPanelXMLHelper
    {
        public static bool GetStatus(string xml, out string message)
        {
            if (xml == null || xml == "")
            {
                throw new Exception("status bulunamadı");
            }

            bool status;

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            // cpanelde bir işlem gerçekleştiren fonksiyonlar 
            // örneğin, kullanıcı oluşturma
            //
            // <name_of_XMLAPI_call>
            //      <result>
            //          <status></status>
            //          <statusmsg></statusmsg>
            //      </result>
            // </name_of_XML_API_call>

            XmlNode n = doc.SelectSingleNode("/*/result/status");
            if (n != null)
            {
                status = (n.InnerText == "1");

                XmlNode n2 = doc.SelectSingleNode("/*/result/statusmsg");
                if (n2 != null)
                    message = n2.InnerText;
                else
                    message = string.Empty;

                return status;
            }


            // bazı veri döndüren fonksiyonlar
            // örneğin, listaccts fonksiyonu
            //
            // <name_of_XMLAPI_call>
            //      <status></status>
            //      <statusmsg></statusmsg>
            // </name_of_XML_API_call>

            n = doc.SelectSingleNode("/*/status");
            if (n != null)
            {
                status = (n.InnerText == "1");

                XmlNode n2 = doc.SelectSingleNode("/*/statusmsg");
                if (n2 != null)
                    message = n2.InnerText;
                else
                    message = string.Empty;

                return status;
            }


            // örneğin şifre değiştirme (passwd) fonksiyonu
            //
            // <passwd>
            //      <passwd>
            //          <status></status>
            //          <statusmsg></statusmsg>
            //      </passwd>
            // </passwd>

            n = doc.SelectSingleNode("/*/*/status");
            if (n != null)
            {
                status = (n.InnerText == "1");

                XmlNode n2 = doc.SelectSingleNode("/*/*/statusmsg");
                if (n2 != null)
                    message = n2.InnerText;
                else
                    message = string.Empty;

                return status;
            }

            throw new Exception("status bulunamadı");
        }

        public static string GetItemDetail(string xml, string xpath)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            XmlNode n = doc.SelectSingleNode(xpath);

            if (n == null)
                return null;

            return n.InnerText;
        }

        public static string GenerateStatusXML(bool status, string message)
        {
            // <custom>
            //      <result>
            //          <status>1</status>
            //          <statusmsg>OK</statusmsg>
            //      </result>
            // </custom>

            string xml = "<custom><result><status>" + (status ? "1" : "0") + "</status><statusmsg>" + message +
                         "</statusmsg></result></custom>";

            return xml;
        }
    }
}