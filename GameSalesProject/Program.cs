using GameSalesProject.Concrete;
using GameSalesProject.Entities;
using System;

namespace GameSalesProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //customerların yaratılması 
            MembersManager members = new MembersManager(new IMemberCheckManager());

            //customerların eklenmesi
            Members nur = new Members() { NationalId = "11111111111", LastName = "cöer", FirstName = "nur", Id = 1, DateOfBirth = new DateTime(1997, 10, 26) };
            members.Add(nur);
            members.Add(new Members() { NationalId = "22211111111", LastName = "cöer", FirstName = "ali", Id = 2, DateOfBirth = new DateTime(1997, 10, 26) });
            members.Add(new Members() { NationalId = "12555511111", LastName = "cöer", FirstName = "türkan", Id = 3, DateOfBirth = new DateTime(1997, 10, 26) });
            members.Add(new Members() { NationalId = "11199999999", LastName = "cöer", FirstName = "emre", Id = 4, DateOfBirth = new DateTime(1997, 10, 26) });
           
            //customer güncelleme
            nur.FirstName = "kadriye";
            members.Update(nur);
            
            

            //Kampanya ekleme
            CampainManager campainManager = new CampainManager();

            Campaing campaing1 = new Campaing() { Id = 3, Name = "Campaing1", Amount = 20 };
            campainManager.Add(campaing1);
            campainManager.Add(new Campaing() {Id=1, Name= "Blact Friday" , Amount = 10 });
            campainManager.Add(new Campaing() {Id=2, Name= "Summary" , Amount = 50 });

            //campaing update 
            campaing1.Name = "newCampain";
            campainManager.Update(campaing1);

            


            // yeni  oyun oluşturma
            GameManager gameManager = new GameManager();
            Game CSGo = new Game() { Id = 1 , Name = "CSGO" };
            gameManager.Add(CSGo);

            gameManager.CampaingGame(CSGo, campaing1);
            gameManager.Sales(CSGo, nur);



            //customerın silinmesi
            members.Delete(nur);

            //campaing deleted
            campainManager.Delete(campaing1);



            Console.ReadLine();

        }

    }
}
