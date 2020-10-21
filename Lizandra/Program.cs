using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Lizandra.Banco.Entities;
using Lizandra.Banco.Entities.Enums;

namespace Lizandra.Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inicio");

            string entrada = @"/home/werter/Documentos/temp/text.csv";

            try
            {
                string[] list = File.ReadAllLines(entrada);
                string pasta = Path.GetDirectoryName(entrada);
                string pastaSaida = pasta + @"/out";
                string arquivoSaida = pastaSaida + @"/saida.csv";

                Path.Combine(pasta, pastaSaida, "saida.csv");

                Directory.CreateDirectory(pastaSaida);

                using (StreamWriter sw = File.AppendText(arquivoSaida))
                {
                    foreach (var item in list)
                    {
                        string[] pro = item.Split(',');

                        string nome = pro[0];
                        decimal preco = decimal.Parse(pro[1]);
                        int qtd = int.Parse(pro[2]);

                        ProdutoBuilder prod = new ProdutoBuilder(nome, preco, qtd);

                        sw.WriteLine(prod.Nome + ", " + prod.Total());
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}