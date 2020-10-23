using System;
using Lizandra.Interfaces.Entities;

namespace Lizandra.Interfaces
{
    public class ServicoDeAluguel
    {
        public decimal PrecoPorHora { get; private set; }
        public decimal PrecoPorDia { get; private set; }

        public ServicoDeAluguel(decimal precoPorHora, decimal precoPorDia)
        {
            PrecoPorHora = precoPorHora;
            PrecoPorDia = precoPorDia;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            decimal total = 0m;
            if (duration.TotalHours <= 12)
            {
                total = PrecoPorHora * (decimal) Math.Ceiling(duration.TotalHours);
            }
            else
            {
                total = PrecoPorDia * (decimal) Math.Ceiling(duration.TotalDays);
            }

            Console.WriteLine($"Total {total}");
        }
    }
}