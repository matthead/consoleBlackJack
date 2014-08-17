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
         //   Shoe testShoe = new Shoe();
          //  Console.WriteLine(testShoe.GetTopCard());
            Models.Table table = new Models.Table();
            Models.Player player= new Models.Player();
            table.AddPlayerToTable(player);
            table.Start();
            foreach (Models.Card card in player.hand.cards)
            {
                Console.WriteLine(card);
            }
            Console.WriteLine(table.rule.EvaluateTotal(player.hand));
        }
    }
}
