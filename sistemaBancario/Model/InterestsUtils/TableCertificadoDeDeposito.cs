using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.InterestsUtils
{
    public class TableCertificadoDeDeposito : TermInterest, InterestTable
    {

        private decimal _amount;
        private int _termInDays;

        public decimal Amount
        {
            get
            {
                return _amount;
            }

            set
            {
                _amount = value;
            }
        }

        public double AnnualInterest
        {
            get
            {
                if(_termInDays >= 30 && _termInDays <= 59)
                {
                    return 0.054; // 5.40 %
                }
                if (_termInDays >= 60 && _termInDays <= 89)
                {
                    return 0.057; // 5.70 %
                }
                if (_termInDays >= 90 && _termInDays <= 149)
                {
                    return 0.063; // 6.30 %
                }
                if (_termInDays >= 150 && _termInDays <= 179)
                {
                    return 0.0945; // 9.45 %
                }
                if (_termInDays >= 180 && _termInDays <= 209)
                {
                    return 0.0995; // 9.95 %
                }
                if (_termInDays >= 210 && _termInDays <= 239)
                {
                    return 0.1;  // 10 %
                }
                if (_termInDays >= 240 && _termInDays <= 269)
                {

                }
                if (_termInDays >= 270 && _termInDays <= 359)
                {

                }
                if (_termInDays >= 360 && _termInDays <= 719)
                {

                }
                if (_termInDays >= 720 && _termInDays <= 1079)
                {

                }
                if (_termInDays >= 1080 && _termInDays <= 1439)
                {

                }
                if (_termInDays >= 1440 && _termInDays <= 1799)
                {

                }
                if (_termInDays >= 1800)
                {
                    return 0.093; // 9.3 %
                }
                return 1.0;
            }
        }

        public int Term
        {
            get
            {
                return _termInDays;
            }

            set
            {
                _termInDays = value;
            }
        }
    }
}
