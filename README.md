# CIS 129 C# Programming I Final Project
## Introduction
You are a game developer for Floppy Plan Green, a studio that specializes in action role playing games (ARPGs).  The studio is currently in a crunch to develop its upcoming game, Wizert 5: Rabid Hunt.  This has been one of the most anticipated games for the better part of a decade, resulting in a bunch of promotional tie-in products to help generate more hype. 

While working on a bugfix for Wizert 5, which involves the main character's horse being stuck to a roof, your boss calls you into his office.  He just got off a conference call with the marketing team, and they have given him the task of assigning development for a text-based adventure game to one of his staff (guess you should have taken that personal day after all).  This is a retro throwback to the first Wizert game, which was also text-based adventure and developed for IBM PC Compatibles back in the mid-80s.  

## Getting to Know the Wizert
The player will take the role of the Wizert, a powerful sorcerer who uses magic to attack his foes.  In this game the Wizert is caught in a dungeon, and he must fight his way out to survive.  He can move in four directions:
-	North
-	South
-	East
-	West

The game should keep track of the Wizert's current location, even though this information is not shared with the player.  After the Wizert moves, he could encounter an enemy.  During an encounter, the Wizert has the three options at his disposal.  The table below shows each option with a description and how many magicka points (aka MP) it drains:

| Attack Name |Description                                      |MP Cost|Effect                                        |
|-------------|-------------------------------------------------|-------|----------------------------------------------|
|Fireball     |The Wizert casts a fireball that burns the enemy.|3      |Does 5 Damage                                 |
|Heal         |The Wizert casts a spell to heal his wounds.     |5      |Heals 3 Health Points (aka HP).               |
|Flee         |The Wizert attempts to flee from battle          |n/a    |Has a chance of allowing the Wizert to escape.|

When an action is performed, a description of what is happening should be displayed.  The amount of MP consumed, and the effects of the action should also be displayed when using an attack.  When an enemy takes an attack, you should display their new value for HP to the user.  When attempting to flee, a message indicating that the Wizert did/did not successfully escape battle should be displayed.   At the start of the game, the Wizert has 100 Health Points (HP) and 200 Magicka Points (MP).  If the Wizert is depleted of health before escaping the dungeon, the game is over.  A message indicating the Wizet has lost should be displayed to the console, along with an offer to play the game again.

## Enemy Lore
There are three kinds of enemies in this dungeon, each with their own HP and attack.  The table below shows the name of each enemy, how much health they have, the name of their attack, and how much damage they can do to the Wizert.

|Enemy Name|HP|Attack Name|Damage to the Wizert|
|----------|--|-----------|--------------------|
|Goblin    |3 |Body Slam  |2 HP                |
|Orc       |5 |Cleave     |3 HP                |
|Banshee   |8 |Screech    |5 HP                |

When an enemy attacks, a message should be displayed to the user informing:
-	The name of the attack used
-	How much damage it caused
-	How much health the Wizert has left 

Enemy encounters should be set manually (not by chance).  You will not always engage in battle after making a move, but at least half of your locations should have an enemy. If you do engage in battle in a certain location and defeat the enemy, make sure that the Wizert does not have to fight in that spot again should they return to it.  If the Wizert flees the area, ensure the enemy is still there waiting for him to continue the fight (their HP should be the same as it was after running).

## Powerups
Finding the exit to the dungeon could take time, and it's possible the Wizert will run low on health and/or magicka.  To help offset this disadvantage, powerups should be scattered throughout the dungeon. The table below describes each powerup and what effect it has on the Wizert:

|Powerup Name  |Description                     |Effect        |
|--------------|--------------------------------|--------------|
|Health Potion |A potion to restore some health.|Restores 10 HP|
|Magicka Potion|A position to restore magicka.  |Restores 20 MP| 

As with enemy encounters, powerup locations should be set manually.  The number of powerups found in the dungeon are at your discretion.  The Wizert should automatically consume the powerup if it is available at their present location.  However, the powerup should only be available for one time use at that location.  No replacement powerup or new powerup should be present if the Wizert backtracks to that location.  After consuming a powerup, display how much HP or MP was restored, then display the current HP and MP of the Wizert.

## The Dungeon 
The dungeon should be separated into smaller units.  Each unit represents the location of the dungeon that the Wizert can travel to.  It would be best to represent the dungeon as a 2-dimensional graph, with each unit representing a coordinate on the graph.  This graph should be 5x5, meaning there are a total of 25 units the Wizert could travel to.  Below is a drawing of a 5x5 graph:

![alt text](blankTable.JPG "A 5 x 5")


Think for a moment about what data structure we learned about that could support 2-dimensional graphs.  There should also be walls surrounding the perimeter of the graph, which prevent the Wizert from traveling out of bounds.  You do not need to place walls anywhere else in the dungeon.  
Every unit should have a description that describes the section of the dungeon the Wizert is in.  This description will be printed on the Console after each move (feel free to reuse some descriptions).  At least one of the following could also happen:
-	The Wizert will encounter an enemy.
-	The Wizert will encounter and consume a power up.

Encountering an enemy and/or powerup should not be by chance; you should set these yourself when writing your app.  If both an enemy and powerup appear in the same location at the same time, have the Wizert fight off the enemy first before consuming the power up. 
Upon startup, two locations are determined at random:
-	The current position of the Wizert.
-	The location of the Dungeon exit. 

You should not display the coordinates for either of these locations, but you should save them off somewhere in their own variables. You will need these as a reference when determining where the Wizert is and if they have reached the exit. When the Wizert reaches the exit, stop the program and inform the player they have won.  Then offer to let them play again.

## Input
You will need to practice good input validation when developing this application.  You could give the user the option to manually enter "commands" to the Wizert, but it may be easier to give them options to select.  For example, you might have something like this in a battle:
```
You have encountered a banshee.
It's the current HP 8.
Press...
1.	To Attack
2.	To Heal
3.	To Attempt to Flee
```

This way, you only need to validate that the user entered the expected number to the console.  You could also use this approach when giving the Wizert instructions on where to move:
```
You are in a room illuminated by torches.  It reeks of orc, though you do not see any nearby.  Press...
1.	To go north
2.	To go south
3.	To go east
4.	To go west
```

# Follow the Instructions Closely
It is crucial you meet all requirements in this project to recieve full credit.  Missing requirements means that an unfinished project has been shipped, which will not make our end users happy.  This will result in a deduction of points.

# Testing
Make sure to run this game on your own and test that it works as expected.  This is the best way to find bugs, and you may run into areas that you would like to improve (i.e. improving location descriptions, tuning difficultly).  Any code that does not build by the due date (or when you state it's finished) will be given an automatic zero.  Runtime errors will result in a deduction of points.

# What This Project Tests
The project gives you the opportunity to use the knowledge you have gained this semester to write a full-fledged application.  This includes:
-	Your understanding of which data types exist and when to use them.
-	Knowledge of data structures.
-	Input validation.
-	Ability to seek out and use libraries.
-	Creating classes and instantiating them into objects.
-	Using operators.
-	Using conditional statements (if and/or switch).
-	Using loops.
-	Inheritance.
- Encapsulation.

When creating new classes, make sure each one is in it's own file.  DO NOT place all logic in Program.cs.  Points will be deducted if I see design decisions that show these concepts have not been understood (i.e. not using classes where they would make the most sense, overengineering, etc).  

# Expectations
From this point on, you will have no homework for the rest of the semester.  As such, you will be expected to work on this project.   To ensure that you are actively developing the application, you will be expected to push at least one commit to Github Classroom per week (every Monday) until either the project is completed or the due date (12/5/2022) is reached.  When pushing a commit, leave me a comment letting me know what changes you have made so that I can monitor your progress (don't forget to assign me as the reviewer so I can see these messages come in via email).  I may choose to leave feedback if I see fit, but I will not proofread your code upon request.  Not pushing your work every Monday will result in a loss of points.

Given the complexity of this assignment, there will be no time for revisions.  However, you are free to ask me for help if you get stuck and can show you've done the best research possible to understand the issue (be sure to include links to resources you've consulted in those emails).  If you finish the project early, please leave a comment indicating such; do not work on the project afterwards. 



