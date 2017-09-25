
namespace Markum.Cloud.Libraries.Mail
{
    // Postoffice, domain, mailbox, login, list, listmember, group un statüleri
    // NOTSUPPLIED eğer statü atamak istenmiyorsa kullanılabilir. (bu durumda mailenable disable yapıyor)
    // Ayrıca arama fonksiyonlarında wildcard olarak kullanılabilir. 
    public static class Status
    {
        public const long DISABLED = 0L;
        public const long ENABLED = 1L;
        public const long NOTSUPPLIED = -1L;
    }
}