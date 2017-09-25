using Markum.Cloud.Libraries.AddressMap;
using Markum.Cloud.Libraries.Domain;
using Markum.Cloud.Libraries.Login;
using Markum.Cloud.Libraries.Mail;
using Markum.Cloud.Libraries.Mailbox;
using Markum.Cloud.Libraries.PostOffice;
using Markum.Cloud.Libraries.Service1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markum.Cloud.Services.Interfaces
{
    public interface IMailService
    {
        #region PostOffice
        int AddPostOffice(string postOffice);
        int AddPostOffice(string postOffice, string domain, string postMasterPassword);
        int AddPostOffice(string postOffice, string domain, string postMasterPassword, string postmasterRight, int postmasterLimit);
        int UpdatePostOfficeStatus(string postOffice, long newStatus);
        int DeletePostOffice(string postOffice);
        Libraries.PostOffice.Postoffice GetPostOffice(string postOffice);
        Libraries.PostOffice.Postoffice[] GetAllPostOffices();
        Libraries.PostOffice.Postoffice[] GetAllPostOffices(long top, long maxlength);
        Libraries.PostOffice.Postoffice[] GetPostOffices(string name, long top, long maxlength);
        Libraries.Service1.Postoffice[] GetPostOfficesService1(string name, long status, int pageNumber, int pageSize, int totalNumber);
        bool PostOfficeExists(string postOffice);
        #endregion

        #region Domain

        int AddDomain(string postOffice, string domain);
        Domain GetDomain(string postOffice, string domainName);
        Domain[] GetAllDomains(string postOffice);
        Domain[] GetDomains(string postOffice, string domainName);
        bool DomainExists(string postOffice, string domain);

        #endregion

        #region Mailbox
        int AddMailbox(string postOffice, string mailboxName, string password, string rights, long limit);
        int AddMailbox(string postOffice, string mailboxName, long limit);
        int AddMailbox(string postOffice, string mailboxName, long limit, long redirectStatus, string redirectAddress);
        int AddMailbox(string postOffice, string domainName, string mailboxName, string password, string rights, long limit);
        int AddMailbox(string postOffice, string domainName, string mailboxName, string password, string rights, long limit, long redirectStatus, string redirectAddress);
        int UpdateMailbox(string postOffice, string mailboxName, string newMailboxName, long newStatus, long newSize, long newLimit, long newRedirectStatus, string newRedirectAddress);
        int UpdateMailboxStatus(string postOffice, string mailboxName, long newStatus);
        int UpdateMailboxStatus(string postOffice, string mailboxName, long newStatus, long loginStatus);
        int UpdateMailboxLimit(string postOffice, string mailboxName, long newLimit);
        int DeleteMailbox(string postOffice, string mailboxName);
        Libraries.Mailbox.Mailbox GetMailbox(string postoffice, string mailboxName);
        Libraries.Mailbox.Mailbox[] GetMailboxes(string postoffice);
        Libraries.Mailbox.Mailbox[] GetMailboxes(string postoffice, long top, long maxlength);
        Markum.Cloud.Libraries.Service1.Mailbox[] GetMailboxesService1(string postoffice);
        Markum.Cloud.Libraries.Service1.Mailbox[] GetMailboxesService1(string postoffice, string mailboxName, long status);
        bool MailboxExists(string postOffice, string mailboxName);
        int SaveMailboxAutoResponder(string postOffice, string mailboxName, bool status, string subject, string message);
        bool GetMailboxAutoResponderStatus(string postOffice, string mailboxName);
        string GetMailboxAutoResponderContents(string postOffice, string mailboxName);
        string GetMailboxAutoResponderSubject(string postOffice, string mailboxName);
        int MailboxCount(string postOffice);
        #endregion

        #region Login
        int AddLogin(string postOffice, string mailboxName, string password, string description, string rights);
        int UpdateLogin(string postOffice, string mailboxName, string newPostOffice, string newMailboxName, string newPassword, long newStatus, string newDescription, string newRights);
        int UpdateLoginStatus(string postOffice, string mailboxName, long newStatus);
        Login GetLogin(string postOffice, string userName);
        bool LoginExists(string postOffice, string userName);
        int ChangePassword(string postOffice, string mailboxName, string password);
        int UpdateLoginRights(string postOffice, string mailboxName, string newRights);
        #endregion

        #region AddressMap
        int AddAddressMap(string postOffice, string domain, string mailboxName);
        AddressMap[] GetAddressMaps(string postOffice, string mailboxName);
        AddressMap GetAddressMap(string postOffice, string domain, string mailboxName);
        bool AddressMapExists(string postOffice, string domain, string mailboxName);
        AddressMap GetAddressMap2(string postOffice, string source, string destination);
        int AddAddressMap2(string postOffice, string source, string destination);
        int UpdateAddressMap(string postOffice, string source, string destination, string newSource, string newDestination, long newStatus);
        int DeleteAddressMap(string postOffice, string source, string destination);
        #endregion

        #region SystemOptions
        string GetSystemOption(string query, int scope, string valueName);
        int SetSystemOption(string query, long scope, string valueName, string value);
        PostOfficeOptions GetPostOfficeOption(string postOffice);
        int SetPostOfficeOption(string postOffice, PostOfficeOptions option);
        MailboxOptions GetMailboxOption(string postOffice, string mailboxName);
        int SetMailboxOption(string postOffice, string mailboxName, MailboxOptions option);
        #endregion

        #region POPRetrieval

        int AddPOPRetrieval(string postoffice, string mailbox, string mailserver, long port, string username, string password);
        bool POPRetrievalExists(string postoffice, string mailserver, long port, string username);

        #endregion

        #region MessageCommand
        MessageCommand[] GetMessageCommands(string path);
        MessageCommand[] GetMessageCommandsBySender(string path, string sender);
        MessageCommand[] GetMessageCommandsByRecipient(string path, string recipient);
        MessageCommand[] GetMessageCommandsByClientIP(string path, string clientip);
        void DeleteMessageCommandFiles(string path, string sender);
        void DeleteMessageCommandFilesByRecipient(string path, string recipient);
        void DeleteMessageCommandFilesByClientIP(string path, string clientip);
        #endregion

        #region Service
        int GetWindowsServiceStatusID(string MailEnableServiceTypeName);
        void StartService(string MailEnableServiceTypeName);
        void StopService(string MailEnableServiceTypeName);
        void RestartService(string MailEnableServiceTypeName, int timeoutMilliseconds);
        DataTable GetWindowsServiceStatus(DataTable MailEnableWinService);
        #endregion
    }
}
