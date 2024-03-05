using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace bll
{
    public  class CallAPI
    {
        private readonly string baseUrl = "http://blackhorse404-001-site1.anytempurl.com";

        public CallAPI(string baseUrl)
        {
            this.baseUrl = baseUrl;
        }
        public CallAPI()
        {

        }
        public async Task<Object> GetApiDataAsync(string endpoint)
        {
       
            string apiUrl = baseUrl + endpoint;

            try
            {
                HttpWebRequest req = HttpWebRequest.CreateHttp(apiUrl);
                WebResponse res = req.GetResponse();
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(OTPEmail));
                Object data = jsonSerializer.ReadObject(res.GetResponseStream());
                return data;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi khi có lỗi trong quá trình gọi API
                return "Lỗi: " + ex.Message;
            }
        }
        public async Task CallWebAPIAsync()
        {
            
        }
        public async Task<string> PostApiDataAsync(string title, string email,string parameter1, string parameter2)
        {
            string endpoint = "/api/data"; // Thay đổi endpoint của API của bạn
            string apiUrl = $"{baseUrl}{endpoint}";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Tạo đối tượng FormUrlEncodedContent để truyền tham số
                    var data = new FormUrlEncodedContent(new[]
                    {
                        new KeyValuePair<string, string>(email, parameter1),
                        new KeyValuePair<string, string>(title, parameter2),
                    });

                    HttpResponseMessage response = await client.PostAsync(apiUrl, data);

                    if (response.IsSuccessStatusCode)
                    {
                        string result = await response.Content.ReadAsStringAsync();
                        return result;
                    }
                    else
                    {
                        return "Lỗi: " + response.StatusCode.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.Message;
            }
        }
    }
    public class OTPEmail
    {
        // Đối tượng này phản ánh cấu trúc của JSON bạn đang nhận được
        public string Email { get; set; }
        public string otpCode { get; set; }
        public long ExpiresTime { get; set; }
    }
}

