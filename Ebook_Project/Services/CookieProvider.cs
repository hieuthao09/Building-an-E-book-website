using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;

namespace Ebook_Project.Services
{
    public class CookieProvider
    {
        public static string getCookies()
        {
            return RequestService.MakeRequestGet("api/Token/GetCookies");
        }
    }
}