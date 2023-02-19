using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuplesPractice
{
    public class SimpleTuple
    {
        public Tuple<string[], int[], int> Process() 
        {
            string[] strArray = { "ABC", "XYZ" };
            int[] intArray = { 1,4,2,5,3,6};
            Tuple<string[], int[], int> tuple = new Tuple<string[], int[], int>(strArray,intArray,1);
            return tuple;
        }

        public(int, int)  Process1()
        {
            return (1, 1);
        }
    }
}
