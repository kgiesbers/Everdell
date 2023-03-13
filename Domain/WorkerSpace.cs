using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class WorkerSpace
    {
        private int berryReward;
        private int twigReward;
        private int pebbleReward;
        private int resinReward;
        private int pointReward;
        private int cardReward;
        private bool isOpen;

        public WorkerSpace(int berryReward, int twigReward, int pebbleReward, int resinReward, int pointReward, int cardReward)
        {
            this.berryReward = berryReward;
            this.twigReward = twigReward;
            this.pebbleReward = pebbleReward;
            this.resinReward = resinReward;
            this.pointReward = pointReward;
            this.cardReward = cardReward;
            this.isOpen = true;
        }

        public void PayResources(Deck deck, Player player)
        {
            if (isOpen)
            {
                player.Berries = player.Berries + berryReward;
                player.Twigs = player.Twigs + twigReward;
                player.Pebbles = player.Pebbles + pebbleReward;
                player.Resin = player.Resin + resinReward;
                player.Points = player.Points + pointReward;
                deck.DealCard(player, cardReward);

            }
        }
    }
}
