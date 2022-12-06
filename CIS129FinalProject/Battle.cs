

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

            {
                Console.WriteLine(enemy.GetName(enemy) + " the " + enemy.GetMonsterType(enemy) + " appears!");
                Console.WriteLine(enemy.GetName(enemy) + "'s current health: " + enemy.GetHealth() + "/" + enemy.GetMaxHP());
                Console.WriteLine();
                Console.WriteLine("Wizert current health: " + wizert.GetCurrentHP() + "/" + wizert.GetMaxHP());
                Console.WriteLine("Wizert current magicka: " + wizert.GetCurrentMP() + "/" + wizert.GetMaxMP());
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
                            Console.WriteLine("Wizert suffers a fatal blow and collapses to the ground. Millenia of knowledge and wisdom lost needlessly.");
                            Console.WriteLine("Will the body ever be recovered, or only be the last thing the next unfortunate soul sees?");
                            break;             
                        }
                        Console.WriteLine("Wizert current health: " + wizert.GetCurrentHP() + "/" + wizert.GetMaxHP());
                        Console.WriteLine("Wizert current magicka: " + wizert.GetCurrentMP() + "/" + wizert.GetMaxMP());
                        Console.WriteLine();

                    }
                    else
                    {
                        Console.WriteLine(enemy.GetName(enemy) + " the " + enemy.GetMonsterType(enemy) + " defeated!");
                    }

                    if (wizert.GetCurrentHP() >= 70)
                    {
                        Console.WriteLine();
                        Console.WriteLine(" -------------        *     ");
                        Console.WriteLine("| 1 to Attack |   *  <_>  * ");
                        Console.WriteLine("| 2 to Heal   |       |     ");
                        Console.WriteLine("| 3 to Flee   |       |     ");
                        Console.WriteLine(" -------------              ");
                    }
                    else if (wizert.GetCurrentHP() >= 45)
                    {
                        Console.WriteLine();
                        Console.WriteLine(" -------------             ");
                        Console.WriteLine("| 1 to Attack |   *  <_>  * ");
                        Console.WriteLine("| 2 to Heal   |       |     ");
                        Console.WriteLine("| 3 to Flee   |       |     ");
                        Console.WriteLine(" -------------              ");
                    }
                    else if (wizert.GetCurrentHP() >= 20)
                    {
                        Console.WriteLine();
                        Console.WriteLine(" -------------             ");
                        Console.WriteLine("| 1 to Attack |   *  <_>   ");
                        Console.WriteLine("| 2 to Heal   |       |     ");
                        Console.WriteLine("| 3 to Flee   |       |     ");
                        Console.WriteLine(" -------------              ");
                    }
                    else if (wizert.GetCurrentHP() > 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine(" -------------             ");
                        Console.WriteLine("| 1 to Attack |      <_>   ");
                        Console.WriteLine("| 2 to Heal   |       |     ");
                        Console.WriteLine("| 3 to Flee   |       |     ");
                        Console.WriteLine(" -------------              ");
                    }


                    command = Console.ReadLine();
                    Console.Clear();

                    if (command == "1")
                    {
                        if (wizert.GetCurrentMP() >= 3)
                        {
                            Console.WriteLine("Wizert spends 3 magicka casting Fireball! 5 damage dealt to " + enemy.GetName(enemy) + " the " + enemy.GetMonsterType(enemy));
                            wizert.CastFireball();
                            enemy.SetHealth(enemy.GetHealth() - 5);
                        }
                        else
                        {
                            Console.WriteLine("Not enough magicka to cast Fireball!");
                            Console.WriteLine();
                        }

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
                    }

                    else if (command == "3")
                    {
                        Random r = new Random();
                        int chance = r.Next(0, 3);
                        if (chance == 0)
                        {
                            Console.WriteLine("Wizert flees the battle!");
                            Console.WriteLine();
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

        public static void SpecialBattle(Hero wizert, Monster evilWizert)
        {
            string command;

            while (wizert.GetHealth() > 0 && evilWizert.GetHealth() > 0)
            {

                if (evilWizert.GetHealth() > 0)
                {
                    if (evilWizert.GetCurrentMP() > 0)
                    {

                        Console.WriteLine("Dark Wizert's current health: " + evilWizert.GetHealth() + "/" + evilWizert.GetMaxHP());
                        Console.WriteLine("Dark Wizert's current magicka: " + evilWizert.GetCurrentMP() + "/" + evilWizert.GetMaxMP());
                        Console.WriteLine();
                        Console.WriteLine("Dark Wizert spends 5 magicka casting Fireball!");
                        Thread.Sleep(2000);
                        Console.WriteLine();
                        Console.WriteLine("10 damage dealt to Wizert!");
                        Console.WriteLine();
                        Console.WriteLine("Dark Wizert's current health: " + evilWizert.GetHealth() + "/" + evilWizert.GetMaxHP());
                        Console.WriteLine("Dark Wizert's current magicka: " + evilWizert.GetCurrentMP() + "/" + evilWizert.GetMaxMP());
                        evilWizert.SetCurrentMP(evilWizert.GetCurrentMP() - 5);
                        Console.WriteLine();
                        wizert.SetHealth(wizert.GetHealth() - 10);
                    }
                    else
                    {
                        evilWizert.SetCurrentMP(0);
                        Console.WriteLine("Dark Wizert has no magicka and is unable to attack!");
                        Console.WriteLine("It flails about, hurting itself and taking 5 damage!");
                        evilWizert.SetHealth(evilWizert.GetHealth() - 5);
                        Console.WriteLine();
                        Console.WriteLine("Dark Wizert's current health: " + evilWizert.GetHealth() + "/" + evilWizert.GetMaxHP());
                        Console.WriteLine("Dark Wizert's current magicka: " + evilWizert.GetCurrentMP() + "/" + evilWizert.GetMaxMP());
                        Console.WriteLine();
                    }

                    if (wizert.GetCurrentHP() <= 0)
                    {
                        Console.WriteLine("Wizert suffers a fatal blow and collapses to the ground. Millenia of knowledge and wisdom lost needlessly.");
                        Console.WriteLine("Will the body ever be recovered, or only be the last thing the next unfortunate soul sees?");
                        break;
                    }
                    Console.WriteLine("Wizert current health: " + wizert.GetCurrentHP() + "/" + wizert.GetMaxHP());
                    Console.WriteLine("Wizert current magicka: " + wizert.GetCurrentMP() + "/" + wizert.GetMaxMP());
                    Console.WriteLine();

                }

                if (wizert.GetCurrentHP() > 60)
                {
                    Console.WriteLine();
                    Console.WriteLine(" -------------        *     ");
                    Console.WriteLine("| 1 to Attack |   *  <_>  * ");
                    Console.WriteLine("| 2 to Heal   |       |     ");
                    Console.WriteLine("|             |       |     ");
                    Console.WriteLine(" -------------              ");
                }
                else if (wizert.GetCurrentHP() <= 60)
                {
                    Console.WriteLine();
                    Console.WriteLine(" -------------        *     ");
                    Console.WriteLine("| 1 to Attack |   *  <_>  * ");
                    Console.WriteLine("| 2 to Heal   |  **   |   **  ");
                    Console.WriteLine("| 3 to ????   | ***   |   ***  ");
                    Console.WriteLine(" -------------   ***     ***      ");
                }
              


                command = Console.ReadLine();
                Console.Clear();

                if (command == "1")
                {
                    if (wizert.GetCurrentMP() >= 3)
                    {

                        Console.WriteLine("Wizert spends 3 magicka casting Fireball!");
                        Thread.Sleep(2000);
                        Console.WriteLine();
                        Console.WriteLine("5 damage dealt to Dark Wizert!");
                        Console.WriteLine();
                        evilWizert.SetHealth(evilWizert.GetHealth() - 5);
                        wizert.SetMP(wizert.GetCurrentMP() - 3);
                        Console.WriteLine("Wizert current health: " + wizert.GetCurrentHP() + "/" + wizert.GetMaxHP());
                        Console.WriteLine("Wizert current magicka: " + wizert.GetCurrentMP() + "/" + wizert.GetMaxMP());
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Not enough magicka to cast Fireball!");
                        Console.WriteLine();
                    }

                    if (evilWizert.GetHealth() <= 0)
                    {
                        evilWizert.SetHealth(0);
                        Console.WriteLine("Dark Wizert slowly crumbles and disintegrates, releasing the spirits it had held captive.");
                        Console.WriteLine();
                    }
                }
                else if (command == "2")
                {
                    wizert.CastHeal();
                }

                else if (command == "3" && wizert.GetCurrentHP() <= 60)
                {
                    Console.WriteLine("Wizert sacrifices 10 health to cast Magicka Burn!");
                    Console.WriteLine();
                    Console.WriteLine("              *                          ");
                    Console.WriteLine("            `   `                         ");
                    Console.WriteLine("           *  ,  *                        ");
                    Console.WriteLine("            `    `                        ");
                    Console.WriteLine("              *                          ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Any key to continue:");
                    Console.ReadKey();
                    Console.WriteLine("75 magicka burned from Dark Wizert!");
                    Console.WriteLine();
                    wizert.SetHealth(wizert.GetHealth() - 10);
                    evilWizert.SetCurrentMP(evilWizert.GetCurrentMP() - 75);
                }

                else
                {
                    Console.WriteLine($"{command} is not a known spell, Wizert flinches!");
                    Console.WriteLine();
                }
            }
        }
    }
}
