using GameSalesProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesProject.Entities
{
    public class Members:IEntity
    {
        public int  Id { get; set; }
        public string  NationalId { get; set; }
        public string   FirstName { get; set; }
        public string   LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
