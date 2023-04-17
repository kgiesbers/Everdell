using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal class ResourcePouch
    {
        private int twig;
        private int pebble;
        private int berry;
        private int resin;

        public int Twig { get => twig; set => twig = value; }
        public int Pebble { get => pebble; set => pebble = value; }
        public int Berry { get => berry; set => berry = value; }
        public int Resin { get => resin; set => resin = value; }

        public ResourcePouch(int twig, int pebble, int berry, int resin)
        {
            this.twig = twig;
            this.pebble = pebble;
            this.berry = berry;
            this.resin = resin;
        }

        public void PayResource()
        {

        }

        public void AddResource()
        {

        }
    }
}
