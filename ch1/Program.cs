using System;


namespace ch1
{
    class Program
    {
        static void Main(string[] args)


        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            for (int i = 0; i < args.Length; i++)
            {
                Console.Write(args[i]+ ", ");
            }
        }
    }
}
