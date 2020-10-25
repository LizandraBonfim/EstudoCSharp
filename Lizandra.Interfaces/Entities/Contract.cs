using System;
using System.Collections.Generic;

namespace Lizandra.Interfaces
{
    public class Contract
    {
        public decimal Numero { get; private set; }
        public DateTime Data { get; private set; }
        public decimal TotalValor  { get;  set; }
        public List<Installment> Installments {get; set;}

        public Contract(decimal numero, DateTime data, decimal total)
        {
            this.Numero = numero;
            this.Data = data;
            this.TotalValor = total;
            this.Installments = new List<Installment>();
        }

        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }
    }
}