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
        private PlayerActions _playerActions;
        public Dealer(Models.Table dealerTable)
        {
            this._table = dealerTable;
            hand = new Models.Hand();
            _playerActions = new PlayerActions(_table);
        }
        public Models.Hand hand { get; private set; }
        public bool isInMiddleOfDeal { get; private set; }
        public void DealMainRound()
        {
            if (!isInMiddleOfDeal)
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
                            // 0 index because each player starts with only 1 hand. if the same player sits in 2 seats it is still going to be a seperate player instance i hope ?
                            player.hand[0].cards.Add(_table.shoe.GetTopCard());
                        }
                        //add cards to dealer hands also;
                        this.hand.cards.Add(_table.shoe.GetTopCard());
                    }
                }
            }
        }
        public void LoopThroughPlayersToAct()
        {
            foreach (Models.Player player in _table.players)
            {
                foreach (Models.Hand hand in player.hand)
                {
                    _playerActions.ShowAvailablePlayerOptions(hand);
                    //some how implement a wait for player to act
                    if (_table.rule.IsHandBusted(hand))
                    {
                    }
                }
            }
        }
        private void RemoveCurrentHand(Models.Player player, Models.Hand cards)
        {

        }
        public void ClearHandFromEveryone()
        {
            foreach (Models.Player player in _table.players)
            {
                foreach (Models.Hand playerHand in player.hand)
                {
                    playerHand.cards.Clear();
                }
            }
            hand.cards.Clear();
            isInMiddleOfDeal = false;
        }
    }
}
