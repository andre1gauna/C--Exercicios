namespace Payment_Service.Services
{
    interface IPayMethod
    {
        double TaxMethod(double Amount, int i_install);
    }
}
