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
            // setting up the url to take the user through spotify auth 
            string clientid = Environment.GetEnvironmentVariable("sprecoid");
            string url = "https://accounts.spotify.com/authorize?client_id=" +
                          clientid +
                          "&response_type=code"+
                          "&redirect_uri=https://localhost:44336/home/callback" +
                          "&scope=user-read-private%20user-read-email%20user-read-recently-played%20user-top-read" +
                          "&state=123";

            ViewBag.AuthUrl = url;

            return View();
        }
        
        // this is working 
        private void getRecentTracks(string access_token)
        {
            var client = _clientFactory.CreateClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", access_token);
            var response = client.GetAsync("https://api.spotify.com/v1/me/player/recently-played").Result;

            string responseString = response.Content.ReadAsStringAsync().Result; 

            Console.WriteLine(responseString); 
        }


        // this worked 
        // need to pass in artist id, track id
        private void getSimilarTracks(string access_token)
        {
            // need to pass this in later 
            string artist = "0Y5tJX1MQlPlqiwlOH1tJY";
            string track = "3dtBVBClM5ms0qCBBrqpUb"; 

            var client = _clientFactory.CreateClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", access_token);

            string url = "https://api.spotify.com/v1/recommendations?" +
                          "seed_artists=" + artist +
                          "&seed_tracks=" + track; 

            var response = client.GetAsync(url).Result;

            string responseString = response.Content.ReadAsStringAsync().Result;

            Console.WriteLine(responseString);

        }
        public IActionResult Callback(string code)
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

            // using .Result causes the thread to block until the async function is done so consider changing this to make it faster 
            var response = client.PostAsync("https://accounts.spotify.com/api/token", formContent).Result;

            var responseContent = response.Content;

            // using .Result causes the thread to block until the async function is done so consider changing this to make it faster 
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

            // first we need to get the recently played tracks - we could make a class to store the information we need 
            // second we need to get tracks that are similar to each recently played track and map them together 
            // third we need to get all the cover at and titles for all tracks to display 
            // lastly we need to make it look good 

            getSimilarTracks(access_token); 

            return View(); 
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
