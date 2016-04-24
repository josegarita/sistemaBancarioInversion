using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Verifiers
{
    class InversionVistaPactadaVerifier:ServiceVerifier
    {
        private int miniumTermInDays;

        public int MiniumTermInDays
        {
            get { return miniumTermInDays; }
            set { miniumTermInDays = value; }
        }

        public InversionVistaPactadaVerifier() {          

        }

        public override ProductServiceMessage canServiceBeOpen()
        {
            throw new NotImplementedException();
        }
    }
}
