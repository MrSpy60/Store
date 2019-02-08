using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore
{
    class Store
    {
        int maxGames = 4;
        List<Game> showcase = new List<Game>();
        User user = new User();
        public void Store()
        {
            showcase.Add(new Game("Daddy simulator", 15f, "how to DAD", "real-life"));
            showcase.Add(new Game("Halflife 3", 1000000f, "best game never", "unreal"));
            showcase.Add(new Game("Hat in Time", 20f, "Cute", "3D"));
        }
        public void AddGame(Game game)
        {
            if (showcase.Count() < maxGames )
                showcase.Add(game);
        }

        public void RemoveGame(Game game)
        {
            if (showcase.Contains(game))
                showcase.Remove(game);
        }

        public void Sell(Game game)
        {
            if (user.wallet >= game.price)
            {
                user.library.Add(game);
                user.wallet -= game.price;
                removeGame(game);
            }
            else
                Console.WriteLine("must construct additional funds");
        }

        //we tryed
        private string gamesForSale;
        private int amountOfGames = 10;
        private string dlc;
        public string sortBy(string genre) { }
        public string buy(string name) { }
        public void addGame(name, price, description, genre)
        {
            Game game1 = new Game();
        }
        public void removeGame(string name) { }
    }
    class Game
    {
        public string genre;
        public string name;
        public float price;
        public string description;
        public Game(string name, float price, string description, string genre)
        {
            this.name = name;
            this.price = price;
            this.description = description;
            this.genre = genre;
        }
        
    }
    class User
    {
        public float wallet;
        public List<Game> library = new List<Game>();
        public User(float walletfunds)
        {
            wallet = walletfunds
        }
    }

}
