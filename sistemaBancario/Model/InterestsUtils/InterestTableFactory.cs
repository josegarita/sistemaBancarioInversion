using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.InterestsUtils
{
    class InterestTableFactory
    {
        public static InterestTable GetInterestTableFor(string productType)
        {
            switch (productType)
            {
                case "CuentaCorrienteColones":
                    return new TableCuentaCorriente();
                case "CertificadoDeDepositoColones":
                    return new TableCertificadoDeDeposito();
                case "InversionVistaPactadaColones":
                    return new TableInversionVistaPactadaColones();
                case "InversionVistaPactadaDolares":
                    return new TableInversionVistaPactadaDolares();
                default:
                    return null;
            }
        }
    }
}
