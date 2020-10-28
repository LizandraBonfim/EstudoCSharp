using System;
using System.Collections.Generic;

namespace Lizandra.Interfaces
{
    public class Produto : IComparable
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public Categoria Categoria { get; set; }

        public Produto(string id, string nome, decimal preco, Categoria categoria)
        {
            Nome = nome;
            Preco = preco;
            this.Id = id;
            this.Categoria = categoria;
        }

        public override string ToString()
        {
            return $"Produto: {Nome} / {Id} - Preco: {Preco} - Categoria: {Categoria.Name}";
        }

        public int CompareTo(object? obj)
        {
            if (!(obj is Produto))
            {
                throw new ArgumentException("Não é um produto");
            }

            Produto prod = obj as Produto;
            return Preco.CompareTo(prod.Preco);
        }
    }
}