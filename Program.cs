using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;

namespace API
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var client = new HttpClient();
            //var KanyeUrl = "https://api.kanye.rest";
            //var kresponse = client.GetStringAsync(KanyeUrl).Result;
            //var kfinal = JObject.Parse(kresponse).GetValue("quote").ToString();

            ////Console.WriteLine(kfinal);

            //var client2 = new HttpClient();
            //var ronUrl = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            //var swonResponse = client2.GetStringAsync(ronUrl).Result;
            //var sfinal = JArray.Parse(swonResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            //// Console.WriteLine(sfinal);

            //for (int i = 0; i < 5; i++)
            //{
                
            //    Console.WriteLine($"KANYE : {kfinal} , " +
            //                                $"_____" +
            //                      $"SWON  : {sfinal}");
            //}
            var client = new HttpClient();
           // var apiKey = "70143570d636ac6152d5366b10cad78c\r\n"
           // var url = "https://api.openweathermap.org/data/2.5/weather?q={cityname}&appid={apikey}";
            Console.WriteLine("what is your api key");
           var apikey =  Console.ReadLine();
            Console.WriteLine("desired city to check weather");
            var cityname = Console.ReadLine();
            var url1 = $"https://api.openweathermap.org/data/2.5/weather?q={cityname}&appid={apikey}&units=imperial";
            var response = client.GetStringAsync(url1).Result;
            var rootObject = JObject.Parse(response);
            Console.WriteLine(rootObject["main"]["temp"]);



            //var main = JObject.Parse(response).GetValue("main").ToString();
            //var temp = JObject.Parse(main).GetValue("temp");
            //Console.WriteLine(temp);




        }
    }
}
