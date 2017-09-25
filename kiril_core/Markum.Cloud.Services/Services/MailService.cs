using Markum.Cloud.Libraries.AddressMap;
using Markum.Cloud.Libraries.Domain;
using Markum.Cloud.Libraries.Login;
using Markum.Cloud.Libraries.Mail;
using Markum.Cloud.Libraries.Mailbox;
using Markum.Cloud.Libraries.PostOffice;
using Markum.Cloud.Libraries.Service1;
using Markum.Cloud.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markum.Cloud.Services.Services
{
    public class MailService : IMailService
    {

        private MailEnableAdmin _mailEnableAdmin = null;

        public MailService()
        {
            _mailEnableAdmin  = new MailEnableAdmin();
        }

        #region PostOffice
        public int AddPostOffice(string postOffice)
        {
            return _mailEnableAdmin.AddPostOffice(postOffice);
        }
        public int AddPostOffice(string postOffice, string domain, string postMasterPassword)
        {
            return _mailEnableAdmin.AddPostOffice(postOffice, domain, postMasterPassword);
        }
        public int AddPostOffice(string postOffice, string domain, string postMasterPassword, string postmasterRight, int postmasterLimit)
        {
            return _mailEnableAdmin.AddPostOffice(postOffice, domain, postMasterPassword, postmasterRight, postmasterLimit);
        }
        public int UpdatePostOfficeStatus(string postOffice, long newStatus)
        {
            return _mailEnableAdmin.UpdatePostOfficeStatus(postOffice, newStatus);
        }
        public int DeletePostOffice(string postOffice)
        {
            return _mailEnableAdmin.DeletePostOffice(postOffice);
        }
        public Libraries.PostOffice.Postoffice GetPostOffice(string postOffice)
        {
            return _mailEnableAdmin.GetPostOffice(postOffice);
        }
        public Libraries.PostOffice.Postoffice[] GetAllPostOffices()
        {
            return GetAllPostOffices(0L, 1000000L);
        }
        public Libraries.PostOffice.Postoffice[] GetAllPostOffices(long top, long maxlength)
        {
            return GetPostOffices("", top, maxlength);
        }
        public Libraries.PostOffice.Postoffice[] GetPostOffices(string name, long top, long maxlength)
        {
            return _mailEnableAdmin.GetPostOffices(name,top,maxlength);
        }
        public Libraries.Service1.Postoffice[] GetPostOfficesService1(string name, long status, int pageNumber, int pageSize, int totalNumber)
        {
            return _mailEnableAdmin.GetPostOfficesService1(name, status, pageNumber, pageSize, out totalNumber);
        }
        public bool PostOfficeExists(string postOffice)
        {
            return _mailEnableAdmin.PostOfficeExists(postOffice);
        }
        #endregion

        #region Domain

        public int AddDomain(string postOffice, string domain)
        {
            return _mailEnableAdmin.AddDomain(postOffice, domain);
        }
        public Domain GetDomain(string postOffice, string domainName)
        {
            return _mailEnableAdmin.GetDomain(postOffice, domainName);
        }
        public Domain[] GetAllDomains(string postOffice)
        {
            return _mailEnableAdmin.GetAllDomains(postOffice);
        }
        public Domain[] GetDomains(string postOffice, string domainName)
        {
            return _mailEnableAdmin.GetDomains(postOffice, domainName);
        }
        public bool DomainExists(string postOffice, string domain)
        {
            return _mailEnableAdmin.DomainExists(postOffice, domain);
        }

        #endregion

        #region Mailbox

        public int AddMailbox(string postOffice, string mailboxName, string password, string rights, long limit)
        {
            return _mailEnableAdmin.AddMailbox(postOffice, mailboxName, password, rights, limit);
        }
        public int AddMailbox(string postOffice, string mailboxName, long limit)
        {
            return _mailEnableAdmin.AddMailbox(postOffice, mailboxName, limit);
        }
        public int AddMailbox(string postOffice, string mailboxName, long limit, long redirectStatus, string redirectAddress)
        {
            return _mailEnableAdmin.AddMailbox(postOffice, mailboxName, limit, redirectStatus, redirectAddress);
        }
        public int AddMailbox(string postOffice, string domainName, string mailboxName, string password, string rights, long limit)
        {
            return _mailEnableAdmin.AddMailbox(postOffice, domainName, mailboxName, password, rights, limit);
        }
        public int AddMailbox(string postOffice, string domainName, string mailboxName, string password, string rights, long limit, long redirectStatus, string redirectAddress)
        {
            return _mailEnableAdmin.AddMailbox(postOffice, domainName, mailboxName, password, rights, limit, redirectStatus, redirectAddress);
        }
        public int UpdateMailbox(string postOffice, string mailboxName, string newMailboxName, long newStatus, long newSize, long newLimit, long newRedirectStatus, string newRedirectAddress)
        {
            return _mailEnableAdmin.UpdateMailbox(postOffice, mailboxName, newMailboxName, newStatus, newSize, newLimit, newRedirectStatus, newRedirectAddress);
        }
        public int UpdateMailboxStatus(string postOffice, string mailboxName, long newStatus)
        {
            return _mailEnableAdmin.UpdateMailboxStatus(postOffice, mailboxName, newStatus);
        }
        public int UpdateMailboxStatus(string postOffice, string mailboxName, long newStatus, long loginStatus)
        {
            return _mailEnableAdmin.UpdateMailboxStatus(postOffice, mailboxName, newStatus, loginStatus);
        }
        public int UpdateMailboxLimit(string postOffice, string mailboxName, long newLimit)
        {
            return _mailEnableAdmin.UpdateMailboxLimit(postOffice, mailboxName,newLimit);
        }
        public int DeleteMailbox(string postOffice, string mailboxName)
        {
            return _mailEnableAdmin.DeleteMailbox(postOffice, mailboxName);
        }
        public Libraries.Mailbox.Mailbox GetMailbox(string postoffice, string mailboxName)
        {
            return _mailEnableAdmin.GetMailbox(postoffice, mailboxName);
        }
        public Libraries.Mailbox.Mailbox[] GetMailboxes(string postoffice)
        {
            return _mailEnableAdmin.GetMailboxes(postoffice);
        }
        public Libraries.Mailbox.Mailbox[] GetMailboxes(string postoffice, long top, long maxlength)
        {
            return _mailEnableAdmin.GetMailboxes(postoffice,top,maxlength);
        }
        public Markum.Cloud.Libraries.Service1.Mailbox[] GetMailboxesService1(string postoffice)
        {
            return _mailEnableAdmin.GetMailboxesService1(postoffice);
        }
        public Markum.Cloud.Libraries.Service1.Mailbox[] GetMailboxesService1(string postoffice, string mailboxName, long status)
        {
            return _mailEnableAdmin.GetMailboxesService1(postoffice,mailboxName,status);
        }
        public bool MailboxExists(string postOffice, string mailboxName)
        {
            return _mailEnableAdmin.MailboxExists(postOffice, mailboxName);
        }
        public int SaveMailboxAutoResponder(string postOffice, string mailboxName, bool status, string subject, string message)
        {
            return _mailEnableAdmin.SaveMailboxAutoResponder(postOffice, mailboxName, status, subject, message);
        }
        public bool GetMailboxAutoResponderStatus(string postOffice, string mailboxName)
        {
            return _mailEnableAdmin.GetMailboxAutoResponderStatus(postOffice, mailboxName);
        }
        public string GetMailboxAutoResponderContents(string postOffice, string mailboxName)
        {
            return _mailEnableAdmin.GetMailboxAutoResponderContents(postOffice,mailboxName);
        }
        public string GetMailboxAutoResponderSubject(string postOffice, string mailboxName)
        {
            return _mailEnableAdmin.GetMailboxAutoResponderSubject(postOffice, mailboxName);
        }
        public int MailboxCount(string postOffice)
        {
            return _mailEnableAdmin.MailboxCount(postOffice);
        }

        #endregion

        #region Login

        public int AddLogin(string postOffice, string mailboxName, string password, string description, string rights)
        {
            return _mailEnableAdmin.AddLogin(postOffice,mailboxName,password,description,rights);
        }
        public int UpdateLogin(string postOffice, string mailboxName, string newPostOffice, string newMailboxName, string newPassword, long newStatus, string newDescription, string newRights)
        {
            return _mailEnableAdmin.UpdateLogin(postOffice,mailboxName,newPostOffice,newMailboxName,newPassword,newStatus,newDescription,newRights);
        }
        public int UpdateLoginStatus(string postOffice, string mailboxName, long newStatus)
        {
            return _mailEnableAdmin.UpdateLoginStatus(postOffice,mailboxName,newStatus);
        }
        public Login GetLogin(string postOffice, string userName)
        {
            return _mailEnableAdmin.GetLogin(postOffice,userName);
        }
        public bool LoginExists(string postOffice, string userName)
        {
            return _mailEnableAdmin.LoginExists(postOffice,userName);
        }
        public int ChangePassword(string postOffice, string mailboxName, string password)
        {
            return _mailEnableAdmin.ChangePassword(postOffice, mailboxName, password);
        }
        public int UpdateLoginRights(string postOffice, string mailboxName, string newRights)
        {
            return _mailEnableAdmin.UpdateLoginRights(postOffice, mailboxName, newRights);
        }

        #endregion

        #region AddressMap

        public int AddAddressMap(string postOffice, string domain, string mailboxName)
        {
            return _mailEnableAdmin.AddAddressMap(postOffice,domain,mailboxName);
        }
        public AddressMap[] GetAddressMaps(string postOffice, string mailboxName)
        {
            return _mailEnableAdmin.GetAddressMaps(postOffice, mailboxName);
        }
        public AddressMap GetAddressMap(string postOffice, string domain, string mailboxName)
        {
            return _mailEnableAdmin.GetAddressMap(postOffice,domain,mailboxName);
        }
        public bool AddressMapExists(string postOffice, string domain, string mailboxName)
        {
            return _mailEnableAdmin.AddressMapExists(postOffice,domain,mailboxName);
        }
        public AddressMap GetAddressMap2(string postOffice, string source, string destination)
        {
            return _mailEnableAdmin.GetAddressMap2(postOffice,source,destination);
        }
        public int AddAddressMap2(string postOffice, string source, string destination)
        {
            return _mailEnableAdmin.AddAddressMap2(postOffice,source,destination);
        }
        public int UpdateAddressMap(string postOffice, string source, string destination, string newSource, string newDestination, long newStatus)
        {
            return _mailEnableAdmin.UpdateAddressMap(postOffice,source,destination,newSource,newDestination,newStatus);
        }
        public int DeleteAddressMap(string postOffice, string source, string destination)
        {
            return _mailEnableAdmin.DeleteAddressMap(postOffice,source,destination);
        }
        #endregion

        #region SystemOptions
        public string GetSystemOption(string query, int scope, string valueName)
        {
            return _mailEnableAdmin.GetSystemOption(query,scope,valueName);
        }
        public int SetSystemOption(string query, long scope, string valueName, string value)
        {
            return _mailEnableAdmin.SetSystemOption(query,scope,valueName,value);
        }
        public PostOfficeOptions GetPostOfficeOption(string postOffice)
        {
            return _mailEnableAdmin.GetPostOfficeOption(postOffice);
        }
        public int SetPostOfficeOption(string postOffice, PostOfficeOptions option)
        {
            return _mailEnableAdmin.SetPostOfficeOption(postOffice,option);
        }
        public MailboxOptions GetMailboxOption(string postOffice, string mailboxName)
        {
            return _mailEnableAdmin.GetMailboxOption(postOffice, mailboxName);
        }
        public int SetMailboxOption(string postOffice, string mailboxName, MailboxOptions option)
        {
            return _mailEnableAdmin.SetMailboxOption(postOffice, mailboxName, option);
        }
        #endregion

        #region POPRetrieval
        public int AddPOPRetrieval(string postoffice, string mailbox, string mailserver, long port, string username, string password)
        {
            return _mailEnableAdmin.AddPOPRetrieval(postoffice,mailbox,mailserver,port,username,password);
        }
        public bool POPRetrievalExists(string postoffice, string mailserver, long port, string username)
        {
            return _mailEnableAdmin.POPRetrievalExists(postoffice,mailserver,port,username);
        }
        #endregion

        #region MessageCommand
        public MessageCommand[] GetMessageCommands(string path)
        {
            return _mailEnableAdmin.GetMessageCommands(path);
        }
        public MessageCommand[] GetMessageCommandsBySender(string path, string sender)
        {
            return _mailEnableAdmin.GetMessageCommandsBySender(path,sender);
        }
        public MessageCommand[] GetMessageCommandsByRecipient(string path, string recipient)
        {
            return _mailEnableAdmin.GetMessageCommandsByRecipient(path,recipient);
        }
        public MessageCommand[] GetMessageCommandsByClientIP(string path, string clientip)
        {
            return _mailEnableAdmin.GetMessageCommandsByClientIP(path,clientip);
        }
        public void DeleteMessageCommandFiles(string path, string sender)
        {
            _mailEnableAdmin.DeleteMessageCommandFiles(path,sender);
        }

        public void DeleteMessageCommandFilesByRecipient(string path, string recipient)
        {
            _mailEnableAdmin.DeleteMessageCommandFilesByRecipient(path,recipient);
        }
        public void DeleteMessageCommandFilesByClientIP(string path, string clientip)
        {
            _mailEnableAdmin.DeleteMessageCommandFilesByClientIP(path,clientip);
        }
        #endregion

        #region Service
        public int GetWindowsServiceStatusID(string MailEnableServiceTypeName)
        {
            return _mailEnableAdmin.GetWindowsServiceStatusID(MailEnableServiceTypeName);
        }
        public void StartService(string MailEnableServiceTypeName)
        {
            _mailEnableAdmin.StartService(MailEnableServiceTypeName);
        }
        public void StopService(string MailEnableServiceTypeName)
        {
            _mailEnableAdmin.StopService(MailEnableServiceTypeName);
        }
        public void RestartService(string MailEnableServiceTypeName, int timeoutMilliseconds)
        {
            _mailEnableAdmin.RestartService(MailEnableServiceTypeName,timeoutMilliseconds);
        }
        public DataTable GetWindowsServiceStatus(DataTable MailEnableWinService)
        {
            return _mailEnableAdmin.GetWindowsServiceStatus(MailEnableWinService);
        }
        #endregion
    }
}
