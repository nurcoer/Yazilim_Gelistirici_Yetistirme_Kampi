using GameSalesProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesProject.Abstract
{
    public interface IMemberCheckManager
    {
        bool CheckIfRealPerson(Members member);
    }
}
