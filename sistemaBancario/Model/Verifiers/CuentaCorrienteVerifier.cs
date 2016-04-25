using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.Verifiers
{
    class CuentaCorrienteVerifier : ServiceVerifier
    {

        public CuentaCorrienteVerifier()
        { 
            //Valores default para las cuentas corrientes
            this.currency = Products.MoneyType.Colones;
            this.miniumMoneyAmount = 25000;
        }

        public override ProductServiceMessage canServiceBeOpen()
        {
            ProductServiceMessage message = new ProductServiceMessage();

            if (this.product.Amount >= this.miniumMoneyAmount)
            {
                message.CanBeOpen = true;
                message.Message = "Se cumple el monto mínimo";
            }
            else
            {
                message.CanBeOpen = false;
                message.Message = "Ingresó: " + System.Convert.ToString(this.product.Amount) + " y el mínimo debe ser: " + System.Convert.ToString(this.miniumMoneyAmount);
            }

            return message;
        }
    }
}
