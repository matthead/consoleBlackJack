using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackConsole.Models.Interfaces
{
    interface IShoe
    {
        //void FillShoe();
        // void Shuffle();
        Card GetTopCard();
        // void AddUsedCardsBackIntoShoe();
    }
}