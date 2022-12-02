using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CIS129FinalProject
{
    public class Map
    {
        int wizertX_Coord;
        int wizertY_Coord;
        object playerPos;

        bool isWall = false;
        bool hasMonster = false;

        Hero Wizert;



        Room wall = new Room(true, false);

        Room exit = new Room(false, true);





        //Monsters

        //Goblins
        Monster goblin1;
        Monster goblin2;
        Monster goblin3;
        Monster goblin4;
        Monster goblin5;
        Monster goblin6;
        Monster goblin7;

        //Orcs
        Monster orc1;
        Monster orc2;
        Monster orc3;
        Monster orc4;

        //Banshees
        Monster banshee1;
        Monster banshee2;
        Monster banshee3;
        Monster banshee4;
        Monster banshee5;
        Monster banshee6;


        //Manually Populate Rooms
        internal Room SpawnRoom;

        Room Hall_1_3;
        Room Hall_2_3;
        Room Hall_3_1;
        Room Hall_3_2;
        Room Hall_3_3_Potion;
        Room Hall_3_4;
        Room Hall_3_5;
        Room Hall_4_3;
        Room Hall_5_3;

        Room NW_1_1;
        Room NW_1_2;
        Room NW_2_1;
        Room NW_2_2;

        Room NE_1_4;
        Room NE_1_5;
        Room NE_2_4;
        Room NE_2_5;

        Room SW_4_1;
        Room SW_4_2;
        Room SW_5_1;
        Room SW_5_2;

        Room SE_4_4;
        Room SE_4_5;
        Room SE_5_4;
        Room SE_5_5;


        public void PopulateMap(object[,] array)
        {

            //Spawn Map

            array[0, 0] = wall;
            array[0, 1] = wall;
            array[0, 2] = wall;
            array[0, 3] = wall;
            array[0, 4] = wall;
            array[0, 5] = wall;
            array[0, 6] = wall;

            array[1, 0] = wall;
            array[1, 1] = NW_1_1 = new Room(true, goblin1 = new Monster(true, "Thel'Kuz", "Goblin", false, null, "NW"), "NW", null, false, false);
            array[1, 2] = NW_1_2 = new Room(true, orc2 = new Monster (true, "Banthomir", "Orc", false, null, "NW"), "NW", null, false, false);
            array[1, 3] = Hall_1_3 = new Room(true, goblin6 = new Monster (true, "D'yer", "Goblin", false, null, "Hall"), "Hall", null, false, false);
            array[1, 4] = NE_1_4 = new Room(true, banshee3 = new Monster (true, "Myn'dir", "Banshee", false, null, "NE"), "NE", null, false, false);
            array[1, 5] = NE_1_5 = new Room(true, banshee4 = new Monster (true, "Vallah", "Banshee", true, "hp", "NE"), "NE", null, false, false);
            array[1, 6] = wall;

            array[2, 0] = wall;
            array[2, 1] = NW_2_1 = new Room(true, orc3 = new Monster(true, "Urum", "Orc", false, null, "NW"), "NW", null, false, false);
            array[2, 2] = NW_2_2 = new Room(true, goblin6 = new Monster(true, "H'ralm", "Goblin", false, null, "NW"), "NW", null, false, false);
            array[2, 3] = Hall_2_3 = new Room(false, null, "Hall", null, false, false);
            array[2, 4] = NE_2_4 = new Room(false, null, "NE", null, false, false);
            array[2, 5] = NE_2_5 = new Room(false, null, "NE", null, false, false);
            array[2, 6] = wall;

            array[3, 0] = wall;
            array[3, 1] = Hall_3_1 = new Room(false, null, "Hall", null, false, false);
            array[3, 2] = Hall_3_2 = new Room(false, null, "Hall", null, false, false);
            array[3, 3] = Hall_3_3_Potion = new Room(false, null, "Hall", "hp", true, false);
            array[3, 4] = Hall_3_4 = new Room(true, goblin2 = new Monster(true, "Oritz", "Goblin", false, null, "Hall"), "Hall", null, false, false);
            array[3, 5] = Hall_3_5 = new Room(true, banshee5 = new Monster(true, "Wexyl", "Banshee", false, null, "Hall"), "Hall", null, false, false);
            array[3, 6] = wall;

            array[4, 0] = wall;
            array[4, 1] = SW_4_1 = new Room(true, goblin4 = new Monster (true, "Znul", "Goblin", false, null, "SW"), "SW", null, false, false);
            array[4, 2] = SW_4_2 = new Room(true, banshee2 = new Monster (true, "Vy'shel", "Banshee", false, null, "SW"), "SW", null, false, false);
            array[4, 3] = Hall_4_3 = new Room(true, goblin5 = new Monster (true, "Yarick", "Goblin", false, null, "Hall"), "Hall", null, false, false);
            array[4, 4] = SE_4_4 = new Room(true, orc1 = new Monster(true, "Yira", "Orc", false, null, "SE"), "SE", null, false, false);
            array[4, 5] = SE_4_5 = new Room(true, banshee6 = new Monster(true, "Trazon", "Banshee", false, null, "SE"), "SE", null, false, false);
            array[4, 6] = wall;

            array[5, 0] = wall;
            array[5, 1] = SW_5_1 = new Room(false, null, "SW", "mp", true, false);
            array[5, 2] = SW_5_2 = new Room(true, orc4 = new Monster (true, "Itheem", "Orc", false, null, "SW"), "SW", null, false, false);
            array[5, 3] = Hall_5_3 = new Room(false, null, "Hall", null, false, false);
            array[5, 4] = SE_5_4 = new Room(true, goblin3 = new Monster (true, "Novka", "Goblin", false, null, "SE"), "SE", null, false, false);
            array[5, 5] = SE_5_5 = new Room(true, banshee1 = new Monster(true, "R'vaj", "Banshee", true, "hp", "SE"), "SE", null, false, false);
            array[5, 6] = wall;

            array[6, 0] = wall;
            array[6, 1] = wall;
            array[6, 2] = wall;
            array[6, 3] = wall;
            array[6, 4] = wall;
            array[6, 5] = wall;
            array[6, 6] = wall;


            //Spawn Exit Randomly
            Random r = new Random();

            int x = r.Next(0, 7);
            int y = r.Next(0, 7);
            int z = r.Next(0, 3);

            if (x == 0 || x == 6)
            {
                y = r.Next(1, 6);
            }

            else if (x != 0 || x != 6)
            {
                if (z == 1)
                {
                    y = 0;
                }
                else
                {
                    y = 6;
                }
            }
            array[x, y] = exit;
        }

        public void SpawnPlayerRandomly(object[,] array)
        {
            //Spawn Player Randomly
            Wizert = new Hero("Wizert", "Wizert", 100, 200);
            Random rand = new Random();
            int spawn1 = rand.Next(1, 6);
            int spawn2 = rand.Next(1, 6);


            playerPos = array[spawn1, spawn2];


            SpawnRoom = new Room(true, "Spawn", true, false, false);
            


            wizertX_Coord = spawn1;
            wizertY_Coord = spawn2;

        }

        public object GetPlayerPosition()
        {
            return wizertX_Coord + "," + wizertY_Coord;
        }



        public void PrintMap(object[,] map)
        {
            int iterator = 0;
            int line = 0;
            foreach (var item in map)
            {
                Console.Write(item + " ");
                iterator++;
                if (iterator == 7)
                {
                    Console.WriteLine();
                    iterator = 0;
                    line++;
                }
            }
        }

        public void Move(string direction, object[,] array, ref bool victory, ref bool defeat, Room? room)
        {


            object nextArray;
            object currentArray;
            Monster monsterToFight;
            Monster deadMonster;
            Room roomNextArray;


            


            Room tempRoom;


            if (victory == false || defeat == false)
            {

                //Move South


                if (direction == "s")

                {
                    Console.Clear();
                    nextArray = array[wizertX_Coord + 1, wizertY_Coord];
                    currentArray = array[wizertX_Coord, wizertY_Coord];


                    if (nextArray.Equals(wall))
                    {
                        //isWall = true;
                        Console.WriteLine("You run into a wall. Despair and hopelessness sets in, but you push on.");
                        Console.WriteLine();
                    }

                    if (nextArray.Equals(exit))
                    {
                        string? prompt = null;
                        while (prompt != "y" || prompt != "n")
                        {
                            Console.WriteLine("You find the exit! Escape? Y/N");
                            prompt = Console.ReadLine().ToLower();
                            Console.Clear();
                            if (prompt == "y")
                            {
                                Console.WriteLine("Wizert escapes to daylight!");
                                Console.WriteLine("But to flee...or seek vengeance?");
                                victory = true;
                                Wizert.SetMP(200);
                                Wizert.SetHP(100);
                                break;
                            }
                            else if (prompt == "n")
                            {
                                Console.WriteLine("The Wizert turns his back on the daylight and returns to the dungeon.");
                                Console.WriteLine("A grim reminder that most who turn their back on the light never again find it...");
                                Console.WriteLine();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Thinking you would never see daylight again, ");
                                Console.WriteLine("the Wizert collapses and reflects on their time spent in this forsaken place...");
                                Console.WriteLine();
                                Console.WriteLine($"{prompt} is not a valid decision to leave the dungeon.");
                            }
                        }
                    }

                    //Move Player
                    else if (!(nextArray.Equals(wall))) 
                    {
                        
                        wizertX_Coord++;
                        playerPos = array[wizertX_Coord, wizertY_Coord];
                        room = (Room?)array[wizertX_Coord, wizertY_Coord];

                        Console.WriteLine("You move to the South");

                        if (room.GetRoomType() == "NE")
                        {
                            Console.WriteLine(room.PrintNERoom());
                        }

                        else if (room.GetRoomType() == "SE")
                        {
                            Console.WriteLine(room.PrintSERoom());
                        }

                        else if (room.GetRoomType() == "SW")
                        {
                            Console.WriteLine(room.PrintSWRoom());
                        }

                        else if (room.GetRoomType() == "NW")
                        {
                            Console.WriteLine(room.PrintNWRoom());
                        }

                        else if (room.GetRoomType() == "Hall")
                        {
                            Console.WriteLine(room.PrintHallRoom());
                        }

                        Console.WriteLine();

                        if (room.GetPotion() == true)
                        {
                            room.UsePotion(room.GetPotionType(), Wizert);
                            room.SetPotion(false);
                            Console.WriteLine();
                        }
                    }
                   

                    if (room.ContainsMonster() == true)
                    {
                        monsterToFight = room.GetMonster();
                        deadMonster = room.GetMonster();



                        if (monsterToFight.GetHealth() > 0)
                        {
                            Battle.BeginBattle(Wizert, monsterToFight);
                            if (Wizert.GetHealth() <= 0)
                            {
                                defeat = true;
                            }
                        }
                        if (monsterToFight.GetHealth() <= 0)
                        {

                            Console.WriteLine($"{deadMonster.GetName(deadMonster)} the {deadMonster.GetMonsterType(deadMonster)}'s corpse lays at your feet");
                            Console.WriteLine();
                            if (monsterToFight.GetHasItem() == true)
                            {
                                Console.WriteLine($"{deadMonster.GetName(deadMonster)} the {deadMonster.GetMonsterType(deadMonster)} drops a potion!");
                                monsterToFight.UsePotion(monsterToFight.GetItemType(), Wizert);
                                monsterToFight.SetHasItem(false);
                            }
                        }  
                    }
                }
            }

                if (direction == "d")
                {
                Console.Clear();
                nextArray = array[wizertX_Coord, wizertY_Coord + 1];


                    if (nextArray.Equals(wall))
                    {

                        Console.WriteLine("Your hands press up against a wall and feel the cracked bricks.");
                        Console.WriteLine();
                }

                    if (nextArray.Equals(exit))
                    {
                    string? prompt = null;
                    while (prompt != "y" || prompt != "n")
                    {
                        Console.WriteLine("You find the exit! Escape? Y/N");
                        prompt = Console.ReadLine().ToLower();
                        Console.Clear();
                        if (prompt == "y")
                        {
                            Console.WriteLine("Wizert escapes to daylight!");
                            Console.WriteLine("But to flee...or seek vengeance?");
                            victory = true;
                            Wizert.SetMP(200);
                            Wizert.SetHP(100);
                            break;
                        }
                        else if (prompt == "n")
                        {
                            Console.WriteLine("The Wizert turns his back on the daylight and returns to the dungeon.");
                            Console.WriteLine("A grim reminder that most who turn their back on the light never again find it...");
                            Console.WriteLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Thinking you would never see daylight again, ");
                            Console.WriteLine("the Wizert collapses and reflects on their time spent in this forsaken place...");
                            Console.WriteLine();
                            Console.WriteLine($"{prompt} is not a valid decision to leave the dungeon.");
                        }
                    }
                }

                    //Move player
                    else if (!(nextArray.Equals(wall)))
                    {
                        
                    wizertY_Coord++;
                    playerPos = array[wizertX_Coord, wizertY_Coord];
                    
                    room = (Room?)array[wizertX_Coord, wizertY_Coord];

                    Console.WriteLine("You move to the East");

                    if (room.GetRoomType() == "NE")
                    {
                        Console.WriteLine(room.PrintNERoom());
                    }

                    else if (room.GetRoomType() == "SE")
                    {
                        Console.WriteLine(room.PrintSERoom());
                    }

                    else if (room.GetRoomType() == "SW")
                    {
                        Console.WriteLine(room.PrintSWRoom());
                    }

                    else if (room.GetRoomType() == "NW")
                    {
                        Console.WriteLine(room.PrintNWRoom());
                    }
                    else if (room.GetRoomType() == "Hall")
                    {
                        Console.WriteLine(room.PrintHallRoom());
                    }

                    Console.WriteLine();

                    if (room.GetPotion() == true)
                    {
                        room.UsePotion(room.GetPotionType(), Wizert);
                        room.SetPotion(false);
                        Console.WriteLine();
                    }
                }


                if (room.ContainsMonster() == true)
                {
                    monsterToFight = room.GetMonster();
                    deadMonster = room.GetMonster();

                    if (monsterToFight.GetHealth() > 0)
                    {
                        Battle.BeginBattle(Wizert, monsterToFight);
                        if (Wizert.GetHealth() <= 0)
                        {
                            defeat = true;
                        }
                    }
                    if (monsterToFight.GetHealth() <= 0)
                    {
                        Console.WriteLine($"{deadMonster.GetName(deadMonster)} the {deadMonster.GetMonsterType(deadMonster)}'s corpse lays at your feet");
                        Console.WriteLine();

                        if (monsterToFight.GetHasItem() == true)
                        {
                            Console.WriteLine($"{deadMonster.GetName(deadMonster)} the {deadMonster.GetMonsterType(deadMonster)} drops a potion!");
                            monsterToFight.UsePotion(monsterToFight.GetItemType(), Wizert);
                            monsterToFight.SetHasItem(false);
                        }
                    }
                }
            }

                if (direction == "a")
                {
                Console.Clear();
                nextArray = array[wizertX_Coord, wizertY_Coord - 1];


                    if (nextArray.Equals(wall))
                    {
                        Console.WriteLine("Your step is impeded as you walk into a fungus covered wall");
                        Console.WriteLine();
                }

                    if (nextArray.Equals(exit))
                    {
                    string? prompt = null;
                    while (prompt != "y" || prompt != "n")
                    {
                        Console.WriteLine("You find the exit! Escape? Y/N");
                        prompt = Console.ReadLine().ToLower();
                        Console.Clear();
                        if (prompt == "y")
                        {
                            Console.WriteLine("Wizert escapes to daylight!");
                            Console.WriteLine("But to flee...or seek vengeance?");
                            victory = true;
                            Wizert.SetMP(200);
                            Wizert.SetHP(100);
                            break;
                        }
                        else if (prompt == "n")
                        {
                            Console.WriteLine("The Wizert turns his back on the daylight and returns to the dungeon.");
                            Console.WriteLine("A grim reminder that most who turn their back on the light never again find it...");
                            Console.WriteLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Thinking you would never see daylight again, ");
                            Console.WriteLine("the Wizert collapses and reflects on their time spent in this forsaken place...");
                            Console.WriteLine();
                            Console.WriteLine($"{prompt} is not a valid decision to leave the dungeon.");
                        }
                    }
                }

                    //Move player
                    else if (!(nextArray.Equals(wall)))
                    {
                        
                        wizertY_Coord--;
                        playerPos = array[wizertX_Coord, wizertY_Coord];
                    
                    room = (Room?)array[wizertX_Coord, wizertY_Coord];
                    Console.WriteLine("You move to the West");

                    if (room.GetRoomType() == "NE")
                    {
                        Console.WriteLine(room.PrintNERoom());
                    }

                    else if (room.GetRoomType() == "SE")
                    {
                        Console.WriteLine(room.PrintSERoom());
                    }

                    else if (room.GetRoomType() == "SW")
                    {
                        Console.WriteLine(room.PrintSWRoom());
                    }

                    else if (room.GetRoomType() == "NW")
                    {
                        Console.WriteLine(room.PrintNWRoom());
                    }

                    else if (room.GetRoomType() == "Hall")
                    {
                        Console.WriteLine(room.PrintHallRoom());
                    }

                    Console.WriteLine();

                    if (room.GetPotion() == true)
                    {
                        room.UsePotion(room.GetPotionType(), Wizert);
                        room.SetPotion(false);
                        Console.WriteLine();
                    }
                }


                if (room.ContainsMonster() == true)
                {
                    monsterToFight = room.GetMonster();
                    deadMonster = room.GetMonster();

                    if (monsterToFight.GetHealth() > 0)
                    {
                        Battle.BeginBattle(Wizert, monsterToFight);
                        if (Wizert.GetHealth() <= 0)
                        {
                            defeat = true;
                        }
                    }
                    if (monsterToFight.GetHealth() <= 0)
                    {
                        Console.WriteLine($"{deadMonster.GetName(deadMonster)} the {deadMonster.GetMonsterType(deadMonster)}'s corpse lays at your feet");
                        Console.WriteLine();

                        if (monsterToFight.GetHasItem() == true)
                        {
                            Console.WriteLine($"{deadMonster.GetName(deadMonster)} the {deadMonster.GetMonsterType(deadMonster)} drops a potion!");
                            monsterToFight.UsePotion(monsterToFight.GetItemType(), Wizert);
                            monsterToFight.SetHasItem(false);
                        }
                    }
                }
            }

                if (direction == "w")
                {
                Console.Clear();
                nextArray = array[wizertX_Coord - 1, wizertY_Coord];


                    if (nextArray.Equals(wall))
                    {
                        Console.WriteLine("You place your hand on a body temperature wall.");
                        Console.WriteLine();
                }

                    if (nextArray.Equals(exit))
                    {
                    string? prompt = null;
                    while (prompt != "y" || prompt != "n")
                    {
                        Console.WriteLine("You find the exit! Escape? Y/N");
                        prompt = Console.ReadLine().ToLower();
                        Console.Clear();
                        if (prompt == "y")
                        {
                            Console.WriteLine("Wizert escapes to daylight!");
                            Console.WriteLine("But to flee...or seek vengeance?");
                            victory = true;
                            Wizert.SetMP(200);
                            Wizert.SetHP(100);
                            break;
                        }
                        else if (prompt == "n")
                        {
                            Console.WriteLine("The Wizert turns his back on the daylight and returns to the dungeon.");
                            Console.WriteLine("A grim reminder that most who turn their back on the light never again find it...");
                            Console.WriteLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Thinking you would never see daylight again, ");
                            Console.WriteLine("the Wizert collapses and reflects on their time spent in this forsaken place...");
                            Console.WriteLine();
                            Console.WriteLine($"{prompt} is not a valid decision to leave the dungeon.");
                        }
                    }
                }

                    
                    //Move player
                    else if (!(nextArray.Equals(wall)))
                    {
                        
                        wizertX_Coord--;
                        playerPos = array[wizertX_Coord, wizertY_Coord];
                  
                    room = (Room?)array[wizertX_Coord, wizertY_Coord];
                    Console.WriteLine("You move to the North");

                    if (room.GetRoomType() == "NE")
                    {
                        Console.WriteLine(room.PrintNERoom());
                    }

                    else if (room.GetRoomType() == "SE")
                    {
                        Console.WriteLine(room.PrintSERoom());
                    }

                    else if (room.GetRoomType() == "SW")
                    {
                        Console.WriteLine(room.PrintSWRoom());
                    }

                    else if (room.GetRoomType() == "NW")
                    {
                        Console.WriteLine(room.PrintNWRoom());
                    }

                    else if (room.GetRoomType() == "Hall")
                    {
                        Console.WriteLine(room.PrintHallRoom());
                    }

                    Console.WriteLine();

                    if (room.GetPotion() == true)
                    {
                        room.UsePotion(room.GetPotionType(), Wizert);
                        room.SetPotion(false);
                        Console.WriteLine();
                    }
                }


                if (room.ContainsMonster() == true)
                {
                    monsterToFight = room.GetMonster();
                    deadMonster = room.GetMonster();

                    if (monsterToFight.GetHealth() > 0)
                    {
                        Battle.BeginBattle(Wizert, monsterToFight);
                        if (Wizert.GetHealth() <= 0)
                        {
                            defeat = true;
                        }
                    }
                    if (monsterToFight.GetHealth() <= 0)
                    {
                        Console.WriteLine($"{deadMonster.GetName(deadMonster)} the {deadMonster.GetMonsterType(deadMonster)}'s corpse lays at your feet");
                        Console.WriteLine();

                        if (monsterToFight.GetHasItem() == true)
                        {
                            Console.WriteLine($"{deadMonster.GetName(deadMonster)} the {deadMonster.GetMonsterType(deadMonster)} drops a potion!");
                            monsterToFight.UsePotion(monsterToFight.GetItemType(), Wizert);
                            monsterToFight.SetHasItem(false);
                        }
                    }
                }
            }
        }
    }
}






