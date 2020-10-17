using System;

namespace Lizandra.Banco.Entities
{
    public class ProdutoUsado : Produto
    {
        public DateTime Fabricacao { get; set; }
        
        public ProdutoUsado(){}

        public ProdutoUsado(string nome, decimal preco, DateTime fabricacao)
            : base(nome, preco)
        {
            this.Fabricacao = fabricacao;
        }

        public override string PrecoEtiqueta()
        {
            return base.PrecoEtiqueta() + $"(usado) (Fab: {Fabricacao}";
        }
    }
}