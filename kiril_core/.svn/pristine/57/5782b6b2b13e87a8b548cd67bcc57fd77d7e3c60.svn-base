using System;
using System.Data;
using System.Linq;
//using MailEnable.Net;
using Service1 = MailEnable.Administration.Service;
using AddressMap = MailEnable.Administration.AddressMap;
using Directory = MailEnable.Administration.Directory;
using Domain = MailEnable.Administration.Domain;
using Group = MailEnable.Administration.Group;
using GroupMember = MailEnable.Administration.GroupMember;
using List = MailEnable.Administration.List;
using ListMember = MailEnable.Administration.ListMember;
using Login = MailEnable.Administration.Login;
using Mailbox = MailEnable.Administration.Mailbox;
using Postoffice = Markum.Cloud.Libraries.PostOffice.Postoffice;
using SystemOpts = MailEnable.Administration.SystemOption;
using Markum.Cloud.Libraries.Service1;
//using MessageCommand = MailEnable.Net.Service1.MessageCommand;


namespace Markum.Cloud.Libraries.Mail
{
    public class MailEnableAdmin
    {
        public AddressMap.AddressMapSoapClient _addrMapClient = null;
        public PostOffice.PostOfficeSoapClient _poClient = null;
        public Service1.Service1SoapClient _ser1Client = null;
        public Mailbox.MailboxSoapClient _mbClient = null;
        //Directory.DirectorySoapClient _dirClient = null;
        public Domain.DomainSoapClient _domClient = null;
        //Group.GroupSoapClient _grpClient = null;
        public GroupMember.GroupMemberSoapClient _grpMemClient = null;
        //List.ListSoapClient _listClient = null;
        //ListMember.ListMemberSoapClient _listMemClient = null;
        public Login.LoginSoapClient _loginClient = null;
        public SystemOptions.SystemOptionsSoapClient _sysOp = null;

        public MailEnableAdmin()
        {
            try
            {
                _addrMapClient = new AddressMap.AddressMapSoapClient();
                _poClient = new PostOffice.PostOfficeSoapClient();
                _ser1Client = new Service1.Service1SoapClient();
                _mbClient = new Mailbox.MailboxSoapClient();
                //_dirClient = new Directory.DirectorySoapClient();
                _domClient = new Domain.DomainSoapClient();
                //_grpClient = new Group.GroupSoapClient();
                _grpMemClient = new GroupMember.GroupMemberSoapClient();
                //_listClient = new List.ListSoapClient();
                //_listMemClient = new ListMember.ListMemberSoapClient();
                _loginClient = new Login.LoginSoapClient();
                _sysOp = new SystemOptions.SystemOptionsSoapClient();
            }
            catch(Exception ex)
            {
                string message = ex.Message;
            }
        }

        #region PostOffice

        public int AddPostOffice(string postOffice)
        {
            long l = _poClient.AddPostoffice(postOffice, postOffice, Status.ENABLED);

            if (l == MEResult.ERROR)
                return ERRORCODES.POSTOFFICE_NOT_ADDED;

            return ERRORCODES.SUCCESS;
        }

        public int AddPostOffice(string postOffice, string domain, string postMasterPassword)
        {
            int r = AddPostOffice(postOffice);

            if (r != ERRORCODES.SUCCESS)
                return ERRORCODES.POSTOFFICE_NOT_ADDED;

            r = AddDomain(postOffice, domain);

            if (r != ERRORCODES.SUCCESS)
                return ERRORCODES.DOMAIN_NOT_ADDED;

            r = AddMailbox(postOffice, "postmaster", postMasterPassword, Rights.ADMIN, -1);

            if (r != ERRORCODES.SUCCESS)
                return ERRORCODES.POSTMASTER_NOT_ADDED;

            return ERRORCODES.SUCCESS;
        }
        public int AddPostOffice(string postOffice, string domain, string postMasterPassword, string postmasterRight, int postmasterLimit)
        {
            int r = AddPostOffice(postOffice);

            if (r != ERRORCODES.SUCCESS)
                return ERRORCODES.POSTOFFICE_NOT_ADDED;

            r = AddDomain(postOffice, domain);

            if (r != ERRORCODES.SUCCESS)
                return ERRORCODES.DOMAIN_NOT_ADDED;

            r = AddMailbox(postOffice, "postmaster", postMasterPassword, postmasterRight, postmasterLimit);

            if (r != ERRORCODES.SUCCESS)
                return ERRORCODES.POSTMASTER_NOT_ADDED;

            return ERRORCODES.SUCCESS;
        }

        public int UpdatePostOfficeStatus(string postOffice, long newStatus)
        {
            if (postOffice == null)
            {
                throw new ArgumentNullException("postOffice");
            }
            if (postOffice == "")
            {
                throw new ArgumentException("postOffice");
            }

            Postoffice p = GetPostOffice(postOffice);

            if (p == null)
                return ERRORCODES.POSTOFFICE_NOT_EXISTS;

            long l = _poClient.EditPostoffice(p.Account, p.Name, p.Name, newStatus);

            if (l == MEResult.ERROR)
                return ERRORCODES.POSTOFFICE_NOT_UPDATED;

            return ERRORCODES.SUCCESS;
        }

        public int DeletePostOffice(string postOffice)
        {
            if (postOffice == null)
            {
                throw new ArgumentNullException("postOffice");
            }
            if (postOffice == "")
            {
                throw new ArgumentException("postOffice");
            }

            long l = _ser1Client.RemoveLogin(postOffice, "");
            // login yoksa MEResult.ERROR döndürüyor
            //if (l == MEResult.ERROR)
            //    return ERRORCODES.LOGIN_NOT_DELETED;

            l = _mbClient.RemoveMailbox(postOffice, "");
            // mailbox yoksa MEResult.ERROR döndürüyor
            //if (l == MEResult.ERROR)
            //    return ERRORCODES.MAILBOX_NOT_DELETED;

            l = _addrMapClient.RemoveAddressMap(postOffice, "", "", "", Status.NOTSUPPLIED);
            // address map yoksa MEResult.ERROR döndürüyor             
            //if (l == MEResult.ERROR)
            //    return ERRORCODES.ADDRESS_MAP_NOT_DELETED;

            l = _domClient.RemoveDomain(postOffice, "");
            // domain yoksa MEResult.ERROR döndürüyor
            //if (l == MEResult.ERROR)
            //    return ERRORCODES.DOMAIN_NOT_DELETED;

            l = _poClient.RemovePostoffice(postOffice, postOffice);
            if (l == MEResult.ERROR)
                return ERRORCODES.POSTOFFICE_NOT_DELETED;

            return ERRORCODES.SUCCESS;
        }
        public Postoffice GetPostOffice(string postOffice)
        {
            Postoffice postoffice = null;
            long l = _poClient.GetPostofficeObjectProperties("", postOffice, ref postoffice);

            if (l != MEResult.SUCCESS)
                return null;

            return postoffice;
        }
        public Postoffice[] GetAllPostOffices()
        {
            return GetAllPostOffices(0L, 1000000L);
        }
        public Postoffice[] GetAllPostOffices(long top, long maxlength)
        {
            return GetPostOffices("", top, maxlength);
        }
        public Postoffice[] GetPostOffices(string name, long top, long maxlength)
        {
            Postoffice[] postoffices = new Postoffice[0];
            long l = _poClient.ListPostoffice(ref postoffices, name, name, top, maxlength);
            return postoffices;
        }
        public Service1.Postoffice[] GetPostOfficesService1(string name, long status, int pageNumber, int pageSize, out int totalNumber)
        {
            Service1.Postoffice[] postoffices = new Service1.Postoffice[0];
            long l = _ser1Client.ListPostoffice(ref postoffices, name, status, pageNumber, pageSize, out totalNumber);

            return postoffices;
        }
        public bool PostOfficeExists(string postOffice)
        {
            long l = _poClient.GetPostoffice(postOffice, postOffice);
            return (l == MEResult.SUCCESS);
        }

        #endregion

        #region Domain

        public int AddDomain(string postOffice, string domain)
        {
            long l = _domClient.AddDomain(postOffice, domain, Status.ENABLED, "", Status.NOTSUPPLIED);

            if (l == MEResult.ERROR)
                return ERRORCODES.DOMAIN_NOT_ADDED;

            return ERRORCODES.SUCCESS;
        }
        public Domain.Domain GetDomain(string postOffice, string domainName)
        {
            Domain.Domain domain = null;
            long l = _domClient.GetDomainObjectProperties(postOffice, domainName, ref domain);

            if (l != MEResult.SUCCESS)
                return null;

            return domain;
        }
        public Domain.Domain[] GetAllDomains(string postOffice)
        {
            return GetDomains(postOffice, "");
        }
        public Domain.Domain[] GetDomains(string postOffice, string domainName)
        {
            long top = 0L, maxlength = 1000000L;
            Domain.Domain[] domains = new Domain.Domain[0];

            long l = _domClient.ListDomain(ref domains,
                                                  postOffice,
                                                  domainName,
                                                  Status.NOTSUPPLIED,
                                                  "",
                                                  Status.NOTSUPPLIED,
                                                  "",
                                                  top,
                                                  maxlength);

            return domains;
        }
        public bool DomainExists(string postOffice, string domain)
        {
            long l = _domClient.GetDomain(postOffice, domain);
            return (l == MEResult.SUCCESS);
        }

        #endregion

        #region Mailbox

        public int AddMailbox(string postOffice, string mailboxName, string password, string rights, long limit)
        {
            int r = AddMailbox(postOffice, mailboxName, limit);

            if (r != ERRORCODES.SUCCESS)
                return ERRORCODES.MAILBOX_NOT_ADDED;

            r = AddLogin(postOffice, mailboxName, password, "", rights);

            if (r != ERRORCODES.SUCCESS)
                return ERRORCODES.LOGIN_NOT_ADDED;

            Domain.Domain[] domains = GetAllDomains(postOffice);
            foreach (var d in domains)
            {
                r = AddAddressMap(postOffice, d.DomainName, mailboxName);
                if (r != ERRORCODES.SUCCESS)
                    return ERRORCODES.ADDRESS_MAP_NOT_ADDED;
            }

            return ERRORCODES.SUCCESS;
        }
        public int AddMailbox(string postOffice, string mailboxName, long limit)
        {
            long l = _mbClient.AddMailbox(postOffice, mailboxName, Status.ENABLED, limit, MailboxRedirectionStatus.NOTSUPPLIED, "");

            if (l == MEResult.ERROR)
                return ERRORCODES.MAILBOX_NOT_ADDED;

            return ERRORCODES.SUCCESS;
        }
        public int AddMailbox(string postOffice, string mailboxName, long limit, long redirectStatus, string redirectAddress)
        {
            long l = _mbClient.AddMailbox(postOffice, mailboxName, Status.ENABLED, limit, redirectStatus, redirectAddress);

            if (l == MEResult.ERROR)
                return ERRORCODES.MAILBOX_NOT_ADDED;

            return ERRORCODES.SUCCESS;
        }
        public int AddMailbox(string postOffice, string domainName, string mailboxName, string password, string rights, long limit)
        {
            int r = AddMailbox(postOffice, mailboxName, limit);

            if (r != ERRORCODES.SUCCESS)
                return ERRORCODES.MAILBOX_NOT_ADDED;

            r = AddLogin(postOffice, mailboxName, password, "", rights);

            if (r != ERRORCODES.SUCCESS)
                return ERRORCODES.LOGIN_NOT_ADDED;

            r = AddAddressMap(postOffice, domainName, mailboxName);
            if (r != ERRORCODES.SUCCESS)
                return ERRORCODES.ADDRESS_MAP_NOT_ADDED;

            return ERRORCODES.SUCCESS;
        }
        public int AddMailbox(string postOffice, string domainName, string mailboxName, string password, string rights, long limit, long redirectStatus, string redirectAddress)
        {
            int r = AddMailbox(postOffice, mailboxName, limit, redirectStatus, redirectAddress);
            if (r != ERRORCODES.SUCCESS)
                return ERRORCODES.MAILBOX_NOT_ADDED;

            r = AddLogin(postOffice, mailboxName, password, "", rights);
            if (r != ERRORCODES.SUCCESS)
                return ERRORCODES.LOGIN_NOT_ADDED;

            r = AddAddressMap(postOffice, domainName, mailboxName);
            if (r != ERRORCODES.SUCCESS)
                return ERRORCODES.ADDRESS_MAP_NOT_ADDED;

            return ERRORCODES.SUCCESS;
        }
        public int UpdateMailbox(string postOffice, string mailboxName, string newMailboxName, long newStatus, long newSize, long newLimit, long newRedirectStatus, string newRedirectAddress)
        {
            if (postOffice == null)
            {
                throw new ArgumentNullException("postOffice");
            }
            if (postOffice == "")
            {
                throw new ArgumentException("postOffice");
            }
            if (mailboxName == null)
            {
                throw new ArgumentNullException("mailboxName");
            }
            if (mailboxName == "")
            {
                throw new ArgumentException("mailboxName");
            }
            if (newMailboxName == null)
            {
                throw new ArgumentNullException("newMailboxName");
            }
            if (newMailboxName == "")
            {
                throw new ArgumentException("newMailboxName");
            }

            int r = UpdateMailboxInternal(postOffice, mailboxName, newMailboxName, newStatus, newSize, newLimit, newRedirectStatus, newRedirectAddress);

            return r;
        }
        public int UpdateMailboxStatus(string postOffice, string mailboxName, long newStatus)
        {
            if (postOffice == null)
            {
                throw new ArgumentNullException("postOffice");
            }
            if (postOffice == "")
            {
                throw new ArgumentException("postOffice");
            }
            if (mailboxName == null)
            {
                throw new ArgumentNullException("mailboxName");
            }
            if (mailboxName == "")
            {
                throw new ArgumentException("mailboxName");
            }

            Mailbox.Mailbox mailbox = GetMailbox(postOffice, mailboxName);

            if (mailbox == null)
                return ERRORCODES.MAILBOX_NOT_EXISTS;

            int r = UpdateMailboxInternal(postOffice, mailboxName, mailboxName, newStatus, mailbox.Size, mailbox.Limit, mailbox.RedirectStatus, mailbox.RedirectAddress);

            return r;
        }
        public int UpdateMailboxStatus(string postOffice, string mailboxName, long newStatus, long loginStatus)
        {
            if (postOffice == null)
            {
                throw new ArgumentNullException("postOffice");
            }
            if (postOffice == "")
            {
                throw new ArgumentException("postOffice");
            }
            if (mailboxName == null)
            {
                throw new ArgumentNullException("mailboxName");
            }
            if (mailboxName == "")
            {
                throw new ArgumentException("mailboxName");
            }

            Mailbox.Mailbox mailbox = GetMailbox(postOffice, mailboxName);

            if (mailbox == null)
                return ERRORCODES.MAILBOX_NOT_EXISTS;

            int r = UpdateMailboxInternal(postOffice, mailboxName, mailboxName, newStatus, mailbox.Size, mailbox.Limit, mailbox.RedirectStatus, mailbox.RedirectAddress);

            if (r != ERRORCODES.SUCCESS)
                return r;

            r = UpdateLoginStatus(postOffice, mailboxName, loginStatus);

            return r;
        }
        public int UpdateMailboxLimit(string postOffice, string mailboxName, long newLimit)
        {
            if (postOffice == null)
            {
                throw new ArgumentNullException("postOffice");
            }
            if (postOffice == "")
            {
                throw new ArgumentException("postOffice");
            }
            if (mailboxName == null)
            {
                throw new ArgumentNullException("mailboxName");
            }
            if (mailboxName == "")
            {
                throw new ArgumentException("mailboxName");
            }

            Mailbox.Mailbox mailbox = GetMailbox(postOffice, mailboxName);

            if (mailbox == null)
                return ERRORCODES.MAILBOX_NOT_EXISTS;

            int r = UpdateMailboxInternal(postOffice, mailboxName, mailboxName, mailbox.Status, mailbox.Size, newLimit, mailbox.RedirectStatus, mailbox.RedirectAddress);

            return r;
        }
        public int DeleteMailbox(string postOffice, string mailboxName)
        {
            if (postOffice == null)
            {
                throw new ArgumentNullException("postOffice");
            }
            if (postOffice == "")
            {
                throw new ArgumentException("postOffice");
            }
            if (mailboxName == null)
            {
                throw new ArgumentNullException("mailboxName");
            }
            if (mailboxName == "")
            {
                throw new ArgumentException("mailboxName");
            }

            int r = DeleteMailboxInternal(postOffice, mailboxName);

            return r;
        }
        public Mailbox.Mailbox GetMailbox(string postoffice, string mailboxName)
        {
            Mailbox.Mailbox mailbox = null;
            long l = _mbClient.GetMailboxObjectProperties(postoffice, mailboxName, ref mailbox);

            if (l != MEResult.SUCCESS)
                return null;

            return mailbox;
        }
        public Mailbox.Mailbox[] GetMailboxes(string postoffice)
        {
            return GetMailboxes(postoffice, 0L, 1000000L);
        }
        public Mailbox.Mailbox[] GetMailboxes(string postoffice, long top, long maxlength)
        {
            Mailbox.Mailbox[] mailboxes = new Mailbox.Mailbox[0];
            long l = _mbClient.ListMailbox(ref mailboxes, postoffice, top, maxlength);
            return mailboxes;
        }
        public Service1.Mailbox[] GetMailboxesService1(string postoffice)
        {
            try
            {
                Service1.Mailbox[] mailboxes = new Service1.Mailbox[0];
                long l = _ser1Client.ListMailbox(ref mailboxes, postoffice, Status.NOTSUPPLIED, MailboxSizeWildCards.LastCalculatedSize, 0L, 9000000L);
                return mailboxes;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return null;
            }
        }

        public Service1.Mailbox[] GetMailboxesService1(string postoffice, string mailboxName, long status)
        {
            Service1.Mailbox[] mailboxes = new Service1.Mailbox[0];
            long l = _ser1Client.ListMailbox(ref mailboxes, postoffice, status, MailboxSizeWildCards.LastCalculatedSize, 0L, 1000000L);

            if (l == MEResult.ERROR)
                return mailboxes;

            var mailboxes2 = mailboxes.Where(m => m.MailboxName.Contains(mailboxName))
                                      .OrderBy(m => m.MailboxName);

            return mailboxes2.ToArray();
        }
        public bool MailboxExists(string postOffice, string mailboxName)
        {
            long l = _mbClient.GetMailbox(postOffice, mailboxName);
            return (l == MEResult.SUCCESS);
        }
        public int SaveMailboxAutoResponder(string postOffice, string mailboxName, bool status, string subject, string message)
        {
            // statüyü detailden önce set edince güncellemiyor
            long l = _mbClient.SetAutoResponderDetails(postOffice, mailboxName, subject, message);
            l = _mbClient.SetAutoResponderStatus(postOffice, mailboxName, Convert.ToInt64(status));
            return ERRORCODES.SUCCESS;
        }
        public bool GetMailboxAutoResponderStatus(string postOffice, string mailboxName)
        {
            long l = _mbClient.GetAutoResponderStatus(postOffice, mailboxName);
            return (l == -Status.ENABLED);
        }
        public string GetMailboxAutoResponderContents(string postOffice, string mailboxName)
        {
            return _mbClient.GetAutoResponderContents(postOffice, mailboxName);
        }
        public string GetMailboxAutoResponderSubject(string postOffice, string mailboxName)
        {
            return _mbClient.GetAutoResponderSubject(postOffice, mailboxName);
        }
        public int MailboxCount(string postOffice)
        {
            Mailbox.Mailbox[] mailboxes = GetMailboxes(postOffice);
            return mailboxes.Length;
        }

        private int UpdateMailboxInternal(string postOffice, string mailboxName, string newMailboxName, long newStatus, long newSize, long newLimit, long newRedirectStatus, string newRedirectAddress)
        {
            long l = _mbClient.EditMailbox(postOffice, mailboxName, newMailboxName, newStatus, newSize, newLimit, newRedirectStatus, newRedirectAddress);

            if (l == MEResult.ERROR)
                return ERRORCODES.MAILBOX_NOT_UPDATED;

            return ERRORCODES.SUCCESS;
        }
        private int DeleteMailboxInternal(string postOffice, string mailboxName)
        {
            string destination = MailEnableUtils.ToSFInternalAddress(postOffice, mailboxName);
            long l = _addrMapClient.RemoveAddressMap(postOffice, "", destination, "", Status.NOTSUPPLIED);
            // kayıtlı addressmap yoksa MEResult.ERROR döndürüyor
            //if (l == MEResult.ERROR)
            //    return ERRORCODES.ADDRESS_MAP_NOT_DELETED;

            string userName = MailEnableUtils.ToUserName(mailboxName, postOffice);
            l = _loginClient.RemoveLogin(postOffice, userName);
            // kayıtlı login yoksa MEResult.ERROR döndürüyor
            //if (l == MEResult.ERROR)
            //    return ERRORCODES.LOGIN_NOT_DELETED;

            l = _mbClient.RemoveMailbox(postOffice, mailboxName);

            if (l == MEResult.ERROR)
                return ERRORCODES.MAILBOX_NOT_DELETED;

            return ERRORCODES.SUCCESS;
        }

        #endregion

        #region Login

        public int AddLogin(string postOffice, string mailboxName, string password, string description, string rights)
        {
            string userName = MailEnableUtils.ToUserName(mailboxName, postOffice);
            long l = _loginClient.AddLogin(postOffice, userName, password, description, Status.ENABLED, rights);

            if (l == MEResult.ERROR)
                return ERRORCODES.LOGIN_NOT_ADDED;

            return ERRORCODES.SUCCESS;
        }
        public int UpdateLogin(string postOffice, string mailboxName, string newPostOffice, string newMailboxName, string newPassword, long newStatus, string newDescription, string newRights)
        {
            if (postOffice == null)
            {
                throw new ArgumentNullException("postOffice");
            }
            if (postOffice == "")
            {
                throw new ArgumentException("postOffice");
            }
            if (mailboxName == null)
            {
                throw new ArgumentNullException("mailboxName");
            }
            if (mailboxName == "")
            {
                throw new ArgumentException("mailboxName");
            }
            if (newPostOffice == null)
            {
                throw new ArgumentNullException("newPostOffice");
            }
            if (newPostOffice == "")
            {
                throw new ArgumentException("newPostOffice");
            }
            if (newMailboxName == null)
            {
                throw new ArgumentNullException("newMailboxName");
            }
            if (newMailboxName == "")
            {
                throw new ArgumentException("newMailboxName");
            }

            string userName = MailEnableUtils.ToUserName(mailboxName, postOffice);
            string newUserName = MailEnableUtils.ToUserName(newMailboxName, newPostOffice);
            long l = _loginClient.EditLogin(postOffice, userName, newPostOffice, newUserName, newPassword, newStatus, newDescription, newRights);

            if (l == MEResult.ERROR)
                return ERRORCODES.LOGIN_NOT_UPDATED;

            return ERRORCODES.SUCCESS;
        }
        public int UpdateLoginStatus(string postOffice, string mailboxName, long newStatus)
        {
            if (postOffice == null)
            {
                throw new ArgumentNullException("postOffice");
            }
            if (postOffice == "")
            {
                throw new ArgumentException("postOffice");
            }
            if (mailboxName == null)
            {
                throw new ArgumentNullException("mailboxName");
            }
            if (mailboxName == "")
            {
                throw new ArgumentException("mailboxName");
            }

            Login.Login login = GetLogin(postOffice, mailboxName);
            if (login == null)
                return ERRORCODES.LOGIN_NOT_EXISTS;

            int r = UpdateLogin(postOffice, mailboxName, postOffice, mailboxName, login.Password, newStatus, login.Description, login.Rights);

            return r;
        }
        public Login.Login GetLogin(string postOffice, string userName)
        {
            Login.Login login = null;
            long l = _loginClient.GetLoginObjectProperties(postOffice, userName, ref login);

            if (l != MEResult.SUCCESS)
                return null;

            return login;
        }
        public bool LoginExists(string postOffice, string userName)
        {
            long l = _loginClient.GetLogin(postOffice, userName);
            return (l == MEResult.SUCCESS);
        }
        public int ChangePassword(string postOffice, string mailboxName, string password)
        {
            if (postOffice == null)
            {
                throw new ArgumentNullException("postOffice");
            }
            if (postOffice == "")
            {
                throw new ArgumentException("postOffice");
            }
            if (mailboxName == null)
            {
                throw new ArgumentNullException("mailboxName");
            }
            if (mailboxName == "")
            {
                throw new ArgumentException("mailboxName");
            }

            Login.Login login = GetLogin(postOffice, mailboxName);

            if (login == null)
                return ERRORCODES.LOGIN_NOT_EXISTS;

            int r = UpdateLogin(postOffice, mailboxName, postOffice, mailboxName, password, login.Status, login.Description, login.Rights);

            return r;
        }
        public int UpdateLoginRights(string postOffice, string mailboxName, string newRights)
        {
            if (postOffice == null)
            {
                throw new ArgumentNullException("postOffice");
            }
            if (postOffice == "")
            {
                throw new ArgumentException("postOffice");
            }
            if (mailboxName == null)
            {
                throw new ArgumentNullException("mailboxName");
            }
            if (mailboxName == "")
            {
                throw new ArgumentException("mailboxName");
            }

            Login.Login login = GetLogin(postOffice, mailboxName);

            if (login == null)
                return ERRORCODES.LOGIN_NOT_EXISTS;

            if (login.Rights == newRights)
                return ERRORCODES.SUCCESS;

            int r = UpdateLogin(postOffice, mailboxName, postOffice, mailboxName, login.Password, login.Status, login.Description, newRights);

            return r;
        }

        #endregion

        #region AddressMap

        public int AddAddressMap(string postOffice, string domain, string mailboxName)
        {
            string destination = MailEnableUtils.ToSFInternalAddress(postOffice, mailboxName);
            string source = MailEnableUtils.ToSMTPInternalAddress(mailboxName, domain);
            long l = _addrMapClient.AddAddressMap(postOffice, source, destination, "", Status.ENABLED);

            if (l == MEResult.ERROR)
                return ERRORCODES.ADDRESS_MAP_NOT_ADDED;

            return ERRORCODES.SUCCESS;
        }
        public AddressMap.AddressMap[] GetAddressMaps(string postOffice, string mailboxName)
        {
            long top = 0L, maxLength = 1000000L;
            string destination = MailEnableUtils.ToSFInternalAddress(postOffice, mailboxName);
            AddressMap.AddressMap[] addressmaps = new AddressMap.AddressMap[0];
            long l = _addrMapClient.ListAddressMap(ref addressmaps, postOffice, "", destination, "", Status.NOTSUPPLIED, top, maxLength);
            return addressmaps;
        }
        public AddressMap.AddressMap GetAddressMap(string postOffice, string domain, string mailboxName)
        {
            string source = MailEnableUtils.ToSMTPInternalAddress(mailboxName, domain);
            string destination = MailEnableUtils.ToSFInternalAddress(postOffice, mailboxName);
            AddressMap.AddressMap addressmap = null;
            long l = _addrMapClient.GetAddressMapObjectProperties(postOffice, source, destination, "", Status.NOTSUPPLIED, ref addressmap);

            if (l != MEResult.SUCCESS)
                return null;

            return addressmap;
        }
        public bool AddressMapExists(string postOffice, string domain, string mailboxName)
        {
            string sourceAddress = MailEnableUtils.ToSMTPInternalAddress(mailboxName, domain);
            long l = _addrMapClient.GetAddressMap(postOffice, sourceAddress, "", -1);

            return (l == MEResult.SUCCESS);
        }

        public AddressMap.AddressMap GetAddressMap2(string postOffice, string source, string destination)
        {
            AddressMap.AddressMap addressmap = null;
            long l = _addrMapClient.GetAddressMapObjectProperties(postOffice, source, destination, "", Status.NOTSUPPLIED, ref addressmap);

            if (l != MEResult.SUCCESS)
                return null;

            return addressmap;
        }
        public int AddAddressMap2(string postOffice, string source, string destination)
        {
            long l = _addrMapClient.AddAddressMap(postOffice, source, destination, "", Status.ENABLED);

            if (l == MEResult.ERROR)
                return ERRORCODES.ADDRESS_MAP_NOT_ADDED;

            return ERRORCODES.SUCCESS;
        }
        public int UpdateAddressMap(string postOffice, string source, string destination, string newSource, string newDestination, long newStatus)
        {
            long l = _addrMapClient.EditAddressMap(postOffice, source, destination, "", Status.NOTSUPPLIED, postOffice, newSource, newDestination, "", newStatus);

            if (l == MEResult.ERROR)
                return ERRORCODES.ADDRESS_MAP_NOT_UPDATED;

            return ERRORCODES.SUCCESS;
        }
        public int DeleteAddressMap(string postOffice, string source, string destination)
        {
            long l = _addrMapClient.RemoveAddressMap(postOffice, source, destination, "", Status.NOTSUPPLIED);

            if (l == MEResult.ERROR)
                return ERRORCODES.ADDRESS_MAP_NOT_DELETED;

            return ERRORCODES.SUCCESS;
        }

        #endregion

        #region + + + Mail Group + + +

        //public void AddPostOfficeMailGroup(string postOffice, string groupName,long status)
        //{

        //    long l = MEServices.Group.AddGroup(postOffice, groupName, status);
        //    if (l == MEResult.ERROR)
        //        return ERRORCODES.;

        //    return ERRORCODES.SUCCESS;


        //}
        //public void GetPostOfficeMailGroup() { }
        //public void EditPostOfficeFromMailGroup() { }
        //public void RemovePostOfficeFromMailGroup() { }


        //public void AddMemberToMailGroup() { }
        //public void GetMembersFromMailGroup() { }
        //public void RemoveMemberFromMailGroup() { }
        //public void EditMemberFromMailGroup() { }




        #endregion

        #region SystemOptions

        public string GetSystemOption(string query, int scope, string valueName)
        {
            return _ser1Client.GetSystemOption(query, scope, valueName);
        }
        public int SetSystemOption(string query, long scope, string valueName, string value)
        {
            long l = _sysOp.SetOption(query, scope, valueName, value);

            if (l == MEResult.ERROR)
                return ERRORCODES.SYSTEM_OPTION_NOT_ADDED;

            return ERRORCODES.SUCCESS;
        }
        public PostOfficeOptions GetPostOfficeOption(string postOffice)
        {
            PostOfficeOptions option = new PostOfficeOptions();

            string value = GetSystemOption(postOffice, (int)SystemOptionScope.POSTOFFICE, PostOfficeOptions.WEBADMINENABLED);
            option.WebAdminEnabled = (value == "1");

            value = GetSystemOption(postOffice, (int)SystemOptionScope.POSTOFFICE, PostOfficeOptions.WEBADMINCANEDITMAILBOXES);
            option.WebAdminCanEditMailboxes = (value == "1");

            value = GetSystemOption(postOffice, (int)SystemOptionScope.POSTOFFICE, PostOfficeOptions.WEBADMINMAXMAILBOXES);
            option.WebAdminMaxMailboxes = (string.IsNullOrEmpty(value) ? 0 : int.Parse(value));

            value = GetSystemOption(postOffice, (int)SystemOptionScope.POSTOFFICE, PostOfficeOptions.WEBADMINDEFAULTMAILBOXSIZE);
            option.WebAdminDefaultMailboxSize = (string.IsNullOrEmpty(value) ? 0 : int.Parse(value));

            value = GetSystemOption(postOffice, (int)SystemOptionScope.POSTOFFICE, PostOfficeOptions.WEBADMINCANEDITMAILBOXSIZE);
            option.WebAdminCanEditMailboxSize = (value == "1");

            value = GetSystemOption(postOffice, (int)SystemOptionScope.POSTOFFICE, PostOfficeOptions.WEBADMINCANEDITLISTS);
            option.WebAdminCanEditLists = (value == "1");

            value = GetSystemOption(postOffice, (int)SystemOptionScope.POSTOFFICE, PostOfficeOptions.WEBADMINMAXLISTS);
            option.WebAdminMaxLists = (string.IsNullOrEmpty(value) ? 0 : int.Parse(value));

            value = GetSystemOption(postOffice, (int)SystemOptionScope.POSTOFFICE, PostOfficeOptions.WEBADMINMAXLISTMEMBERS);
            option.WebAdminMaxListMembers = (string.IsNullOrEmpty(value) ? 0 : int.Parse(value));

            value = GetSystemOption(postOffice, (int)SystemOptionScope.POSTOFFICE, PostOfficeOptions.SMTPINBOUNDMESSAGEUSAGERESTRICTIONENABLED);
            option.SMTPInboundMessageUsageRestrictionEnabled = (value == "1");

            value = GetSystemOption(postOffice, (int)SystemOptionScope.POSTOFFICE, PostOfficeOptions.SMTPINBOUNDMESSAGEUSAGERESTRICTION);
            option.SMTPInboundMessageUsageRestriction = (string.IsNullOrEmpty(value) ? 0 : int.Parse(value));

            return option;
        }
        public int SetPostOfficeOption(string postOffice, PostOfficeOptions option)
        {
            if (postOffice == null)
            {
                throw new ArgumentNullException("postOffice");
            }
            if (postOffice == "")
            {
                throw new ArgumentException("postOffice");
            }

            int r = SetSystemOption(postOffice, SystemOptionScope.POSTOFFICE, PostOfficeOptions.WEBADMINENABLED, option.WebAdminEnabled ? "1" : "0");
            r = SetSystemOption(postOffice, SystemOptionScope.POSTOFFICE, PostOfficeOptions.WEBADMINCANEDITMAILBOXES, option.WebAdminCanEditMailboxes ? "1" : "0");
            r = SetSystemOption(postOffice, SystemOptionScope.POSTOFFICE, PostOfficeOptions.WEBADMINMAXMAILBOXES, option.WebAdminMaxMailboxes.ToString());
            r = SetSystemOption(postOffice, SystemOptionScope.POSTOFFICE, PostOfficeOptions.WEBADMINDEFAULTMAILBOXSIZE, option.WebAdminDefaultMailboxSize.ToString());
            r = SetSystemOption(postOffice, SystemOptionScope.POSTOFFICE, PostOfficeOptions.WEBADMINCANEDITMAILBOXSIZE, option.WebAdminCanEditMailboxSize ? "1" : "0");
            r = SetSystemOption(postOffice, SystemOptionScope.POSTOFFICE, PostOfficeOptions.WEBADMINCANEDITLISTS, option.WebAdminCanEditLists ? "1" : "0");
            r = SetSystemOption(postOffice, SystemOptionScope.POSTOFFICE, PostOfficeOptions.WEBADMINMAXLISTS, option.WebAdminMaxLists.ToString());
            r = SetSystemOption(postOffice, SystemOptionScope.POSTOFFICE, PostOfficeOptions.WEBADMINMAXLISTMEMBERS, option.WebAdminMaxListMembers.ToString());
            r = SetSystemOption(postOffice, SystemOptionScope.POSTOFFICE, PostOfficeOptions.SMTPINBOUNDMESSAGEUSAGERESTRICTIONENABLED, option.SMTPInboundMessageUsageRestrictionEnabled ? "1" : "0");
            r = SetSystemOption(postOffice, SystemOptionScope.POSTOFFICE, PostOfficeOptions.SMTPINBOUNDMESSAGEUSAGERESTRICTION, option.SMTPInboundMessageUsageRestriction.ToString());

            return ERRORCODES.SUCCESS;
        }
        public MailboxOptions GetMailboxOption(string postOffice, string mailboxName)
        {
            MailboxOptions option = new MailboxOptions();

            string value = GetSystemOption(postOffice + "/" + mailboxName, (int)SystemOptionScope.MAILBOX, MailboxOptions.SMTPINBOUNDMESSAGEUSAGERESTRICTIONENABLED);
            option.SMTPInboundMessageUsageRestrictionEnabled = (value == "1");

            value = GetSystemOption(postOffice + "/" + mailboxName, (int)SystemOptionScope.MAILBOX, MailboxOptions.SMTPINBOUNDMESSAGEUSAGERESTRICTION);
            option.SMTPInboundMessageUsageRestriction = (string.IsNullOrEmpty(value) ? 0 : int.Parse(value));

            value = GetSystemOption(postOffice + "/" + mailboxName, (int)SystemOptionScope.MAILBOX, MailboxOptions.DISPLAYNAME);
            option.DisplayName = value;

            //value = GetSystemOption(postOffice + "/" + mailboxName, (int)SystemOptionScope.MAILBOX, MailboxOptions.AUTHFAILURECOUNT);
            //option.AuthFailureCount = value;

            return option;
        }
        public int SetMailboxOption(string postOffice, string mailboxName, MailboxOptions option)
        {
            if (postOffice == null)
            {
                throw new ArgumentNullException("postOffice");
            }
            if (postOffice == "")
            {
                throw new ArgumentException("postOffice");
            }
            if (mailboxName == null)
            {
                throw new ArgumentNullException("mailboxName");
            }
            if (mailboxName == "")
            {
                throw new ArgumentException("mailboxName");
            }

            int r = SetSystemOption(postOffice + "/" + mailboxName, SystemOptionScope.MAILBOX, MailboxOptions.SMTPINBOUNDMESSAGEUSAGERESTRICTIONENABLED, option.SMTPInboundMessageUsageRestrictionEnabled ? "1" : "0");
            r = SetSystemOption(postOffice + "/" + mailboxName, SystemOptionScope.MAILBOX, MailboxOptions.SMTPINBOUNDMESSAGEUSAGERESTRICTION, option.SMTPInboundMessageUsageRestriction.ToString());
            r = SetSystemOption(postOffice + "/" + mailboxName, SystemOptionScope.MAILBOX, MailboxOptions.DISPLAYNAME, option.DisplayName ?? "");
            //r = SetSystemOption(postOffice + "/" + mailboxName, SystemOptionScope.MAILBOX, MailboxOptions.AUTHFAILURECOUNT, option.AuthFailureCount ?? "");

            return ERRORCODES.SUCCESS;
        }

        #endregion

        #region Directory

        #endregion

        #region List

        #endregion

        #region Group

        #endregion

        #region POPRetrieval

        public int AddPOPRetrieval(string postoffice, string mailbox, string mailserver, long port, string username, string password)
        {
            int i = _ser1Client.POPRetrieval(postoffice, mailbox, mailserver, port, username, password);

            if (i != MEResult.SUCCESS)
                return ERRORCODES.POPRETRIEVAL_NOT_ADDED;

            return ERRORCODES.SUCCESS;
        }
        public bool POPRetrievalExists(string postoffice, string mailserver, long port, string username)
        {
            long l = _ser1Client.GetPOPRetriever(postoffice, mailserver, port, username);

            return (l == MEResult.SUCCESS);
        }

        #endregion

        #region MessageCommand

        public MessageCommand[] GetMessageCommands(string path)
        {
            return _ser1Client.GetMessageCommands(path);
        }
        public MessageCommand[] GetMessageCommandsBySender(string path, string sender)
        {
            return _ser1Client.GetMessageCommandsBySender(path, sender);
        }
        public MessageCommand[] GetMessageCommandsByRecipient(string path, string recipient)
        {
            return _ser1Client.GetMessageCommandsByRecipient(path, recipient);
        }
        public MessageCommand[] GetMessageCommandsByClientIP(string path, string clientip)
        {
            return _ser1Client.GetMessageCommandsByClientIP(path, clientip);
        }
        public void DeleteMessageCommandFiles(string path, string sender)
        {
            _ser1Client.DeleteMessageCommandFiles(path, sender);
        }

        public void DeleteMessageCommandFilesByRecipient(string path, string recipient)
        {
            _ser1Client.DeleteMessageCommandFilesByRecipient(path, recipient);
        }
        public void DeleteMessageCommandFilesByClientIP(string path, string clientip)
        {
            _ser1Client.DeleteMessageCommandFilesByClientIP(path, clientip);
        }

        #endregion

        #region Service

        public int GetWindowsServiceStatusID(string MailEnableServiceTypeName)
        {
            return _ser1Client.GetWindowsServiceStatusID(MailEnableServiceTypeName);
        }

        public void StartService(string MailEnableServiceTypeName)
        {
            _ser1Client.StartService(MailEnableServiceTypeName);
        }

        public void StopService(string MailEnableServiceTypeName)
        {
            _ser1Client.StopService(MailEnableServiceTypeName);
        }

        public void RestartService(string MailEnableServiceTypeName, int timeoutMilliseconds)
        {
            _ser1Client.RestartService(MailEnableServiceTypeName, timeoutMilliseconds);
        }

        public DataTable GetWindowsServiceStatus(DataTable MailEnableWinService)
        {
            MailEnableWinService.TableName = "Service";

            return _ser1Client.GetWindowsServiceStatus(MailEnableWinService);
        }

        #endregion
    }
}