using System;
using System.Text;
using System.Collections.Generic;
using System.Globalization;

namespace Controle_estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            Console.WriteLine("Entre com os dados do produto");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preco: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p);

            Console.Write("Digite Quantas unidades do produto devem ser adicionados ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.Alterar(qte);
            Console.WriteLine("Dados do produto: " + p);
            Console.Write("Digite Quantas unidades do produto devem ser removidas do estoque: ");
            qte = -(int.Parse(Console.ReadLine()));
            p.Alterar(qte);
            Console.WriteLine("Dados do produto: " + p);
        }
    }
}
