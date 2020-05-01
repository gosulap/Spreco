using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using Spreco.Models;

namespace Spreco.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IHttpClientFactory _clientFactory; 

        public HomeController(ILogger<HomeController> logger, IHttpClientFactory clientFactory)
        {
            _logger = logger;
            _clientFactory = clientFactory;
        }

        public IActionResult Index()
        {
            string clientid = Environment.GetEnvironmentVariable("sprecoid");
            string url = "https://accounts.spotify.com/authorize?client_id=" +
                          clientid +
                          "&response_type=code"+
                          "&redirect_uri=https://localhost:44336/home/callback" +
                          "&scope=user-read-private%20user-read-email" +
                          "&response_type=token" +
                          "&state=123";

            ViewBag.AuthUrl = url;

            return View();
        }
        

        public async Task<IActionResult> CallbackAsync(string code)
        {
            // things are the # are not even sent to the server so we cant see it here

            // make a post request to get access and refresh tokens 

            var client = _clientFactory.CreateClient(); 
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(Environment.GetEnvironmentVariable("sprecoid") + ":" + Environment.GetEnvironmentVariable("sprecosecret"))));

            FormUrlEncodedContent formContent = new FormUrlEncodedContent(new[]
            {
                        new KeyValuePair<string, string>("code", code),
                        new KeyValuePair<string, string>("redirect_uri", "https://localhost:44336/home/callback"),
                        new KeyValuePair<string, string>("grant_type", "authorization_code"),
             });

            var response = client.PostAsync("https://accounts.spotify.com/api/token", formContent).Result;

            var responseContent = response.Content;
            string responseString = responseContent.ReadAsStringAsync().Result;

            // access and refresh tokens are in this responsestring 
            var json = JObject.Parse(responseString); 

            string access_token = (string) json["access_token"];
            string refresh_token = (string)json["refresh_token"];
            string expires_in = (string)json["expires_in"];

            Console.WriteLine(access_token);
            Console.WriteLine(refresh_token);
            Console.WriteLine(expires_in); 

            // now we can use the api and get some actual information 

            return View(); 
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
