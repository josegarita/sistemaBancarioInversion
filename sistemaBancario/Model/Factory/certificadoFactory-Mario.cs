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
        public override ServiceVerifier createVerify()
        {
            CertificadoDeDepositoVerifier cuenta = new CertificadoDeDepositoVerifier();
            return cuenta;
           
        }
        public override SavingInvestementProduct createProduct()
        {
            CentificadoDeposito cuenta = new CentificadoDeposito();
            return cuenta;
           
        }

    }

}
