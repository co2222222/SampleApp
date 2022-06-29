using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SampleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SampleClass sc = new SampleClass();

            Console.WriteLine("Enter a range start value");
            sc.StartRange = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a range end value");
            sc.EndRange = Convert.ToInt32(Console.ReadLine());
            
            sc.GetResult();
            Console.WriteLine($"Result: {sc.Result}");
            string json = JsonConvert.SerializeObject(sc);
            //Console.WriteLine(json);
            JObject jsonObject = JObject.Parse(json);
            Console.WriteLine(jsonObject);
        }
    }
}