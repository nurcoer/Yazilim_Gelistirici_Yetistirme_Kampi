using GameSalesProject.Abstract;
using GameSalesProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameSalesProject.Concrete
{
    public class CampainManager : ICampaingService
    {
        List<Campaing> campaings = new List<Campaing>();
        public void Add(Campaing entity)
        {
            campaings.Add(entity);
            Console.WriteLine(entity.Name + " isimli Kampanya Eklenmiştir.");
        }

        public void Delete(Campaing entity)
        {
            campaings.Remove(entity);
            Console.WriteLine(entity.Name + " isimli Kampanya Silinmiştir.");

        }

        public void Update(Campaing entity)
        {
            campaings.Select(c => c.Id==entity.Id ? c = entity : c ).ToList();
            Console.WriteLine(entity.Name + " isimli Kampanya Güncellenmiştir.");
        }
    }
}
