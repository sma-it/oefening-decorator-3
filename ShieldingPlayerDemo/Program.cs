using ShieldingPlayerDemo.Projectiles;
using ShieldingPlayerDemo.Shields;
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

                switch(random.Next(4))
                {
                    case 0:
                        projectile = new Stone();
                        Console.WriteLine("Trowing a stone...");
                        break;
                    case 1:
                        projectile = new Arrow();
                        Console.WriteLine("Shooting an arrow...");
                        break;
                    case 2:
                        projectile = new FireArrow();
                        Console.WriteLine("Shooting a flaming arrow...");
                        break;
                    case 3:
                        projectile = new Spell();
                        Console.WriteLine("Casting a spell...");
                        break;
                }

                player.AttackWith(projectile);
                player.PrintStatus();
            });

            menu.AddOption('2', "Add Basic Shield", () =>
            {
                player = new BasicShield(player);
                Console.WriteLine("Basic Shield Applied");
            });

            menu.AddOption('3', "Add Fire Shield", () =>
            {
                player = new FireShield(player);
                Console.WriteLine("Fire Shield Applied");
            });

            menu.AddOption('4', "Add Arcane Shield", () =>
            {
                player = new ArcaneShield(player);
                Console.WriteLine("Arcane Shield Applied");
            });

            menu.AddOption('5', "Add SuperShield", () =>
            {
                player = new SuperShield(player);
                Console.WriteLine("Superior Shield Applied");
            });

            menu.Start();
        }
    }
}
