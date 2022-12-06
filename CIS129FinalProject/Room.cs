

namespace CIS129FinalProject
{
    public class Room
    {
        private bool _hasMonster;
        private Monster _monster;
        private string _roomType;
        private bool _hasPotion;
        private bool _isWall;
        private bool _isExit;
        private string _potionType;

        //Wall
        public Room(bool isWall, bool isExit)
        {
            _isWall = isWall;
            _isExit = isExit;
        }


        public Room(bool hasMonster, Monster? monster, string roomType, string? potionType,
             bool hasPotion, bool isWall)
        {
            _hasMonster = hasMonster;
            _monster = monster;
            _roomType = roomType;
            _potionType = potionType;
            _hasPotion = hasPotion;
            _isWall = isWall;
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

        public string GetRoomType ()
        {
            return _roomType;
        }

        public bool ContainsMonster()
        {
            return _hasMonster;
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
                    Console.WriteLine("Wizert finds magic potion! 20 magicka restored!");
                    wizert.SetMP(wizert.GetCurrentMP() + 20);
                    Console.WriteLine("Wizert HP: " + wizert.GetCurrentHP() + "/" + wizert.GetMaxHP());
                    Console.WriteLine("Wizert MP: " + wizert.GetCurrentMP() + "/" + wizert.GetMaxMP());
                }
                else
                {
                    Console.WriteLine("Wizert finds magicka potion! The effects are diminished...");
                    wizert.SetMP(wizert.GetMaxMP());
                    Console.WriteLine("Wizert HP: " + wizert.GetCurrentHP() + "/" + wizert.GetMaxHP());
                    Console.WriteLine("Wizert MP: " + wizert.GetCurrentMP() + "/" + wizert.GetMaxMP());
                }


        }

        public void PrintNWRoom()
        {
            Console.WriteLine("It sounds as if you are walking through water, but the substance feels much thicker...");
        }

        public void PrintNERoom()
        {
            Console.WriteLine("The air smells fetid and the soft dirt below your feet feels like a freshly dug grave.");
        }

        public void PrintSWRoom()
        {
            Console.WriteLine("The room is so silent that you can hear your own breathing, a moment of respite\n...until you remember you are holding your breath.");
        }

        public void PrintSERoom()
        {
            Console.WriteLine("A screeching sound is apparent, but you can not tell if it is near or echoing from a far away location.");
        }

        public void PrintHallRoom()
        {
            Console.WriteLine("You feel ornate marble flooring under your feet, covered in a thick layer of dust and fur.");
        }

        public Monster GetMonster()
        {
            return _monster;

        }
    }
}
