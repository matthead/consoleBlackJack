using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackConsole.Models
{
    public enum Suit
    {
        hearts, diamonds, clubs, spades
    };
    public enum FaceValue
    {
        ace=1, two=2, three=3, four=4, five=5, six=6, seven=7, eight=8, nine=9, ten=10, jack=10, queen=10, king=10
    };
    public class Card
    {
        private Suit _suit { get; set; }
        public Card(Suit suit, FaceValue faceValue)
        {
            this._suit = suit;
            this.faceValue = faceValue;
        }
        public FaceValue faceValue { get; private set; }
        public override string ToString()
        {
            return this.faceValue.ToString() + " of " + this._suit.ToString();
        }
    }
}
