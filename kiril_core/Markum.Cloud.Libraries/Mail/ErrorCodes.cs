
namespace Markum.Cloud.Libraries.Mail
{
    // API sonuçları ERRORCODE'lara dönüştürülür
    // Örneğin; Mailbox ekleme başarılı ise sonuç ERRORCODE.SUCCESS değilse ERRORCODE.MAILBOX_NOT_ADDED olur
    //
    //                      Error
    //                      Warning
    //  Code  MailEnable    Info            Error
    //  [-]      [1]        [1]     [01]    [001]
    //                               99 - General
    public static class ERRORCODES
    {
        // başarılı
        public const int SUCCESS = 1000000;
        // genel hata
        public const int ERROR = -1000000;

        // postoffice
        public const int POSTOFFICE_NOT_ADDED = -1101001;
        public const int POSTOFFICE_NOT_UPDATED = -1101002;
        public const int POSTOFFICE_GET_FAIL = -1101003;
        public const int POSTOFFICE_NOT_DELETED = -1101004;
        public const int POSTOFFICE_EXISTS = -1101005;
        public const int POSTOFFICE_NOT_EXISTS = -1101006;
        public const int POSTOFFICE_PARTIAL_ADDED = -1101007;
        public const int POSTOFFICE_PARTIAL_DELETED = -1101008;
        public const int POSTOFFICE_NOT_VALID_NAME = -1101009;

        // domain
        public const int DOMAIN_NOT_ADDED = -1102001;
        public const int DOMAIN_NOT_UPDATED = -1102002;
        public const int DOMAIN_GET_FAIL = -1102003;
        public const int DOMAIN_NOT_DELETED = -1102004;
        public const int DOMAIN_EXISTS = -1102005;
        public const int DOMAIN_NOT_EXISTS = -1102006;
        public const int DOMAIN_NOT_VALID_NAME = -1102007;

        // mailbox
        public const int MAILBOX_NOT_ADDED = -1103001;
        public const int MAILBOX_NOT_UPDATED = -1103002;
        public const int MAILBOX_GET_FAIL = -1103003;
        public const int MAILBOX_NOT_DELETED = -1103004;
        public const int MAILBOX_EXISTS = -1103005;
        public const int MAILBOX_NOT_EXISTS = -1103006;
        public const int MAILBOX_PARTIAL_ADDED = -1103007;
        public const int MAILBOX_PARTIAL_DELETED = -1103008;
        public const int MAILBOX_NOT_VALID_NAME = -1103009;

        // address map
        public const int ADDRESS_MAP_NOT_ADDED = -1104001;
        public const int ADDRESS_MAP_NOT_UPDATED = -1104002;
        public const int ADDRESS_MAP_GET_FAIL = -1104003;
        public const int ADDRESS_MAP_NOT_DELETED = -1104004;
        public const int ADDRESS_MAP_EXISTS = -1104005;
        public const int ADDRESS_MAP_NOT_EXISTS = -1104006;

        // login
        public const int LOGIN_NOT_ADDED = -1105001;
        public const int LOGIN_NOT_UPDATED = -1105002;
        public const int LOGIN_GET_FAIL = -1105003;
        public const int LOGIN_EXISTS = -1105005;
        public const int LOGIN_NOT_EXISTS = -1105006;
        public const int LOGIN_NOT_DELETED = -1105004;

        // system option
        public const int SYSTEM_OPTION_NOT_ADDED = -1106001;
        public const int SYSTEM_OPTION_NOT_UPDATED = -1106002;
        public const int SYSTEM_OPTION_GET_FAIL = -1106003;
        public const int OPTIONS_NOT_FOUND = -1106004;

        // genel
        public const int POSTMASTER_NOT_ADDED = -1199001;
        public const int POPRETRIEVAL_NOT_ADDED = -1199002;
        public const int EMAIL_NOT_VALID = -1199008;

        // kota
        public const int MAX_NUMBER_OF_MAILBOX_REACHED = -1199005;
        public const int ZERO_NEGATIVE_LIMIT = -1199006;
        public const int NEGATIVE_HOURLY_SEND_USAGE = -1199007;

        // bağlantı sorunu
        public const int CONNECTION_FAILURE = -1199003;
        public const int MAIL_SERVER_FAILURE = -1199004;
    }   
}