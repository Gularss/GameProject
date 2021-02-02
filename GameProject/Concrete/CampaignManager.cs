using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Yeni kampanya bilgileri sisteme başarıyla eklenmiştir.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanya bilgileri silinmiştir.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanya bilgileri güncellenmiştir.");
        }
    }
}
