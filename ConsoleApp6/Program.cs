using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //var pic = File.ReadAllBytes("hotel.jpg");
            //var text = Convert.ToBase64String(pic);
            //Console.WriteLine(text);
            var client = new WebClient();
            var response = client.DownloadString("http://localhost:50052/api/Hotels");
            Console.WriteLine(response);
            Console.WriteLine("eeee");
            Console.ReadKey();
        }
    }
}
