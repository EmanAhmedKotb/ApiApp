using System;
using System.Threading.Tasks;

namespace SampleConsoleUseAPI
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new System.Net.Http.HttpClient();
            var content = await client.GetStringAsync("https://localhost:44382/average?nums=5&nums=8&nums=7&nums=3&nums=2&nums=9");

            Console.WriteLine(content);
            Console.Read();
        }
    }
}
