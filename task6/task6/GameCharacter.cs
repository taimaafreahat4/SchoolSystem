using System;

namespace task6
{
    public abstract class GameCharacter
    {
        // Private field
        private string _name;


        // Public Property
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }


        // Protected Health
        protected int Health { get; set; }


        // Constructor
        public GameCharacter(string name, int health)
        {
            Name = name;

            if (health < 0)
                Health = 0;

            else if (health > 100)
                Health = 100;

            else
                Health = health;
        }


        // Abstract method
        public abstract void UseSpecialAbility();



        // Virtual method
        public virtual void TakeDamage(int amount)
        {
            Health -= amount;


            if (Health < 0)
                Health = 0;


            Console.WriteLine($"{Name} takes {amount} damage.");
        }



        // Method Overloading

        public void Heal()
        {
            Health += 10;


            if (Health > 100)
                Health = 100;


            Console.WriteLine($"{Name} heals 10 points.");
            Console.WriteLine($"{Name}'s health: {Health}");
        }



        public void Heal(int amount)
        {
            Health += amount;


            if (Health > 100)
                Health = 100;


            Console.WriteLine($"{Name} heals {amount} points.");
            Console.WriteLine($"{Name}'s health: {Health}");
        }



        public void DisplayHealth()
        {
            Console.WriteLine($"{Name}'s health: {Health}");
        }

    }
}