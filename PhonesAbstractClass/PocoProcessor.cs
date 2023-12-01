using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonesAbstractClass
{
    internal class PocoProcessor : IProcessor
    {
        public override void constructProcessor() => Console.WriteLine("Poco processor was created");

    }
}
