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
            switch (productType)
            {
                case "CertificadoDeDeposito":
                    return new CertificadoDeDepositoFactory();
                case "InversionVistaPactada":
                    return new InversionVistaPactaFactory();
                case "CuentaCorriente":
                    return new CuentaCorrienteFactory();
                default:
                    return null;
            }
        }
    }
}
