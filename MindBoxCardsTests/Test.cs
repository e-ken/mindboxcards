using NUnit.Framework;
using System;
using System.Collections.Generic;
using MindboxCards;

namespace MindboxCardsTests {
    [TestFixture ()]
    public class Test {
        [Test ()]
        public void Test_InsertionSort_ToPrevEqualsFromNextInList () {
            // Arrange
            var cards = new List<Card> {
                new Card { From = "Мельбурн", To = "Кельн" },
                new Card { From = "Москва", To = "Париж" },
                new Card { From = "Кельн", To = "Москва" },
                new Card { From = "Владивосток", To = "Мельбурн" },
            };
            // Act
            cards.InsertionSort ();
            // Assert
            AssertOrder (cards);
        }

        [Test ()]
        public void Test_InsertionSort_ToPrevEqualsFromNextInList_2Elements () {
            // Arrange
            AssertOrder(new List<Card> {
                new Card { From = "Кельн", To = "Москва" },
                new Card { From = "Мельбурн", To = "Кельн" },
            }.InsertionSort ());
        }

        private void AssertOrder (List<Card> cards) {
            for (int i = 1; i < cards.Count; i++)
                StringAssert.AreEqualIgnoringCase (cards [i - 1].To, cards [i].From);
        }
    }
}
