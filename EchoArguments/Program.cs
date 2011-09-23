using System;

namespace EchoArguments
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            for (int i   = 0; i < args.Length; i++)
            {
                Console.WriteLine("Arg #: {0} Value: {1}", i, args[i]);
            }
        }
    }
}
