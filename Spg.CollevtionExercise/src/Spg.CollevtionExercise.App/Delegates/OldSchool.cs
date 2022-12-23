using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CollevtionExercise.App.Delegates
{
    public class OldSchool
    {
        public bool GreatMethodForNearlyEverything(int x, int y)
        {
            // ...
            // 1000 Zeilen Code (z.B. irgendweche Vorbereitungen werden duhgeführt)
            // ...

            bool result = CompareEqual(x, y);
            if (result == true) { }
            else { }

            // ...
            // 1000 Zeilen Code (z.B. result wird irgendwie verarbeitet)
            // ...

            return result;
        }

        public bool CompareEqual (int x, int y) 
        {
            return x == y;
        }

        public bool CompareGreaterl(int x, int y)
        {
            return x > y;
        }
    }
}
