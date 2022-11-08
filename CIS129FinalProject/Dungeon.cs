using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    public class Dungeon
    {

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
            string direction;
            if (directon == "e")
            {

            }
        }

        public void CheckPlayerPosition()
        {

        }

        public void PrintMap()
        {
            foreach (var item in map)
            {

            }
        }
    }
}
