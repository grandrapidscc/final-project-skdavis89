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


        public Monster(string name, string monsterType, int maxHP, int currentHP, bool hasItem)
        {
            _name = name;
            _monsterType = monsterType;
            _maxHP = maxHP;
            _currentHP = currentHP;
            _hasItem = hasItem;
        }

        public Monster(string name, string monsterType, bool hasItem, string roomType)
        {
            _name = name;
            _monsterType = monsterType;

            if (monsterType == "Goblin")
            {
                _maxHP = 3;
            }

            if (monsterType == "Orc")
            {
                _maxHP = 5;
            }

            if (monsterType == "Banshee")
            {
                _maxHP = 8;
            }

            _hasItem = hasItem;
        }

        public int GetHealth
        {
            get { return _maxHP; }
            set { _maxHP = value; }
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
}
