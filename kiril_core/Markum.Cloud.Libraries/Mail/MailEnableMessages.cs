using System.Collections.Generic;

namespace Markum.Cloud.Libraries.Mail
{
    public static class MailEnableMessages
    {
        private static Dictionary<int, string> _msg;

        static MailEnableMessages()
        {
            _msg = new Dictionary<int, string>();
            LoadMessages();
        }

        private static void LoadMessages()
        {
            // postoffice
            _msg.Add(ERRORCODES.POSTOFFICE_NOT_ADDED, "Postoffice eklenemedi");
            _msg.Add(ERRORCODES.POSTOFFICE_NOT_UPDATED, "Postoffice güncellenemedi");
            _msg.Add(ERRORCODES.POSTOFFICE_GET_FAIL, "Postoffice bilgisi alınamadı");
            _msg.Add(ERRORCODES.POSTOFFICE_EXISTS, "Postoffice kayıtlı");
            _msg.Add(ERRORCODES.POSTOFFICE_NOT_DELETED, "Postoffice sunucuda bulunmadığı için silinemedi ancak veritabanından kaldırıldı.");
            _msg.Add(ERRORCODES.POSTOFFICE_NOT_EXISTS, "Postoffice kayıtlı değil");
            _msg.Add(ERRORCODES.POSTOFFICE_PARTIAL_ADDED, "Postoffice eksik kaydedildi");
            _msg.Add(ERRORCODES.POSTOFFICE_PARTIAL_DELETED, "Postoffice tamamen silinemedi");
            _msg.Add(ERRORCODES.POSTOFFICE_NOT_VALID_NAME, "Postoffice ismi geçerli değil");

            // domain
            _msg.Add(ERRORCODES.DOMAIN_NOT_ADDED, "Domain kaydedilemedi");
            _msg.Add(ERRORCODES.DOMAIN_NOT_UPDATED, "Domain güncellenemedi");
            _msg.Add(ERRORCODES.DOMAIN_GET_FAIL, "Domain bilgisi alınamadı");
            _msg.Add(ERRORCODES.DOMAIN_NOT_DELETED, "Domain silinemedi");
            _msg.Add(ERRORCODES.DOMAIN_EXISTS, "Domain kayıtlı");
            _msg.Add(ERRORCODES.DOMAIN_NOT_EXISTS, "Domain kayıtlı değil");
            _msg.Add(ERRORCODES.DOMAIN_NOT_VALID_NAME, "Domain ismi geçerli değil");

            // mailbox
            _msg.Add(ERRORCODES.MAILBOX_NOT_ADDED, "Mailbox eklenemedi");
            _msg.Add(ERRORCODES.MAILBOX_NOT_UPDATED, "Mailbox güncellenemedi");
            _msg.Add(ERRORCODES.MAILBOX_GET_FAIL, "Mailbox bilgisi alınamadı");
            _msg.Add(ERRORCODES.MAILBOX_NOT_DELETED, "Mailbox silinemedi");
            _msg.Add(ERRORCODES.MAILBOX_EXISTS, "Mailbox kayıtlı");
            _msg.Add(ERRORCODES.MAILBOX_NOT_EXISTS, "Mailbox kayıtlı değil");
            _msg.Add(ERRORCODES.MAILBOX_PARTIAL_ADDED, "Mailbox eksik kaydedildi");
            _msg.Add(ERRORCODES.MAILBOX_PARTIAL_DELETED, "Mailbox tamamen silinemedi");
            _msg.Add(ERRORCODES.MAILBOX_NOT_VALID_NAME, "Mailbox ismi geçerli değil");

            // address map
            _msg.Add(ERRORCODES.ADDRESS_MAP_NOT_ADDED, "Mail adresi kaydedilmedi");
            _msg.Add(ERRORCODES.ADDRESS_MAP_NOT_UPDATED, "Mail adresi güncellenemedi");
            _msg.Add(ERRORCODES.ADDRESS_MAP_GET_FAIL, "Mail adresi bilgisi alınamadı");
            _msg.Add(ERRORCODES.ADDRESS_MAP_NOT_DELETED, "Mail adresi silinemedi");
            _msg.Add(ERRORCODES.ADDRESS_MAP_EXISTS, "Mail adresi kayıtlı");
            _msg.Add(ERRORCODES.ADDRESS_MAP_NOT_EXISTS, "Mail adresi kayıtlı değil");

            // login
            _msg.Add(ERRORCODES.LOGIN_NOT_ADDED, "Kullanıcı eklenemedi");
            _msg.Add(ERRORCODES.LOGIN_NOT_UPDATED, "Kullanıcı güncellenemedi");
            _msg.Add(ERRORCODES.LOGIN_GET_FAIL, "Kullanıcı bilgisi alınamadı");
            _msg.Add(ERRORCODES.LOGIN_EXISTS, "Kullanıcı kayıtlı");
            _msg.Add(ERRORCODES.LOGIN_NOT_EXISTS, "Kullanıcı kayıtlı değil");
            _msg.Add(ERRORCODES.LOGIN_NOT_DELETED, "Kullanıcı silinemedi");

            // system option
            _msg.Add(ERRORCODES.SYSTEM_OPTION_NOT_ADDED, "SYSTEM_OPTION_NOT_ADDED");
            _msg.Add(ERRORCODES.SYSTEM_OPTION_NOT_UPDATED, "SYSTEM_OPTION_NOT_UPDATED");
            _msg.Add(ERRORCODES.SYSTEM_OPTION_GET_FAIL, "SYSTEM_OPTION_GET_FAIL");
            _msg.Add(ERRORCODES.OPTIONS_NOT_FOUND, "Mail ayarlarınızda sorun var");

            // genel
            _msg.Add(ERRORCODES.POSTMASTER_NOT_ADDED, "Postmaster hesabı oluşturulamadı");
            _msg.Add(ERRORCODES.POPRETRIEVAL_NOT_ADDED, "POPRETRIEVAL_NOT_ADDED");
            _msg.Add(ERRORCODES.EMAIL_NOT_VALID, "Email geçerli değil");

            // kota
            _msg.Add(ERRORCODES.MAX_NUMBER_OF_MAILBOX_REACHED, "Maksimum mail sayısına ulaştınız");
            _msg.Add(ERRORCODES.ZERO_NEGATIVE_LIMIT, "ZERO_NEGATIVE_LIMIT");
            _msg.Add(ERRORCODES.NEGATIVE_HOURLY_SEND_USAGE, "NEGATIVE_HOURLY_SEND_USAGE");

            // bağlantı sorunu
            _msg.Add(ERRORCODES.CONNECTION_FAILURE, "CONNECTION_FAILURE");
            _msg.Add(ERRORCODES.MAIL_SERVER_FAILURE, "MAIL_SERVER_FAILURE");
        }

        public static string GetMessage(int errorcode)
        {
            if (_msg.ContainsKey(errorcode))
                return _msg[errorcode];

            return string.Format("Mail Hata {0}", errorcode);
        }
    }
}