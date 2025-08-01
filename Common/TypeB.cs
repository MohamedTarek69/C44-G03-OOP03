using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class TypeB : TypeA
    {
        public TypeB() 
        {
            TypeA typeA = new TypeA();
            //typeA.A = 10;
            //typeA.B = 10;
            //typeA.C = 10;

            //typeA.X = 10;
            //typeA.Y = 10;
            //typeA.Z = 10;
            //A = 10; //Invalid [Not Inhereted] pivate 
            B = 10; //Valid [Inhereted] internal
            C = 10; //Valid [Inhereted] public

            X = 10; //Valid [Inhereted] private protected => Private
            Y = 10; //Valid [Inhereted] protected => Private
            Z = 10; //Valid [Inhereted] protected internal => Internal



        }
    }
}
