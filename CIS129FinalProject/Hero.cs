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
        private int currentHP;
        private int currentMP;
        private int xCoord;
        private int yCoord;

        public Hero(string name, string type, int hp, int mp)
        {
            _name = name;
            _type = type;
            _maxHP = hp;
            _maxMP = mp;
            currentHP = hp;
            currentMP = mp;
        }

        public void CastFireball() //costs 3 mp, deals 5 damage
        {
            if (currentMP >= 3) 
            {
                Console.WriteLine($"{_type} casts Fireball! 5 damage dealt to enemy");
                currentMP = currentMP - 3;
                Console.WriteLine($"{_type}'s MP remaining: {currentMP}/{_maxMP}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Not enough MP!");
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
                    Console.WriteLine($"{_type}'s HP remaining: {currentHP}/{_maxHP}");
                    Console.WriteLine($"{_type}'s MP remaining: {currentMP}/{_maxMP}");
                    Console.WriteLine();
                }
                else if (currentHP <= (_maxHP - 2))
                {
                    actualAmountHealed = _maxHP - currentHP;
                    overheal = _maxHP - 2;
                    Console.WriteLine($"{_type} casts Heal for {actualAmountHealed}! {_type} overheals by {overheal} HP.");
                    currentMP = currentMP - 5;
                    Console.WriteLine($"{_type}'s HP remaining: {currentHP}/{_maxHP}");
                    Console.WriteLine($"{_type}'s MP remaining: {currentMP}/{_maxMP}");
                    Console.WriteLine();
                }
                else if (currentHP <= (_maxHP - 1))
                {
                    actualAmountHealed = _maxHP - currentHP;
                    overheal = _maxHP - 1;
                    Console.WriteLine($"{_type} casts Heal for {actualAmountHealed}! {_type} overheals by {overheal} HP.");
                    currentMP = currentMP - 5;
                    Console.WriteLine($"{_type}'s HP remaining: {currentHP}/{_maxHP}");
                    Console.WriteLine($"{_type}'s MP remaining: {currentMP}/{_maxMP}");
                    Console.WriteLine();
                }
                else if (currentHP == _maxHP)
                {
                    actualAmountHealed = _maxHP - currentHP;
                    overheal = 3;
                    Console.WriteLine($"{_type} casts Heal for {actualAmountHealed}! {_type} overheals by {overheal} HP.");
                    currentMP = currentMP - 5;
                    Console.WriteLine($"{_type}'s HP remaining: {currentHP}/{_maxHP}");
                    Console.WriteLine($"{_type}'s MP remaining: {currentMP}/{_maxMP}");
                    Console.WriteLine();
                }

            }
            else
            {
                Console.WriteLine("Not enough MP!");
                Console.WriteLine();
            }
        } 

        
        public void Move(string direction)
        {
            if (direction == "s")
            {

            }
        }
    }


}
