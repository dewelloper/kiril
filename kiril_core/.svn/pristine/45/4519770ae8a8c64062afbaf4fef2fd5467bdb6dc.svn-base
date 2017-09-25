using Markum.Cloud.Libraries.LibraryObjects;
using Microsoft.Web.Services3;
using System;
using System.Collections.Generic;
using System.Data;
using WebsitePanel.EnterpriseServer;


namespace Markum.Cloud.Libraries.Util
{
    public class esHelper
    {
        private static Dictionary<int, string> Messages;
        private static Dictionary<string, string> ResourceStrings;

        static esHelper()
        {
            Messages = new Dictionary<int, string>();
            LoadMessages();
            ResourceStrings = new Dictionary<string, string>();
            LoadResourceStrings();
        }

        private static void LoadMessages()
        {
            /**********************************************************************
             *  Warning.[BusinessErrorCodes ID] ve Error.[BusinessErrorCodes ID] (örnek Warning.301, Error.1001) olan mesajlar 
             *  WebsitePanel_SharedResources.ascx.tr-TR.resx dosyasından bu mesajlar alınmıştır
             *  Solution Items altına eklenmiştir
             *  Websitepanel App_GlobalResources klasöründe bulunabilir
             *  WebsitePanel_SharedResources.ascx.resx (ingilizce) solution items altına eklenmiştir
             *  
             *  Ayrıca bu mesajların açıklamalarıda mevcut. Açıklamalar buraya eklenmedi
             *  
             *********************************************************************/

            // Todo: Doğrudan websitepanelin resource dosyasını kullanacak şekilde düzenle

            Messages.Add(-100, "Belirtilen kullanıcı adı veritabanında zaten var");
            Messages.Add(-101, "Kullanıcı hesabı veritabanında bulunamadı");
            Messages.Add(-102, "Kullanıcı hesabı alt kullanıcı hesaplarına sahip100");
            Messages.Add(-103, "Kullanıcı hesabı Bekleme modunda");
            Messages.Add(-104, "Kullanıcı hesabı Askıya Al modunda");
            Messages.Add(-105, "Kullanıcı hesabı İptal Edildi modunda");
            Messages.Add(-106, "Kullanıcı hesabı Demo modunda");
            Messages.Add(-107, "Bu işlemi yürütmek için Yönetici yetkilerine sahip olmalısınız");
            Messages.Add(-108, "Bu işlemi yürütmek için Satıcı yetkilerine sahip olmalısınız");
            Messages.Add(-109, "Belirtilen kullanıcı adı ile bir kullanıcı bulunamadı");
            Messages.Add(-110, "Yanlış parola belirtilmiş");
            Messages.Add(-111, "Belirtilen Kullanıcı adı geçersiz.");
            Messages.Add(-200, "Hesap özet mektubu belirtilmemiş ya da boş");
            Messages.Add(-201, "Barındırma alanı özet mektubu belirtilmedi ya da boş bir gövdeye sahip");
            Messages.Add(-202, "Parola anımsatıcı mektubu belirtilmedi ya da boş gövdeye sahip");
            Messages.Add(-300, "Barındırma alanı meta öğesi veritabanında bulunamadı");
            Messages.Add(-301, "Barındırma alanı silinemedi çünkü alt alanlara sahip");
            Messages.Add(-302, "Barındırma alanı Yeni modda");
            Messages.Add(-303, "Barındırma alanı Askıda modunda");
            Messages.Add(-304, "Barındırma alanı İptal Edildi modunda");
            Messages.Add(-305, "Yetersiz barındırma kaynakları");
            Messages.Add(-400, "Yanlış Sunucu URL'si belirtildi (-Bulunamadı)");
            Messages.Add(-401, "Hatalı İstek");
            Messages.Add(-402, "Active Directory'e bağlanma hatası");
            Messages.Add(-403, "İç Sunucu Hatası");
            Messages.Add(-404, "Servis Kullanılamaz");
            Messages.Add(-405, "Yetkisiz");
            Messages.Add(-406, "Yanlış Sunucu erişim parolası belirtildi");
            Messages.Add(-407, "WebsitePanel Sunucusu İç Uygulama Hatası");
            Messages.Add(-409, "WebsitePanel Sunucusu kullanılabilir değil");
            Messages.Add(-500, "Etki Alanı kotasına ulaşıldı");
            Messages.Add(-501, "Üst etki alanı için alt etki alanlarına izin verilmedi");
            Messages.Add(-502, "Belirtilen etki alanı zaten var");
            Messages.Add(-503, "Etki alanı adı \"www.\" ile başlamalı");
            Messages.Add(-504, "Etki alanı meta öğesi veritabanında bulunamadı");
            Messages.Add(-505, "DNS bölgesi meta öğesi veritabanında bulunamadı");
            Messages.Add(-506, "Web sitesini gösterdiği için etki alanı silinemez");
            Messages.Add(-507, "Posta etki alanını gösterdiği için etki alanı silinemez");
            Messages.Add(-508, "Alt etki alanları kotasına ulaşıldı");
            Messages.Add(-509, "Hedef serviste DNS Bölgesi zaten var.");
            Messages.Add(-510, "Etki alanı diğer adları kotasına ulaşıldı");
            Messages.Add(-511, "Anlık diğer ad, barındırma sağlayıcı tarafından yapılandırılmamış");
            Messages.Add(-600, "Web Sitelerinin kotasına ulaşıldı");
            Messages.Add(-601, "Belirtilen web sitesi zaten var");
            Messages.Add(-602, "Web Siteleri servisi barındırma planı nedeniyle kullanılabilir değil");
            Messages.Add(-603, "Belirtilen FrontPage hesabı zaten sistemde var");
            Messages.Add(-604, "FrontPage hesap parolası değiştirme hatası");
            Messages.Add(-605, "Belirtilen adla Sanal Dizin zaten var");
            Messages.Add(-606, "Web Sitesi barındırma alanı meta öğesi bulunamadı");
            Messages.Add(-607, "Web Sitesi meta öğesi IP adresi belirtilmemiş");
            Messages.Add(-608, "Paylaşımlı IP adresi belirtilmedi");
            Messages.Add(-609, "Paylaşılan SSL Klasörleri kotasına ulaşıldı");
            Messages.Add(-700, "Belirtilen posta etki alanı serviste zaten var");
            Messages.Add(-701, "Posta kaynakları seçili barındırma alanı için kullanılamaz");
            Messages.Add(-702, "Posta hesapları kotasına ulaşıldı");
            Messages.Add(-703, "Belirtilen posta hesabı barındırma alanında zaten var");
            Messages.Add(-704, "Belirtilen posta hesabı hedef serviste zaten var");
            Messages.Add(-705, "Posta iletme kotasına ulaşıldı");
            Messages.Add(-706, "Belirtilen posta iletmesi barındırma alanında zaten var");
            Messages.Add(-707, "Belirtilen posta iletmesi hedef serviste zaten var");
            Messages.Add(-708, "Posta grubu kotasına ulaşıldı");
            Messages.Add(-709, "Belirtilen posta grubu barındırma alanında zaten var");
            Messages.Add(-710, "Belirtilen posta grubu hedef serviste zaten var");
            Messages.Add(-711, "Posta listeleri kotasına ulaşıldı");
            Messages.Add(-712, "Belirtilen posta listesi barındırma alanında zaten var");
            Messages.Add(-713, "Belirtilen posta listesi hedef serviste zaten var");
            Messages.Add(-714, "Posta hesabı meta öğesi veritabanında bulunamadı");
            Messages.Add(-715, "Posta iletme meta öğesi veritabanında bulunamadı");
            Messages.Add(-716, "Posta grubu meta öğesi veritabanında bulunamadı");
            Messages.Add(-717, "Posta listesi meta öğesi veritabanında bulunamadı");
            Messages.Add(-718, "Posta etki alanı meta öğesi veritabanında bulunamadı");
            Messages.Add(-719, "Posta etki alanı hedef servisten okunamadı");
            Messages.Add(-720, "Posta etki alanı silinemedi çünkü boş değil");
            Messages.Add(-721, "İzin verilen posta grup alıcısı sayısını aştınız");
            Messages.Add(-722, "İzin verilen posta listesi alıcısı sayısını aştınız");
            Messages.Add(-723, "İzin verilen maksimum etki alanı sayısına ulaşıldı.");
            Messages.Add(-724, "Sunucu için izin verilen maksimum kullanıcı sayısına ulaşıldı.");
            Messages.Add(-801, "Seçili barındırma alanı için FTP kaynakları kullanılamaz");
            Messages.Add(-802, "FTP Hesapları kotasına ulaşıldı");
            Messages.Add(-803, "Belirtilen FTP hesabı barındırma alanında zaten var");
            Messages.Add(-804, "Belirtilen FTP hesabı hedef serviste zaten var");
            Messages.Add(-805, "FTP hesabı meta öğesi veritabanında bulunamadı");
            Messages.Add(-806, "Lütfen Microsoft FTP için FTP Kullanıcı Adı'nın 20 karakterden uzun olmamasına dikkat edin.");
            Messages.Add(-901, "Seçili barındırma alanı için MS SQL kaynağı kullanılamaz");
            Messages.Add(-902, "Veritabanı kotasına ulaşıldı");
            Messages.Add(-903, "Belirtilen veritabanı barındırma alanında zaten var");
            Messages.Add(-904, "Belirtilen veritabanı hedef serviste zaten var");
            Messages.Add(-905, "Veritabanı kullanıcı kotasına ulaşıldı");
            Messages.Add(-906, "Belirtilen veritabanı kullanıcısı barındırma alanında zaten var");
            Messages.Add(-907, "Belirtilen veritabanı kullanıcısı hedef serviste zaten var");
            Messages.Add(-908, "SQL veritabanı meta öğesi veritabanında bulunamadı");
            Messages.Add(-909, "SQL kullanıcısı meta öğesi veritabanında  bulunamadı");
            Messages.Add(-999, "İstediğiniz işlem tamamlanırken başarısız oldu");
            Messages.Add(-1001, "Seçili barındırma alanı için MySQL kaynağı kullanılamıyor");
            Messages.Add(-1002, "MySQL veritabanları kotasına ulaşıldı");
            Messages.Add(-1003, "Belirtilen veritabanı barındırma alanında zaten var");
            Messages.Add(-1004, "Belirtilen veritabanı hedef serviste zaten var");
            Messages.Add(-1005, "Veritabanı kullanıcı kotasına ulaşıldı");
            Messages.Add(-1006, "Belirtilen veritabanı kullanıcısı barındırma alanında zaten var");
            Messages.Add(-1007, "Belirtilen veritabanı kullanıcısı hedef serviste zaten var");
            Messages.Add(-1008, "MySQL veritabanı meta öğesi veritabanında bulunamadı");
            Messages.Add(-1009, "MySQL kullanıcı meta öğesi veritabanında bulunamadı");
            Messages.Add(-1010, "Belirtilen MySQL kullanıcı adı geçersiz.");
            Messages.Add(-1011, "Belirtilen MySQL veritabanı adı geçersiz.");
            Messages.Add(-1100, "Belirtilen kullanıcı adıyla kullanıcı hesabı veritabanında zaten var");
            Messages.Add(-1101, "Belirtilen FTP hesabı zaten var");
            Messages.Add(-1201, "Web Sitesi yok");
            Messages.Add(-1202, "Belirttiğiniz kullanıcı adı ve parola ile veritabanına bağlanılamadı");
            Messages.Add(-1203, "Seçili web sitesi zaten bazı uygulamalar yüklü");
            Messages.Add(-1204, "Seçili veritabanında zaten bazı uygulamalar yüklü");
            Messages.Add(-1301, "Seçili barındırma alanı için gelişmiş istatistik kaynağı kullanılamaz");
            Messages.Add(-1302, "İstatistik yüklemeleri kotasına ulaşıldı");
            Messages.Add(-1303, "Belirtilen istatistik yükleme barındırma alanında zaten var");
            Messages.Add(-1304, "Belirtilen istatistik yükleme hedef serviste zaten var");
            Messages.Add(-1305, "Gelişmiş istatistikler meta öğesi, veritabanında bulunamadı");
            Messages.Add(-1401, "SharePoint kaynakları seçili barındırma alanı için kullanılabilir değil");
            Messages.Add(-1402, "SharePoint kullanıcıları kotasına ulaşıldı");
            Messages.Add(-1403, "SharePoint kullanıcısı zaten barındırma alanında var");
            Messages.Add(-1404, "SharePoint kullanıcısı zaten hedef serviste var");
            Messages.Add(-1405, "SharePoint grupları kotasına ulaşıldı");
            Messages.Add(-1406, "SharePoint grubu zaten barındırma alanı içinde var");
            Messages.Add(-1407, "SharePoint grubu zaten hedef serviste var");
            Messages.Add(-1408, "SharePoint kullanıcı meta öğesi veritabanında bulunamadı");
            Messages.Add(-1409, "SharePoint grubu meta öğesi veritabanında bulunamadı");
            Messages.Add(-1410, "SharePoint siteleri kotasına ulaşıldı");
            Messages.Add(-1501, "Barındırma Planı silinemedi");
            Messages.Add(-1502, "Barındırma Eklentisi silinemedi");
            Messages.Add(-1601, "IP Adresi silinemedi");
            Messages.Add(-1602, "IP Adresi silinemedi");
            Messages.Add(-1701, "Sunucu silinemedi");
            Messages.Add(-1702, "Sunucu silinemedi");
            Messages.Add(-1703, "Sunucu silinemedi");
            Messages.Add(-1801, "Servis silinemedi");
            Messages.Add(-1802, "Servis silinemedi");
            Messages.Add(-1901, "SMTP Hatası: Hatalı Komut Sırası");
            Messages.Add(-1902, "SMTP Hatası: Kullanıcı doğrulanamıyor fakat teslim denenecek");
            Messages.Add(-1903, "SMTP Hatası: İzin verilmeyen istemci");
            Messages.Add(-1904, "SMTP Hatası: Komut uygulanmadı");
            Messages.Add(-1905, "SMTP Hatası: Komut parametresi uygulanmadı");
            Messages.Add(-1906, "SMTP Hatası: Komut tanınmadı");
            Messages.Add(-1907, "SMTP Hatası: Ayrılan depolama alanı aşıldı");
            Messages.Add(-1908, "SMTP Hatası: Genel hata");
            Messages.Add(-1909, "SMTP Hatası: Yetersiz depolama alanı");
            Messages.Add(-1910, "SMTP Hatası: İşleme sırasında yerel hata");
            Messages.Add(-1911, "SMTP Hatası: Posta kutusu meşgul");
            Messages.Add(-1912, "SMTP Hatası: Posta kutusu adına izin verilmiyor");
            Messages.Add(-1913, "SMTP Hatası: Posta kutusu kullanılamıyor");
            Messages.Add(-1914, "SMTP Hatası: Önce TLS ile başlamalı");
            Messages.Add(-1915, "SMTP Hatası: Servis aktarım kanalını kapatıyor");
            Messages.Add(-1916, "SMTP Hatası: Servis kullanılamıyor");
            Messages.Add(-1917, "SMTP Hatası: Sözdizimi hatası");
            Messages.Add(-1918, "SMTP Hatası: İşlem başarısız oldu");
            Messages.Add(-1919, "SMTP Hatası: Kullanıcı yerel değil, alternatif yolları dene");
            Messages.Add(-1920, "SMTP Hatası: Kullanıcı yerel değil, iletilecek");
            Messages.Add(-1921, "SMTP Hatası: Bilinmeyen hata");
            Messages.Add(-2001, "SharePoint kaynakları seçili alan için kullanılabilir değil");
            Messages.Add(-2003, "Hedef alanda SharePoint sitesi zaten var");
            Messages.Add(-2004, "SharePoint site meta öğesi veritabanında bulunamadı");
            Messages.Add(-2101, "İşletim Sistemi kaynakğı seçili alan için kullanılabilir değil");
            Messages.Add(-2102, "ODBC DSN'leri kota sınırına ulaşıldı");
            Messages.Add(-2103, "Belirtilen ada sahip ODBC DSN hedef alanda zaten var");
            Messages.Add(-2104, "Belirtilen ada sahip ODBC DSN hedef hizmette zaten var");
            Messages.Add(-2105, "ODBC DSN meta öğesi veritabanında bulunamadı");
            Messages.Add(-2200, "Zamanlanmış Görevler kotasına ulaşıldı");
            Messages.Add(-2400, "Yedekler geçici klasörü bulunmuyor ya da yazılamaz");
            Messages.Add(-2401, "Yedekler hedef klasörü bulunmuyor ya da yazılamaz");
            Messages.Add(-2501, "Geçersiz yedekleme sağlandı");
            Messages.Add(-2502, "Yedekleme kaynağı erişilemez");
            Messages.Add(-2503, "Yedekleme kaynağı bulunamadı");
            Messages.Add(-2601, "Belirtilen ID'de Exchange Organizasyonu zaten var.");
            Messages.Add(-2602, "Belirtilen e-posta adresi zaten kullanımda.");
            Messages.Add(-2605, "Exchange organizasyonları kotasına ulaşıldı");
            Messages.Add(-2606,
                "Exchange organizasyonu silindi fakat işlem sırasında bazı sorunlar oluştu. Lütfen ayrıntılı bilgi için WebsitePanel Server günlüğünü kontrol edin.");
            Messages.Add(-2607, "Exchange posta kutusu kotasına ulaşıldı");
            Messages.Add(-2608, "Exchange kişileri kotasına ulaşıldı");
            Messages.Add(-2609, "Exchange dağıtım listesi kotasına ulaşıldı");
            Messages.Add(-2610, "Exchange ortak klasörler kotasına ulaşıldı");
            Messages.Add(-2611, "Exchange etki alanları kotasına ulaşıldı");
            Messages.Add(-2612, "Belirtilen depolama alanı kotası ana bilgisayar seviyesinin maksimum değerini aştı");
            Messages.Add(-2701, "Bu kimliğe sahip organizasyon zaten var.");
            Messages.Add(-2702, "Lütfen farklı bir e-posta adresi belirtin.");
            Messages.Add(-2703, "Organizasyonlar kotasına ulaşıldı.");
            Messages.Add(-2704, "Organizasyon etki alanı belirtilmedi.");
            Messages.Add(-2705, "Etki alanı zaten kullanımda.");
            Messages.Add(-2706,
                "Organizasyon silindi fakat işlem sırasında bazı sorunlar oluştu. Lütfen daha fazla ayrıntı için WebsitePanel Sunucu günlüğünü kontrol edin.");
            Messages.Add(-2707, "Kullanıcı kotasına ulaşıldı.");
            Messages.Add(-2708,
                "CRM organizasyonunda kullanılan kullanıcı hesabı silinemiyor. Kullanıcı hesabını silmek yerine sistemde devre dışı bırakabilirsiniz.");
            Messages.Add(-2709, "OCS'de kullanıldığı için kullanıcı hesabı silinemiyor.");
            Messages.Add(-3000, "Dosya/klasörü kendi üzerine kopyalanamıyor ya da taşınamıyor.");
            Messages.Add(-3001, "Klasörün içindeki alt klasörler taşınamıyor ya da kopyalanamıyor.");
            Messages.Add(-3002, "Hedef dizin bulunamadı.");
            Messages.Add(-3003, "Varolan bir klasör ile aynı isimli dosya oluşturulamaz.");
            Messages.Add(-3004, "Varolan dosya ya da klasörün üzerine taşınamıyor.");
            Messages.Add(-3333,
                "Bu eylemi gerçekleştirirken beklenmeyen bir hata oluştu. Daha fazla bilgi için denetim günlüğünü kontrol edin.");
        }

        private static void LoadResourceStrings()
        {
            /********************************************************************** 
             *  WebsitePanel_SharedResources.ascx.tr-TR.resx dosyasından bu stringler alınmıştır
             *  Solution Items altına eklenmiştir
             *  Websitepanel App_GlobalResources klasöründe bulunabilir
             *  WebsitePanel_SharedResources.ascx.resx (ingilizce) solution items altına eklenmiştir
             *********************************************************************/

            ResourceStrings.Add("Quota.BlackBerry.Users", "Organizasyonlara göre BlackBerry Kullanıcıları");
            ResourceStrings.Add("Quota.DNS.Editor", "DNS Düzenleyici");
            ResourceStrings.Add("Quota.DNS.PrimaryZones", "B2B Birincil Bölgeler İzinli");
            ResourceStrings.Add("Quota.DNS.SecondaryZones", "B2B İkincil Bölgeler İzinli");
            ResourceStrings.Add("Quota.DNS.Zones", "B2B Bölgeleri Numarası");
            ResourceStrings.Add("Quota.Exchange2007.ActiveSyncAllowed", "ActiveSync Erişimine İzin Verildi");
            ResourceStrings.Add("Quota.Exchange2007.ActiveSyncEnabled", "ActiveSync Varsayılan Olarak Etkin");
            ResourceStrings.Add("Quota.Exchange2007.Contacts", "Organizasyon başına Kişiler");
            ResourceStrings.Add("Quota.Exchange2007.DiskSpace", "Maks Posta Kutusu Boyutu, MB");
            ResourceStrings.Add("Quota.Exchange2007.DistributionLists", "Organizasyon başına Dağıtım Listeleri");
            ResourceStrings.Add("Quota.Exchange2007.Domains", "Organizasyon başına Etki Alanları");
            ResourceStrings.Add("Quota.Exchange2007.IMAPAllowed", "IMAP Erişimi İzinli");
            ResourceStrings.Add("Quota.Exchange2007.IMAPEnabled", "IMAP Varsayılan olarak Etkin");
            ResourceStrings.Add("Quota.Exchange2007.Mailboxes", "Organizasyonlara göre Posta kutuları");
            ResourceStrings.Add("Quota.Exchange2007.MailEnabledPublicFolders", "Posta Etkin Ortak Klasörleri İzinli");
            ResourceStrings.Add("Quota.Exchange2007.MAPIAllowed", "MAPI Erişimi İzinli");
            ResourceStrings.Add("Quota.Exchange2007.MAPIEnabled", "MAPI Varsayılan Olarak Etkin");
            ResourceStrings.Add("Quota.Exchange2007.Organizations", "Exchange 2007 Organizasyonları");
            ResourceStrings.Add("Quota.Exchange2007.OWAAllowed", "OWA/HTTP Erişimi İzinli");
            ResourceStrings.Add("Quota.Exchange2007.OWAEnabled", "OWA/HTTP Erişimi Varsayılan olarak Etkin");
            ResourceStrings.Add("Quota.Exchange2007.POP3Allowed", "POP3 Erişimi İzinli");
            ResourceStrings.Add("Quota.Exchange2007.POP3Enabled", "POP3 Varsayılan Olarak Etkin");
            ResourceStrings.Add("Quota.Exchange2007.PublicFolders", "Organizasyon başına Ortak Klasör");
            ResourceStrings.Add("Quota.FTP.Accounts", "FTP Hesapları");
            ResourceStrings.Add("Quota.HostedCRM.Organization", "CRM Organizasyonu");
            ResourceStrings.Add("Quota.HostedCRM.Users", "Organizasyon başına CRM kullanıcıları");
            ResourceStrings.Add("Quota.HostedSharePoint.MaxStorage", "Maks site depolama alanı , MB");
            ResourceStrings.Add("Quota.HostedSharePoint.Sites", "Organizasyon başına SharePoint Site Koleksiyonları");
            ResourceStrings.Add("Quota.HostedSolution.Domains", "Organizasyon başına Etki Alanları");
            ResourceStrings.Add("Quota.HostedSolution.Organizations", "Organizasyonlar");
            ResourceStrings.Add("Quota.HostedSolution.Users", "Organizasyon Başına Kullanıcı Sayısı");
            ResourceStrings.Add("Quota.Mail.Accounts", "Posta Hesapları");
            ResourceStrings.Add("Quota.Mail.Forwardings", "Posta İletmeleri");
            ResourceStrings.Add("Quota.Mail.Groups", "Posta Grupları");
            ResourceStrings.Add("Quota.Mail.Lists", "Posta Listeleri");
            ResourceStrings.Add("Quota.Mail.MaxBoxSize", "Maks Posta Kutusu Boyutu, MB");
            ResourceStrings.Add("Quota.Mail.MaxGroupMembers", "Maks Grup Alıcıları");
            ResourceStrings.Add("Quota.Mail.MaxListMembers", "Maks Liste Alıcıları");
            ResourceStrings.Add("Quota.MsSQL2000.Backup", "Veritabanı Yedekleri");
            ResourceStrings.Add("Quota.MsSQL2000.Databases", "Veritabanları");
            ResourceStrings.Add("Quota.MsSQL2000.MaxDatabaseSize", "Maks Veritabanı Boyutu, MB");
            ResourceStrings.Add("Quota.MsSQL2000.MaxLogSize", "Maks Günlük Boyutu, MB");
            ResourceStrings.Add("Quota.MsSQL2000.Restore", "Veritabanı Geri Yüklemeleri");
            ResourceStrings.Add("Quota.MsSQL2000.Truncate", "Veritabanı Kes");
            ResourceStrings.Add("Quota.MsSQL2000.Users", "Kullanıcılar");
            ResourceStrings.Add("Quota.MsSQL2005.Backup", "Veritabanı Yedekleri");
            ResourceStrings.Add("Quota.MsSQL2005.Databases", "Veritabanları");
            ResourceStrings.Add("Quota.MsSQL2005.MaxDatabaseSize", "Maks Veritabanı Boyutu, MB");
            ResourceStrings.Add("Quota.MsSQL2005.MaxLogSize", "Maks Günlük Boyutu, MB");
            ResourceStrings.Add("Quota.MsSQL2005.Restore", "Veritabanı Geri Yüklemeleri");
            ResourceStrings.Add("Quota.MsSQL2005.Truncate", "Veritabanı Kes");
            ResourceStrings.Add("Quota.MsSQL2005.Users", "Kullanıcılar");
            ResourceStrings.Add("Quota.MsSQL2008.Backup", "Veritabanı Yedekleri");
            ResourceStrings.Add("Quota.MsSQL2008.Databases", "Veritabanları");
            ResourceStrings.Add("Quota.MsSQL2008.MaxDatabaseSize", "Maks Veritabanı Boyutu, MB");
            ResourceStrings.Add("Quota.MsSQL2008.MaxLogSize", "Maks Günlük Boyutu, MB");
            ResourceStrings.Add("Quota.MsSQL2008.Restore", "Veritabanı Geri Yüklemeleri");
            ResourceStrings.Add("Quota.MsSQL2008.Truncate", "Veritabanı Kes");
            ResourceStrings.Add("Quota.MsSQL2008.Users", "Kullanıcılar");
            ResourceStrings.Add("Quota.MySQL4.Backup", "Veritabanı Yedekleri");
            ResourceStrings.Add("Quota.MySQL4.Databases", "Veritabanları");
            ResourceStrings.Add("Quota.MySQL4.Users", "Kullanıcılar");
            ResourceStrings.Add("Quota.MySQL5.Backup", "Veritabanı Yedekleri");
            ResourceStrings.Add("Quota.MySQL5.Databases", "Veritabanları");
            ResourceStrings.Add("Quota.MySQL5.Users", "Kullanıcılar");
            ResourceStrings.Add("Quota.OCS.ArchiveFederatedIMConversation", "Şirket Dışı Mesajları Arşivleme İzinli");
            ResourceStrings.Add("Quota.OCS.ArchiveFederatedIMConversationByDefault",
                "Varsayılan Olarak Şirket Dışı Mesajları Arşivleme Etkin");
            ResourceStrings.Add("Quota.OCS.ArchiveIMConversation", "İç İleti Arşivleme İzinli");
            ResourceStrings.Add("Quota.OCS.ArchiveIMConvervationByDefault", "Varsayılan Olarak İç İleti Arşivleme Etkin");
            ResourceStrings.Add("Quota.OCS.Federation", "Federasyon İzinli");
            ResourceStrings.Add("Quota.OCS.FederationByDefault", "Varsayılan Olarak Federasyon Etkin");
            ResourceStrings.Add("Quota.OCS.PresenceAllowed", "Gelişmiş İletişim Durumuna İzin Verildi");
            ResourceStrings.Add("Quota.OCS.PresenceAllowedByDefault",
                "Gelişmiş İletişim Durumu Varsayılan olarak Etkin (Not: Gelişmiş iletişim durumu, ayarlandıktan sonra değiştirilemez)");
            ResourceStrings.Add("Quota.OCS.PublicIMConnectivity", "Ortak Anlık İleti Bağlantısı İzinli");
            ResourceStrings.Add("Quota.OCS.PublicIMConnectivityByDefault",
                "Ortak Anlık İleti Bağlantısı Varsayılan Olarak Etkin");
            ResourceStrings.Add("Quota.OCS.Users", "Organizasyon başına OCS Kullanıcıları");
            ResourceStrings.Add("Quota.OS.AppInstaller", "Uygulama Yükleyicisi");
            ResourceStrings.Add("Quota.OS.Bandwidth", "Bant Genişliği, MB");
            ResourceStrings.Add("Quota.OS.Diskspace", "Disk Alanı, MB");
            ResourceStrings.Add("Quota.OS.DomainPointers", "Etki Alanı Diğer Adları");
            ResourceStrings.Add("Quota.OS.Domains", "Etki Alanları");
            ResourceStrings.Add("Quota.OS.ExtraApplications", "Ekstra Uygulama Paketleri");
            ResourceStrings.Add("Quota.OS.FileManager", "Dosya Yöneticisi");
            ResourceStrings.Add("Quota.OS.MinimumTaskInterval", "Minimum Görev Aralığı, dakika");
            ResourceStrings.Add("Quota.OS.ODBC", "ODBC DSN'ler");
            ResourceStrings.Add("Quota.OS.ScheduledIntervalTasks", "Aralıklı Görevler İzinli");
            ResourceStrings.Add("Quota.OS.ScheduledTasks", "Zamanlanmış Görevler");
            ResourceStrings.Add("Quota.OS.SubDomains", "Alt Etki Alanları");
            ResourceStrings.Add("Quota.SharePoint.Groups", "SharePoint Grupları");
            ResourceStrings.Add("Quota.SharePoint.Sites", "SharePoint Siteleri");
            ResourceStrings.Add("Quota.SharePoint.Users", "Share Point Kullanıcıları");
            ResourceStrings.Add("Quota.Stats.Sites", "İstatistikler Siteleri");
            ResourceStrings.Add("Quota.VPS.Bandwidth", "Aylık bant genişliği, GB");
            ResourceStrings.Add("Quota.VPS.BootCdAllowed", "CD'den Önyükleme'ye izin verildi");
            ResourceStrings.Add("Quota.VPS.BootCdEnabled", "CD'den Önyükleme");
            ResourceStrings.Add("Quota.VPS.CpuNumber", "CPU çekirdekleri sayısı");
            ResourceStrings.Add("Quota.VPS.DvdEnabled", "DVD sürücüsü");
            ResourceStrings.Add("Quota.VPS.ExternalIPAddressesNumber", "Dış IP adresleri sayısı");
            ResourceStrings.Add("Quota.VPS.ExternalNetworkEnabled", "Dış Ağ");
            ResourceStrings.Add("Quota.VPS.Hdd", "Sabit Disk boyutu, GB");
            ResourceStrings.Add("Quota.VPS.ManagingAllowed", "Kullanıcıya VPS oluşturma, silme izni ver");
            ResourceStrings.Add("Quota.VPS.NumLockEnabled", "\"Num Lock\" ön tanımlı");
            ResourceStrings.Add("Quota.VPS.PauseResumeAllowed", "Kullanıcıya VPS Durdurma, Devam Ettirme izni ver");
            ResourceStrings.Add("Quota.VPS.PrivateIPAddressesNumber", "VPS başına Özel IP adresleri sayısı");
            ResourceStrings.Add("Quota.VPS.PrivateNetworkEnabled", "Özel Ağ");
            ResourceStrings.Add("Quota.VPS.Ram", "RAM boyutu, MB");
            ResourceStrings.Add("Quota.VPS.RebootAllowed", "Kullanıcıya VPS Yeniden Başlatma izni ver");
            ResourceStrings.Add("Quota.VPS.ReinstallAllowed", "Kullanıcıya VPS Yeniden Yükleme izni ver");
            ResourceStrings.Add("Quota.VPS.ResetAlowed", "Kullanıcıya VPS Sıfırlama izni ver");
            ResourceStrings.Add("Quota.VPS.ServersNumber", "VPS Sayısı");
            ResourceStrings.Add("Quota.VPS.SnapshotsNumber", "Anlık Görüntü Sayısı");
            ResourceStrings.Add("Quota.VPS.StartShutdownAllowed", "Kullanıcıya VPS Başlatma, Kapatma izni ver");
            ResourceStrings.Add("Quota.Web.AppPools", "Adanmış Uygulama Havuzları");
            ResourceStrings.Add("Quota.Web.Asp", "ASP");
            ResourceStrings.Add("Quota.Web.AspNet11", "ASP.NET 1.1");
            ResourceStrings.Add("Quota.Web.AspNet20", "ASP.NET 2.0");
            ResourceStrings.Add("Quota.Web.AspNet40", "ASP.NET 4.0");
            ResourceStrings.Add("Quota.Web.CFVirtualDirectories", "ColdFusion Sanal Dizinleri");
            ResourceStrings.Add("Quota.Web.CgiBin", "CGI-BIN Klasörü");
            ResourceStrings.Add("Quota.Web.ColdFusion", "ColdFusion");
            ResourceStrings.Add("Quota.Web.DefaultDocs", "Özel Varsayılan Belgeler");
            ResourceStrings.Add("Quota.Web.Errors", "Özel Hatalar");
            ResourceStrings.Add("Quota.Web.FrontPage", "FrontPage");
            ResourceStrings.Add("Quota.Web.Headers", "Özel Üstbilgiler");
            ResourceStrings.Add("Quota.Web.HomeFolders", "Site/Sanal Klasör Ana Klasörü Değiştiriliyor");
            ResourceStrings.Add("Quota.Web.IPAddresses", "Adanmış IP Adresleri");
            ResourceStrings.Add("Quota.Web.Mime", "Özel Mime Türleri");
            ResourceStrings.Add("Quota.Web.Perl", "Perl");
            ResourceStrings.Add("Quota.Web.Php4", "PHP 4.x");
            ResourceStrings.Add("Quota.Web.Php5", "PHP 5.x");
            ResourceStrings.Add("Quota.Web.Python", "Python");
            ResourceStrings.Add("Quota.Web.Redirections", "Web Siteleri Yönlendirmesi");
            ResourceStrings.Add("Quota.Web.RemoteManagement", "Uzak Web Yönetimi");
            ResourceStrings.Add("Quota.Web.SecuredFolders", "Güvenli Klasörler");
            ResourceStrings.Add("Quota.Web.Security", "Özel Güvenlik Ayarları");
            ResourceStrings.Add("Quota.Web.SharedSSL", "PaylaşılanSSL Klasörleri");
            ResourceStrings.Add("Quota.Web.Sites", "Web Siteleri");
            ResourceStrings.Add("Quota.Web.VirtualDirs", "Sanal Dizinler");
            ResourceStrings.Add("Quota.Web.WebAppGallery", "Microsoft Web App Galerisi");
        }

        public static void SetConnection(WebServicesClientProtocol obj, string EnterpriseServerUrl, string Username,
            string Password)
        {
            EnterpriseServerProxyConfigurator configurator = new EnterpriseServerProxyConfigurator
            {
                EnterpriseServerUrl = EnterpriseServerUrl,
                Username = Username,
                Password = Password
            };
            configurator.Configure(obj);
        }

        public static void SetConnection(WebServicesClientProtocol obj,LibraryObjects.Server server)
        {
            EnterpriseServerProxyConfigurator configurator = new EnterpriseServerProxyConfigurator
            {
                EnterpriseServerUrl = server.ServerControlPanelApiUrl,
                Username = server.ServerControlPanelApiUsername,
                Password = CryptoUtils.Decrypt(server.ServerContorlPanelApiPassword, server.ServerCryptoKey)
            };
            configurator.Configure(obj);
        }

        public static string GetMessage(int errorcode)
        {
            if (Messages.ContainsKey(errorcode))
                return Messages[errorcode];

            return string.Format("WebsitePanel Hata {0}", errorcode);
        }

        public static string GetResourceString(string key)
        {
            if (ResourceStrings.ContainsKey(key))
                return ResourceStrings[key];

            return "";
        }

        public static string GetResourceString(string className, string key)
        {
            string newKey = className + "." + key;

            return GetResourceString(newKey);
        }

        public static string GetExceedingQuotasMessage(DataSet ds)
        {
            if (ds == null || ds.Tables[0].Rows.Count == 0)
                return "";

            List<string> quotas = new List<string>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                quotas.Add(String.Format("{0} ({1})",
                    GetResourceString("Quota." + dr["QuotaName"]),
                    dr["QuotaValue"]));
            }
            return "Aşağıdaki kotalar, izin verilen değerlerini aşacak:" + String.Join(", ", quotas.ToArray());
        }
    }

}