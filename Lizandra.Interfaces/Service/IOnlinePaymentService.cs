namespace Lizandra.Interfaces
{
    public interface IOnlinePaymentService
    {
        public decimal PaymentFee(decimal amount);
        public decimal Interest(decimal amount, int mount);
    }
}