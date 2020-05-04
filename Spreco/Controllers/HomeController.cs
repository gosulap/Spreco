using System;
using System.Collections;
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

/*
 * Things to add/change 
 * 1 - need to check if similar song already exists in users saved music - if it does dont show it 
 * 2 - add button next to each song "save songs" 
 * 3 - implement web player so people can listen to the song right here 
*/

namespace Spreco.Controllers
{
    public class Track
    {
        private string track_id;
        private string artist_id;
        private string track_name;
        private string artist_name;
        private List<string> images;

        public Track(string t_id, string a_id, string t_name, string a_name, List<string> images)
        {
            // could get rid of the "this" but left it in for clarity 
            this.track_id = t_id;
            this.artist_id = a_id;
            this.track_name = t_name;
            this.artist_name = a_name;
            this.images = new List<string>(images);
        }

        public string getTrackId()
        {
            return this.track_id;
        }
        public string getArtistId()
        {
            return this.artist_id;
        }
        public string getTrackName()
        {
            return this.track_name;
        }
        public string getArtistName()
        {
            return this.artist_name;
        }
        public List<string> getImages()
        {
            return this.images;
        }
    }


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
        // need this to return an array of tracks
        // ITLL GIVE US DUPLICATE TRACKS SO ELIMINATE ONES WE HAVE ALREADY SEEN
        private List<Track> getRecentTracks(string access_token)
        {

            List<Track> tracks = new List<Track>(); 

            var client = _clientFactory.CreateClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", access_token);

            var response = client.GetAsync("https://api.spotify.com/v1/me/player/recently-played").Result;
            string responseString = response.Content.ReadAsStringAsync().Result;

            HashSet<string> seen = new HashSet<string>(); 

            var data = JObject.Parse(responseString); 

            // when we refresh the callback page we get an error here so check it out later this could be a problem 
            foreach(var track in data["items"])
            {
                var track_object = JObject.Parse(track.ToString())["track"];
                var track_name = track_object["name"];
                var track_id = track_object["id"];
                if (!seen.Contains((string)track_id))
                {
                    var artist_id = track_object["artists"][0]["id"];
                    var artist_name = track_object["artists"][0]["name"];


                    List<string> image_urls = new List<string>();

                    image_urls.Add((string)track_object["album"]["images"][0]["url"]);
                    image_urls.Add((string)track_object["album"]["images"][1]["url"]);
                    image_urls.Add((string)track_object["album"]["images"][2]["url"]);

                    Track current = new Track((string)track_id, (string)artist_id, (string)track_name, (string)artist_name, image_urls);

                    //Console.WriteLine(current.getTrackName());
                    //Console.WriteLine(current.getArtistName());
                    //Console.WriteLine(current.getImages()[0]);

                    tracks.Add(current);
                    seen.Add((string)track_id);
                }

            }


            return tracks; 
           
        }


        // this worked 
        // need to get this to return an array of tracks 
        // need to pass in artist id, track id
        // we should also check for similar tracks that the user does not already have in a playlist 
        private List<Track> getSimilarTracks(string access_token, string seed_artist, string seed_track)
        {

            List<Track> tracks = new List<Track>(); 

            //need to pass this in later 
            //string artist_test = "0Y5tJX1MQlPlqiwlOH1tJY";
            //string track_test = "3dtBVBClM5ms0qCBBrqpUb"; 

            var client = _clientFactory.CreateClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", access_token);

            string url = "https://api.spotify.com/v1/recommendations?" +
                          "seed_artists=" + seed_artist +
                          "&seed_tracks=" + seed_track; 

            var response = client.GetAsync(url).Result;

            string responseString = response.Content.ReadAsStringAsync().Result;

            var data = JObject.Parse(responseString);

            foreach (var track in data["tracks"])
            {
                var track_object = JObject.Parse(track.ToString());
                var track_name = track_object["name"];
                var track_id = track_object["id"];
                var artist_id = track_object["artists"][0]["id"];
                var artist_name = track_object["artists"][0]["name"];


                List<string> image_urls = new List<string>();

                image_urls.Add((string)track_object["album"]["images"][0]["url"]);
                image_urls.Add((string)track_object["album"]["images"][1]["url"]);
                image_urls.Add((string)track_object["album"]["images"][2]["url"]);

                Track current = new Track((string)track_id, (string)artist_id, (string)track_name, (string)artist_name, image_urls);

                //Console.WriteLine(current.getTrackName());
                //Console.WriteLine(current.getArtistName());
                //Console.WriteLine(current.getImages()[0]);

                tracks.Add(current);

            }

            return tracks; 
        }

        // at some point i think the user shuold be able to input tracks that they want to see similar songs for 
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

            //Console.WriteLine(access_token);
            //Console.WriteLine(refresh_token);
            //Console.WriteLine(expires_in);

            // https://api.spotify.com/v1/me/tracks/contains 
            // this check if one or more tracks is already saved by the user in "your songs" 

            List<Track> recently_played = getRecentTracks(access_token);

            Dictionary<Track, List<Track>> trackMapping = new Dictionary<Track, List<Track>>();


            // go through all the recently played tracks
            foreach (var track in recently_played)
            {
                // for each track we need to get the similar tracks to it and associate the track with tracks that are similar
                trackMapping.Add(track, getSimilarTracks(access_token, track.getArtistId(), track.getTrackId())); 
            }

            foreach (KeyValuePair<Track, List<Track>> kvp in trackMapping)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                    kvp.Key.getTrackName(), kvp.Value[0].getTrackName());
            }

            ViewBag.mapping = trackMapping; 

            return View(); 
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
