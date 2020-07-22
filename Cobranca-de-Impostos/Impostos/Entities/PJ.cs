using System;
using System.Collections.Generic;
using System.Text;

namespace Impostos.Entities
{
    class PJ : Pessoa
    {
        public int Nfunc { get; set; }
        private double Taxa;

        public PJ()
        {
        }

        public PJ(string nome, double rendaAnual, int nfunc) :base(nome, rendaAnual)
        {
            Nfunc = nfunc;
        }

        public override double Imposto()
        {
            if (Nfunc > 10)
            {
                Taxa = 0.14;
            }
            else
                Taxa = 0.16;

            return RendaAnual * Taxa;
        }
    }
}
