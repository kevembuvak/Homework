using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    class CampaignManager  // operator class for campaign entity
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign called " + campaign.Name + " has been added");
        }
        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign called " + campaign.Name + " has been updated");
        }
        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign called " + campaign.Name + " has been deleted");
        }
    }
}
