using CIS129FinalProject;


object[,] testMap = new object[7, 7];
Map floorPlan = new Map();
bool victory = false;
bool defeat = false;
string direction;
bool playAgain = true;
string repeat;
Monster testBanshee = new Monster(true, "testMonster", "Banshee", false, "testRoom", null);
Room dummyRoom = new Room(false, testBanshee, "Dummy", null, false, false);

while (playAgain == true)
{
    floorPlan.PopulateMap(testMap);
    floorPlan.SpawnPlayerRandomly(testMap);
    Console.WriteLine("Often misunderstood but always respected, the Wizert travels from town to town in search of someone or something.");
    Console.WriteLine("While passing through the quiet village of Nome, the Wizert sets out in search of the town's missing children.");
    Console.WriteLine();
    Console.WriteLine("Shortly into their hike through the surrounding hillside, the Wizert reflects on the townspeople.");
    Console.WriteLine("\"Only men in the town,\" the Wizert ponders. \"Where are the mothers of these children? Also missing?\"");
    Console.WriteLine("\"This couldn't be...\"");
    Console.WriteLine("A chasm below opens, engulfing the Wizert and the surrounding flora.");
    Console.WriteLine("\"...a trap?\"");
    Console.WriteLine();
    Console.WriteLine("Light from above shines through the hole you fell through, illuminating the damp wretched ground.");
    Console.WriteLine();

    while (victory == false && defeat == false)
    {
        Console.WriteLine("Move which direction? Input selection and press Enter");
        Console.WriteLine("W to move north, S to move south, A to move west, D to move east");
        direction = Console.ReadLine().ToLower();
        floorPlan.Move(direction, testMap, ref victory, ref defeat, dummyRoom);
        //Console.WriteLine(floorPlan.GetPlayerPosition());
        //floorPlan.PrintMap(testMap);
    }

 
    while (victory == true || defeat == true)
    {
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
            Console.Clear();
        }
        else if (repeat != "y" || repeat != "n")
        {
            Console.WriteLine($"{repeat} is not a valid option.");
        }
    }
}