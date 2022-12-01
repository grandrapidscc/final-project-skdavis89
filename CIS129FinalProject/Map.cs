using System;
using System.Collections.Generic;
using System.Linq;
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
        bool winGame;
        bool isWall = false;
        bool hasMonster = false;

        Hero Wizert;



        Room wall = new Room(true, false);

        Room exit = new Room(false, true);





        //Monsters
        Monster goblin1;
        Monster goblin2;
        Monster goblin3;
        Monster banshee1;
        Monster orc1;
        Monster banshee2;
        Monster orc2;


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
            array[1, 3] = Hall_1_3 = new Room(false, null, "Hall", null, false, false);
            array[1, 4] = NE_1_4 = new Room(false, null, "NE", null, false, false);
            array[1, 5] = NE_1_5 = new Room(false, null, "NE", null, false, false);
            array[1, 6] = wall;

            array[2, 0] = wall;
            array[2, 1] = NW_2_1 = new Room(false, null, "NW", null, false, false);
            array[2, 2] = NW_2_2 = new Room(false, null, "NW", null, false, false);
            array[2, 3] = Hall_2_3 = new Room(false, null, "Hall", null, false, false);
            array[2, 4] = NE_2_4 = new Room(false, null, "NE", null, false, false);
            array[2, 5] = NE_2_5 = new Room(false, null, "NE", null, false, false);
            array[2, 6] = wall;

            array[3, 0] = wall;
            array[3, 1] = Hall_3_1 = new Room(false, null, "Hall", null, false, false);
            array[3, 2] = Hall_3_2 = new Room(false, null, "Hall", "mp", true, false);
            array[3, 3] = Hall_3_3_Potion = new Room(false, null, "Hall", "hp", true, false);
            array[3, 4] = Hall_3_4 = new Room(true, goblin2 = new Monster(true, "Oritz", "Goblin", false, null, "Hall"), "Hall", null, false, false);
            array[3, 5] = Hall_3_5 = new Room(false, null, "Hall", null, false, false);
            array[3, 6] = wall;

            array[4, 0] = wall;
            array[4, 1] = SW_4_1 = new Room(false, null, "SW", null, false, false);
            array[4, 2] = SW_4_2 = new Room(true, banshee2 = new Monster (true, "Vy'shel", "Banshee", false, null, "SW"), "SW", null, false, false);
            array[4, 3] = Hall_4_3 = new Room(false, null, "Hall", null, false, false);
            array[4, 4] = SE_4_4 = new Room(true, orc1 = new Monster(true, "Yira", "Orc", false, null, "SE"), "SE", null, false, false);
            array[4, 5] = SE_4_5 = new Room(false, null, "SE", null, false, false);
            array[4, 6] = wall;

            array[5, 0] = wall;
            array[5, 1] = SW_5_1 = new Room(false, null, "SW", null, false, false);
            array[5, 2] = SW_5_2 = new Room(false, null, "SW", null, false, false);
            array[5, 3] = Hall_5_3 = new Room(false, null, "Hall", null, false, false);
            array[5, 4] = SE_5_4 = new Room(true, goblin3 = new Monster (true, "Novka", "Goblin", true, "mp", "SE"), "SE", null, false, false);
            array[5, 5] = SE_5_5 = new Room(true, banshee1 = new Monster(true, "R'vaj", "Banshee", true, "hp", "SE"), "SE", null, false, false);
            array[5, 6] = wall;

            array[6, 0] = wall;
            array[6, 1] = wall;
            array[6, 2] = wall;
            array[6, 3] = wall;
            array[6, 4] = wall;
            array[6, 5] = wall;
            array[6, 6] = wall;



            //array[0, 0] = "wall 0,0";
            //array[0, 1] = "wall 0,1";
            //array[0, 2] = "wall 0,2";
            //array[0, 3] = "wall 0,3";
            //array[0, 4] = "wall 0,4";
            //array[0, 5] = "wall 0,5";
            //array[0, 6] = "wall 0,6";

            //array[1, 0] = "wall 1,0";
            //array[1, 1] = "space 1,1";
            //array[1, 2] = "space 1,2";
            //array[1, 3] = "space 1,3";
            //array[1, 4] = "space 1,4";
            //array[1, 5] = "space 1,5";
            //array[1, 6] = "wall 1,6";

            //array[2, 0] = "wall 2,0";
            //array[2, 1] = "space 2,1";
            //array[2, 2] = "space 2,2";
            //array[2, 3] = "space 2,3";
            //array[2, 4] = "goblin 2.4";
            //array[2, 5] = "space 2.5";
            //array[2, 6] = "wall 2.6";

            //array[3, 0] = "wall 3.0";
            //array[3, 1] = "space 3.1";
            //array[3, 2] = "space 3.2";
            //array[3, 3] = goblin1 = new Monster(true, "Goblin1", "Goblin", false, "Hall");
            //array[3, 4] = Hall_3_4 = new Room(true, goblin2 = new Monster (true, "Goblin2", "Goblin", false, "Hall"), "Hall", false, false, false);
            //array[3, 5] = "space 3.5";
            //array[3, 6] = "wall 3.6";

            //array[4, 0] = "wall 4.0";
            //array[4, 1] = "space 4.1";
            //array[4, 2] = "space 4.2";
            //array[4, 3] = "space 4.3";
            //array[4, 4] = "goblin 4.4";
            //array[4, 5] = "space 4.5";
            //array[4, 6] = "wall 4.6";

            //array[5, 0] = "wall 5.0";
            //array[5, 1] = "space 5.1";
            //array[5, 2] = "space 5.2";
            //array[5, 3] = "space 5.3";
            //array[5, 4] = "orc 5.4";
            //array[5, 5] = "space 5.5";
            //array[5, 6] = "wall 5.6";

            //array[6, 0] = "wall 6.0";
            //array[6, 1] = "wall 6.1";
            //array[6, 2] = "wall 6.2";
            //array[6, 3] = "wall 6.3";
            //array[6, 4] = "wall 6.4";
            //array[6, 5] = "wall 6.5";
            //array[6, 6] = "wall 6.6";







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

        public Room ReturnSpawnRoom()
        {
            return SpawnRoom;
        }



           






            public int PlayerX_Coord()
        {
            return wizertX_Coord;
        }



        public int PlayerY_Coord()
        {
            return wizertY_Coord;
        }

        //ARRAYS ARE Y.X INSTEAD OF X.Y??
        public void Set_Wizert_X_Coord(int xCoord)
        {
            wizertX_Coord = xCoord;
        }

        public void Set_Wizert_Y_Coord(int yCoord)
        {
            wizertY_Coord = yCoord;
        }

        public int Get_Wizert_X_Coord()
        {
            return wizertX_Coord;
        }

        public int Get_Wizert_Y_Coord()
        {
            return wizertY_Coord;
        }

        public object GetPlayerPosition()
        {
            return wizertX_Coord + "," + wizertY_Coord;
        }

        public int[] GetWizertPosition()
        {
            return new int[2] { wizertX_Coord, wizertY_Coord }; 
        }



        public void SetPlayerPos(int x, int y)
        {
            wizertX_Coord = x;
            wizertY_Coord = y;
        }

        public Room GetSpawnRoom()
        {
            return SpawnRoom;
        }

        public void PrintMap(object[,] map)
        {
            int iterator = 0;
            int line = 0;
            foreach (var item in map)
            {
                //Console.Write(item.Equals(SpawnRoom));
                
                //Console.Write(item.Equals(SpawnRoom.GetOccupied()) + " ");
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
                        //Console.WriteLine("Move which direction? Input selection and press Enter");
                        //Console.WriteLine("W to move north, S to move south, A to move west, D to move east");
                        //Console.WriteLine();
                        //array[wizertX_Coord - 1, wizertY_Coord] = playerPos; // was = Wizert
                        //currentArray = Wizert;


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
                                Console.WriteLine("Escape to daylight!");
                                victory = true;
                                Wizert.SetMP(200);
                                Wizert.SetHP(100);
                                break;
                            }
                            else if (prompt == "n")
                            {
                                Console.WriteLine("The Wizert turns his back on the daylight and returns to the dungeon. A grim reminder that most who turn their back on the light never again find it...");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Thinking you would never see daylight again, the Wizert collapses and reflects on their time spent in this forsaken place...");
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

                    if (victory != true)
                    {
                        Console.WriteLine("Move which direction? Input selection and press Enter");
                        Console.WriteLine("W to move north, S to move south, A to move west, D to move east");
                        Console.WriteLine();
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
                            Console.WriteLine("Escape to daylight!");
                            victory = true;
                            Wizert.SetMP(200);
                            Wizert.SetHP(100);
                            break;
                        }
                        else if (prompt == "n")
                        {
                            Console.WriteLine("The Wizert turns his back on the daylight and returns to the dungeon. A grim reminder that most who turn their back on the light never again find it...");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Thinking you would never see daylight again, the Wizert collapses and reflects on their time spent in this forsaken place...");
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
                if (victory != true)
                {
                    Console.WriteLine("Move which direction? Input selection and press Enter");
                    Console.WriteLine("W to move north, S to move south, A to move west, D to move east");
                    Console.WriteLine();
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
                            Console.WriteLine("Escape to daylight!");
                            victory = true;
                            Wizert.SetMP(200);
                            Wizert.SetHP(100);
                            break;
                        }
                        else if (prompt == "n")
                        {
                            Console.WriteLine("The Wizert turns his back on the daylight and returns to the dungeon. A grim reminder that most who turn their back on the light never again find it...");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Thinking you would never see daylight again, the Wizert collapses and reflects on their time spent in this forsaken place...");
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
                if (victory != true)
                {
                    Console.WriteLine("Move which direction? Input selection and press Enter");
                    Console.WriteLine("W to move north, S to move south, A to move west, D to move east");
                    Console.WriteLine();
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
                            Console.WriteLine("Escape to daylight!");
                            victory = true;
                            Wizert.SetMP(200);
                            Wizert.SetHP(100);
                            break;
                        }
                        else if (prompt == "n")
                        {
                            Console.WriteLine("The Wizert turns his back on the daylight and returns to the dungeon. A grim reminder that most who turn their back on the light never again find it...");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Thinking you would never see daylight again, the Wizert collapses and reflects on their time spent in this forsaken place...");
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

                if (victory != true)
                {
                    Console.WriteLine("Move which direction? Input selection and press Enter");
                    Console.WriteLine("W to move north, S to move south, A to move west, D to move east");
                    Console.WriteLine();
                }
            }
        }
    }
}






