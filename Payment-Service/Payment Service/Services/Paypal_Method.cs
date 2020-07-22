namespace Payment_Service.Services
{
    class Paypal_Method : IPayMethod
    {
        public double TaxMethod(double Amount, int i_install)
        {
            double installTax = 0.01 * i_install;
            double NewAmount = Amount * (1 + installTax); // 1% - taxa de parcelamento
            return NewAmount * 1.02; // 1% - taxa de serviço do Paypal
        }
    }
}
