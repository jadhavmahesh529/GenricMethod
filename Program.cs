using System.Runtime.ExceptionServices;

namespace GenricMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestClass testClass = new TestClass();
            int result = testClass.IntCompare(3, 4, 5);
          
            Console.WriteLine( result );
          
        }
    }
}
