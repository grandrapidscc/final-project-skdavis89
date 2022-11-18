using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    public class Battle
    {
        Hero wizert;
        Monster enemy;

        public Battle(Hero wizert, Monster enemy)
        {
            this.wizert = wizert;
            this.enemy = enemy;
        }

        public static void BeginBattle (Hero wizert, Monster enemy)
        {
            string command;

            Console.WriteLine(enemy.GetName(enemy) + " the " + enemy.GetMonsterType(enemy) + " appears!");
            Console.WriteLine("Wizert current health: " + wizert.GetHealth());

            while (wizert.GetHealth() > 0 && enemy.GetHealth() > 0)
            {
                Console.WriteLine("press 1 to use fireball, 2 to heal, or 3 to flee");
                command = Console.ReadLine();

                if (command == "1")
                {
                    Console.WriteLine("Wizert casts Fireball! 5 damage dealt to " + enemy.GetName(enemy) + " the " + enemy.GetMonsterType(enemy));
                    wizert.CastFireball();
                    enemy.SetHealth(enemy.GetHealth() - 5);
                    Console.WriteLine("enemy current health: " + enemy.GetHealth());
                }
                else if (command == "2")
                {
                    wizert.CastHeal();
                }

                else if (command == "3")
                {
                    Console.WriteLine("Wizert flees the battle!");
                    break;
                }

                else
                {
                    Console.WriteLine($"{command} is not a known spell, Wizert flinches!");
                }

                if (enemy.GetHealth() > 0)
                {
                    enemy.Attack();
                    wizert.SetHealth(wizert.GetHealth() - enemy.GetMonsterAttackPower(enemy));
                    Console.WriteLine(" current health: " + wizert.GetHealth());

                }
                else
                {
                    Console.WriteLine(enemy.GetName(enemy) + " the " + enemy.GetMonsterType(enemy) + " defeated!");
                    
                }

            }
        }
    }
}
