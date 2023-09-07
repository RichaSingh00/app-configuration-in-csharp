using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConfiguration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string animal = ConfigurationManager.AppSettings["Animal"];
            string phylum = ConfigurationManager.AppSettings["Phylum"];
            string order = ConfigurationManager.AppSettings["Order"];
            string species = ConfigurationManager.AppSettings["Species"];
            string subspecies = ConfigurationManager.AppSettings["Subspecies"];
            
            Console.WriteLine("Animal: " + animal);
            Console.WriteLine("Phylum: " + phylum);
            Console.WriteLine("Order: " + order);
            Console.WriteLine("Species: "+species);
            Console.WriteLine("Subspecies: "+subspecies);

            int intSubspecies = int.Parse(subspecies);

        }
    }
}
