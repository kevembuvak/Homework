using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    class MarketManager
    {
        public void Sell(Game game, Campaign campaign, Player player)
        {
            Console.WriteLine("Game called " + game.Name + "has been sold by player named "
                + player.Name + " at the cost of " + game.Cost*(100 - campaign.DiscountAmount)/100);
        }
    }
}
