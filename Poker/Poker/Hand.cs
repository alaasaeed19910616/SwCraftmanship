using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class Hand
    {
        public List<Card> Cards;
        public void CreateHand(List<Card> cards)
        {
            Cards = cards;
        }

        public string GetOrder()
        {
            if (IsPair() && 
                !(IsThreeOfAKind()))
            {
                return "Pair";
            }
            else if (IsTwoPairs())
            {
                return "Two Pairs";
            }
            else if (IsThreeOfAKind() && !(IsPair()))
            {
                return "Three of a kind";
            }
            else if (IsStraight() && !(IsFlush()))
            {
                return "Straight";
            }
            else if (IsFlush()&& !(IsStraight()))
            {
                return "Flush";
            }
            else if (IsThreeOfAKind() && IsPair())
            {
                return "Full House";
            }
            else if (IsFourOfAKind())
            {
                return "Four of a kind";
            }
            else if (IsFlush() && IsStraight())
            {
                return "Straight flush";
            }
            return "High Card";
        }

        private bool IsFourOfAKind()
        {
            return Cards.GroupBy(x => x.Value).Where(uniqueList => uniqueList.Count() == 4).Any();
        }

        private bool IsFlush()
        {
            return Cards.GroupBy(x => x.Suit).Where(uniqueList => uniqueList.Count() == 5).Any();
        }

        private bool IsTwoPairs()
        {
            return Cards.GroupBy(x => x.Value).Where(uniqueList => uniqueList.Count() == 2).Count() == 2;
        }

        private bool IsThreeOfAKind()
        {
            return Cards.GroupBy(x => x.Value).Where(uniqueList => uniqueList.Count() == 3).Any();
        }

        private bool IsPair()
        {
            return Cards.GroupBy(x => x.Value).Where(uniqueList => uniqueList.Count() == 2).Count() == 1;
        }

        private bool IsStraight()
        {
            var sortedCards = Cards.OrderBy(h => h.Value).ToArray();
            for (int i = 0; i < 4; i++)
            {
                if (sortedCards[i+1].Value != sortedCards[i].Value + 1)
                {
                    return false;
                }
            }
            return true;

        }
    }
}
