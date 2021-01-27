using GameSalesProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesProject.Entities
{
    public class Campaing:IEntity
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public int Amount { get; set; } // Kampanya miktarı
    }
}
