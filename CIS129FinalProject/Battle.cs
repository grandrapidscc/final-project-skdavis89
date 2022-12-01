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

        public static void BeginBattle(Hero wizert, Monster enemy)
        {
            string command;
            bool enemyDefeated = false;
            bool wizertDefeated = false;
            //while (enemyDefeated == false)
            {

                //Console.Clear();
                Console.WriteLine(enemy.GetName(enemy) + " the " + enemy.GetMonsterType(enemy) + " appears!");
                Console.WriteLine(enemy.GetName(enemy) + "'s current health: " + enemy.GetHealth() + "/" + enemy.GetMaxHP());
                Console.WriteLine();
                Console.WriteLine("Wizert current health: " + wizert.GetCurrentHP() + "/" + wizert.GetMaxHP());
                Console.WriteLine("Wizert current mana: " + wizert.GetCurrentMP() + "/" + wizert.GetMaxMP());
                Console.WriteLine();

                while (wizert.GetHealth() > 0 && enemy.GetHealth() > 0)
                {

                    if (enemy.GetHealth() > 0)
                    {
                        enemy.Attack();
                        Console.WriteLine(enemy.GetName(enemy) + "'s current health: " + enemy.GetHealth() + "/" + enemy.GetMaxHP());
                        Console.WriteLine();
                        wizert.SetHealth(wizert.GetHealth() - enemy.GetMonsterAttackPower(enemy));
                        if (wizert.GetCurrentHP() <= 0)
                        {
                            Console.WriteLine("Wizert defeated....");
                            wizertDefeated = true;
                            break;             
                        }
                        Console.WriteLine("Wizert current health: " + wizert.GetCurrentHP() + "/" + wizert.GetMaxHP());
                        Console.WriteLine("Wizert current mana: " + wizert.GetCurrentMP() + "/" + wizert.GetMaxMP());
                        Console.WriteLine();

                    }
                    else
                    {
                        Console.WriteLine(enemy.GetName(enemy) + " the " + enemy.GetMonsterType(enemy) + " defeated!");

                        enemyDefeated = true;
                    }
                    //Console.WriteLine("press 1 to use fireball, 2 to heal, or 3 to flee");
                    Console.WriteLine();
                    Console.WriteLine(" -------------        *     ");
                    Console.WriteLine("| 1 to Attack |   *  <_>  * ");
                    Console.WriteLine("| 2 to Heal   |       |     ");
                    Console.WriteLine("| 3 to Flee   |       |     ");
                    Console.WriteLine(" -------------              ");


                    command = Console.ReadLine();
                    Console.Clear();

                    if (command == "1")
                    {
                        Console.WriteLine("Wizert casts Fireball! 5 damage dealt to " + enemy.GetName(enemy) + " the " + enemy.GetMonsterType(enemy));
                        wizert.CastFireball();
                        enemy.SetHealth(enemy.GetHealth() - 5);
                        if (enemy.GetHealth() <= 0)
                        {
                            enemy.SetHealth(0);
                            Console.WriteLine(enemy.GetName(enemy) + " the " + enemy.GetMonsterType(enemy) + " has been slain!");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine(enemy.GetName(enemy) + " the " + enemy.GetMonsterType(enemy) + "'s current health: " + enemy.GetHealth() + "/" + enemy.GetMaxHP());
                        }
                    }
                    else if (command == "2")
                    {
                        wizert.CastHeal();
                        Console.WriteLine();
                    }

                    else if (command == "3")
                    {
                        Random r = new Random();
                        int chance = r.Next(0, 3);
                        if (chance == 0)
                        {
                            Console.WriteLine("Wizert flees the battle!");
                            Console.WriteLine();
                            Console.WriteLine("Move which direction? Input selection and press Enter");
                            Console.WriteLine("W to move north, S to move south, A to move west, D to move east");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Wizert attempts to flee the battle against " + enemy.GetName(enemy) + " the " + enemy.GetMonsterType(enemy) + ", but fails!");
                            Console.WriteLine();
                        }
                        
                    }

                    else
                    {
                        Console.WriteLine($"{command} is not a known spell, Wizert flinches!");
                    }
                }
            }
        }
    }
}
