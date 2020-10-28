using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThoseWhoPrintFight
{
    public class Cloud : FatherServus
    {
        public Cloud(string name) : base(name)
        {
        }

        public override void SayHelloWorld()
        {
            Console.WriteLine("Fight!");
            Console.ReadLine();
        }
    }
}
