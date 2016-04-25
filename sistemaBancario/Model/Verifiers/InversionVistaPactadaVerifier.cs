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

        public InversionVistaPactadaVerifier()
        {
            //Valores por defecto 
            this.miniumTermInDays = 15;
        }

        public int MiniumTermInDays
        {
            get { return miniumTermInDays; }
            set { miniumTermInDays = value; }
        }

      
        public override ProductServiceMessage canServiceBeOpen()
        {
            ProductServiceMessage message = new ProductServiceMessage();

            if (this.miniumTermInDays <= this.product.TermInDays)
            {
                message.CanBeOpen = true;
            }
            else
            {
                message.CanBeOpen = false;
            }


            return message;
        }
    }
}
