using System;

namespace AppDomainArguments
{
    internal class Program
    {
        static void Main()
        {
            AppDomain appDomain = AppDomain.CreateDomain("EchoArguments");
            var args = new[] {"argument 1", "argument 2", "argument 3"};
            appDomain.ExecuteAssembly("EchoArguments.exe", null, args);
            Console.Write("Press Any Key To Continue . . . ");
            Console.ReadKey(true);
        }
    }
}
