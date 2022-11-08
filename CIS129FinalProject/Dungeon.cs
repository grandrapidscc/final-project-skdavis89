using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    public class Dungeon
    {

        string[,] dungeon = new string[7, 7]
        {
            {"wall", "wall", "wall", "wall", "wall", "wall", "wall" },
            {"wall", "space", "space", "space", "space", "space", "wall"},
            {"wall", "space", "space", "space", "space", "space", "wall"},
            {"wall", "space", "space", "space", "space", "space", "wall"},
            {"wall", "space", "space", "space", "space", "space", "wall"},
            {"wall", "space", "space", "space", "space", "space", "wall"},
            {"wall", "wall", "wall", "wall", "wall", "wall", "wall" },
        };

        //trying create map outside of method
        int[,,] map = new int[2, 7, 7]
{

                    // 1 = exit
                    // 9 = random spawn
                {
                    //first array
                    {1, 1, 1, 1, 1, 1, 1},
                    {1, 0, 0, 0, 0, 0, 1},
                    {1, 0, 9, 9, 9, 0, 1},
                    {1, 0, 9, 9, 9, 0, 1},
                    {1, 0, 9, 9, 9, 0, 1},
                    {1, 0, 0, 0, 0, 0, 1},
                    {1, 1, 1, 1, 1, 1, 1}
                },


                    // 9 = null
                {
                    //second array
                    {9, 9, 9, 9, 9, 9, 9},
                    {9, 0, 0, 0, 0, 0, 9},
                    {9, 0, 0, 0, 0, 0, 9},
                    {9, 0, 0, 0, 0, 0, 9},
                    {9, 0, 0, 0, 0, 0, 9},
                    {9, 0, 0, 0, 0, 0, 9},
                    {9, 9, 9, 9, 9, 9, 9},
                }
};


        int xCoord = 0;
        int yCoord = 0;
        //int[,,] map = new int[2, 7, 7];

        //var playerPosition = map[xCoord, yCoord];

        public int[,,] CreateMap()
        {
            //int[,,] map = new int[2, 7, 7];

            ////create random start and end position
            //int playerPosition = map[0, 2, 2];
            //int a1PlayerPosition = playerPosition;
            //int a2PlayerPosition = playerPosition;
            //int a1TempPosition;
            //int a2TempPosition;
            //int startingPosition;
            //int endingPosition;

            //int[,] map = new int[7, 7]

            //WORKING BELOW, SAVE!
            //int[,,] map = new int[2, 7, 7]
            //{

            //        // 1 = exit
            //        // 9 = random spawn
            //    {
            //        //first array
            //        {1, 1, 1, 1, 1, 1, 1},
            //        {1, 0, 0, 0, 0, 0, 1},
            //        {1, 0, 9, 9, 9, 0, 1},
            //        {1, 0, 9, 9, 9, 0, 1},
            //        {1, 0, 9, 9, 9, 0, 1},
            //        {1, 0, 0, 0, 0, 0, 1},
            //        {1, 1, 1, 1, 1, 1, 1}
            //    },


            //        // 9 = null
            //    {
            //        //second array
            //        {9, 9, 9, 9, 9, 9, 9},
            //        {9, 0, 0, 0, 0, 0, 9},
            //        {9, 0, 0, 0, 0, 0, 9},
            //        {9, 0, 0, 0, 0, 0, 9},
            //        {9, 0, 0, 0, 0, 0, 9},
            //        {9, 0, 0, 0, 0, 0, 9},
            //        {9, 9, 9, 9, 9, 9, 9},
            //    }
            //};

            //testing purposes
            //{
            //{1, 2, 3, 4, 5 },
            //{6, 7, 8, 9, 10 },
            //{11, 12, 13, 14, 15},
            //{16, 17, 18, 19, 20},
            //{21, 22, 23, 24, 25}
            //};

            // 1 = wall/exit
            //{
            //{1, 1, 1, 1, 1, 1, 1; },
            //{1, 0, 0, 0, 0, 0, 1},
            //{1, 0, 0, 0, 0, 0, 1},
            //{1, 0, 0, 0, 0, 0, 1},
            //{1, 0, 0, 0, 0, 0, 1},
            //{1, 0, 0, 0, 0, 0, 1},
            //{1, 1, 1, 1, 1, 1, 1}
            //};

            //create random start and end position
            int playerPosition = map[0, 2, 2];
            int a1PlayerPosition = playerPosition;
            int a2PlayerPosition = playerPosition;
            int a1TempPosition;
            int a2TempPosition;
            int startingPosition;
            int endingPosition;

            return map;
        }

        public void MoveDirection(string directon)
        {
            int xCoord = 2;
            int yCoord = 3;
            int current = map[0, xCoord, yCoord];
            int originalPosition;
            int newPosition;
            int temp;
            string direction;
            if (directon == "d")
            {
                current = map[0, xCoord, yCoord];
                Console.WriteLine("moving east");
                newPosition = map[0, xCoord, yCoord + 1];
                //newPosition = current;
                temp = current;
                originalPosition = temp;
                yCoord++;
                //current = temp;
                map[0, xCoord, yCoord] = 5;
            }
        }

        //public int GetPlayerPosition()
        //{
        //    int playerPos;




        //    return playerPos;

        //}



        public void SetPlayerPosition()
        {
            map[0, 2, 3] = 5;
        }

        public void PrintMap()
        {
            int iterator = 0;
            int line = 0;
            foreach (var item in dungeon)
            {
                Console.Write(item + " ");
                iterator++;
                if (iterator == 7)
                {
                    Console.WriteLine();
                    iterator = 0;
                    line++;
                    if (line == 7)
                    {
                        Console.WriteLine("-------------");
                    }
                }
            }
        }
    }
}
