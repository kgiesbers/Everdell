using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Player
    {
        public int workers;
        public int berries;
        public int pebbles;
        public int twigs;
        public int resin;
        private List<Critter> critters= new List<Critter>();
    }
}
