using System;
using System.Collections.Generic;
using System.Text;

namespace Produtos_comuns_usados_e_importados_.Entities
{
    class ImProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImProduct()
        {
        }

        public ImProduct(string name, double price, double customsFee)
               :base( name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            return base.PriceTag() + $" (Customs fee: $ {CustomsFee})";
        }

    }
}
