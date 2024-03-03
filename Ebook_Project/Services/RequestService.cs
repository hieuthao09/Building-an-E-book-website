using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text;
using Newtonsoft.Json.Linq;
using System.Web.UI;
using Ebook_Project.Models;
using RestSharp;
using System.Net.Http.Headers;
using System.Web.Helpers;

namespace Ebook_Project.Services
{
    public class RequestService
    {
        public const string BASEURL = "http://localhost:8899/";

        public const string LIST_EBOOK = "api/Data/GetListEBooks";
        public const string LOGIN = "api/Auth/Login";
        public const string REGISTER = "api/Auth/Register";
        public const string LIST_NEWS = "api/Data/GetListNews";
        public const string NUM_OF_PAGE = "api/Data/GetNumOfPage";
        public const string TOKEN = "api/Token/GetToken";
        public const string BOOK_DETAIL = "api/Data/GetEBookById";
        public const string SEARCH = "api/Data/Search";
        public const string ADDTOCART = "api/Payment/AddToCart";
        public const string COOKIES = "api/Token/GetCookies";
        public const string LIST_GIOHANG = "api/Payment/GetListGioHang";
        public const string CONFIRM_PAY = "api/Payment/SendConfirmPayment";
        public const string EBOOK_OWNER = "api/Data/ShowEbookOwner";
        public const string REMOVE_ITEM_CART = "api/Payment/DeleteItemFromCart";
        public const string DOWNLOAD_BOOK_OWNER = "api/Data/GetFile";


        public static string MakeRequestGet(string URI, string token = null)
        {
            var httpClient = new HttpClient();
            if(token != null)
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);            
            Task<HttpResponseMessage> res = httpClient.GetAsync(BASEURL + URI);
            Task<string> result = res.Result.Content.ReadAsStringAsync();
            return result.Result;
        }

        public static string MakeRequestDelete(string URI, string token = null)
        {
            var httpClient = new HttpClient();
            if (token != null)
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            Task<HttpResponseMessage> res = httpClient.DeleteAsync(BASEURL + URI);
            Task<string> result = res.Result.Content.ReadAsStringAsync();
            return result.Result;
        }

        public static string MakeJsonBody(List<KeyValuePair<string, string>> items, bool strMode)
        {
            string str = "{";
            for(int i = 0; i < items.Count; i++)
            {
                if(items[i].Value.All(e => char.IsDigit(e)) && !strMode)
                    str += string.Format("\"{0}\":{1}", items[i].Key, items[i].Value);
                else
                    str += string.Format("\"{0}\":\"{1}\"",items[i].Key, items[i].Value);

                if (i < items.Count - 1)
                    str += ",";
            }
            str += "}";

            return str;
        }

        public static string MakePOSTRequest(string URI, StringContent jsonBody, string token = null)
        {
            var httpClient = new HttpClient();
            if (token != null)
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            Task<HttpResponseMessage> res = httpClient.PostAsync(BASEURL + URI, jsonBody);

            Task<string> result = res.Result.Content.ReadAsStringAsync();
            return result.Result;
        }

        public static JObject createRequest(string url, Method method, List<KeyValuePair<string, string>> header = null, List<KeyValuePair<string, string>> body = null)
        {
            var client = new RestClient(url);
            var request = new RestRequest(method);
            if (header != null && header.Count > 0)
            {
                for (int i = 0; i < body.Count; i++)
                {
                    request.AddHeader(header[i].Key, header[i].Value);
                }
            }

            if (body != null && body.Count > 0)
            {
                for (int i = 0; i < body.Count; i++)
                {
                    request.AddParameter(body[i].Key, body[i].Value) ;
                }
            }


            IRestResponse response = client.Execute(request);
            var content = response.Content;
            var res = (JObject)JsonConvert.DeserializeObject(content);
            return res;
        }


        //============================
        //call API DATA
        //============================
        public static string sendReqListBook(int page=1, int num = 10)
        {
            string query = string.Format("?page={0}&numItem={1}", page, num);
            string res = MakeRequestGet(LIST_EBOOK + query);
            return res;
        }

        public static string sendReqBookDetail(string id)
        {
            string query = string.Format("?SachId={0}", id);
            string res = MakeRequestGet(BOOK_DETAIL + query);
            return res;
        }

        public static string sendReqListTinTuc(int page = 1, int num = 4)
        {
            string query = string.Format("?page={0}&numItem={1}", page, num);
            string res = MakeRequestGet(LIST_NEWS + query);
            return res;
        }

        public static string sendReqNumOfPage(int size = 3)
        {
            string query = string.Format("?size={0}", size);
            string res = MakeRequestGet(NUM_OF_PAGE + query);
            return res;
        }

        public static string sendReqSearch(string value)
        {
            string query = "?value="+value;
            return MakeRequestGet(SEARCH + query);
        }
        //============================
        //CALL API AUTH
        //============================
        public static JObject sendReqLogin(Account account)
        {
            List<KeyValuePair<string, string>> body = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("username", account.Email),
                new KeyValuePair<string, string>("password", account.Password),
                new KeyValuePair<string, string>("typeAccount", "KH")
            };
            JObject res = createRequest(BASEURL + LOGIN, Method.POST, null, body);
            return res;
        }

        public static string sendReqJWT(string uid)
        {
            try
            {
                string query = "?userId=" + uid;
                return MakeRequestGet(TOKEN + query);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public static string sendReqRegister(Account acc)
        {
            List<KeyValuePair<string, string>> kpbody = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("Email",acc.Email),
                new KeyValuePair<string, string>("Password",acc.Password),
                new KeyValuePair<string, string>("NameUser",acc.NameUser),
                new KeyValuePair<string, string>("Sdt",acc.Sdt)
            };

            string body = MakeJsonBody(kpbody, true);
            StringContent jsonContent = new StringContent(body, Encoding.UTF8, "application/json");

            return MakePOSTRequest(REGISTER, jsonContent, null);
        }
        //============================
        //CALL API PAY
        //============================

        public static string sendReqAddToCart(string email, string maSach, string token)
        {
            List<KeyValuePair<string, string>> kpbody = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("email",email),
                new KeyValuePair<string, string>("eBookId",maSach)
            };

            //string res = MakeRequestGet(COOKIES);
            //JObject json = JObject.Parse(res);

            string body = MakeJsonBody(kpbody, true);
            StringContent jsonContent = new StringContent(body, Encoding.UTF8, "application/json");

            return MakePOSTRequest(ADDTOCART, jsonContent, token);
        }

        public static string sendReqConfirmPay(string email, string token)
        {
            List<KeyValuePair<string, string>> kpbody = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("email",email),
                new KeyValuePair<string, string>("eBookId", "")
            };

            //string res = MakeRequestGet(COOKIES);
            //JObject json = JObject.Parse(res);

            string body = MakeJsonBody(kpbody, true);
            StringContent jsonContent = new StringContent(body, Encoding.UTF8, "application/json");

            return MakePOSTRequest(CONFIRM_PAY, jsonContent, token);
        }

        public static string sendReqGetListGioHang(string email, string token)
        {
            string query = "?email=" + email;
            return MakeRequestGet(LIST_GIOHANG + query, token);
        }

        public static string sendReqShowEbookOwner(string email, string token)
        {
            //string res = MakeRequestGet(COOKIES);
            //JObject json = JObject.Parse(res);

            string textJson = "\""+email+"\"";
            StringContent jsonContent = new StringContent(textJson, Encoding.UTF8, "text/json");

            return MakePOSTRequest(EBOOK_OWNER, jsonContent, token);
        }
        public static string sendReqDownloadEbookOwner(string fileName)
        {
            //string res = MakeRequestGet(COOKIES);
            //JObject json = JObject.Parse(res);

            string query = "?fileName=" + fileName;

            return BASEURL + DOWNLOAD_BOOK_OWNER + query;
        }

        public static string sendReqRemoveItemFromCart(string SachId, string email, string token)
        {
            string query = string.Format("?SachId={0}&email={1}", SachId, email);
            return MakeRequestDelete(REMOVE_ITEM_CART + query, token);
        }

    }
}