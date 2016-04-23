using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Verifiers
{
    class CertificadoDeDepositoVerifier:ServiceVerifier
    {
        private int miniumTermInDays;

        public int MiniumTermInDays
        {
            get { return miniumTermInDays; }
            set { miniumTermInDays = value; }
        }
        //constructor
        public CertificadoDeDepositoVerifier() { 
        
        }

        public void/*productMessage*/ applyTax() {
            //return productMessage
        }
    }
}
