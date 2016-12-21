using System;
using System.Collections.Generic;


namespace MindboxCards {
    class MainClass {
        public static void Main (string [] args) {

            var cards = new List<Card> {
                new Card { From = "Мельбурн", To = "Кельн" },
                new Card { From = "Москва", To = "Париж" },
                new Card { From = "Кельн", To = "Москва" },
            };

            // Сортировка вставками
            foreach (var card in cards.InsertionSort ())
                Console.Write ($"{card.From}>{card.To},");

            Console.WriteLine ("\r\nPress any key");
            Console.ReadKey ();
        }
    }
}
