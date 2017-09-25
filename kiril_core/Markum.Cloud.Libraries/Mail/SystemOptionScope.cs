namespace Markum.Cloud.Libraries.Mail
{
    // CATEGORY     Sistem ayarları
    // POSTOFFICE   Postoffice ayarları
    // MAILBOX      Mailbox ayarları
    // Mailenable kontrol panelinde ilgili bölüme sağ tıklayınca çıkan ekran
    // Bu üç bölümün ayarları API değiştirilebilmektedir
    // Hangi kısım için ayarları değiştirmek istediğimizi belirtmek için kullanılır
    public static class SystemOptionScope
    {
        public const long CATEGORY = 0L;
        public const long POSTOFFICE = 1L;
        public const long MAILBOX = 2L;
    }
}