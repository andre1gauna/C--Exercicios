using System;
using Payment_Service.Entities;
using Payment_Service.Services;
using System.Collections.Generic;

namespace Payment_Service
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date: ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine());            
            Console.WriteLine("Installments: ");
            int i_installs = int.Parse(Console.ReadLine());

            Contract Contract = new Contract(number, date, value);

            PayServ Payserv = new PayServ(i_installs, new Paypal_Method());
            List<Installment> Installments = Payserv.Inst_Processing(Contract);
            double total = 0;
            foreach(Installment I in Installments)
            {
                Console.WriteLine(I.ToString());
                total += I.Amount;
            }
            Console.WriteLine($"Total: {total}");
            


            


        }
    }
}
