using System;

namespace FighterGame
{

    class Program
    {
        static void Main(string [] args)
        {
            Fighter a1 = new Fighter("Warrior", 100,10);
            a1.PrintHealth();
            a1.PrintAttack();
            Fighter a2 = new Fighter("Dumb Mage", 100, 10);
            a2.PrintHealth();
            a2.PrintAttack();

        }

    }


    class Fighter
    {
       string name;

       int health;

       int attack;

        /* Constructor*/
        public Fighter(string n, int h, int a)
        {
            name = n;
            health = h;
            attack = a;
        }

        public void PrintHealth()
        {
            Console.WriteLine(name + " health is " + health);
        }

        public void PrintAttack()
        {
            Console.WriteLine(name + " attack does " + attack +" damage");

        }

    }


    class Enemy: Fighter
    {
        public Enemy( string nm) : base (n);
       
        Name = n
    }


}

    
