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

            Models.Player player = new Models.Player();
            Multiplayer mp = Multiplayer.Instance;
            bool personAdded;
            Models.Table table =  mp.selectTable(player, 2,out personAdded);
            if (personAdded)
            {
                table.Start();
                table.dealer.ClearHandFromEveryone();
                table.Start();
            }
            foreach (Models.Hand hand in player.hand)
            {
                foreach (Models.Card card in hand.cards)
                {
                    Console.WriteLine(card);
                }
            }
            Console.WriteLine(table.rule.EvaluateTotal(player.hand[0]));
        }
    }
}
