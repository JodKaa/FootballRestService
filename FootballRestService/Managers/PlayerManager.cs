using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballRestService.Managers
{
    public class PlayerManager
    {
        private static int _nextId = 1;
        private static readonly List<FootballPlayer> players = new List<FootballPlayer>();

        public static List<FootballPlayer> GetAllPlayers()
        {
            return new List<FootballPlayer>(players);
        }

        public static FootballPlayer GetById(int id)
        {
            return players.Find(player => player.Id == id);
        }

        public static FootballPlayer AddNewPlayer(FootballPlayer newPlayer)
        {
            newPlayer.Id = _nextId++;
            players.Add(newPlayer);
            return newPlayer;
        }

        public static FootballPlayer DeletePlayer(int id)
        {
            FootballPlayer player = players.Find(player => player.Id == id);
            if (player.Id == id)
            {
                players.Remove(player);
            }
            return player;
        }

        public static FootballPlayer UpdateItem(int Id, FootballPlayer update)
        {
            FootballPlayer player = players.Find(player => player.Id == Id);
            player.Name = update.Name;
            player.Price = update.Price;
            player.ShirtNumber = update.ShirtNumber;

            return player;
        }
    }
}
