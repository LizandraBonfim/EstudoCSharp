using System;

namespace Lizandra.Interfaces
{
    public class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int month)
        {
            var parcelas = contract.TotalValor / month;
            for (int i = 1; i <= month; i++)
            {
                DateTime qtdPar = contract.Data.AddMonths(1);

                var atualizaValorSimples = parcelas + _onlinePaymentService.PaymentFee(parcelas);
                var atualizaValorComposto = parcelas + _onlinePaymentService.Interest(atualizaValorSimples, i);
                
                contract.AddInstallment(new Installment(atualizaValorComposto, qtdPar));
            }
        }
    }
}