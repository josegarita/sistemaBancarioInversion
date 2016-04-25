using Model.Verifiers;
using Model.Products;


namespace Model.Factory
{
    class InversionVistaPactadaFactory : AbstractProductServiceFactory
    {
        public override ServiceVerifier createVerify()
        {
            InversionVistaPactadaVerifier cuenta = new InversionVistaPactadaVerifier();
            return cuenta;
           
        }

        public override SavingInvestementProduct createProduct()
        {
            InversionPactada cuenta = new InversionPactada();
            
            return cuenta;
        }
    }
}
