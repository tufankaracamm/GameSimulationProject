using Demo1._1.Abstarct;
using Demo1._1.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1._1.concrete
{
    public class CampaignManager : CampaignServices
    {
        public void CampaignAdd(Campaign campaign)
        {
            Console.WriteLine("Kampanya Eklendi");
        }

        public void CampaignDelete(Campaign campaign)
        {
            Console.WriteLine("Kampanya Silindi");
        }

        public void CampaignSales(Campaign campaign)
        {
            throw new NotImplementedException();
        }
    }
}
