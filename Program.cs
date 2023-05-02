using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace CS_Lab7
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Console.WriteLine("Which category would u like to see? ");

            string firstpart = "https://api.chucknorris.io/jokes/random?category=";

            string category = Console.ReadLine();

            string url = firstpart + category;

           

            var client = new RestClient(url);

            var request = new RestRequest();

            var response = client.Get(request);

            string final = response.Content.ToString();

            Console.WriteLine($"Your category is: {category}");
            

            string date = final.Substring(final.LastIndexOf("created_at"));
            date = date.Remove(date.IndexOf(","));
            date = date.Replace('"', ' ');


            string joke = final.Substring(final.LastIndexOf("value"));
            joke = joke.Remove(joke.IndexOf("}"));
            joke = joke.Replace('"', ' ');

            joke = joke.Replace ( "value","joke");

           


            Console.WriteLine(date);
            Console.WriteLine(joke);
            Console.Read();
        }
    }
}
