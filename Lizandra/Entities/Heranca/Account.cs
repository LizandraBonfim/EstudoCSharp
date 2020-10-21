using Lizandra.Banco.Entities.Exceptions;

namespace Lizandra.Banco.Entities
{
    public class Account
    {
        public decimal Numero { get; set; }
        public string Titular { get; set; }
        public decimal Saldo { get; set; }
        public decimal LimiteSaque { get; set; }
        
        public Account (){}

        public Account(decimal numero, string nome, decimal saldo, decimal limite)
        {
            this.Numero = numero;
            this.Titular = nome;
            this.Saldo = saldo;
            this.LimiteSaque = limite;
        }

        public void Deposito(decimal deposito)
        {
            Saldo += deposito;
        }

        public void Saque(decimal saque)
        {
            if(Saldo < saque)
                throw new DominioException("Saldo insuficiente");
            if(saque > LimiteSaque)
                throw  new DominioException($"Seu limite para saque diário é de: {LimiteSaque}");

            Saldo -= saque;
        }

        public override string ToString()
        {
            return $"Titular: {Titular}, Saldo: {Saldo}, Limite: {LimiteSaque}";
        }

      
    }
}