using System;

namespace CS_Narvel
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.length == 1)
                get(args[1]);
            Console.WriteLine("Hello World!");
        }

        void get(string location)
        {
            switch (location)
            {
                case ".":
                    get("curren_directory");
                    break;
                default:
                    break;
            }
        }
    }
}
