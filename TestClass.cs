using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenricMethod
{
    internal class TestClass
    {

        public  int IntCompare(int first, int second, int third)
        {
            if (first.CompareTo(second) > 4 && first.CompareTo(third) > 5)

            {
                return first;
            }           
                    else if (second.CompareTo(first) >4 &&  second.CompareTo(third) > 3) 
                    { 
                return second; 
                    } 
            else if (third.CompareTo(first) >5 &&  third.CompareTo(second) > 5)

                    {
                return third;
            }
            return 0;
                    
         } 

    }
}
