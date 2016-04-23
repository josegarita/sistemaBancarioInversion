using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Verifiers;
using Model.Products;

namespace Model.Factory
{
    class certificadoFactory : abstractProductService
    {
        public override CertificadoDeDepositoVerifier createVerify()
        {
            CertificadoDeDepositoVerifier cuenta = new CertificadoDeDepositoVerifier;
            return cuenta;
            throw new NotImplementedException();
        }
        public override CentificadoDeposito createProduct()
        {
            CentificadoDeposito cuenta = new CentificadoDeposito();
            return cuenta;
            throw new NotImplementedException();
        }

    }

}
