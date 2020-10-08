using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAPIDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            SWAPIHelper swapiHelper = new SWAPIHelper();

            Console.WriteLine("Enter the ID of the vehicle you would like to see");
            int requestedID = Convert.ToInt32(Console.ReadLine());
            VehicleModel requestedVehicle = swapiHelper.GetVehicleByIDAsync(requestedID).Result;

            Console.WriteLine(requestedVehicle.Name);
            Console.WriteLine(requestedVehicle.Model);
            Console.WriteLine(requestedVehicle.Cost_in_Credits);

            Console.ReadLine();
        }
    }
}
