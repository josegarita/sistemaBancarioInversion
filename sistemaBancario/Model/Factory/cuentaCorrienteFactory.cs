using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Products;
using Model.Verifiers;

namespace Model.Factory
{
    class cuentaCorrienteFactory : abstractProductService
    {
        public override CuentaCorrienteVerifier createVerify()
        {
            CuentaCorrienteVerifier cuenta = new CuentaCorrienteVerifier();
            return cuenta;
            throw new NotImplementedException();
        }
        public override CuentaCorriente createProduct()
        {
            CuentaCorriente cuenta = new CuentaCorriente();
            return cuenta;
            throw new NotImplementedException();
        }
    }

}
