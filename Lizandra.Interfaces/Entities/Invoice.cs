namespace Lizandra.Interfaces.Entities
{
    public class Invoice
    {
        public decimal Pagamento { get; set; }
        public decimal Taxa { get; set; }
        
        public decimal PagamentoTotal
        {
            get { return Pagamento * Taxa; }
        }

        public Invoice(decimal pagamento, decimal taxa)
        {
            Pagamento = pagamento;
            Taxa = taxa;
        }

        public override string ToString()
        {
            return $"Pagamento: {Pagamento}\n" +
                   $"Taxa: {Taxa}\n" +
                   $"Pagamento Total: {PagamentoTotal}";
        }
    }
}