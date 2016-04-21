using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaBancario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hola");
            Console.ReadKey();
        }
    }


    abstract class abstractProductService {
        abstract public void createVerify();
        abstract public void createProduct();
    }

    class cuentaCorrienteFactory : abstractProductService {
        public override void createVerify()
        {
            throw new NotImplementedException();
        }
        public override void createProduct()
        {
            throw new NotImplementedException();
        }
    }

    class certificadoFactory : abstractProductService {
        public override void createVerify()
        {
            throw new NotImplementedException();
        }
        public override void createProduct()
        {
            throw new NotImplementedException();
        }

    }

    class pactoFactory : abstractProductService {
        public override void createVerify()
        {
            throw new NotImplementedException();
        }
        public override void createProduct()
        {
            throw new NotImplementedException();
        }
    }

}
