using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Shoe testShoe = new Shoe();
            Console.WriteLine(testShoe.GetTopCard());
        }
    }
}
