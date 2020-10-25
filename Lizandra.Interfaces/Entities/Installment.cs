using System;
using System.Globalization;

namespace Lizandra.Interfaces
{
     public class Installment
     {
          public decimal Amount { get; set; }
          public DateTime Data { get; set; }

          public Installment(decimal amount, DateTime data)
          {
               this.Amount = amount;
               this.Data = data;
          }

          public override string ToString()
          {
               return $"{Data.ToString("dd/MM/yyyy")} - {Amount.ToString("f2", CultureInfo.CurrentCulture)}";
          }
     }
}