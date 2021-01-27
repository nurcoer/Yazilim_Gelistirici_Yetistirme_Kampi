using GameSalesProject.Abstract;
using GameSalesProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameSalesProject.Concrete
{
    public class GameManager : IGameService
    {
        List<Game> games = new List<Game>();

        public void Add(Game entity)
        {
            games.Add(entity);
            Console.WriteLine(entity.Name + " isimli oyun Eklenmiştir.");
        }

        public void CampaingGame(Game game, Campaing campaing)
        {
            games.Select(g => g.Id == game.Id ? g.CampaingId = campaing.Id : g.CampaingId).ToList();
            Console.WriteLine(game.Name + " oyununa" + campaing.Name + " kampanyası %"+campaing.Amount+ " oranında  tanımlandı" );
        }

        public void Delete(Game entity)
        {
            games.Remove(entity);
            Console.WriteLine(entity.Name + " isimli oyun Silinmiştir.");
        }

        public void Sales(Game game, Members member)
        {
            Console.WriteLine(game.Name + " oyununa " + member.FirstName +" "+ member.LastName + " Kişisine satıldı.");
        }

        public void Update(Game entity)
        {
            games.Select(c => c.Id == entity.Id ? c = entity : c).ToList();
            Console.WriteLine(entity.Name + " isimli oyun Güncellenmiştir.");
        }
    }
}
