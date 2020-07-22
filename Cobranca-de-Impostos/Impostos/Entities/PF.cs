using System;
using System.Collections.Generic;
using System.Text;
using Impostos.Entities;

namespace Impostos.Entities
{
    class PF : Pessoa
    {
        public double GSaude { get; set; }
        private double Taxa;

        public PF()
        {
        }

        public PF(string nome, double rendaAnual, double gSaude) :base(nome, rendaAnual)
        {
            GSaude = gSaude;
        }

        public override double Imposto()
        {
            if (RendaAnual <= 20000)
            {
                Taxa = 0.15;
            }
            else
                Taxa = 0.25;

            return (RendaAnual * Taxa) - (GSaude * 0.5);
        }

    }
}
