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
            
        }
    }
}