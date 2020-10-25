using System;
using Lizandra.Interfaces.Entities;

namespace Lizandra.Interfaces
{
    public class ServicoDeAluguel
    {
        public decimal PrecoPorHora { get; private set; }
        public decimal PrecoPorDia { get; private set; }

        private ITaxService _taxService;
        public ServicoDeAluguel(decimal precoPorHora, decimal precoPorDia, ITaxService taxService)
        {
            PrecoPorHora = precoPorHora;
            PrecoPorDia = precoPorDia;
            _taxService = taxService;
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

            decimal tax = _taxService.Tax(total);
            carRental.Invoice = new Invoice(total, tax);

            Console.WriteLine($"Total {total}");
        }
    }
}