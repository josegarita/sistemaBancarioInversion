﻿using System;
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
        public override ServiceVerifier createVerify()
        {
            InversionVistaPactadaVerifier cuenta = new InversionVistaPactadaVerifier();
            return cuenta;
           
        }

        public override SavingInvestementProduct createProduct()
        {
            InversionPactada cuenta = new InversionPactada();
            return cuenta;
            throw new NotImplementedException();
        }
    }
}
