using System;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Web.Services.Protocols;
using MEAddressMap = MailEnable.Administration.AddressMap;
using MEDirectory = MailEnable.Administration.Directory;
using MEDomain = MailEnable.Administration.Domain;
using MEGroup = MailEnable.Administration.Group;
using MEGroupMember = MailEnable.Administration.GroupMember;
using MEList = MailEnable.Administration.List;
using MEListMember = MailEnable.Administration.ListMember;
using MELogin = MailEnable.Administration.Login;
using MEMailbox = MailEnable.Administration.Mailbox;
using MEPostOffice = MailEnable.Administration.Postoffice;
using MEService1 = MailEnable.Administration.Service;
//using MESystemOptions = Markum.Cloud.Libraries.SystemOptions;



namespace Markum.Cloud.Libraries.Mail.Net

{
    public class MEServices
    {
        private MEConnection _connection;
        private MEAddressMap _addressMap;
        private MEDomain _domain;
        private MEDirectory _directory;
        private MEGroup _group;
        private MEGroupMember _groupMember;
        private MEList _list;
        private MEListMember _listMember;
        private MELogin _login;
        private MEMailbox _mailbox;
        private MEPostOffice _postOffice;
        //private MESystemOptions _systemOptions;
        private MEService1 _service1;

        public MEConnection Connection
        {
            get { return _connection; }
            set { _connection = value; }
        }

        public MEAddressMap AddressMap
        {
            get
            {
                if (_addressMap == null)
                    _addressMap = new MEAddressMap();

                PrepareConnection(_addressMap, "AddressMap.asmx");

                return _addressMap;
            }
        }

        public MEDomain Domain
        {
            get
            {
                if (_domain == null)
                    _domain = new MEDomain();

                PrepareConnection(_domain, "Domain.asmx");

                return _domain;
            }
        }

        public MEDirectory Directory
        {
            get
            {
                if (_directory == null)
                    _directory = new MEDirectory();

                PrepareConnection(_directory, "Directory.asmx");

                return _directory;
            }
        }

        public MEGroup Group
        {
            get
            {
                if (_group == null)
                    _group = new MEGroup();

                PrepareConnection(_group, "Group.asmx");

                return _group;
            }
        }

        public MEGroupMember GroupMember
        {
            get
            {
                if (_groupMember == null)
                    _groupMember = new MEGroupMember();

                PrepareConnection(_groupMember, "GroupMember.asmx");

                return _groupMember;
            }
        }

        public MEList List
        {
            get
            {
                if (_list == null)
                    _list = new MEList();

                PrepareConnection(_list, "List.asmx");

                return _list;
            }
        }

        public MEListMember ListMember
        {
            get
            {
                if (_listMember == null)
                    _listMember = new MEListMember();

                PrepareConnection(_listMember, "ListMember.asmx");

                return _listMember;
            }
        }

        public MELogin Login
        {
            get
            {
                if (_login == null)
                    _login = new MELogin();

                PrepareConnection(_login, "Login.asmx");

                return _login;
            }
        }

        public MEMailbox Mailbox
        {
            get
            {
                if (_mailbox == null)
                    _mailbox = new MEMailbox();

                PrepareConnection(_mailbox, "Mailbox.asmx");

                return _mailbox;
            }
        }

        public MEPostOffice Postoffice
        {
            get
            {
                if (_postOffice == null)
                    _postOffice = new MEPostOffice();

                PrepareConnection(_postOffice, "PostOffice.asmx");

                return _postOffice;
            }
        }

        //public MESystemOptions SystemOptions
        //{
        //    get
        //    {
        //        if (_systemOptions == null)
        //            _systemOptions = new MESystemOptions();

        //        PrepareConnection(_systemOptions, "Systemoptions.asmx");

        //        return _systemOptions;
        //    }
        //}

        public MEService1 Service1
        {
            get
            {
                if (_service1 == null)
                    _service1 = new MEService1();

                
                PrepareConnection(_service1, "Service1.asmx");
                return _service1;
            }
        }

        public MEServices()
        {
        }

        public MEServices(MEConnection connection)
        {
            _connection = connection;
        }

        private void PrepareConnection(SoapHttpClientProtocol service, string pageName)
        { 
            service.Url = _connection.Url + "/" + pageName;

            if (!string.IsNullOrEmpty(_connection.Username) && !string.IsNullOrEmpty(_connection.Password))
            {
                NetworkCredential credential = new NetworkCredential(_connection.Username, _connection.Password);
                service.Credentials = credential;
            }

            service.Timeout = _connection.Timeout;

            // HACK: The underlying connection was closed: Could not establish trust relationship for the SSL/TLS secure channel
            ServicePointManager.ServerCertificateValidationCallback = delegate(object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
        }

        private void ControlConnection()
        {
            if (_connection == null)
            {
                throw new InvalidOperationException("bağlantı bilgisi yok");
            }
            if (_connection.Url == null || _connection.Url == "")
            {
                throw new InvalidOperationException("bağlantı url yok");
            }
            if (!IsValidUrl(_connection.Url))
            {
                throw new InvalidOperationException("bağlantı url geçerli değil");
            }
        }

        private bool IsValidUrl(string url)
        {
            Uri u;
            if (Uri.TryCreate(url, UriKind.Absolute, out u) && (u.Scheme == "http" || u.Scheme == "https"))
            {
                return true;
            }
            return false;
        }

        //~MEServices()
        //{
        //    if (_addressMap != null) _addressMap.Dispose();
        //    if (_directory != null) _directory.Dispose();
        //    if (_domain != null) _domain.Dispose();
        //    if (_group != null) _group.Dispose();
        //    if (_groupMember != null) _groupMember.Dispose();
        //    if (_list != null) _list.Dispose();
        //    if (_listMember != null) _listMember.Dispose();
        //    if (_login != null) _login.Dispose();
        //    if (_mailbox != null) _mailbox.Dispose();
        //    if (_postOffice != null) _postOffice.Dispose();
        //    if (_systemOptions != null) _systemOptions.Dispose();
        //}
    }
}