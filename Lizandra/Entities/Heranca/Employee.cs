using System;

namespace Lizandra.Banco.Entities
{
    public class Employee
    {
        public string Nome { get;private set; }
        public decimal Hora { get; private set; }
        public decimal ValorPorHora { get; private set; }

        public Employee()
        {
            
        }

        public Employee(string nome, decimal hora, decimal valorPorHora)
        {
            Nome = nome;
            Hora = hora;
            ValorPorHora = valorPorHora;
        }

        public virtual decimal Pagamento()
        {
            return Hora * ValorPorHora;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}" +
                   $"Horas: {Hora}" +
                   $"Valor total a receber: {Pagamento()}";
        }
    }
}