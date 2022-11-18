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
        private Monster _monster;
        private string _roomType;
        private bool _wizertOccupied;
        private bool _hasPotion;
        private bool _isWall;
        private bool _isExit;
        Monster realBadGuy = new Monster(true, "Bad Guy", "Orc", false, "SW");


        //Wall
        public Room(bool isWall, bool isExit)
        {
            _isWall = isWall;
            _isExit = isExit;
        }

        public Room(bool isWall, bool isExit, string roomType)
        {
            _isWall = isWall;
            _isExit = isExit;
            _roomType = roomType;
        }

        //public class Room : Monster (Monster a)


        public Room(bool hasMonster, string roomType, bool wizertOccupied, 
            bool hasPotion, bool isWall)
        {
            _hasMonster = hasMonster;
            _roomType = roomType;
            _wizertOccupied = wizertOccupied;
            _hasPotion = hasPotion;
            _isWall = isWall;
        }

        public Room(Monster monster, string roomType, bool hasPotion, bool isWall)
        {
            _monster = monster;
            _roomType = roomType;
            _hasPotion = hasPotion;
            _isWall = isWall;
        }

        public void SetOccupied(bool isOccupied)
        {
            _wizertOccupied = isOccupied;
        }

        public bool GetOccupied()
        {
            return _wizertOccupied;
        }

        public bool ContainsMonster()
        {
            return _hasMonster;
        }

        //Monster Constructor
        //public Room MonsterRoom(Monster monster, string roomType, //ref to Monster?
        //    bool hasPotion, bool isWall)
        //{
        //    _monster = monster;
        //    _roomType = roomType;
        //    //_wizertOccupied = wizertOccupied;
        //    _hasPotion = hasPotion;
        //    _isWall = isWall;
        //}




        public Monster GetMonster()
        {
            return _monster;
        }
    }
}
