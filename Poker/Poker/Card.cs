using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{

    public class Card
    {
        public string Suit;
        public int Value;

        public Card(string suit, int value)
        {
            Suit = suit;
            Value = value;
        }

    }
}
