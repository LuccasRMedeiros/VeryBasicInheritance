using System;
using ThoseWhoPrintFight;

namespace UserInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type -servus or -cloud to what d they have to say");
            string UserCommand = Console.ReadLine();
            Mapper(UserCommand);
        }

        public static void Mapper(string command)
        {
            switch (command)
            {
                case "-servus":
                    FatherServus servus = new FatherServus("Father Servus");
                    servus.SayHelloWorld();
                    break;
                case "-cloud":
                    Cloud cloud = new Cloud("Cloud");
                    cloud.SayHelloWorld();
                    break;
                default:
                    Console.WriteLine("Your code is unnaceptable...");
                    Console.WriteLine("Breaking operation!");
                    break;
            }
        }
    }
}
