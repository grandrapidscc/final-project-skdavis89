using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    public class Map
    {
        int wizertX_Coord;
        int wizertY_Coord;
        Hero Wizert = new Hero("Wizert", "Wizert", 100, 200);
        Monster goblin1 = new Monster("Blargh", "Orc", false, "NW");
        Monster goblin2 = new Monster("Gobz2", "Goblin", false, "NW");
        Room wall = new Room(true, false);
        Room exit = new Room(false, true);
        Room nw1 = new Room(false, "NW", false, false, false);
        //Room nw2 = new Room(goblin2), "NW", false, false, false);



        //public object[,] CreateEmptyMap()
        //{
        //    object[,] map = new object[7, 7];

        //    return map;
        //}

        public void PopulateMap(object[,] array)
        {
            array[0, 0] = wall;
            array[0, 1] = wall;
            array[0, 2] = wall;
            array[0, 3] = wall;
            array[0, 4] = wall;
            array[0, 5] = wall;
            array[0, 6] = wall;
            
            array[1, 0] = wall;
            array[1, 1] = "space";
            array[1, 2] = "space";
            array[1, 3] = "space";
            array[1, 4] = "space";
            array[1, 5] = "space";
            array[1, 6] = wall;

            array[2, 0] = wall;
            array[2, 1] = "space";
            array[2, 2] = "space";
            array[2, 3] = "space";
            array[2, 4] = goblin1;
            array[2, 5] = "space";
            array[2, 6] = wall;

            array[3, 0] = wall;
            array[3, 1] = "space";
            array[3, 2] = "space";
            array[3, 3] = "space";
            array[3, 4] = goblin1;
            array[3, 5] = "space";
            array[3, 6] = wall;

            array[4, 0] = wall;
            array[4, 1] = "space";
            array[4, 2] = "space";
            array[4, 3] = "space";
            array[4, 4] = goblin1;
            array[4, 5] = "space";
            array[4, 6] = wall;

            array[5, 0] = wall;
            array[5, 1] = "space";
            array[5, 2] = "space";
            array[5, 3] = "space";
            array[5, 4] = goblin1;
            array[5, 5] = "space";
            array[5, 6] = wall;

            array[6, 0] = wall;
            array[6, 1] = wall;
            array[6, 2] = wall;
            array[6, 3] = wall;
            array[6, 4] = wall;
            array[6, 5] = wall;
            array[6, 6] = wall;
        }

        public void SpawnExitRandomly(object[,] array)
        {
            Random rand = new Random();

            int x = rand.Next(0, 7);
            int y = rand.Next(0, 7);
            int z = rand.Next(0, 3);

            if (x == 0 || x == 6)
            {
                y = rand.Next(1, 6);
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
            Random rand = new Random();
            int spawn1 = rand.Next(1, 6);
            int spawn2 = rand.Next(1, 6);

            array[spawn1, spawn2] = Wizert;

            wizertX_Coord = spawn1;
            wizertY_Coord = spawn2;
        }

        public int PlayerX_Coord()
        {
            return wizertX_Coord;
        }

        public int PlayerY_Coord()
        {
            return wizertY_Coord;
        }

        public void Set_Wizert_X_Coord(int xCoord)
        {
            wizertX_Coord = xCoord;
        }

        public void Set_Wizert_Y_Coord(int yCoord)
        {
            wizertY_Coord = yCoord;
        }

        //public int playerPos(int playerX_Coord, int playerY_Coord)
        //{
        //    int x = playerX_Coord;
        //    int y = playerY_Coord;
        //}

        public void PrintMap(object[,] map)
        {
            int iterator = 0;
            int line = 0;
            foreach (var item in map)
            {
                Console.Write(item.Equals(Wizert) + " ");
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

        public void Move(string direction)
        {
            

            if (direction == "s")
            {
                
            }
        }
    }
}

