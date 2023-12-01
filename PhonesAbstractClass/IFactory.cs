using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonesAbstractClass
{
    internal interface IFactory
    {
        IProcessor constructProcessor();
        IPhone_ constructPhone();
    }
}
