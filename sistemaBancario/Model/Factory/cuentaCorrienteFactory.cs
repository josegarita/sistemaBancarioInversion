using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Products;
using Model.Verifiers;

namespace Model.Factory
{
    class CuentaCorrienteFactory : AbstractProductServiceFactory
    {
        public override ServiceVerifier createVerify()
        {
            CuentaCorrienteVerifier cuenta = new CuentaCorrienteVerifier();
            
            return cuenta;
           
        }
        public override SavingInvestementProduct createProduct()
        {
            CuentaCorriente cuenta = new CuentaCorriente();
            
            return cuenta;
        }
    }

}
