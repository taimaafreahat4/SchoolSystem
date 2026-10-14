using System;
using System.Collections.Generic;
using task6;
using task6;


namespace task6
{

    class Program
    {

        static void Main(string[] args)
        {


            Console.WriteLine("===== ADVENTURE GAME =====");
            Console.WriteLine();



            // Create Characters

            Warrior warrior = new Warrior("Alex", 80);

            Wizard wizard = new Wizard("Luna", 70);

            // Store in List

            List<GameCharacter> characters = new List<GameCharacter>();

            characters.Add(warrior);
            characters.Add(wizard);

            // Loop abilities

            foreach (GameCharacter character in characters)
            {

                Console.WriteLine($"{character.Name} enters the game!");
                Console.WriteLine();


                character.UseSpecialAbility();

                Console.WriteLine();


                character.TakeDamage(10);


                character.DisplayHealth();

                Console.WriteLine();

            }




            // Test Heal()

            warrior.Heal();


            Console.WriteLine();


            warrior.Heal(15);


            Console.WriteLine();



            // Potion

            HealthPotion potion = new HealthPotion();

            potion.PotionName = "Super Health Potion";


            potion.Collect();


            Console.WriteLine();



            // Valid input

            potion.Use(wizard, "15");


            Console.WriteLine();



            // Invalid input

            potion.Use(wizard, "abc");



        }

    }

}