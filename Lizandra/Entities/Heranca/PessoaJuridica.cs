namespace Lizandra.Banco.Entities
{
    public class PessoaJuridica : Renda
    {
        public decimal NumeroDeFuncionario { get; set; }

        public PessoaJuridica(string nome, decimal rendaAnual,decimal numeroDeFuncionario) : base(nome, rendaAnual)
        {
            this.NumeroDeFuncionario = numeroDeFuncionario;
        }

        public PessoaJuridica() {
        }

        public override decimal Impostos()
        {
            if (this.NumeroDeFuncionario >= 0.10m)
                return RendaAnual - 0.14m;
            else 
                return RendaAnual -0.16m;
        }

        public override string Text()
        {
            return  base.Text() + $"Num de funcionarios: {NumeroDeFuncionario}, Impostos: {Impostos()}";
        }
    }
}