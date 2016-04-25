using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.InterestsUtils
{
    class TableInversionVistaPactadaColones : InterestTable, TermInterest
    {
        private int _termInDays;

        public decimal Amount
        {
            get;
            set;
        }

        public int Term
        {
            get
            {
                return this._termInDays;
            }
            set
            {
                this._termInDays = value;
            }
        }

        public double AnnualInterest
        {
            get 
            {
                if (_termInDays >= 15 && _termInDays <= 29)
                {
                    return 0.0485;
                }
                if (_termInDays >= 30 && _termInDays <= 59)
                {
                    return 0.0494;
                }
                if (_termInDays >= 60 && _termInDays <= 89)
                {
                    return 0.0523;
                }
                if (_termInDays >= 90 && _termInDays <= 179)
                {
                    return 0.0581;
                }
                if (_termInDays >= 180 && _termInDays <= 269)
                {
                    return 0.0883;
                }
                if (_termInDays >= 270 && _termInDays <= 359)
                {
                    return 0.0869;
                }
                if (_termInDays >= 360 && _termInDays <= 719)
                {
                    return 0.0869;

                }
                if (_termInDays >= 720 && _termInDays <= 1079)
                {
                    return 0.0869;

                }
                if (_termInDays >= 1080 && _termInDays <= 1439)
                {
                    return 0.0869;

                }
                if (_termInDays >= 1440 && _termInDays <= 1799)
                {
                    return 0.0869;

                }
                if (_termInDays >= 1800)
                {
                    return 0.0869;
                }

                return 1.0;
            }
        }
    }
}
