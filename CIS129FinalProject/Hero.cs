using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{

    public class Hero
    {
        int wizertX_Coord;
        int wizertY_Coord;
        private string _name;
        private string _type;
        private int _maxHP;
        private int _maxMP;
        public int currentHP;
        private int currentMP;
        private int xCoord;
        private int yCoord;
        private bool _isPotion;
        private string _potionType;
        private int _potionHealthRestored;
        private int _potionMagicRestored;

        public string FindType()
        {
            return _type;
        }

        public int GetMaxHP()
        {
            return _maxHP;
        }

        public int GetCurrentHP()
        {
            return currentHP;
        }

        public int GetMaxMP()
        {
            return _maxMP;
        }

        public int GetCurrentMP()
        {
            return currentMP;
        }

        public int SetMP(int setMP)
        {
            return currentMP = setMP;
        }

        public int SetHP(int setHP)
        {
            return currentHP = setHP;
        }

        public bool GetIsPotion()
        {
            return _isPotion;
        }

        public bool SetIsPotion(bool isPotion_true_false)
        {
            return _isPotion = isPotion_true_false;
        }


        public Hero(bool isPotion, string potionType)
        {
            _isPotion = isPotion;
            _potionType = potionType;
        }

        public Hero(string name, string type, int hp, int mp)
        {
            _name = name;
            _type = type;
            _maxHP = hp;
            _maxMP = mp;
            currentHP = hp;
            currentMP = mp;
        }



        //Wizert
        public void CastFireball() //costs 3 mp, deals 5 damage
        {
            if (currentMP >= 3) 
            {
                //Console.WriteLine($"{_type} casts Fireball! 5 damage dealt to enemy");
                //Thread.Sleep(1500);
                currentMP = currentMP - 3;
                Console.WriteLine($"{_type}'s current health: {currentHP}/{_maxHP}");
                Console.WriteLine($"{_type}'s current mana: {currentMP}/{_maxMP}");
                Console.WriteLine();
                
            }
            else
            {
                Console.WriteLine("Not enough mana!");
                Console.WriteLine();
            }
        }

        public void CastHeal() //costs 5 mp, heals 3 
        {
            int overheal;
            int actualAmountHealed;

            if (currentMP >= 3)
            {
                if (currentHP <= (_maxHP - 3))
                {
                    Console.WriteLine($"{_type} casts Heal! {_type} heals for 3 HP!");
                    currentHP = currentHP + 3;
                    currentMP = currentMP - 5;
                    Console.WriteLine($"{_type}'s current health: {currentHP}/{_maxHP}");
                    Console.WriteLine($"{_type}'s current mana: {currentMP}/{_maxMP}");
                    Console.WriteLine();
                }
                else if (currentHP <= (_maxHP - 2))
                {
                    actualAmountHealed = _maxHP - currentHP;
                    overheal = _maxHP - 2;
                    Console.WriteLine($"{_type} casts Heal for {actualAmountHealed}! {_type} overheals by {overheal} HP.");
                    currentMP = currentMP - 5;
                    Console.WriteLine($"{_type}'s current health: {currentHP}/{_maxHP}");
                    Console.WriteLine($"{_type}'s current mana: {currentMP}/{_maxMP}");
                    Console.WriteLine();
                }
                else if (currentHP <= (_maxHP - 1))
                {
                    actualAmountHealed = _maxHP - currentHP;
                    overheal = _maxHP - 1;
                    Console.WriteLine($"{_type} casts Heal for {actualAmountHealed}! {_type} overheals by {overheal} HP.");
                    currentMP = currentMP - 5;
                    Console.WriteLine($"{_type}'s current health: {currentHP}/{_maxHP}");
                    Console.WriteLine($"{_type}'s current mana: {currentMP}/{_maxMP}");
                    Console.WriteLine();
                }
                else if (currentHP == _maxHP)
                {
                    actualAmountHealed = _maxHP - currentHP;
                    overheal = 3;
                    Console.WriteLine($"{_type} casts Heal for {actualAmountHealed}! {_type} overheals by {overheal} HP.");
                    currentMP = currentMP - 5;
                    Console.WriteLine($"{_type}'s current health: {currentHP}/{_maxHP}");
                    Console.WriteLine($"{_type}'s current mana: {currentMP}/{_maxMP}");
                    Console.WriteLine();
                }

            }
            else
            {
                Console.WriteLine("Not enough mana!");
                Console.WriteLine();
            }
        }

        public void Set_Wizert_X_Coord(int xCoord)
        {
            wizertX_Coord = xCoord;
        }

        public void Set_Wizert_Y_Coord(int yCoord)
        {
            wizertY_Coord = yCoord;
        }

        public int Get_Wizert_X_Coord()
        {
            return wizertX_Coord;
        }

        public int Get_Wizert_Y_Coord()
        {
            return wizertY_Coord;
        }


        public void Move(string direction)
        {
            int x;
            int y;

            if (direction == "s")
            {
               // y = Set_Wizert_Y_Coord(Get_Wizert_Y_Coord();
            }
        }

        public int GetHealth()
        {
            return currentHP;
        }

        public int SetHealth(int setHealth)
        {
            return currentHP = setHealth;
        }



        //POTION
        public class Potion
        {
            int health;
            int magic;
            string potionType;


            public Potion(string type)
            {
                if (type == "hp")
                {
                    health = 10;
                    potionType = type;
                }
                else if (type == "mp")
                {
                    magic = 20;
                    potionType = type;
                }
            }

            public string GetPotionType()
            {
                return potionType;
            }

        }
    }
}
