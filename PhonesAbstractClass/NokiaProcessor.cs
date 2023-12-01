using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonesAbstractClass
{
    internal class NokiaProcessor : IProcessor
    {
        public override void constructProcessor() => Console.WriteLine("Nokia processor was created");

    }
}
