namespace GenricMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestClass testClass = new TestClass();
            int result = testClass.IntCompare(1, 2, 3);
            Console.WriteLine( result );
        }
    }
}
