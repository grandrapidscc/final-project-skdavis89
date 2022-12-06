using CIS129FinalProject;


object[,] testMap = new object[7, 7];
Map floorPlan = new Map();
bool victory = false;
bool defeat = false;
bool allEnemiesDefeated = false;
string direction;
bool playAgain = true;
string repeat;
Monster testBanshee = new Monster(true, "placeholderMonster", "Banshee", false, "placeholderRoom", null);
Room dummyRoom = new Room(false, testBanshee, "Dummy", null, false, false);
Hero specialWizert = new Hero("Wizert", "Wizert", 100, 200);
Monster evilWizert = new Monster("Dark Wizert", "Dark Wizert", 75, 175);


while (playAgain == true)
{
    floorPlan.PopulateMap(testMap);
    floorPlan.SpawnPlayerRandomly(testMap);
    Console.WriteLine("The Wizert was a mysterious being, summoned into towns across the Nome region to bring peace to the dead.");
    Console.WriteLine("Without a visit from the Wizert, the deceased spirits would become restless and manifest as evil.");
    Console.WriteLine();
    Console.WriteLine("One town had not requested the Wizert's services in an unordinarily long time.");
    Console.WriteLine("Upon arriving in Tappel, a clergyman greeted the Wizert.");
    Console.WriteLine();
    Console.WriteLine("\"Why have I not been summoned here since long before the Awakening?\" the Wizert asked.");
    Console.WriteLine("\"My dear Wizert,\" the clergyman began. \"You have not been summoned because we have no dead.");
    Console.WriteLine("We have found the fabled water from the springs of Atouma, which as you know grants eternal life.\"");
    Console.WriteLine();
    Console.WriteLine("\"Surely it can't be!? I thought it was but a fairy tale! Can you take me to it?\"");
    Console.WriteLine("\"Right this way,\" the clergyman said calmly.");
    Console.WriteLine("The clergyman welcomed the Wizert into the stoney, vine covered church, closing the splintered wooden doors behind them.");
    Console.WriteLine("\"Right this way...\" the clergyman continued with a smirk. The candles in the church flickered as");
    Console.WriteLine("he sunk to the ground in a twisting motion, becoming black billowing smoke.");
    Console.WriteLine();
    Console.WriteLine("One by one, the old brick tiles of the church started falling, giving way to darkness below.");
    Console.WriteLine("The Wizert was able to find his footing on bricks, but it only bought him a few moments of safety.");
    Console.WriteLine("With the last brick falling, the Wizert fell with it deep into the abyss below.");
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Press any key to continue");
    Console.ReadKey();
    Console.Clear();
    Console.WriteLine("Light from above shines through the hole you fell through, illuminating the damp wretched ground.");
    Console.WriteLine();

    while (victory == false && defeat == false)
    {
        Console.WriteLine("Move which direction? Input selection and press Enter");
        Console.WriteLine("W to move north, S to move south, A to move west, D to move east");
        direction = Console.ReadLine().ToLower();
        floorPlan.Move(direction, testMap, ref victory, ref defeat, dummyRoom, ref allEnemiesDefeated);
    }

 
    while (victory == true || defeat == true)
    {
        if (allEnemiesDefeated == true)
        {
            Console.WriteLine("The spirits of the slain monsters combine in a whirling mist, blocking your path...");
            Console.WriteLine("Dark Wizert appears!");
            Battle.SpecialBattle(specialWizert, evilWizert);
        }
        Console.WriteLine();
        Console.WriteLine("Play again? Y/N");
        repeat = Console.ReadLine().ToLower();
        Console.Clear();

        if (repeat == "n")
        {
            playAgain = false;
            break;
        }
        else if (repeat == "y")
        {
            playAgain = true;
            victory = false;
            defeat = false;
            allEnemiesDefeated = false;
            specialWizert.SetHP(specialWizert.GetMaxHP());
            specialWizert.SetMP(specialWizert.GetMaxMP());
            evilWizert.SetHealth(evilWizert.GetMaxHP());
            evilWizert.SetCurrentMP(evilWizert.GetCurrentMP());
            Console.Clear();
        }
        else if (repeat != "y" || repeat != "n")
        {
            Console.WriteLine($"{repeat} is not a valid option.");
        }
    }
}