using System.Collections.Generic;
using Payment_Service.Entities;

namespace Payment_Service.Services
{
    class PayServ
    {
        public int InstNum { get; set; }

        private IPayMethod _payMethod;
        public PayServ(int instNum, IPayMethod payMethod)
        {
            InstNum = instNum;
            _payMethod = payMethod;
        }

        public List<Installment> Inst_Processing(Contract contract)
        {
            double InstValue = contract.TotalValue / InstNum;
            List<Installment> Installments = new List<Installment>();
            for (int i = 0; i < InstNum; i++)
            {
                Installments.Add(new Installment(contract.Date.AddMonths(i + 1), _payMethod.TaxMethod(InstValue, (i + 1))));
            }
            
            return Installments;
        }
        
    }
}
