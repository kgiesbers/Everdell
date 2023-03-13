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
        private int berries;
        private int pebbles;
        private int twigs;
        private int resin;
        private int points;
        private List<Card> cards= new List<Card>();
        private City city;

        public int Worker
        {
            get { return workers; }
            set { workers = value; }
        }
        public int Berries
        {
            get { return berries; }
            set { berries = value; }
        }
        public int Pebbles
        {
            get { return pebbles; }
            set { pebbles = value; }
        }
        public int Twigs
        {
            get { return twigs; }
            set { twigs = value; }
        }
        public int Resin
        {
            get { return resin; }
            set { resin = value; }
        }
        public int Points
        {
            get { return points; }
            set { points = value; }
        }

        public Player()
        {
            this.workers = 2;
            this.berries = 0;
            this.pebbles = 0;
            this.twigs = 0;
            this.resin = 0;
        }

        public void PlaceWorker(Deck deck, WorkerSpace workerSpace)
        {
            if (workers > 0)
            {
                workerSpace.PayResources(deck, this);
            }
            else
            {
                Console.WriteLine("All your workers are occupied!");
            }
        }
        
        public void PlaceCard(Card card, City city)
        {

        }
        
        public void AddCard(Card card)
        {
            cards.Add(card);
        }
    }
}
