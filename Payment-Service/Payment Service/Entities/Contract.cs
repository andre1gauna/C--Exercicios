using System;

namespace Payment_Service.Entities
{
    class Contract
    {
        public double Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }

        public Contract(double number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
        }
    }
}
