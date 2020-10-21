namespace Lizandra.Banco.Entities
{
    public class PessoaFisica : Renda
    {
        public decimal ValorGastoComSaude { get; set; }

        public PessoaFisica(string nome, decimal rendaAnual,decimal valorGastoComSaude) : base(nome, rendaAnual)
        {
            this.ValorGastoComSaude = valorGastoComSaude;
        }

        public PessoaFisica() {
        }

        public override decimal Impostos()
        {
            if (RendaAnual < 20000.00m)
                return (RendaAnual * 0.15m) - (RendaAnual - 0.50m);
            else
                return (RendaAnual * 0.25m) - (RendaAnual - 0.50m);
        }
        
        public override string Text()
        {
            return base.Text() + $"Total de valor gasto com saúde: {this.ValorGastoComSaude}, Impostos: {Impostos()}";
        }
    }
}