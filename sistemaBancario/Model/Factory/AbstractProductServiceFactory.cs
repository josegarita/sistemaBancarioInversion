using Model.Products;
using Model.Verifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Factory
{
    public abstract class AbstractProductServiceFactory
    {
        abstract public ServiceVerifier createVerify();
        abstract public SavingInvestementProduct createProduct();
    }

}
