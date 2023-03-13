using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Deck
    {
        private List<Card> cards = new List<Card>();
        
        public void DealCard(Player player, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                
            }
        }

        public void AddCard(Card card)
        {
            cards.Add(card);
        }
    }
}
