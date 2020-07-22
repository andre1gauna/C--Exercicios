using System;
using Impostos.Entities;
using System.Collections.Generic;
namespace Impostos
{
    class Program
    {
        static double total = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o numero de Contribuintes");
            int contrib = int.Parse(Console.ReadLine());
            List < Pessoa > Pessoas = new List<Pessoa>();
            for (int i=0;i<contrib; i++)
            {
                Console.WriteLine($"Pagador {i + 1}");
                Console.Write("Insira o tipo de pessoa (PF ou PJ): ");
                string tipoP = Console.ReadLine();
                if (tipoP == "PF".ToLower())
                {
                    Console.Write("Insira o nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Insira a renda anual: ");
                    double renda = double.Parse(Console.ReadLine());
                    Console.Write("Insira o valor de gastos com saúde: ");
                    double gastoS = double.Parse(Console.ReadLine());
                    Pessoas.Add(new PF(nome, renda, gastoS));
                }
                else if (tipoP == "PJ".ToLower())
                    {
                        Console.Write("Insira o nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Insira a renda anual: ");
                        double renda = double.Parse(Console.ReadLine());
                        Console.Write("Insira o numero de funcionarios: ");
                        int func = int.Parse(Console.ReadLine());
                        Pessoas.Add(new PJ(nome, renda, func));
                    }
            }
            
            foreach(Pessoa p in Pessoas)
            {
                Console.WriteLine($"{p.Nome} $ {p.Imposto().ToString("F2")}");
                total += p.Imposto();
            }

            Console.WriteLine($"Total de imposto: {total.ToString("F2")}");
        }
    }
}
