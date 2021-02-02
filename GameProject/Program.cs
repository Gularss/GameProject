using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GameManager gameManager = new GameManager();
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                FirstName = "ENGİN",
                LastName = "DEMİROĞ",
                BirthYear = 1985,
                IdentityNumber = 11111111111
            });
            gamerManager.Delete(new Gamer
            {
                Id = 1,
                FirstName = "ENGİN",
                LastName = "DEMİROĞ",
                BirthYear = 1985,
                IdentityNumber = 11111111111
            });
            gamerManager.Update(new Gamer
            {
                Id = 1,
                FirstName = "ENGİN",
                LastName = "DEMİROĞ",
                BirthYear = 1985,
                IdentityNumber = 11111111111
            });
            gameManager.GameBuying(new Gamer
            {
                Id = 1,
                FirstName = "ENGİN",
                LastName = "DEMİROĞ",
                BirthYear = 1985,
                IdentityNumber = 11111111111
            }, new Game
            {
                Id = 1,
                GameName = "Last King",
                GamePrice = 100
            });
            gameManager.GameBuying(new Gamer
            {
                Id = 1,
                FirstName = "ENGİN",
                LastName = "DEMİROĞ",
                BirthYear = 1985,
                IdentityNumber = 11111111111
            }, new Game
            {
                Id =1,
                GameName = "Last King",
                GamePrice = 100
            },
            new Campaign 
            { 
                Id = 1,
                CampaignName = "Muhteşem Cuma",
                Description ="Strateji oyunlarında %50 indirim sağlar",
                RateOfDiscount = 50
            });
        }
    }
}
