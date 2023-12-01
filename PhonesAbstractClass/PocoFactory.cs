using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonesAbstractClass
{
    internal class PocoFactory : IFactory
    {
        public IPhone_ constructPhone() => new Poco();

        public IProcessor constructProcessor() => new PocoProcessor();

    }
}
