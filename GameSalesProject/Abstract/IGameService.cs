using GameSalesProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesProject.Abstract
{
    public interface IGameService:IEntityService<Game>
    {
        void Sales(Game game, Members member);
        void CampaingGame(Game game, Campaing campaing);
    }
}
