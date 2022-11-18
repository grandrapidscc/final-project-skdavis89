using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
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

        public void UsePotion()
        {
            if (potionType == "hp")
            {
                
            }
        }
    }
}
