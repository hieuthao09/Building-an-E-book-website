using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ebook_Project.Services
{
    public class GoogleProvider
    {
        public static JObject loginGoogle(string code)
        {
            var client = new RestClient("https://www.googleapis.com/oauth2/v4/token");
            var request = new RestRequest(Method.POST);
            request.AddParameter("grant_type", "authorization_code");
            request.AddParameter("code", code);
            request.AddParameter("redirect_uri", "http://localhost:51323/Login/GoogleLogin");
            request.AddParameter("client_id", "687789064070-b0u7bbb65o9kbnck3vvlbtqc6l79m0mj.apps.googleusercontent.com");
            request.AddParameter("client_secret", "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");
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            var res = (JObject)JsonConvert.DeserializeObject(content);

            var client2 = new RestClient("https://www.googleapis.com/oauth2/v1/userinfo");
            client2.AddDefaultHeader("Authorization", "Bearer" + res["access_token"]);
            request = new RestRequest(Method.GET);
            var response2 = client2.Execute(request);
            var content2 = response2.Content;
            return (JObject)JsonConvert.DeserializeObject(content2);

        }
    }
}