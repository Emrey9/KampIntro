using System;
using System.Collections.Generic;
using System.Text;

namespace GameManager
{
    class MarketManager : IMarketService
    {
        public void AddCampaign(Campaign campaign, Product product)
        {
            product.Price = product.Price - product.Price * campaign.DiscountRate;
        }

        public void DeleteCampaign(Campaign campaign, Product product)
        {
            product.Price = product.Price / campaign.DiscountRate * 100;
        }

        public void Sell(Customer customer, Product product)
        {
            if (customer.Verified)
            {
                Console.WriteLine(customer.FirstName + " is buy the " + product.Name);
            }
            else
            {
                Console.WriteLine(customer.FirstName + " can not buy the " + product.Name);
            }
        }
        public void UpdateCampaign(Campaign campaign, Product product, Campaign campaignNew)
        {
            product.Price = product.Price / campaign.DiscountRate * 100;
            product.Price = product.Price - product.Price * campaignNew.DiscountRate;
        }
    }

}
