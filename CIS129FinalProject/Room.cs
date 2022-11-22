﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    public class Room
    {
        private bool _hasMonster;
        private Monster _monster;
        private string _roomType;
        private bool _wizertOccupied;
        private bool _hasPotion;
        private bool _isWall;
        private bool _isExit;
        private object _location;
        //Monster realBadGuy = new Monster(true, "Bad Guy", "Orc", false, "SW");
        //Monster banshee1 = new Monster(true, "Banz", "Banshee", false, "Hall");
        //Room room1 = new Room(false, false);

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

        public Room(bool hasMonster, Monster? monster, string roomType, bool wizertOccupied,
             bool hasPotion, bool isWall)
        {
            _hasMonster = hasMonster;
            _monster = monster;
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

        public Room(string roomType, bool hasPotion, bool isWall)
        {
            //_monster = monster;
            _roomType = roomType;
            _hasPotion = hasPotion;
            _isWall = isWall;
        }

        //spawn room
        public Room(object location, string roomType, bool wizertOccupied)
        {
            _location = location;
            _roomType = roomType;
            _wizertOccupied = wizertOccupied;
        }

        public void SetOccupied(bool isOccupied)
        {
            _wizertOccupied = isOccupied;
        }

        //public Room AddEnemy(Monster enemy)
        //{
        //    return enemy;
        //}

        public bool GetOccupied()
        {
            return _wizertOccupied;
        }

        public bool ContainsMonster()
        {
            return _hasMonster;
        }

        public string SpawnRoom()
        {
            return "Light from above shines through the hole you fell through, illuminating the damp wretched ground";
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
