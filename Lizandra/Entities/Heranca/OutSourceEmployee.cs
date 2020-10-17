namespace Lizandra.Banco.Entities
{
    public class OutSourceEmployee : Employee
    {
        public decimal ValorAdicional { get; private set; }
        
        public OutSourceEmployee(){}

        public OutSourceEmployee(string nome, decimal hora, decimal valorPorHora , decimal valorAdicional) 
            : base(nome, hora, valorPorHora)
        {
            this.ValorAdicional = valorAdicional;
        }

     
        public override decimal Pagamento()
        {
            return base.Pagamento() + (this.ValorAdicional * 1.1m);
        }
    }
}