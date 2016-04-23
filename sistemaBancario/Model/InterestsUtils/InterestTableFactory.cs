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
                case "CuentaCorriente":
                    return new TableCurrentAccountInterest();
                default:
                    return null;
            }
        }
    }
}
