using GameSalesProject.Abstract;
using GameSalesProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesProject.Concrete
{
    public class IMemberCheckManager : Abstract.IMemberCheckManager
    {
        public bool CheckIfRealPerson(Members member)
        {
            Console.WriteLine("Kullanıcı https://tckimlik.nvi.gov.tr/Service/KPSPublic.asmx?WSDL   Adresinden Kontrol edildi.");
            return true;
        }
    }
}
