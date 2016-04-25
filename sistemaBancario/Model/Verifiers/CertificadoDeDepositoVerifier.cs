using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Verifiers
{
    class CertificadoDeDepositoVerifier : ServiceVerifier
    {
        private int miniumTermInDays;

        //constructor
        public CertificadoDeDepositoVerifier()
        {
            //Valores por defecto para el certificado de depósito
            this.miniumTermInDays = 30;
        }

        public int MiniumTermInDays
        {
            get { return miniumTermInDays; }
            set { miniumTermInDays = value; }
        }


        public void/*productMessage*/ applyTax() {
            //return productMessage
        }

        public override ProductServiceMessage canServiceBeOpen()
        {
            ProductServiceMessage message = new ProductServiceMessage();

            this.calculateMinimumAmount();

            if (this.miniumMoneyAmount <= this.product.Amount && this.miniumTermInDays <= this.product.TermInDays)
            {
                message.CanBeOpen = true;
                message.Message = "se puede abrir";
            }
            else
            {
                message.CanBeOpen = false;

                message.Message = "La cantidad mínima de días debe ser : " 
                    + System.Convert.ToString(this.miniumTermInDays) 
                    + " y la cantidad mínima del monto debe ser: " 
                    + System.Convert.ToString(this.miniumMoneyAmount); 
            }

            return message;

        }

        private void calculateMinimumAmount()
        {
            int termInDaysForTheProduct = this.product.TermInDays;

            if (termInDaysForTheProduct >= 30 && termInDaysForTheProduct <= 89)
            {
                this.miniumMoneyAmount = 100000; // 100 000 colones
            }
            else if (termInDaysForTheProduct >= 90)
            {
                this.miniumMoneyAmount = 50000; // 50 000 colones
            }
           
        }
    }
}
