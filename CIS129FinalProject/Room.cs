using System;
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
        private string _potionType;
        Room tempRoom;

        //Wall
        public Room(bool isWall, bool isExit)//, bool containsMonster)
        {
            _isWall = isWall;
            _isExit = isExit;
            //_hasMonster = containsMonster;
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

        public Room(bool hasMonster, Monster? monster, string roomType, string? potionType,
             bool hasPotion, bool isWall)
        {
            _hasMonster = hasMonster;
            _monster = monster;
            _roomType = roomType;
            _potionType = potionType;
            //_wizertOccupied = wizertOccupied;
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


        public Room GetRoom(object roomLocation)
        {
            return tempRoom;
        }

        public void SetRoom(object room)
        {
            room = room;
        }

        public bool GetPotion()
        {
            return _hasPotion;
        }

        public bool SetPotion(bool setPotion)
        {
            return _hasPotion = setPotion;
        }

        public string GetPotionType()
        {
            return _potionType;
        }

        public string SetPotionType(string potionType)
        {
            return _potionType = potionType;
        }


        public bool GetOccupied()
        {
            return _wizertOccupied;
        }

        public string GetRoomType ()
        {
            return _roomType;
        }

        public bool ContainsMonster()
        {
            return _hasMonster;
        }

        public bool SetRoomContainsMonster(bool isMonster)
        {
            return isMonster;
        }

        public void UsePotion(string aPotionType, Hero wizert)
        {
            string potionType;
            int missingHealth = wizert.GetMaxHP() - wizert.GetCurrentHP();
            int missingMana = wizert.GetMaxMP() - wizert.GetCurrentMP();
            if (aPotionType == "hp")
            {
                if (missingHealth >= 10)
                {
                    Console.WriteLine("Wizert finds health potion! 10 health restored!");
                    wizert.SetHealth(wizert.GetCurrentHP() + 10);
                    Console.WriteLine("Wizert HP: " + wizert.GetCurrentHP() + "/" + wizert.GetMaxHP());
                    Console.WriteLine("Wizert MP: " + wizert.GetCurrentMP() + "/" + wizert.GetMaxMP());
                }
                else
                {
                    Console.WriteLine("Wizert finds health potion! The effects are diminished...");
                    wizert.SetHealth(wizert.GetMaxHP());
                    Console.WriteLine("Wizert HP: " + wizert.GetCurrentHP() + "/" + wizert.GetMaxHP());
                    Console.WriteLine("Wizert MP: " + wizert.GetCurrentMP() + "/" + wizert.GetMaxMP());
                }
                
            }
            if (aPotionType == "mp")

                if (missingMana >= 20)
                {
                    Console.WriteLine("Wizert finds magic potion! 20 mana restored!");
                    wizert.SetHealth(wizert.GetCurrentMP() + 20);
                    Console.WriteLine("Wizert HP: " + wizert.GetCurrentHP() + "/" + wizert.GetMaxHP());
                    Console.WriteLine("Wizert MP: " + wizert.GetCurrentMP() + "/" + wizert.GetMaxMP());
                }
                else
                {
                    Console.WriteLine("Wizert finds mana potion! The effects are diminished...");
                    wizert.SetMP(wizert.GetMaxMP());
                    Console.WriteLine("Wizert HP: " + wizert.GetCurrentHP() + "/" + wizert.GetMaxHP());
                    Console.WriteLine("Wizert MP: " + wizert.GetCurrentMP() + "/" + wizert.GetMaxMP());
                }


        }


        public string PrintNWRoom()
        {
            return "It sounds as if you are walking through water, but the substance feels much thicker...";
        }

        public string PrintNERoom()
        {
            return "The air smells fetid and the soft dirt below your feet feels like a freshly dug grave.";
        }

        public string PrintSWRoom()
        {
            return "The room is so silent that you can hear your own breathing...at least you hope it is your own.";
        }

        public string PrintSERoom()
        {
            return "A screeching sound is apparent, but you can not tell if it is near or echoing from a far away location";
        }

        public string PrintHallRoom()
        {
            return "You feel ornate marble flooring under your feet, covered in a thick layer of dust, blood, and fur.";
        }

        public Monster GetMonster()
        {
            return _monster;

        }
    }
}
