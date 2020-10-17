namespace Lizandra.Banco.Entities
{
    public class ProdutoImportado : Produto
    {
        public decimal CustoImportado { get; set; }
        
        public ProdutoImportado(){}

        public ProdutoImportado(string nome, decimal preco, decimal custoImportado)
            : base(nome, preco)
        {
            this.CustoImportado = custoImportado;
        }

        public override string PrecoEtiqueta()
        {
            return base.PrecoEtiqueta() + $"Custom fre ${CustoImportado}";
        }

        public decimal PrecoTotal()
        {
            return this.Preco + this.CustoImportado;
        }
    }
}