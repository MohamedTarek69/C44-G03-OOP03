using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class TypeC : TypeB
    {
        public TypeC()
        {
            B = 10; //Valid [Inhereted] internal
            C = 10; //Valid [Inhereted] public

            X = 10; //Valid [Inhereted] private protected => Private
            Y = 10; //Valid [Inhereted] protected => Private
            Z = 10; //Valid [Inhereted] protected internal => Internal
        }

        public void Test()
        {
            TypeB typeB = new TypeB();
            typeB.B = 10;
            typeB.C = 20;

            //typeB.X= 30;
            //typeB.Y = 40;
            typeB.Z = 50;
        }
    }
}
