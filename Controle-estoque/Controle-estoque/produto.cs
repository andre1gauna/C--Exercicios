using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Controle_estoque
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;
        
        public double ValTot ()
        {
            return Quantidade * Preco;
        }
        public void Alterar (int qtdAdd)
        {
            Quantidade += qtdAdd;
            qtdAdd = 0;
        }

        public override string ToString()
        {
            return Nome + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + " Quantidade: "
                + Quantidade
                + " Unidades. Valor total: "
                + ValTot();
        }

    }
}
