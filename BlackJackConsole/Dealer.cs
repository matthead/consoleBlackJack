using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackConsole
{
    class Dealer
    {
        private Models.Table _table;
        private Models.Shoe _shoe;
        public Dealer(Models.Table dealerTable)
        {
            this._table = dealerTable;
            hand = new Models.Hand();
        }
        public Models.Hand hand { get; private set; }
        public bool isInMiddleOfDeal { get; private set; }
        public void DealMainRound()
        {
            isInMiddleOfDeal = true;
            //makes sure there are people at the _table and that the _shoe did not end
            if (_table.players.Count > 0 && !_table.shoe.ShoeEnded())
            {                
                    //loop the players twice so each player will have 2 cards
                for (int index = 0; index < 2; index++)
                {
                    foreach (Models.Player player in _table.players)
                    {

                        player.hand.cards.Add(_table.shoe.GetTopCard());
                    }
                    //add cards to dealer hands also;
                    this.hand.cards.Add(_table.shoe.GetTopCard());
                }
            }
        }     
    }
}
