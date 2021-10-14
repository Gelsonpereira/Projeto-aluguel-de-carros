using System;
using System.Globalization;
using Aluguel_de_carro.Entities;
using Aluguel_de_carro.Services;

namespace Aluguel_de_carro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre rental data");
            Console.Write("Car Modelo:");
            string modelo = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:ss); ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm ", CultureInfo.InvariantCulture);
            Console.Write("Pickup (dd/MM/yyyy hh:ss); ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm ", CultureInfo.InvariantCulture);

            Console.Write(" Entre price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            CarRental carRental = new CarRental(start, finish, new Vehicle(modelo));

            RentalService rentalservice = new RentalService(hour, day);

            rentalservice.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE: ");
            Console.WriteLine(carRental.Invoice);

        }
    }
}
