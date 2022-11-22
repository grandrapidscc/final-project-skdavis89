using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    public class Monster
    {
        private string _name;
        private string _monsterType;
        private int _maxHP;
        private int _currentHP;
        private bool _hasItem;
        private string _roomType;
        private int goblinAttackPower = 2;
        private int orcAttackPower = 3;
        private int bansheeAttackPower = 5;
        private int monsterAttackPower;
        private bool _isMonster;
        private Potion potion;



        

        public Monster(string name, string monsterType, int maxHP, int currentHP, bool hasItem)
        {
            _name = name;
            _monsterType = monsterType;
            _maxHP = maxHP;
            _currentHP = currentHP;
            _hasItem = hasItem;
        }

        

        

        public Monster(bool isMonster, string name, string monsterType, bool hasItem, string roomType)
        {
            _isMonster = isMonster;
            _name = name;
            _monsterType = monsterType;

            if (monsterType == "Goblin")
            {
                _maxHP = 3;
                _currentHP = 3;
                monsterAttackPower = 2;
            }

            if (monsterType == "Orc")
            {
                _maxHP = 5;
                _currentHP = 5;
                monsterAttackPower = 3;
            }

            if (monsterType == "Banshee")
            {
                _maxHP = 8;
                _currentHP = 8;
                monsterAttackPower = 5;
            }



            //potion = aPotion;
            _hasItem = hasItem;

            _roomType = roomType;
        }




        public string GetMonsterRoom()
        {
            return _roomType;
        }

        public bool GetIsMonster()
        {
            return _isMonster;
        }

        public bool SetIsMonster(bool isMonster_T_or_F)
        {
            return _isMonster = isMonster_T_or_F;
        }

        public Type GetMonster(Type type)
        {
            return type;
        }

        //public int GetHealth
        //{
        //    get { return _maxHP; }
        //    set { _maxHP = value; }
        //}

        public int GetHealth()
        {
            return _currentHP;
        }

        public int SetHealth(int setHealth)
        {
            return _currentHP = setHealth;
        }

        public string GetName(Monster getName)
        {
            return _name;
        }

        public string GetMonsterType(Monster getType)
        {
            return _monsterType;
        }

        public int GetMonsterAttackPower(Monster getMonsterAttackPower)
        {
            return monsterAttackPower;
        }

        public void Attack()
        {
            if (_monsterType == "Goblin")
            {
                Console.WriteLine($"{_name} the {_monsterType} Body Slam's Wizert, dealing 2 damage!");
                //subtract 2 health from Wizert
            }

            if (_monsterType == "Orc")
            {
                Console.WriteLine($"{_name} the {_monsterType} Cleaves Wizert, dealing 3 damage!");
                //subtract 3 health from Wizert
            }

            if (_monsterType == "Banshee")
            {
                Console.WriteLine($"{_name} the {_monsterType} Screeches, dealing 5 damage to the Wizert");
                //subtract 5 health from Wizert
            }
        }
    }




    public class MonsterRoom
    {
        Monster monster;
        private string _item; // later change to object?
        private string _roomType;


        //public MonsterRoom(Monster aMonster, string item, string roomType)
        //{
        //    monster = aMonster;
        //    _item = item;
        //    _roomType = roomType;
        //}
    }

    //public (Monster monster, string monsterType, string roomType)
    
}
