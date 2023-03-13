using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal class Worker
    {
        private Player owner;

        public Player Owner
        {
            get { return owner; }
        }

        public Worker(Player owner)
        {
            this.owner = owner;
        }
    }
}
