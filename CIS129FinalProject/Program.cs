using CIS129FinalProject;

Hero Wizert = new Hero("Wizert", "Wizert", 100, 200);

Wizert.CastFireball();
Wizert.CastFireball();
Wizert.CastHeal();

int[,] map = new int[5, 5]
{
    {1, 2, 3, 4, 5 },
    {6, 7, 8, 9, 10 },
    {11, 12, 13, 14, 15},
    {16, 17, 18, 19, 20},
    {21, 22, 23, 24, 25},
};


////x = row, y = column
//Console.WriteLine(map.GetValue(3, 1));

//int[,] map = new int[5, 5]
//{
//    {1, 0, 0, 0, 0},
//    {0, 0, 0, 0, 0},
//    {0, 0, 0, 0, 0},
//    {0, 0, 0, 0, 0},
//    {0, 0, 0, 0, 0},
//};

int xCoord = 0;
int yCoord = 0;
var playerPosition = map[xCoord, yCoord];
Console.WriteLine("Starting upperleft most:");
Console.WriteLine(map.GetValue(0,0));
playerPosition = map[xCoord, yCoord++];
Console.WriteLine("move east, new location:");
Console.WriteLine(map.GetValue(0, 1));
Console.WriteLine("original location:");
Console.WriteLine(map.GetValue(0, 0));
Console.WriteLine("move south, new location:");
playerPosition = map[xCoord++, yCoord];
Console.WriteLine(map.GetValue(1,1));
Console.WriteLine("last value: ");
Console.WriteLine(map.GetValue(0,1));
Console.WriteLine("move west");
playerPosition = map[xCoord--, yCoord];
Console.WriteLine(map.GetValue(1,0));
//Console.WriteLine(playerPosition);

Dungeon layout = new Dungeon();
//layout.CreateMap();
Console.WriteLine("testing print map");
//layout.PrintMap();
layout.SetPlayerPosition();
layout.PrintMap();
layout.MoveDirection("d");
layout.PrintMap();




