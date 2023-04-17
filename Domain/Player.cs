using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Player
    {
        private int workers;
        private ResourcePouch resources;
        private int points;
        private Card[] cards = new Card[8];
        private City city;

        public int Worker
        {
            get { return workers; }
            set { workers = value; }
        }
        public int Points
        {
            get { return points; }
            set { points = value; }
        }

        public Player()
        {
            this.workers = 2;
            this.resources.Twig = 0;
            this.resources.Pebble = 0;
            this.resources.Berry = 0;
            this.resources.Resin = 0;
        }

        public void PlaceWorker(Deck deck, WorkerSpace workerSpace)
        {
                workerSpace.PayResources(deck, this);
        }
        
        public void PlaceCard(Card card, City city)
        {

        }
        
        public void AddCard(Card card)
        {
            cards.ToArray(card);
        }
    }
}
