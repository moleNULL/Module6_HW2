using MicroserviceWebAPIToDocker.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroserviceWebAPIToDocker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameProductsController : ControllerBase
    {
        private static readonly List<GameProduct> Games = new List<GameProduct>
        {
            new GameProduct("Counter Strike: Global Offensive", 2021, 15.99m, "Valve"),
            new GameProduct("Europa Universalis III", 2007, 7.99m, "Paradox Interactive"),
            new GameProduct("Sid Meier's Pirates!", 2004, 4.99m, "Firaxis Games"),
            new GameProduct("PUBG: Battlegrounds", 2017, 0m, "PUBG Studios"),
            new GameProduct("PES 2009", 2008, 13.99m, "Konami")
        };

        [HttpGet]
        public IEnumerable<GameProduct> Get()
        {
            ShuffleGames();

            return Games;
        }

        private void ShuffleGames()
        {
            int n = Games.Count;
            Random rnd = new Random();

            while (n > 1)
            {
                int k = rnd.Next(0, n) % n;
                n--;

                GameProduct value = Games[k];
                Games[k] = Games[n];
                Games[n] = value;
            }
        }
    }
}
