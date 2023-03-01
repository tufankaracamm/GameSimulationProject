using Demo1._1.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1._1.Abstarct
{
    internal interface SalesServices
    {
        public void Sales(Game game, Gamer gamer);
        public void SalesWithCampaign(Game game, Gamer gamer, Campaign campaign);

    }
}
