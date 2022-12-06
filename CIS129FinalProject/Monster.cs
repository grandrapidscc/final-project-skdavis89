

namespace CIS129FinalProject
{
    public class Monster
    {
        private string _name;
        private string _monsterType;
        private int _maxHP;
        private int _maxMP;
        private int _currentMP;
        private int _currentHP;
        private bool _hasItem;
        private string _itemType;
        private string _roomType;
        private int monsterAttackPower;
        private bool _isMonster;
        Monster monster;



        public Monster(bool isMonster, string name, string monsterType, bool hasItem, string? itemType, string? roomType)
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

            _hasItem = hasItem;

            _itemType = itemType;

            _roomType = roomType;
        }

        public Monster(string name, string monsterType, int hp, int mp)
        {
            _name = name;
            _monsterType = monsterType;
            _maxHP = hp;
            _maxMP = mp;
            _currentHP = hp;
            _currentMP = mp;
        }



        public int GetMaxHP ()
        {
            return _maxHP;
        }

        public int GetMaxMP ()
        {
            return _maxMP;
        }

        public int SetCurrentMP(int setMP)
        {
            return _currentMP = setMP;
        }

        public int GetCurrentMP ()
        {
            return _currentMP;
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
                    Console.WriteLine("Wizert finds magicka potion! 20 magicka restored!");
                    Console.WriteLine();
                    wizert.SetMP(wizert.GetCurrentMP() + 20);
                    Console.WriteLine("Wizert HP: " + wizert.GetCurrentHP() + "/" + wizert.GetMaxHP());
                    Console.WriteLine("Wizert MP: " + wizert.GetCurrentMP() + "/" + wizert.GetMaxMP());
                }
                else
                {
                    Console.WriteLine("Wizert finds magicka potion! The effects are diminished...");
                    Console.WriteLine();
                    wizert.SetMP(wizert.GetMaxMP());
                    Console.WriteLine("Wizert HP: " + wizert.GetCurrentHP() + "/" + wizert.GetMaxHP());
                    Console.WriteLine("Wizert MP: " + wizert.GetCurrentMP() + "/" + wizert.GetMaxMP());
                }
            Console.WriteLine();



        }

        public void Attack()
        {
            if (_monsterType == "Goblin")
            {
                Console.WriteLine($"{_name} the {_monsterType} Body Slam's Wizert, dealing 2 damage!");

            }

            if (_monsterType == "Orc")
            {
                Console.WriteLine($"{_name} the {_monsterType} Cleaves Wizert, dealing 3 damage!");

            }

            if (_monsterType == "Banshee")
            {
                Console.WriteLine($"{_name} the {_monsterType} Screeches, dealing 5 damage to the Wizert");
            }
        }
    }
}


    

