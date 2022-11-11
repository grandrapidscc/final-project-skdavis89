using CIS129FinalProject;

Hero Wizert = new Hero("Wizert", "Wizert", 100, 200);
Monster goblin1 = new Monster("Gobs", "Goblin", false, "NW");
Monster banshee1 = new Monster("Banz", "Banshee", false, "NW");
Monster orc1 = new Monster("Orcy", "Orc", false, "NW");

goblin1.Attack();
banshee1.Attack();
orc1.Attack();

Wizert.CastFireball();
Wizert.CastFireball();
Wizert.CastHeal();
Console.WriteLine();



object[,] testMap = new object[7, 7];




Map floorPlan = new Map();

floorPlan.PopulateMap(testMap);
floorPlan.SpawnExitRandomly(testMap);
floorPlan.SpawnPlayerRandomly(testMap);
floorPlan.PrintMap(testMap);
Console.WriteLine("--------------------");
Console.WriteLine(floorPlan.PlayerX_Coord());
Console.WriteLine(floorPlan.PlayerY_Coord());










