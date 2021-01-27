using GameSalesProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesProject.Entities
{
    public class Game:IEntity
    {
        public int Id { get; set; }
        public int CampaingId { get; set; }
        public string Name { get; set; }
    }
}
