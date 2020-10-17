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
            List<Employee> list = new List<Employee>();

            Console.WriteLine("Digite quantos funcionaros você deseja:");
            int data = int.Parse(Console.ReadLine());

            for (int i = 0; i < data; i++)
            {
                Console.WriteLine("Digite o nome do funcionario:");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite o total de horas trabalhadas:");
                decimal hora = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor por hora:");
                decimal valorPorHora = decimal.Parse(Console.ReadLine());

                Console.WriteLine("O funcionario é terceiro?");
                char terceiro = char.Parse(Console.ReadLine());

                if (terceiro == 's' || terceiro == 'S')
                {
                    Console.WriteLine("Digite o valor adicional ");

                    decimal valorAdicional = decimal.Parse(Console.ReadLine());
                    list.Add(new OutSourceEmployee(nome, hora, valorPorHora, valorAdicional));
                }

                else list.Add(new Employee("Liz", 25, 50.5m));

                Console.WriteLine("Teste");
            }

            foreach (var items in list)
            { 
                Console.WriteLine(items.ToString());
            }

            Console.ReadKey();
        }
    }
}