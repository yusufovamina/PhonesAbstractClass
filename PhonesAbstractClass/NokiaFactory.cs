using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonesAbstractClass
{
    internal class NokiaFactory : IFactory
    {
        public IPhone_ constructPhone() => new Nokia();

        public IProcessor constructProcessor() => new NokiaProcessor();

    }
}
