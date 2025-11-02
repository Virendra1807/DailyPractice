using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPractice
{
    using System;

    public class OperatorOverloadding
    {
        int a, b;
        public OperatorOverloadding(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public static OperatorOverloadding operator +(OperatorOverloadding Obj1, OperatorOverloadding Obj2)
        {
            return new OperatorOverloadding(Obj1.a + Obj2.a, Obj1.b + Obj2.b);
        }


        public override string ToString() => $"({a}, {b})";

    }

}
