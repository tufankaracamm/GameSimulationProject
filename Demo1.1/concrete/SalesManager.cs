using Demo1._1.Abstarct;
using Demo1._1.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1._1.concrete
{
    internal class SalesManager : SalesServices
    {
        public void Sales(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.GamerFirstName+"kişisi"+game.GameName+"oyununu satın aldı");
        }

        public void SalesWithCampaign(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(gamer.GamerFirstName + " kişisi " +campaign.CampaignName + " kampanya adıyla " +game.GameName+ " oyunu satın aldı ");
        }
    }
}
