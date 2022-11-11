using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    internal class Room
    {
        private bool _hasMonster;
        private Object _monster;
        private string _roomType;
        private bool _wizertOccupied;
        private bool _hasPotion;
        private bool _isWall;
        private bool _isExit;


        //Wall
        public Room(bool isWall, bool isExit)
        {
            _isWall = isWall;
            _isExit = isExit;
        }

        //No Monster Constructor
        public Room(bool hasMonster, string roomType, bool wizertOccupied, 
            bool hasPotion, bool isWall)
        {
            _hasMonster = hasMonster;
            _roomType = roomType;
            _wizertOccupied = wizertOccupied;
            _hasPotion = hasPotion;
            _isWall = isWall;
        }

        //Monster Constructor
        public Room(Object monster, string roomType, bool wizertOccupied,
            bool hasPotion, bool isWall)
        {
            _monster = monster;
            _roomType = roomType;
            _wizertOccupied = wizertOccupied;
            _hasPotion = hasPotion;
            _isWall = isWall;
        }

    }
}
