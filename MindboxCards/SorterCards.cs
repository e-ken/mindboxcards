using System;
using System.Collections.Generic;

namespace MindboxCards {
    public static class SorterCards {
        /// <summary>
        /// Сортировка вставками
        /// </summary>
        /// <returns>The sort cards.</returns>
        /// <param name="cards">Cards.</param>
        public static List<Card> InsertionSort (this List<Card> cards) {

            int n = cards.Count;

            for (int i = 1; i < n; i++) {
                for (int j = i; j > 0 && cards [j - 1].To.CompareTo(cards[j].From) > 0; j--) {
                    cards.Swap(j - 1, j);
                }
            }

            return cards;
        }

        private static void Swap (this List<Card> cards, int index1, int index2) {
            var tmp = cards [index1];
            cards [index1] = cards [index2];
            cards [index2] = tmp;
        }
    }
}
