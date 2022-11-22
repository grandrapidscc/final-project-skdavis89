﻿using System;
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
        Hero Wizert = new Hero("Wizert", "Wizert", 100, 200);
        Potion potion1 = new Potion("hp");
        //Monster goblin1 = new Monster(true, "Blargh", "Goblin", false, "NW");
        ////Monster goblin = new Monster()
        //Monster goblin1 = new Monster(true, "Blargh", "Goblin", potion1, "NW");
        //Monster goblin2 = new Monster(true, "Gobz2", "Goblin", false, "NW");
        //Monster banshee1 = new Monster(true, "Banz", "Banshee", false, "Hall");

        Room wall = new Room(true, false);
        Room exit = new Room(false, true);
        Room goblinRoom = new Room("NW", false, false);

        //Room goblinRoom2 = new Room(banshee1, "Damp", false, false);


        //Room blankSpaceBB = new Room(, "scary", false, false, false);
        Room blank = new Room(false, false, "Damp");
        Monster goblin1;
        Monster goblin2;
        Monster banshee1;
        


        Room nw1 = new Room(false, "NW", false, false, false);
        //Monster orc1 = new Monster(true, "Urk", "Orc", false, "NW");
        Room hall = new Room(false, "Hall", false, false, false);
        //Room nw2 = new Room(goblin2), "NW", false, false, false);
        //Room goblinRoom = new Room(realBadGuy, "Goblin Room", false, false);
        //Room spawnRoom = new Room(false, false, "Hallway");
        //Room goblinInRoom = new Room(, "Hall", false, false);
        //MonsterRoom goblinInRoom = new MonsterRoom(m1, )

        //Monster scaryMonster = new Monster(true, "Mr. Scary", "Goblin", false, "Damp Room");
        //Room roomWithScaryMonster = new Room(scaryMonster, "Damp Room", false, false);



        //Hall Rooms
        //Room Hall_1_3 = new Room(false, false, "Hall");
        //Room Hall_2_3 = new Room(false, false, "Hall");
        //Room Hall_3_1 = new Room(false, false, "Hall");
        //Room Hall_3_2 = new Room(false, false, "Hall");
        //Room Hall_3_3_Potion = new Room(false, false, "Hall");
        //Room Hall_3_4 = new Room(false, false, "Hall");
        //Room Hall_3_5 = new Room(false, false, "Hall");
        //Room Hall_4_3 = new Room(false, false, "Hall");
        //Room Hall_5_3 = new Room(false, false, "Hall");

        //Manually Populate Rooms
        Room SpawnRoom;

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
            array[1, 1] = NW_1_1 = new Room(true, goblin1 = new Monster(true, "Goblin1", "Goblin", false, "NW"), "NW", false, false, false);
            array[1, 2] = NW_1_2 = new Room(false, null, "NW", false, false, false);
            array[1, 3] = Hall_1_3 = new Room(false, null, "Hall", false, false, false);
            array[1, 4] = NE_1_4 = new Room(false, null, "NE", false, false, false);
            array[1, 5] = NE_1_5 = new Room(false, null, "NE", false, false, false);
            array[1, 6] = wall;

            array[2, 0] = wall;
            array[2, 1] = NW_2_1 = new Room(false, null, "NW", false, false, false);
            array[2, 2] = NW_2_2 = new Room(false, null, "NW", false, false, false);
            array[2, 3] = Hall_2_3 = new Room(false, null, "Hall", false, false, false);
            array[2, 4] = NE_2_4 = new Room(false, null, "NE", false, false, false);
            array[2, 5] = NE_2_5 = new Room(false, null, "NE", false, false, false);
            array[2, 6] = wall;

            array[3, 0] = wall;
            array[3, 1] = Hall_3_1 = new Room(false, null, "Hall", false, false, false);
            array[3, 2] = Hall_3_2 = new Room(false, null, "Hall", false, false, false);
            array[3, 3] = Hall_3_3_Potion = new Room(false, null, "Hall", false, true, false);
            array[3, 4] = Hall_3_4 = new Room(false, null, "Hall", false, false, false);
            array[3, 5] = Hall_3_5 = new Room(false, null, "NW", false, false, false);
            array[3, 6] = wall;

            array[4, 0] = wall;
            array[4, 1] = SW_4_1 = new Room(false, null, "SW", false, false, false);
            array[4, 2] = SW_4_2 = new Room(false, null, "SW", false, false, false);
            array[4, 3] = Hall_4_3 = new Room(false, null, "Hall", false, false, false);
            array[4, 4] = SE_4_4 = new Room(false, null, "SE", false, false, false);
            array[4, 5] = SE_4_5 = new Room(false, null, "SE", false, false, false);
            array[4, 6] = wall;

            array[5, 0] = wall;
            array[5, 1] = SW_5_1 = new Room(false, null, "SW", false, false, false);
            array[5, 2] = SW_5_2 = new Room(false, null, "SW", false, false, false);
            array[5, 3] = Hall_5_3 = new Room(false, null, "Hall", false, false, false);
            array[5, 4] = SE_4_4 = new Room(false, null, "SE", false, false, false);
            array[5, 5] = SE_5_5 = new Room(true, banshee1 = new Monster(true, "Banshee1", "Banshee", false, "NW"), "NW", false, false, false);
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
            //array[3, 4] = "goblin 3.4";
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




            //////Spawn Player Randomly
            //Random rand = new Random();
            //int spawn1 = rand.Next(1, 6);
            //int spawn2 = rand.Next(1, 6);

            //playerPos = array[spawn1, spawn2];
            //SpawnRoom = new Room(playerPos, "Spawn", true);
            //array[spawn1, spawn2] = SpawnRoom;

            //wizertX_Coord = spawn1;
            //wizertY_Coord = spawn2;



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

        //public void SpawnMonsters(object[,] array)
        //{
        //    //array[1, 5] = goblin1 = new Monster (true, "Blargh", "Goblin", false, "damp");
        //    goblin1 = new Monster(true, "Blargh", "Goblin", false, "damp");

        //    array[5, 1] = banshee1 = new Monster(true, "Banz", "Banshee", false, "arid");
        //    Hall_1_3 = new Room(goblin1, "Damp", false, false);
        //}

        //public void SpawnExitRandomly(object[,] array)
        //{
        //    Random rand = new Random();

        //    int x = rand.Next(0, 7);
        //    int y = rand.Next(0, 7);
        //    int z = rand.Next(0, 3);

        //    if (x == 0 || x == 6)
        //    {
        //        y = rand.Next(1, 6);
        //    }

        //    else if (x != 0 || x != 6)
        //    {
        //        if (z == 1)
        //        {
        //            y = 0;
        //        }
        //        else
        //        {
        //            y = 6;
        //        }
        //    }
        //    array[x, y] = exit;
        //}



        //public void SpawnPlayerRandomly(object[,] array)
        //{
        //    Random rand = new Random();
        //    int spawn1 = rand.Next(1, 6);
        //    int spawn2 = rand.Next(1, 6);

        //    array[spawn1, spawn2] = Wizert;

        //    wizertX_Coord = spawn1;
        //    wizertY_Coord = spawn2;
        //}



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

        //public object SetPlayerPosition(int xCoord, int yCoord)
        //{
        //    return playerPos[xCoord, yCoord];
        //}

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
                //Console.Write(item.Equals(SpawnRoom);
                Console.Write(item.Equals(SpawnRoom.GetOccupied()));
                //Console.Write(item + " ");
                iterator++;
                if (iterator == 7)
                {
                    Console.WriteLine();
                    iterator = 0;
                    line++;
                }
            }
        }

        public void Move(string direction, object[,] array, ref bool victory, ref Room room)// ref Room SpawnRoom)
        {
            //victory = victory;
            object nextArray;
            //object coordJustCameFrom = array[wizertX_Coord, wizertY_Coord];
            //string roomType = monster.GetMonsterRoom();
            //Monster enemy = monster.GetMonsterType();
            //Object replacement;
            //var originalRoom = spawnRoom;
            Room tempRoom;

            if (victory == false)
            {

                //Move South
                if (direction == "s")

                {
                    nextArray = array[wizertX_Coord + 1, wizertY_Coord];


                    if (nextArray.Equals(wall))
                    {
                        //isWall = true;
                        Console.WriteLine("You have ran into a wall");
                        array[wizertX_Coord - 1, wizertY_Coord] = playerPos; // was = Wizert
                        //currentArray = Wizert;
                        

                    }

                    if (nextArray.Equals(exit))
                    {
                        Console.WriteLine("You find the exit! Escape? Y/N");
                        string prompt = Console.ReadLine();
                        if (prompt == "y")
                        {
                            victory = true;

                        }


                    }

                    //Move Player
                    else if (!(nextArray.Equals(wall))) 
                    {
                        //array[wizertX_Coord, wizertY_Coord] = originalRoom;
                        //room.SetOccupied(false);
                        wizertX_Coord++;
                        playerPos = array[wizertX_Coord, wizertY_Coord];
                        
                        
                        //array[wizertX_Coord, wizertY_Coord] = playerPos; //was = Wizert
                        //array[wizertX_Coord, wizertY_Coord] = SpawnRoom.SetOccupied
                        //array[wizertX_Coord--, wizertY_Coord] = originalRoom;

                    }

                    //else if (!(nextArray.Equals(wall)))
                    //{
                    //    //array[wizertX_Coord, wizertY_Coord] = nw1;
                    //    array[wizertX_Coord, wizertY_Coord] = spawnRoom;
                    //    wizertY_Coord++;
                    //    array[wizertX_Coord, wizertY_Coord] = Wizert;
                    //}

                    //if (nextArray.Equals(goblin1))
                    //{
                    //    Battle.BeginBattle(Wizert, goblin1);
                    //}

                    if (nextArray.Equals(room.ContainsMonster()))
                    {
                        Battle.BeginBattle(Wizert, room.GetMonster());
                    }


                    //else if (!(nextArray.Equals(blankSpaceBB)))
                    //{
                    //    wizertX_Coord++;
                    //    blankSpaceBB.SetOccupied(true);

                    //}

                    //if (blankSpaceBB.GetOccupied() == true)
                    //{
                    //    blankSpaceBB.Get
                    //}

                }

                if (direction == "d")
                {
                    nextArray = array[wizertX_Coord, wizertY_Coord + 1];


                    if (nextArray.Equals(wall))
                    {
                        //isWall = true;
                        Console.WriteLine("You have ran into a wall");
                        array[wizertX_Coord, wizertY_Coord - 1] = playerPos;

                    }

                    if (nextArray.Equals(exit))
                    {
                        Console.WriteLine("You find the exit! Escape? Y/N");
                        string prompt = Console.ReadLine();
                        if (prompt == "y")
                        {
                            victory = true;


                        }
                    }

                    //Move player
                    else if (!(nextArray.Equals(wall)))
                    {
                        //array[wizertX_Coord, wizertY_Coord] = nw1;
                        //array[wizertX_Coord, wizertY_Coord] = spawnRoom;
                        wizertY_Coord++;
                        playerPos = array[wizertX_Coord, wizertY_Coord];
                        //array[wizertX_Coord, wizertY_Coord] = playerPos;
                    }

                    //if (nextArray.Equals(goblin1))
                    //{
                    //    Battle.BeginBattle(Wizert, goblin1);
                    //}
                    if (nextArray.Equals(room.ContainsMonster()))
                    {
                        Battle.BeginBattle(Wizert, room.GetMonster());
                    }
                }

                if (direction == "a")
                {
                    nextArray = array[wizertX_Coord, wizertY_Coord - 1];


                    if (nextArray.Equals(wall))
                    {
                        //isWall = true;
                        Console.WriteLine("You have ran into a wall");
                        array[wizertX_Coord, wizertY_Coord + 1] = playerPos;

                    }

                    if (nextArray.Equals(exit))
                    {
                        Console.WriteLine("You find the exit! Escape? Y/N");
                        string prompt = Console.ReadLine();
                        if (prompt == "y")
                        {
                            victory = true;


                        }
                    }

                    //Move player
                    else if (!(nextArray.Equals(wall)))
                    {
                        //array[wizertX_Coord, wizertY_Coord] = nw1;
                        //array[wizertX_Coord, wizertY_Coord] = spawnRoom;
                        wizertY_Coord--;
                        playerPos = array[wizertX_Coord, wizertY_Coord];
                        //array[wizertX_Coord, wizertY_Coord] = playerPos;
                    }

                    //if (nextArray.Equals(goblin1))
                    //{
                    //    Battle.BeginBattle(Wizert, goblin1);
                    //}
                    if (nextArray.Equals(room.ContainsMonster()))
                    {
                        Battle.BeginBattle(Wizert, room.GetMonster());
                    }

                }

                if (direction == "w")
                {
                    nextArray = array[wizertX_Coord - 1, wizertY_Coord];


                    if (nextArray.Equals(wall))
                    {
                        //isWall = true;
                        Console.WriteLine("You have ran into a wall");
                        array[wizertX_Coord + 1, wizertY_Coord] = playerPos;
                        //currentArray = Wizert;

                    }

                    if (nextArray.Equals(exit))
                    {
                        Console.WriteLine("You find the exit! Escape? Y/N");
                        string prompt = Console.ReadLine();
                        if (prompt == "y")
                        {
                            victory = true;



                        }
                    }

                    
                    //Move player
                    else if (!(nextArray.Equals(wall)))
                    {
                        //array[wizertX_Coord, wizertY_Coord] = nw1;
                        //array[wizertX_Coord, wizertY_Coord] = spawnRoom;
                        wizertX_Coord--;
                        playerPos = array[wizertX_Coord, wizertY_Coord];
                        //array[wizertX_Coord, wizertY_Coord] = playerPos;
                    }

                    //if (nextArray.Equals(goblin1))
                    //{
                    //    Battle.BeginBattle(Wizert, goblin1);
                    //}
                    if (nextArray.Equals(room.ContainsMonster()))
                    {
                        Battle.BeginBattle(Wizert, room.GetMonster());
                    }
                }
            }
            //if (victory == true)
            //{
            //    //Victory();
            //    Console.WriteLine("Play Again? y/n");
            //    string prompt = Console.ReadLine();
            //    if (prompt == "y")
            //    {
                   
            //    }
            //}



        }
        public string SpawnRoomText()
        {
            return "Light from above shines through the hole you fell through, illuminating the damp wretched ground";
        }

        public void SpawnPlayerRandomly(object[,] array)
        {
            ////Spawn Player Randomly
            Random rand = new Random();
            int spawn1 = rand.Next(1, 6);
            int spawn2 = rand.Next(1, 6);

            //array[spawn1, spawn2] = playerPos;
            playerPos = array[spawn1, spawn2];
            //array[spawn1, spawn2] = SpawnRoom;
            SpawnRoom = new Room(playerPos, "Spawn", true);
            array[spawn1, spawn2] = "Spawn Room";//SpawnRoom;
            //SpawnRoom = array[spawn1, spawn2];
            //array[spawn1, spawn2] = playerPos;
            // playerPos = array[spawn1, spawn2];

            wizertX_Coord = spawn1;
            wizertY_Coord = spawn2;
            //playerPos = (object[,])playerPos[wizertX_Coord, wizertY_Coord];
            // array[spawn1, spawn2] = playerPos;
            //playerPos = array[wizertX_Coord, wizertY_Coord];
        }
    }




}

