using Demo1._1.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1._1.Abstarct
{
    public interface CampaignServices
    {
         void CampaignAdd(Campaign campaign);
         void CampaignDelete(Campaign campaign);
        void CampaignSales(Campaign campaign);
    
    }
}
