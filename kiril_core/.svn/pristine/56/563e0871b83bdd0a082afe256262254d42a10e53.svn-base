
namespace Markum.Cloud.Libraries.Mail.Net
{    
    public class MEConnection
    {
        private string url;

        public string Url 
        {
            get
            {
                return url;
            }
            set
            {
                // / (slash) ile bitmediğinden emin ol
                // MEServices sınıfında / ekliyoruz
                string tmp = value;
                if (tmp != null && tmp.EndsWith("/"))
                {
                    tmp = tmp.TrimEnd('/');
                }
                url = tmp;
            }
        }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Timeout { get; set; }

        public MEConnection()
        {
            // Web servislerin default timeout değeri
            // bkz. WebClientProtocol.Timeout property
            // Bu yüzden varsayılan değer olarak bunu kullanıyoruz
            // milliseconds
            Timeout = 100000;  
        }
        public MEConnection(string url)
            : this()
        {
            Url = url;
        }
        public MEConnection(string url, string username, string password)
            : this(url)
        {
            Username = username;
            Password = password;
        }
    }
}