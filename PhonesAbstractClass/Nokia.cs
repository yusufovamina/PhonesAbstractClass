using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonesAbstractClass
{
    internal class Nokia: IPhone_
    {
        public void constructPhone(IProcessor processor)
        {
            processor.constructProcessor();
            Console.WriteLine("Nokia created");
        }
    }
}
