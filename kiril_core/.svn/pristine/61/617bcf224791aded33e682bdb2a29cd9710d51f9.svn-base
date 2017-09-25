
namespace Markum.Cloud.Libraries.Mail
{
    /*************************************************************
     * 
     * MailEnable API .NET Reference dosyasından alınmıştır
     * For FindFirstMailbox and GetMailbox, you can make calls to these functions faster by not have the mail server
     * return the current disk usage. If this is a large mailbox, and the current quota usage details are out of date, the
     * function will try to index the mailbox and calculate quota. This will make the function slower. A way around this
     * is to change the value of the Size property. Accepted values are:
     * 
     * Use -1 as the normal wildcard which will get usage
     * Use -2 to not return the current disk usage if there is no quota set on a mailbox
     * Use -3 to just return last calculated usage
     * Use -4 to not get any mailbox usage at all
     * So unless you need to get the current disk usage for a mailbox, always use -4.
     * 
     * Mailbox bilgilerini  alırken mailbox boyutunun nasıl hesaplanacağını belirtir
     * 
     *************************************************************/
    public static class MailboxSizeWildCards
    {
        public const long CurrentSize = -1;
        public const long CurrentSizeForLimited = -2;
        public const long LastCalculatedSize = -3;
        public const long NoSize = -4;
    }   
}