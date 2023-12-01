using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonesAbstractClass
{
    internal class Poco: IPhone_
    {
        public void constructPhone(IProcessor processor)
        {
            processor.constructProcessor();
            Console.WriteLine("Poco created");
        }
    }
}
