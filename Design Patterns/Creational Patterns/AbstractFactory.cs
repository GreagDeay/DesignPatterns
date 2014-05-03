using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creationalpatterns
{
    public class AbstractFactory
    {

        public virtual T DoStuff<T>();
    }


    public class ExtendedAbstractFactory : AbstractFactory
    {
        public virtual void DoStuff<T>();
    }
}
