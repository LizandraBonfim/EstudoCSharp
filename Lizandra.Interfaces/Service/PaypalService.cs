using System.Dynamic;

namespace Lizandra.Interfaces
{
    public class PaypalService : IOnlinePaymentService
    {
        private decimal JurosSimples = 0.01m;
        private decimal JurosComposto = 0.02m;
        
        public decimal PaymentFee(decimal amount)
        {
            return amount * JurosSimples;
        }

        public decimal Interest(decimal amount, int mount)
        {
            return amount * mount * JurosComposto;
        }
    }
}