using System;
using System.Drawing;
using System.Runtime.Intrinsics.X86;
using CIS129FinalProject;

//Hero Wizert = new Hero("Wizert", "Wizert", 100, 200);
//Monster goblin1 = new Monster(true, "Gobs", "Goblin", false, "NW");
//Monster banshee1 = new Monster("Banz", "Banshee", false, "NW");
//Monster orc1 = new Monster("Orcy", "Orc", false, "NW");





object[,] testMap = new object[7, 7];


//There 's a simple answer to this. Use instances of the "System.Drawing.Point" class. Create a "Point" array to store coordinates. To create the array:

//Point[] points = new Point[4];
//And to assign a value to the array (e.g. at position 0) use the following code.

//points[0] = new Point(xvalue, yvalue);//Where "xvalue" and "yvalue" are integer variables.
//And to get the X and Y values from an instance of the point class. Use the below code.

//int xvalue = points[0].X;

//int yvalue = points[0].Y

//Map floorPlan = new Map();

//floorPlan.PopulateMap(testMap);
////floorPlan.SpawnExitRandomly(testMap);
////floorPlan.SpawnPlayerRandomly(testMap);
//floorPlan.PrintMap(testMap);
//Console.WriteLine("--------------------");
//Console.WriteLine(floorPlan.Get_Wizert_X_Coord());
//Console.WriteLine(floorPlan.Get_Wizert_Y_Coord());
//Console.WriteLine();
////Console.WriteLine("Wizert Health:");
////Console.WriteLine(Wizert.GetHealth());
//Console.WriteLine();
////Battle.BeginBattle(Wizert, banshee1);
//Console.WriteLine();
//floorPlan.Move("s", testMap);
//Console.WriteLine();
//floorPlan.PrintMap(testMap);
//Console.WriteLine("--------------------");
//Console.WriteLine(floorPlan.Get_Wizert_X_Coord());
//Console.WriteLine(floorPlan.Get_Wizert_Y_Coord());
//floorPlan.Move("s", testMap);
//Console.WriteLine();
//floorPlan.PrintMap(testMap);
//Console.WriteLine("--------------------");
//Console.WriteLine(floorPlan.Get_Wizert_X_Coord());
//Console.WriteLine(floorPlan.Get_Wizert_Y_Coord());
//Console.WriteLine(Wizert.GetHealth());
//Console.WriteLine("test battle");

//Battle.BeginBattle(Wizert, banshee1);
//Battle.BeginBattle(Wizert, orc1);

//Battle.BeginBattle(Wizert, goblin1);


Map floorPlan = new Map();
bool victory = false;

floorPlan.PopulateMap(testMap);

//test room
Room roomOccupied = new Room(true, "dark", false, false, false);
MonsterRoom monsterRoom = new MonsterRoom();
//Room room = new Room()
Monster goblin2 = new Monster(true, "Gobz2", "Goblin", false, "NW");



Console.WriteLine("You fall into a dungeon");
Console.WriteLine("Move which direction?");
Console.WriteLine(floorPlan.Get_Wizert_X_Coord() + "," + floorPlan.Get_Wizert_Y_Coord());




//do
//{

//    string direction = Console.ReadLine();
//    floorPlan.Move(direction, testMap);
//    Console.WriteLine("Move which direction?");
//    direction = Console.ReadLine();

//} while (victory == false);

string direction;

Hero.Potion potion1 = new Hero.Potion("hp");



while (victory == false)
{
    direction = Console.ReadLine(); ;
    floorPlan.Move(direction, testMap, ref victory);
    //Console.WriteLine("Move which direction?");
    Console.WriteLine(floorPlan.Get_Wizert_X_Coord() + "," + floorPlan.Get_Wizert_Y_Coord());
    floorPlan.PrintMap(testMap);
}
















