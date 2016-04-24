using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ProductServiceMessage
    {
        public bool CanBeOpen
        {
            set;
            get;
        }

        public bool ApplyTax
        {
            set;
            get;
        }

        public string Message
        {
            set;
            get;
        }
    }
}
