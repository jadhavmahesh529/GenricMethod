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
           
            TestClass2 testClass2 = new TestClass2();
            string result2 = testClass2.stringCompare("Ayush", "Trisha", "Kavya");
            Console.WriteLine( result2 );

            TestClass3 testClass3 = new TestClass3();
            int result3 = testClass3.CompareAll<int>(3, 4, 5);
            float result4 =testClass3.CompareAll(1.1f, 2.2f, 3.3f);
            string result5 = testClass3.CompareAll("Parth", "Ayush", "Kavya");
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.WriteLine(result5);
        }
    }
}
