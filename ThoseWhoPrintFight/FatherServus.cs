using System;

namespace ThoseWhoPrintFight
{
    public class FatherServus
    {
        protected string Name;
        
        public FatherServus(string name)
        {
            Name = name;
            Console.WriteLine($"This is {this.Name}");
        }

        public virtual void SayHelloWorld()
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

    }
}
