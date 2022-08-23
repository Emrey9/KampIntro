using System;

namespace GameManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Product game1 = new Game()
            {
                Name = "Lol",
                Price = 100,
                TypeOfGame = "MOBA"
            };
            Customer gamer = new Gamer()
            {
                Id = 1,
                FirstName = "Emre",
                LastName = "Yılmaz",
                DateOfBirth = new DateTime(1999, 4, 12),
                UserName = "Roc35",
                TcNo = "16516543543",
                Verified = false
            };

            Campaign campaign = new Campaign()
            {
                DiscountRate = 0.5,
                Name = "New customer gift"
            };

            GamerManager gameManager = new GamerManager(new EDevletServisAdapter());
            MarketManager marketManager = new MarketManager();
            gameManager.Register(gamer);
            Console.WriteLine(game1.Name + " price is " + game1.Price);
            marketManager.AddCampaign(campaign, game1);
            Console.WriteLine(game1.Name + " new price is " + game1.Price);
            marketManager.Sell(gamer, game1);

        }
    }
}
