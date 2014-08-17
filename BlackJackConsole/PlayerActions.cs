using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackConsole
{
    class PlayerActions
    {
        private Models.Table _table;
        public PlayerActions(Models.Table table)
        {
            _table = table;
        }
        public void ShowAvailablePlayerOptions(Models.Hand hand)
        {
            if (_table.rule.IsHandSplitablle(hand))
            {
                // some logic to show the button or allow the command
            }
            if (_table.rule.IsHandDoubleable(hand))
            {
                // some logic to allow the button or allow the command
            }
        }
    }
}
