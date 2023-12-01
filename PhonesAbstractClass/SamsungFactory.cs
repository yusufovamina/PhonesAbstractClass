using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonesAbstractClass
{
    internal class SamsungFactory : IFactory
    {
        public IPhone_ constructPhone() => new Samsung();

        public IProcessor constructProcessor() => new SamsungProcessor();

    }
}
