using System;
using System.Collections.Generic;
using System.Text;

namespace GameManager
{
    interface IMarketService
    {
        void Sell(Customer customer, Product product);
        void AddCampaign(Campaign campaign, Product product);
        void DeleteCampaign(Campaign campaign, Product product);
        void UpdateCampaign(Campaign campaign, Product product, Campaign campaignNew);

    }
}
