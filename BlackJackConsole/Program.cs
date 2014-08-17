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
            Models.Table table =  mp.selectTable(player, 2);
            foreach (Models.Card card in player.hand.cards)
            {
                Console.WriteLine(card);
            }
            Console.WriteLine(table.rule.EvaluateTotal(player.hand));
        }
    }
}
