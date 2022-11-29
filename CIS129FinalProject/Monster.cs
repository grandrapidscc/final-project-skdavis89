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
        private string _itemType;
        private string _roomType;
        private int goblinAttackPower = 2;
        private int orcAttackPower = 3;
        private int bansheeAttackPower = 5;
        private int monsterAttackPower;
        private bool _isMonster;
        //private Potion potion;
        Monster monster;



        

        public Monster(string name, string monsterType, int maxHP, int currentHP, bool hasItem)
        {
            _name = name;
            _monsterType = monsterType;
            _maxHP = maxHP;
            _currentHP = currentHP;
            _hasItem = hasItem;
        }

        

        

        public Monster(bool isMonster, string name, string monsterType, bool hasItem, string? itemType)
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

            _itemType = itemType;
        }



        public bool GetHasItem ()
        {
            return _hasItem;
        }

        public bool SetHasItem(bool setHasItem)
        {
            return _hasItem = setHasItem;
        }

        public string GetItemType()
        {
            return _itemType;
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

        public Monster GetMonster()
        {
            return monster;
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
                    Console.WriteLine();
                    wizert.SetHealth(wizert.GetCurrentHP() + 10);
                    Console.WriteLine("Wizert HP: " + wizert.GetCurrentHP() + "/" + wizert.GetMaxHP());
                    Console.WriteLine("Wizert MP: " + wizert.GetCurrentMP() + "/" + wizert.GetMaxMP());
                }
                else
                {
                    Console.WriteLine("Wizert finds health potion! The effects are diminished...");
                    Console.WriteLine();
                    wizert.SetHealth(wizert.GetMaxHP());
                    Console.WriteLine("Wizert HP: " + wizert.GetCurrentHP() + "/" + wizert.GetMaxHP());
                    Console.WriteLine("Wizert MP: " + wizert.GetCurrentMP() + "/" + wizert.GetMaxMP());
                }
                Console.WriteLine();

            }
            if (aPotionType == "mp")

                if (missingMana >= 20)
                {
                    Console.WriteLine("Wizert finds magic potion! 20 mana restored!");
                    Console.WriteLine();
                    wizert.SetHealth(wizert.GetCurrentMP() + 20);
                    Console.WriteLine("Wizert HP: " + wizert.GetCurrentHP() + "/" + wizert.GetMaxHP());
                    Console.WriteLine("Wizert MP: " + wizert.GetCurrentMP() + "/" + wizert.GetMaxMP());
                }
                else
                {
                    Console.WriteLine("Wizert finds mana potion! The effects are diminished...");
                    Console.WriteLine();
                    wizert.SetMP(wizert.GetMaxMP());
                    Console.WriteLine("Wizert HP: " + wizert.GetCurrentHP() + "/" + wizert.GetMaxHP());
                    Console.WriteLine("Wizert MP: " + wizert.GetCurrentMP() + "/" + wizert.GetMaxMP());
                }



        }

        public void Attack()
        {
            if (_monsterType == "Goblin")
            {
                Console.WriteLine($"{_name} the {_monsterType} Body Slam's Wizert, dealing 2 damage!");
                Console.WriteLine();
                //subtract 2 health from Wizert
            }

            if (_monsterType == "Orc")
            {
                Console.WriteLine($"{_name} the {_monsterType} Cleaves Wizert, dealing 3 damage!");
                Console.WriteLine();
                //subtract 3 health from Wizert
            }

            if (_monsterType == "Banshee")
            {
                Console.WriteLine($"{_name} the {_monsterType} Screeches, dealing 5 damage to the Wizert");
                Console.WriteLine();
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
