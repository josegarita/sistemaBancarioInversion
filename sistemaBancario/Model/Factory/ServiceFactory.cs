using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Factory
{
    public class ServiceFactory
    {
        public static AbstractProductServiceFactory GetFactoryFor (string productType)
        {
            /*
            string namespaceName = typeof(AbstractProductServiceFactory).Namespace;

            AbstractProductServiceFactory factory = null;

            string className = namespaceName + "." + productType + "Factory";

            factory = (AbstractProductServiceFactory)Activator.CreateInstance(Type.GetType(className));

            return factory;
             * */


              
            switch (productType)
            {
                case "CertificadoDeDeposito":
                    return new CertificadoDeDepositoFactory();
                case "InversionVistaPactada":
                    return new InversionVistaPactadaFactory();
                case "CuentaCorriente":
                    return new CuentaCorrienteFactory();
                case "VistaPactada":
                    return new InversionVistaPactadaFactory();
                default:
                    return null;
            }
           /* */
        }
    }
}
