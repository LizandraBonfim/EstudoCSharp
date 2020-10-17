using System;
using System.Collections.Generic;
using Lizandra.Banco.Entities;
using Lizandra.Banco.Entities.Enums;

namespace Lizandra.Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> list = new List<Produto>();

            Produto prod = new Produto("IPhone", 5.845m);
            ProdutoImportado impot = new ProdutoImportado("Arroz" , 43.56m , 24.2m);
            ProdutoUsado usado = new ProdutoUsado("Note", 245.51m, DateTime.Parse("14/02/2002"));
            
            list.Add(prod);
            list.Add(impot);
            list.Add(usado);
            

            foreach (var items in list)
            { 
                Console.WriteLine(items.PrecoEtiqueta());
            }

            Console.ReadKey();
        }
    }
}