using Model.Products;
using Model.Verifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Factory
{
    abstract class AbstractProductService
    {
        abstract public ServiceVerifier createVerify();
        abstract public SavingInvestementProduct createProduct();
    }

}
