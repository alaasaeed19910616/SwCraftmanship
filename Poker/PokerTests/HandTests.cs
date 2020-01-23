using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Poker;

namespace PokerTests
{
    [TestClass]
    public class HandTests
    {

        [TestMethod]
        public void testCheckIfHandHasAPair()
        {
            Hand hand = new Hand();
            List<Card> cards = new List<Card>();
            cards.Add(new Card("Hearts", 2));
            cards.Add(new Card("Diamonds", 2));
            cards.Add(new Card("Spades", 3));
            cards.Add(new Card("Clubs", 5));
            cards.Add(new Card("Hearts", 8));
            hand.CreateHand(cards);
            string rank = hand.GetOrder();
            Assert.AreEqual("Pair", rank);
        }
        [TestMethod]
        public void testCheckIfHandHasTwoPairs()
        {
            Hand hand = new Hand();
            List<Card> cards = new List<Card>();
            cards.Add(new Card("Hearts", 2));
            cards.Add(new Card("Diamonds", 2));
            cards.Add(new Card("Spades", 3));
            cards.Add(new Card("Clubs", 3));
            cards.Add(new Card("Hearts", 8));
            hand.CreateHand(cards);
            string rank = hand.GetOrder();
            Assert.AreEqual("Two Pairs", rank);
        }
        [TestMethod]
        public void testCheckIfHandHasThreecardsWithSameValue()
        {
            Hand hand = new Hand();
            List<Card> cards = new List<Card>();
            cards.Add(new Card("Hearts", 2));
            cards.Add(new Card("Diamonds", 2));
            cards.Add(new Card("Spades", 2));
            cards.Add(new Card("Clubs", 3));
            cards.Add(new Card("Hearts", 8));
            hand.CreateHand(cards);
            string rank = hand.GetOrder();
            Assert.AreEqual("Three of a kind", rank);
        }
        [TestMethod]
        public void testCheckIfHandHasStraigt()
        {
            Hand hand = new Hand();
            List<Card> cards = new List<Card>();
            cards.Add(new Card("Hearts", 2));
            cards.Add(new Card("Diamonds", 3));
            cards.Add(new Card("Spades", 4));
            cards.Add(new Card("Clubs", 5));
            cards.Add(new Card("Hearts", 6));
            hand.CreateHand(cards);
            string rank = hand.GetOrder();
            Assert.AreEqual("Straight", rank);
        }
        [TestMethod]
        public void testCheckIfHandHasFlush()
        {
            Hand hand = new Hand();
            List<Card> cards = new List<Card>();
            cards.Add(new Card("Hearts", 2));
            cards.Add(new Card("Hearts", 8));
            cards.Add(new Card("Hearts", 4));
            cards.Add(new Card("Hearts", 5));
            cards.Add(new Card("Hearts", 6));
            hand.CreateHand(cards);
            string rank = hand.GetOrder();
            Assert.AreEqual("Flush", rank);
        }
        [TestMethod]
        public void testCheckIfHandHasFullHouse()
        {
            Hand hand = new Hand();
            List<Card> cards = new List<Card>();
            cards.Add(new Card("Hearts", 2));
            cards.Add(new Card("Diamonds", 2));
            cards.Add(new Card("Clubs", 2));
            cards.Add(new Card("Hearts", 4));
            cards.Add(new Card("Diamonds", 4));
            hand.CreateHand(cards);
            string rank = hand.GetOrder();
            Assert.AreEqual("Full House", rank);
        }
        [TestMethod]
        public void testCheckIfHandHasFourcardsWithSameValue()
        {
            Hand hand = new Hand();
            List<Card> cards = new List<Card>();
            cards.Add(new Card("Hearts", 2));
            cards.Add(new Card("Diamonds", 2));
            cards.Add(new Card("Spades", 2));
            cards.Add(new Card("Clubs", 2));
            cards.Add(new Card("Hearts", 8));
            hand.CreateHand(cards);
            string rank = hand.GetOrder();
            Assert.AreEqual("Four of a kind", rank);
        }

        [TestMethod]
        public void testCheckIfHandHasStraightFlush()
        {
            Hand hand = new Hand();
            List<Card> cards = new List<Card>();
            cards.Add(new Card("Hearts", 2));
            cards.Add(new Card("Hearts", 3));
            cards.Add(new Card("Hearts", 4));
            cards.Add(new Card("Hearts", 5));
            cards.Add(new Card("Hearts", 6));
            hand.CreateHand(cards);
            string rank = hand.GetOrder();
            Assert.AreEqual("Straight flush", rank);
        }
    }
}
