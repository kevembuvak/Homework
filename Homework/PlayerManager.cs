using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    class PlayerManager  // operator class for player entity
    {

        CheckIfRealPersonManager check;

        public PlayerManager(CheckIfRealPersonManager checkIfRealPersonManager)
        {
            this.check = checkIfRealPersonManager;
        }

        public void Add(Player player)
        {

            if (check.CheckIfRealPerson(player)){
                Console.WriteLine("Player named: " + player.Name + "has been added");
            }
            else
            {
                throw new Exception("Not a real person");
            }
            
        }

        public void Delete(Player player)
        {
            // Check if person is real
            Console.WriteLine("Player named: " + player.Name + "has been deleted");
        }

        public void Update(Player player)
        {
            // Check if person is real
            Console.WriteLine("Player named: " + player.Name + "has been updated");
        }
    }
}
