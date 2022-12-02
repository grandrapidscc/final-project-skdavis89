using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{

    public class Hero
    {
        private string _name;
        private string _type;
        private int _maxHP;
        private int _maxMP;
        public int currentHP;
        private int currentMP;

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
                currentMP = currentMP - 3;
                if (currentMP < 0)
                {
                    currentMP = 0;
                }
                Console.WriteLine($"{_type}'s current health: {currentHP}/{_maxHP}");
                Console.WriteLine($"{_type}'s current magicka: {currentMP}/{_maxMP}");
                Console.WriteLine();
                
            }
            else
            {
                Console.WriteLine("Not enough magicka!");
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
                    Console.WriteLine($"{_type} spends 5 magicka casting Heal! {_type} heals for 3 HP!");
                    currentHP = currentHP + 3;
                    currentMP = currentMP - 5;
                    if (currentMP < 0)
                    {
                        currentMP = 0;
                    }
                    Console.WriteLine($"{_type}'s current health: {currentHP}/{_maxHP}");
                    Console.WriteLine($"{_type}'s current magicka: {currentMP}/{_maxMP}");
                    Console.WriteLine();
                }
                else if (currentHP == (_maxHP - 2))
                {
                    actualAmountHealed = _maxHP - currentHP;
                    overheal = actualAmountHealed - 1;
                    Console.WriteLine($"{_type} spends 5 magicka casting Heal for 3 HP! {_type} overheals by {overheal} HP.");
                    currentHP = currentHP + 2;
                    currentMP = currentMP - 5;
                    if (currentMP < 0)
                    {
                        currentMP = 0;
                    }
                    Console.WriteLine($"{_type}'s current health: {currentHP}/{_maxHP}");
                    Console.WriteLine($"{_type}'s current magicka: {currentMP}/{_maxMP}");
                    Console.WriteLine();
                }
                else if (currentHP == (_maxHP - 1))
                {
                    actualAmountHealed = _maxHP - currentHP;
                    overheal = actualAmountHealed + 1;
                    Console.WriteLine($"{_type} spends 5 magicka casting Heal for 3 HP! {_type} overheals by {overheal} HP.");
                    currentHP = currentHP + 1;
                    currentMP = currentMP - 5;
                    if (currentMP < 0)
                    {
                        currentMP = 0;
                    }
                    Console.WriteLine($"{_type}'s current health: {currentHP}/{_maxHP}");
                    Console.WriteLine($"{_type}'s current magicka: {currentMP}/{_maxMP}");
                    Console.WriteLine();
                }
                else if (currentHP == _maxHP)
                {
                    actualAmountHealed = _maxHP - currentHP;
                    overheal = 3;
                    Console.WriteLine($"{_type} spends 5 magicka casting Heal for 3 HP! {_type} overheals by {overheal} HP.");
                    currentMP = currentMP - 5;
                    Console.WriteLine($"{_type}'s current health: {currentHP}/{_maxHP}");
                    Console.WriteLine($"{_type}'s current magicka: {currentMP}/{_maxMP}");
                    Console.WriteLine();
                }

            }
            else
            {
                Console.WriteLine("Not enough magicka to cast Heal!");
                Console.WriteLine();
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
    }
}
