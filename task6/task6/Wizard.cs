using System;
using task6;

namespace task6
{
    public class Wizard : GameCharacter
    {

        public Wizard(string name, int health)
            : base(name, health)
        {

        }
        public override void UseSpecialAbility()
        {
            Console.WriteLine("The Wizard uses magic!");
        }

        public override void TakeDamage(int amount)
        {
            base.TakeDamage(amount);
        }


    }
}