using System;
using System.Text.RegularExpressions;

namespace Markum.Cloud.Libraries.Mail
{
    public class MailEnableUtils
    {
        /*************************************************************
         * 
         * Address Formatting
         * An internal MailEnable address is made of two core parts. 
         * Firstly, there is the Connector Descriptor and secondly there is the addressing detail.
         * The exact syntax is shown below:
         *
         * Syntax           
         * [Connector Acronym: Connector Address Details]
         *   
         * Examples 
         * MailEnable Internal Address             Explanation
         *  
         * [SF:POSTOFFICE/MAILBOX]                 The location of mailbox (MAILBOX) on postoffice (POSTOFFICE) using the SF Connector (Postoffice Connector)  
         * [SMTP:User@domain]                      The SMTP Address of a user at the prescribed domain using the SMTP Connector
         * [LS:POSTOFFICE/LISTNAME]                The location of list mailbox (LISTNAME) on postoffice (POSTOFFICE) using the LS Connector (List Connector).
         * 
         * 
         * 
         * Username: mailboxname@postofficename
         * 
         *************************************************************/

        public static string ToUserName(string mailbox, string postOffice)
        {
            return String.Format("{0}@{1}", mailbox, postOffice);
        }

        public static string ToSFInternalAddress(string postOffice, string mailbox)
        {
            return String.Format("[SF:{0}/{1}]", postOffice, mailbox);
        }

        public static string ToSFInternalAddress(string addressDetail)
        {
            return "[SF:" + addressDetail + "]";
        }

        public static string ToSMTPInternalAddress(string mailbox, string domain)
        {
            return String.Format("[SMTP:{0}@{1}]", mailbox, domain);
        }

        public static string ToSMTPInternalAddress(string addressDetail)
        {
            return "[SMTP:" + addressDetail + "]";
        }

        public static string ToLSInternalAddress(string postOffice, string list)
        {
            return String.Format("[LS:{0}/{1}]", postOffice, list);
        }

        public static string ToLSInternalAddress(string addressDetail)
        {
            return "[LS:" + addressDetail + "]";
        }

        public static string ToMailAddress(string name, string domain)
        {
            return String.Format("{0}@{1}", name, domain);
        }

        public static void ParseUserName(string userName, out string mailbox, out string postOffice)
        {
            string[] arr = userName.Split(new[] {'@'}, StringSplitOptions.RemoveEmptyEntries);

            if (arr.Length != 2)
            {
                throw new FormatException();
            }

            mailbox = arr[0];
            postOffice = arr[1];
        }

        public static void ParseSFInternalAddress(string internalAddress, out string postOffice, out string mailbox)
        {
            Match m = Regex.Match(internalAddress, @"\[SF:(.+)/(.+)\]");

            if (!m.Success || m.Groups.Count != 3)
            {
                throw new FormatException();
            }

            postOffice = m.Groups[1].Value;
            mailbox = m.Groups[2].Value;
        }

        public static string ParseSFInternalAddress(string internalAddress)
        {
            if (internalAddress.Length < 6 || !internalAddress.StartsWith("[SF:") || !internalAddress.EndsWith("]"))
            {
                throw new FormatException();
            }

            return internalAddress.Substring(4, internalAddress.Length - 5);
        }

        public static void ParseLSInternalAddress(string internalAddress, out string postOffice, out string list)
        {
            Match m = Regex.Match(internalAddress, @"\[LS:(.+)/(.+)\]");

            if (!m.Success || m.Groups.Count != 3)
            {
                throw new FormatException();
            }

            postOffice = m.Groups[1].Value;
            list = m.Groups[2].Value;
        }

        public static string ParseLSInternalAddress(string internalAddress)
        {
            if (internalAddress.Length < 6 || !internalAddress.StartsWith("[LS:") || !internalAddress.EndsWith("]"))
            {
                throw new FormatException();
            }

            return internalAddress.Substring(4, internalAddress.Length - 5);
        }

        public static void ParseSMTPInternalAddress(string internalAddress, out string mailbox, out string domain)
        {
            Match m = Regex.Match(internalAddress, @"\[SMTP:(.+)@(.+)\]");

            if (!m.Success || m.Groups.Count != 3)
            {
                throw new FormatException();
            }

            mailbox = m.Groups[1].Value;
            domain = m.Groups[2].Value;
        }

        public static string ParseSMTPInternalAddress(string internalAddress)
        {
            if (internalAddress.Length < 8 || !internalAddress.StartsWith("[SMTP:") || !internalAddress.EndsWith("]"))
            {
                throw new FormatException();
            }

            return internalAddress.Substring(6, internalAddress.Length - 7);
        }

        public static void ParseMailAddress(string mailAddress, out string name, out string domain)
        {
            string[] arr = mailAddress.Split(new[] {'@'}, StringSplitOptions.RemoveEmptyEntries);

            if (arr.Length != 2)
            {
                throw new FormatException();
            }

            name = arr[0];
            domain = arr[1];
        }
    }
}