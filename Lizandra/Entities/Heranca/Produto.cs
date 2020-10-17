namespace Lizandra.Banco.Entities
{
    public class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public Produto() { }

        public Produto(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public virtual string PrecoEtiqueta()
        {
            return $"Produto: {Nome} Preco: {Preco} ";
        }
    }
}