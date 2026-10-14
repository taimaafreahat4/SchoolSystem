using System;
using task6;

namespace task6
{

    public class HealthPotion : ICollectible
    {

        public string PotionName { get; set; }//auto property



        public void Collect()
        {
            Console.WriteLine($"Health Potion collected! :{PotionName}");
        }



        public void Use(GameCharacter character, string amountText)
        {

            try
            {

                int amount = Convert.ToInt32(amountText);


                character.Heal(amount);

            }


            catch (Exception)
            {

                Console.WriteLine("Invalid input! Please enter a number.");

            }

        }


    }

}