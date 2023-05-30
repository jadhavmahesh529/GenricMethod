using System.Runtime.ExceptionServices;

namespace GenricMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestClass testClass = new TestClass();
            int result = testClass.IntCompare(3, 4, 5);

            Console.WriteLine( result);
            Testclass1 testClass1 = new Testclass1();
            float result1 = testClass1.FloatCompare(1.1f, 2.2f, 3.3f);
            Console.WriteLine( result1 );
          
        }
    }
}
