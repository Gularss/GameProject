using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class GameManager : IGameService
    {
        public void GameBuying(Gamer gamer, Game game)
        {
            Console.WriteLine("Sayın " + gamer.FirstName + " " + gamer.LastName +", " + game.GameName +
                " adlı oyun satın alınmıştır. Fiyatı : " + game.GamePrice + " TL");
        }

        public void GameBuying(Gamer gamer, Game game, Campaign campaign)
        {
            double totalPrice = (game.GamePrice * campaign.RateOfDiscount) / 100;
            Console.WriteLine("Sayın " + gamer.FirstName + " " + gamer.LastName + ", fiyatı " + game.GamePrice + " TL olan " + game.GameName +
                " adlı oyun " + campaign.CampaignName + " kampanyasıyla " + totalPrice + "TL'ye satın alınmıştır.");
        }
    }
}
