using System;

namespace pensao_da_véia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira uma string para ter seu prifmeiro caractere alterado");
            string alterar = Console.ReadLine();
            Console.WriteLine($" {alterar.Change()}");

            //Rooms[] pensao = new Rooms[10];            
            //Console.WriteLine("Insira o numero de hóspedes a serem registrados");
            //int hosp = int.Parse(Console.ReadLine());
            //int i = 0;
            //for (i = 0; i < hosp; i++)
            //{
            //    Console.WriteLine("Insira o quarto desejado (de 0 à 9), nome e email");
            //    int quarto = int.Parse(Console.ReadLine());
            //    string nome = Console.ReadLine();
            //    string email = Console.ReadLine();
            //    pensao[quarto] = new Rooms {  Name= nome, Email = email};
            //}

            //for (i=0; i<10; i++)
            //{
            //    if (pensao[i] != null)
            //    {
            //        Console.WriteLine(" Quarto: " + i);
            //        Console.WriteLine(" Nome: " + pensao[i].Name);
            //        Console.WriteLine(" Em-Mail: " + pensao[i].Email);

            //    }
            //}


        }
    }
}
