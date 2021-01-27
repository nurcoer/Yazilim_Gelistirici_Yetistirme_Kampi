using GameSalesProject.Abstract;
using GameSalesProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameSalesProject.Concrete
{
    
    public class MembersManager : IMemberService
    {
        List<Members> members = new List<Members>();
        IMemberCheckManager _memberCheckManager ;

        public MembersManager(IMemberCheckManager memberCheckManager)
        {
            _memberCheckManager = memberCheckManager;
        }

        public void Add(Members entity)
        {
            if (_memberCheckManager.CheckIfRealPerson(entity))
            {
                members.Add(entity);
                Console.WriteLine(entity.FirstName + " " + entity.LastName + " isimli kullanıcı Eklenmiştir.");
            }
            else
            {
                Console.WriteLine("Kullanıcı Bilgileri Yanlıştır.");
            }
           
            
        }

        public void Delete(Members entity)
        {
            members.Remove(entity);
            Console.WriteLine(entity.FirstName + " " + entity.LastName + " isimli kullanıcı Silinmiştir.");
        }

        public void Update(Members entity)
        {
            members.Select(m => m.Id == entity.Id ? m = entity : m).ToList();
            Console.WriteLine(entity.FirstName+" "+ entity.LastName + " isimli kullancı Güncellenmiştir.");
        }
    }
}
