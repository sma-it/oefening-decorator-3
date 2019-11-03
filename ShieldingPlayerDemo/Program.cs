using ShieldingPlayerDemo.Projectiles;
using System;

namespace ShieldingPlayerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IDamageTaker player = new Player();
            var random = new Random();

            var menu = new SMUtils.Menu();
            menu.AddOption('1', "Fire!", () =>
            {
                IProjectile projectile = null;

                // create a projectile here

                if(projectile != null)
                {
                    player.AttackWith(projectile);
                }
                
                player.PrintStatus();
            });

            menu.AddOption('2', "Add Basic Shield", () =>
            {
                Console.WriteLine("Basic Shield Applied");
            });

            menu.AddOption('3', "Add Fire Shield", () =>
            {
                Console.WriteLine("Fire Shield Applied");
            });

            menu.AddOption('4', "Add Arcane Shield", () =>
            {
                Console.WriteLine("Arcane Shield Applied");
            });

            menu.AddOption('5', "Add SuperShield", () =>
            {
                Console.WriteLine("Superior Shield Applied");
            });

            menu.Start();
        }
    }
}
