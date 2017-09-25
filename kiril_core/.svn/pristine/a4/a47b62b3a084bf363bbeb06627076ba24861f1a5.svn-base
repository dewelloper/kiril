using Markum.Cloud.Libraries.Mail;
using Markum.Cloud.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Markum.Cloud.Api.Controllers
{
    public class MailController : BaseApiController
    {

        private IMailService _mailService;
        public MailController(IMailService mailService)
        {
            _mailService = mailService;
        }

        // PostOffice
        public IHttpActionResult AddPostOffice([FromBody] string postOffice)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.AddPostOffice(postOffice);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult AddPostOffice([FromBody] string postOffice, string domain, string postMasterPassword)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.AddPostOffice(postOffice, domain, postMasterPassword);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult AddPostOffice([FromBody] string postOffice, string domain, string postMasterPassword, string postmasterRight, int postmasterLimit)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.AddPostOffice(postOffice, domain, postMasterPassword, postmasterRight, postmasterLimit);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult UpdatePostOfficeStatus([FromBody] string postOffice, long newStatus)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.UpdatePostOfficeStatus(postOffice, newStatus);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult DeletePostOffice([FromBody] string postOffice)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.DeletePostOffice(postOffice);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult GetPostOffice([FromBody] string postOffice)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.GetPostOffice(postOffice);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult GetAllPostOffices()
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.GetAllPostOffices();

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult GetAllPostOffices([FromBody] long top, long maxlength)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.GetAllPostOffices(top,maxlength);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult GetPostOffices([FromBody] string name, long top, long maxlength)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.GetPostOffices(name,top,maxlength);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult GetPostOfficesService1([FromBody] string name, long status, int pageNumber, int pageSize, int totalNumber)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.GetPostOfficesService1(name,status,pageNumber,pageSize,totalNumber);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult PostOfficeExists([FromBody] string postOffice)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.PostOfficeExists(postOffice);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        //Domain
        public IHttpActionResult AddDomain([FromBody] string postOffice, string domain)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.AddDomain(postOffice, domain);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult GetDomain([FromBody]string postOffice, string domainName)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.GetDomain(postOffice, domainName);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult GetAllDomains([FromBody] string postOffice)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.GetAllDomains(postOffice);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult GetDomains([FromBody] string postOffice, string domainName)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.GetDomains(postOffice, domainName);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult DomainExists([FromBody] string postOffice, string domain)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.DomainExists(postOffice, domain);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        // Mailbox
        public IHttpActionResult AddMailbox([FromBody] string postOffice, string mailboxName, string password, string rights, long limit)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.AddMailbox(postOffice, mailboxName, password, rights, limit);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult AddMailbox([FromBody] string postOffice, string mailboxName, long limit)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.AddMailbox(postOffice, mailboxName, limit);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult AddMailbox([FromBody] string postOffice, string mailboxName, long limit, long redirectStatus, string redirectAddress)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.AddMailbox(postOffice, mailboxName, limit, redirectStatus, redirectAddress);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult AddMailbox([FromBody] string postOffice, string domainName, string mailboxName, string password, string rights, long limit)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.AddMailbox(postOffice, domainName, mailboxName, password, rights, limit);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult AddMailbox([FromBody] string postOffice, string domainName, string mailboxName, string password, string rights, long limit, long redirectStatus, string redirectAddress)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.AddMailbox(postOffice, domainName, mailboxName, password, rights, limit, redirectStatus, redirectAddress);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult UpdateMailbox([FromBody] string postOffice, string mailboxName, string newMailboxName, long newStatus, long newSize, long newLimit, long newRedirectStatus, string newRedirectAddress)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.UpdateMailbox(postOffice, mailboxName, newMailboxName, newStatus, newSize, newLimit, newRedirectStatus, newRedirectAddress);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult UpdateMailboxStatus([FromBody] string postOffice, string mailboxName, long newStatus)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.UpdateMailboxStatus(postOffice, mailboxName, newStatus);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult UpdateMailboxStatus([FromBody] string postOffice, string mailboxName, long newStatus, long loginStatus)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.UpdateMailboxStatus(postOffice, mailboxName, newStatus, loginStatus);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult UpdateMailboxLimit([FromBody] string postOffice, string mailboxName, long newLimit)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.UpdateMailboxLimit(postOffice, mailboxName, newLimit);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult DeleteMailbox([FromBody] string postOffice, string mailboxName)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.DeleteMailbox(postOffice, mailboxName);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult GetMailbox([FromBody] string postoffice, string mailboxName)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.GetMailbox(postoffice, mailboxName);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult GetMailboxes([FromBody] string postoffice)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.GetMailboxes(postoffice);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult GetMailboxes([FromBody] string postoffice, long top, long maxlength)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.GetMailboxes(postoffice, top, maxlength);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult GetMailboxesService1([FromBody] string postoffice)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.GetMailboxesService1(postoffice);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult GetMailboxesService1([FromBody] string postoffice, string mailboxName, long status)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.GetMailboxesService1(postoffice, mailboxName, status);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult MailboxExists([FromBody] string postOffice, string mailboxName)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.MailboxExists(postOffice, mailboxName);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult SaveMailboxAutoResponder([FromBody] string postOffice, string mailboxName, bool status, string subject, string message)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.SaveMailboxAutoResponder(postOffice, mailboxName, status, subject, message);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult GetMailboxAutoResponderStatus([FromBody] string postOffice, string mailboxName)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.GetMailboxAutoResponderStatus(postOffice, mailboxName);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult GetMailboxAutoResponderContents([FromBody] string postOffice, string mailboxName)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.GetMailboxAutoResponderContents(postOffice, mailboxName);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult GetMailboxAutoResponderSubject([FromBody] string postOffice, string mailboxName)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.GetMailboxAutoResponderSubject(postOffice, mailboxName);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult MailboxCount([FromBody] string postOffice)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.MailboxCount(postOffice);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        //Login
        public IHttpActionResult AddLogin([FromBody] string postOffice, string mailboxName, string password, string description, string rights)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.AddLogin(postOffice, mailboxName, password, description, rights);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult UpdateLogin([FromBody] string postOffice, string mailboxName, string newPostOffice, string newMailboxName, string newPassword, long newStatus, string newDescription, string newRights)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.UpdateLogin(postOffice, mailboxName, newPostOffice, newMailboxName, newPassword, newStatus, newDescription, newRights);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult UpdateLoginStatus([FromBody] string postOffice, string mailboxName, long newStatus)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.UpdateLoginStatus(postOffice, mailboxName, newStatus);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult GetLogin([FromBody] string postOffice, string userName)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.GetLogin(postOffice, userName);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult LoginExists([FromBody] string postOffice, string userName)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.LoginExists(postOffice, userName);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult ChangePassword([FromBody] string postOffice, string mailboxName, string password)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.ChangePassword(postOffice, mailboxName, password);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult UpdateLoginRights([FromBody] string postOffice, string mailboxName, string newRights)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.UpdateLoginRights(postOffice, mailboxName, newRights);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        //AddressMap
        public IHttpActionResult AddAddressMap([FromBody] string postOffice, string domain, string mailboxName)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.AddAddressMap(postOffice, domain, mailboxName);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult GetAddressMaps([FromBody] string postOffice, string mailboxName)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.GetAddressMaps(postOffice, mailboxName);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult GetAddressMap([FromBody] string postOffice, string domain, string mailboxName)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.GetAddressMap(postOffice, domain, mailboxName);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult AddressMapExists([FromBody] string postOffice, string domain, string mailboxName)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.AddressMapExists(postOffice, domain, mailboxName);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult GetAddressMap2([FromBody] string postOffice, string source, string destination)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.GetAddressMap2(postOffice, source, destination);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult AddAddressMap2([FromBody] string postOffice, string source, string destination)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.AddAddressMap2(postOffice, source, destination);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult UpdateAddressMap([FromBody] string postOffice, string source, string destination, string newSource, string newDestination, long newStatus)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.UpdateAddressMap(postOffice, source, destination, newSource, newDestination, newStatus);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult DeleteAddressMap([FromBody] string postOffice, string source, string destination)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.DeleteAddressMap(postOffice, source, destination);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        //SystemOptions
        public IHttpActionResult GetSystemOption([FromBody] string query, int scope, string valueName)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.GetSystemOption(query, scope, valueName);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult SetSystemOption([FromBody] string query, long scope, string valueName, string value)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.SetSystemOption(query, scope, valueName, value);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult GetPostOfficeOption([FromBody] string postOffice)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.GetPostOfficeOption(postOffice);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult SetPostOfficeOption([FromBody] string postOffice, PostOfficeOptions option)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.SetPostOfficeOption(postOffice, option);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult GetMailboxOption([FromBody] string postOffice, string mailboxName)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.GetMailboxOption(postOffice, mailboxName);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult SetMailboxOption([FromBody] string postOffice, string mailboxName, MailboxOptions option)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.SetMailboxOption(postOffice, mailboxName, option);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        //POPRetrieval
        public IHttpActionResult AddPOPRetrieval([FromBody] string postoffice, string mailbox, string mailserver, long port, string username, string password)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.AddPOPRetrieval(postoffice, mailbox, mailserver, port, username, password);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult POPRetrievalExists([FromBody] string postoffice, string mailserver, long port, string username)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.POPRetrievalExists(postoffice, mailserver, port, username);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        //MessageCommand
        public IHttpActionResult GetMessageCommands([FromBody] string path)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.GetMessageCommands(path);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult GetMessageCommandsBySender([FromBody] string path, string sender)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.GetMessageCommandsBySender(path, sender);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult GetMessageCommandsByRecipient([FromBody] string path, string recipient)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.GetMessageCommandsByRecipient(path, recipient);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult GetMessageCommandsByClientIP([FromBody] string path, string clientip)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.GetMessageCommandsByClientIP(path, clientip);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult DeleteMessageCommandFiles([FromBody] string path, string sender)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                _mailService.DeleteMessageCommandFiles(path, sender);

                return JSendCreated("", "ok-void");
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult DeleteMessageCommandFilesByRecipient([FromBody] string path, string recipient)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                _mailService.DeleteMessageCommandFilesByRecipient(path, recipient);

                return JSendCreated("", "ok-void");
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult DeleteMessageCommandFilesByClientIP([FromBody] string path, string clientip)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.GetMailboxOption(path, clientip);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        //Service
        public IHttpActionResult GetWindowsServiceStatusID([FromBody] string MailEnableServiceTypeName)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.GetWindowsServiceStatusID(MailEnableServiceTypeName);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult StartService([FromBody] string MailEnableServiceTypeName)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                _mailService.StartService(MailEnableServiceTypeName);

                return JSendCreated("", "ok-void");
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult StopService([FromBody] string MailEnableServiceTypeName)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                _mailService.StopService(MailEnableServiceTypeName);

                return JSendCreated("", "ok-void");
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult RestartService([FromBody] string MailEnableServiceTypeName, int timeoutMilliseconds)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                _mailService.RestartService(MailEnableServiceTypeName, timeoutMilliseconds);

                return JSendCreated("", "ok-void");
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        public IHttpActionResult GetWindowsServiceStatus([FromBody] DataTable MailEnableWinService)
        {
            try
            {
                if (!ModelState.IsValid)
                    JSendBadRequest(ModelState);

                var res = _mailService.GetWindowsServiceStatus(MailEnableWinService);

                return JSendCreated("", res);
            }
            catch (Exception ex)
            {
                return JSendError(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

    }
}
