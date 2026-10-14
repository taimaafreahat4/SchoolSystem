using System;
using System.Xml.Linq;
using task6;

namespace task6
{
    public class Warrior : GameCharacter
    {


        public Warrior(string name, int health)
            : base(name, health)
        {

        }



        public override void UseSpecialAbility()
        {
            Console.WriteLine("The Warrior attacks with a sword!");
        }



        public override void TakeDamage(int amount)
        {

            int reducedDamage = amount - 2;


            if (reducedDamage < 0)
                reducedDamage = 0;


            Health -= reducedDamage;


            if (Health < 0)
                Health = 0;



            Console.WriteLine($"{Name} takes {reducedDamage} damage.");
        }

    }
}