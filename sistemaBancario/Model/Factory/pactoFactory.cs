using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Verifiers;
using Model.Products;


namespace Model.Factory
{
    class pactoFactory : abstractProductService
    {
        public override InversionVistaPactadaVerifier createVerify()
        {
            InversionVistaPactadaVerifier cuenta = new InversionVistaPactadaVerifier();
            return cuenta;
            throw new NotImplementedException();
        }

        public override InversionPactada createProduct()
        {
            InversionPactada cuenta = new InversionPactada();
            return cuenta;
            throw new NotImplementedException();
        }
    }
}
