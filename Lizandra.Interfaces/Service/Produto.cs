using System;
using System.Collections.Generic;

namespace Lizandra.Interfaces
{
    public class Produto : IComparable
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public Produto(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override string ToString()
        {
            return $"Produto: {Nome} - Preco: {Preco}";
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