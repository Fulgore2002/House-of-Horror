using House_Of_Horror;
using System;
using System.Numerics;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Cryptography;

namespace House_Of_Horror
{
    public class Rooms
    {
        private Player player;

        public Rooms(Player player)
        {
            this.player = player;
        }

        public void PlayGame()
        {
            Console.WriteLine("Welcome to the Haunted Mansion!");
            Console.WriteLine("You are a distant family member of a rich millionaire who just passed away, leaving his mansion to you.");
            Console.WriteLine("Now that you are the newfound owner, you decide to take a look inside.");
            Console.WriteLine("The house is dated, creaky, and falling apart. You cautiously step through the front door, ready for adventure");

            while (true)
            {
                Console.WriteLine("Do you want to enter the living room, the dining room, the kitchen, the backyard or the master bedroom?");
                Console.Write("> ");
                string roomChoice = Console.ReadLine();

                if (roomChoice == "living room")
                {
                    EnterLivingRoom();
                }
                else if (roomChoice == "dining room")
                {
                    EnterDiningRoom();
                }
                else if (roomChoice == "kitchen")
                {
                    EnterKitchen();
                }
                else if (roomChoice == "backyard")
                {
                    EnterBackyard();
                }
                else if (roomChoice == "master bedroom") 
                { 
                    EnterMasterBedroom(); 
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please answer 'living room', 'dining room', 'kitchen', 'backyard' or 'master bedroom'.");
                }

                player.ShowInventory();

                // Check if the player has the Gold Jewelry and/or Gold Coins and give them the option to leave
                if (player.Inventory.HasItem("Gold Jewelry") || player.Inventory.HasItem("Gold Coins"))
                {
                    Console.WriteLine("Do you want to leave the house? (yes/no)");
                    Console.Write("> ");
                    string leaveChoice = Console.ReadLine();

                    if (leaveChoice.ToLower() == "yes")
                    {
                        if (player.Inventory.HasItem("Gold Jewelry") && player.Inventory.HasItem("Gold Coins"))
                        {
                            Console.WriteLine("Congratulations! You have safely left the house with both the Gold Jewelry and Gold Coins. You're rich!");
                        }
                        else if (player.Inventory.HasItem("Gold Jewelry"))
                        {
                            Console.WriteLine("Congratulations! You have safely left the house with the Gold Jewelry, but you feel like there was still more in the house.");
                        }
                        else if (player.Inventory.HasItem("Gold Coins"))
                        {
                            Console.WriteLine("Congratulations! You have safely left the house with the Gold Coins, but you feel like there was still more in the house.");
                        }
                        break;
                    }
                }

                Console.WriteLine("Do you want to explore another room? (yes/no)");
                Console.Write("> ");
                string exploreMore = Console.ReadLine();

                if (exploreMore.ToLower() == "no")
                {
                    break;
                }
            }
        }

        private void EnterLivingRoom()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Program.DisplayTitle();
            Console.ResetColor();
            Console.WriteLine("You chose to go into the living room.");
            Console.WriteLine("As you walk in, you see a sleeping pitbull guarding some gold jewelry.");
            Console.WriteLine("Do you want to steal the jewelry? WARNING!");
            Console.Write("> ");
            string pitbullChoice = Console.ReadLine();

            if (pitbullChoice == "yes")
            {
                if (player.Inventory.HasItem("Bones"))
                {
                    Console.WriteLine("You give the bones to the pitbull, who happily munches on them.");
                    Console.WriteLine("You take the jewelry while the pitbull is distracted.");
                    player.Inventory.AddItem("Gold Jewelry");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(@" 
........-:==:-........................................................:---=:.........
.........-:::-........................................................:=-:-:.........
.........:-::::.......................................................-:--::.........
.........-:+=:-......................................................:---=:..........
..........:-:--......................................................---::-..........
..........:--:::.....................................................:--:::..........
..........-:=-:-....................................................:=---:...........
...........:-=-=:...................................................==-:--...........
...........:--:::..................................................::=-::............
...........::==:::.................................................-=-=-:............
............:-::-:................................................-=-::--............
............::-::-................................................-:-:::.............
............::-==.-..............................................::-:-:..............
.............:--:--..............................................=--::=..............
.............::-::-.............................................:.=:::...............
..............--+=-=............................................:-::-:...............
..............:--:=-...........................................-::::-:...............
...............---:--..........................................-=--::................
...............::+-=-:........................................-----:.................
................:-::-:.......................................--:::::.................
................::-::::.....................................:-+--::..................
.................--=-==:...................................:=-++-:...................
..................:----:..................................::-..::....................
..................-=--:--.................................--+-=:.....................
...................::=:-=:...............................=---::......................
....................----:-..............................:==.:::......................
.....................+---===...........................=-+---........................
......................:-:.--..........................:-.-:::........................
.......................-:----=:.....................:---=::..........................
........................--+-.=-:...................-::=-:-...........................
.........................:---+=-==..............:--=-:.::............................
...........................=----.=++::.......::--.-+---:.............................
.............................-----==:=--=++-=:-+=-.-::...............................
...............................=--=.-=+=:==+=.---=-:.................................
..................................-----+----+-:::....................................
.......................................:::...........................................
.....................................................................................
...............................................-=:...................................
.................-=%-#--**..............--#%*%##**+...+*+:........:=*+=:.............
-----=----=---:-*%:#+%+---*=.-........=*+-...:=*+#++*++*#=**=:-++-=%*+++++===--=-==:=
%#+*:*%*++=%#++*%%%-:=:=:...+-.......-++........+%##%#+*..:-*%%++=--%-*:::*%*#@**#*#%
*+*++*=#=*=**##**#%*%#+-....--.......=*-........-+#**#*...:=++=*##+**:+-::=#*=+:*#+=:
#%%##%%@##%%@%=#@%@@@%====+=-.........%%+.....-=*+*==#=+=+++*==#*=-@=+%*+=+@%+=%%%*-#
................:::-=+-::..............:++%*+#*++=:.-**%#*=......--+##+-:............
...........................................:-:....................................... ");
                    Console.ResetColor();
                    player.Inventory.RemoveItem("Bones");
                }
                else
                {
                    Console.WriteLine("You attempt to steal the jewelry, but the pitbull wakes up and rips your shirt to shreds.");
                    Console.WriteLine("Game Over. You have been attacked by the pitbull.");
                    Environment.Exit(0); // End the game
                }
            }
            else if (pitbullChoice == "no")
            {
                Console.WriteLine("You decide not to steal the dog's jewelry.");
                Console.WriteLine("You turn back and find your way out of the house safely.");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please answer 'yes' or 'no'.");
            }
        }

        private void EnterMasterBedroom()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Program.DisplayTitle();
            Console.ResetColor();
            Console.WriteLine("You chose to go into the master bedroom.");
            Console.WriteLine("As you walk in, you see an ornate bed and a large, dusty wardrobe.");
            Console.WriteLine("Do you want to open the wardrobe?");
            Console.Write("> ");
            string wardrobeChoice = Console.ReadLine();

            if (wardrobeChoice.ToLower() == "yes")
            {
                Console.WriteLine("You open the wardrobe and find a skeleton holding a golden locket and a Holy Relic.");
                Console.WriteLine("Do you want to take the locket and the Holy Relic? (yes/no)");
                string itemChoice = Console.ReadLine();

                if (itemChoice.ToLower() == "yes")
                {
                    Console.WriteLine("You take the golden locket and the Holy Relic, feeling a chill run down your spine.");
                    player.Inventory.AddItem("Golden Locket");
                    player.Inventory.AddItem("Holy Relic");
                }
                else if (itemChoice.ToLower() == "no")
                {
                    Console.WriteLine("You decide to leave the items and close the wardrobe.");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please answer 'yes' or 'no'.");
                }
            }
            else if (wardrobeChoice.ToLower() == "no")
            {
                Console.WriteLine("You decide not to open the wardrobe.");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please answer 'yes' or 'no'.");
            }

            Console.WriteLine("As you explore further, you suddenly feel a cold presence in the room.");
            Console.WriteLine("The ghost from the dining room appears and floats towards you.");
            Console.WriteLine("It looks at you with longing but doesn't take anything.");
            Console.WriteLine("The ghost nods and vanishes, leaving you to explore the rest of the room.");

            if (player.Inventory.HasItem("Gold Coins") && player.Inventory.HasItem("Gold Jewelry") && player.Inventory.HasItem("Holy Relic") && player.Inventory.HasItem("Golden Locket"))
            {
                Console.WriteLine("As you explore further, you notice a hidden door behind a tapestry.");
                Console.WriteLine("With the gold coins, gold jewelry, golden locket, and Holy Relic in your possession, the ghost reappears and nods approvingly.");
                Console.WriteLine("The ghost opens the hidden door, revealing a staircase to the attic.");
                // Handle entering the attic and cleansing the house of ghosts
                CleansingHouse();
            }
            else
            {
                Console.WriteLine("You notice a hidden door behind a tapestry, but it remains tightly shut. It seems you need more items to unlock it.");
            }
        }

        private void CleansingHouse()
        {
            Console.WriteLine("You use the Holy Relic and the golden locket, Gold Jewelry, and gold coins to cleanse the house of all ghosts.");
            Console.WriteLine("The spirits are finally at peace, and the mansion feels lighter and more welcoming.");

            // Remove items from the inventory
            player.Inventory.RemoveItem("Gold Coins");
            player.Inventory.RemoveItem("Gold Jewelry");
            player.Inventory.RemoveItem("Holy Relic");
            player.Inventory.RemoveItem("Golden Locket");

            // End the game
            Console.WriteLine("Congratulations! Though you may not have found what you initially sought, you have performed a noble deed and brought peace to the haunted mansion.");
            Environment.Exit(0); // End the game
        }




        private void EnterDiningRoom()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Program.DisplayTitle();
            Console.ResetColor();
            Console.WriteLine("You chose to go into the dining room.");
            Console.WriteLine("As you walk in, you see a shiny vase on the table.");
            Console.WriteLine("Do you want to open it?");
            Console.Write("> ");
            string vaseChoice = Console.ReadLine();

            if (vaseChoice == "yes")
            {
                Console.WriteLine("You open the vase and find a pile of bones.");
                player.Inventory.AddItem("Bones");
            }
            else if (vaseChoice == "no")
            {
                Console.WriteLine("You decide not to open the vase.");
                Console.WriteLine("As you turn to leave, you hear a creaking sound coming from the corner.");
                Console.WriteLine("A dark figure with glowing red eyes launches at you!");
                Console.WriteLine("Do you want to run or fight? (run/fight) WARNING!");
                Console.Write("> ");
                string actionChoice = Console.ReadLine();

                if (actionChoice.ToLower() == "run")
                {
                    Console.WriteLine("You run as fast as you can and manage to escape the dark figure.");
                }
                else if (actionChoice.ToLower() == "fight")
                {
                    Console.WriteLine("You try to fight the dark figure, but it overpowers you, knocking you unconscious.");
                    Console.WriteLine("You wake up in your bed. It was all a dream.");
                    Environment.Exit(0); // End the game
                }
                else
                {
                    Console.WriteLine("Invalid choice. The dark figure overpowers you, knocking you unconscious.");
                    Console.WriteLine("You wake up in your bed. It was all a dream.");
                    Environment.Exit(0); // End the game
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please answer 'yes' or 'no'.");
            }
        }

        private void EnterKitchen()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Program.DisplayTitle();
            Console.ResetColor();
            Console.WriteLine("You chose to go into the kitchen.");
            Console.WriteLine("As you walk in, you see a refrigerator humming loudly.");
            Console.WriteLine("Do you want to open the refrigerator?");
            Console.Write("> ");
            string fridgeChoice = Console.ReadLine();

            if (fridgeChoice == "yes")
            {
                Console.WriteLine("You open the refrigerator and find some expired food.");
                Console.WriteLine("As you take a closer look, you hear a noise coming from the pantry.");
                Console.WriteLine("Do you want to investigate the noise coming from the pantry? (yes/no) WARNING!");
                string pantryChoice = Console.ReadLine();

                if (pantryChoice.ToLower() == "yes")
                {
                    Console.WriteLine("You investigate the pantry and find a ghostly figure! It attacks you!");
                    Console.WriteLine("Game Over. You have been attacked by a ghost.");
                    Environment.Exit(0); // End the game
                }
            }
            else if (fridgeChoice == "no")
            {
                Console.WriteLine("You decide not to open the refrigerator.");
                Console.WriteLine("As you turn to leave, you hear a whispering sound coming from behind the refrigerator. However a calm feeling washes over you.");
                Console.WriteLine("Do you want to investigate the noise? (yes/no) Warning?");
                string whisperChoice = Console.ReadLine();

                if (whisperChoice.ToLower() == "yes")
                {
                    Console.WriteLine("You investigate the noise and find a ghostly figure!");
                    Console.WriteLine("The ghostly figure holds out a rusty key and whispers, 'Take it...'");
                    player.Inventory.AddItem("Rusty Key");
                    Console.WriteLine(@"         
              .....                ...:..                  .....                 .:::.              
             ..   ..               ..    ..              ...   ..             ....   ..             
           .         ..          ..        ..           .        ..         ....        ..          
..      ...            ..      ..            ..      ...          ...    .......          ..      ..
  ..   ..                ... ...               ......               ... .....              ..   ..  
   .::.                   .::.                  .::.                .......                  ...    
   .....                 ......                 .....              ........    .. .. .      ..  ..  
..      ...            ..      ..           ...      ..          .....     .....=++++++-....      ..
          ..         ..          ..        ..          ..       ....        ..++#%#####**+...       
             ...  ..                ..  ..                ..   ..          ..+*#:. . ..*#**=.       
               ...                    ...                  ...             .:++-. .::  ..#**=..     
           .  .....                 .....                  .....    .    . .:***..::..  .-***:      
      ......................................................................-+**+..  ... .***+.    .
.    .=++++-=+++++++=+++++++++++++=+++++++=++====-++++++++++++++++**************#-.     ..+***.   ..
..   .=+*++*#######*******########*****##***######**#########**######*#######***#:       .=***-.....
  .. ..+**###%%%@%%%%%%%%%%##=######**####*#**********++*++++++++**********##***=.       .=***-.... 
 ...........-**##******++..... .   . .          .::. ...    .     ..   :::..:**#..       .=**+...   
.........  ..:::=*###----.. ...                ..  ..                ... ....***:.      .-++++. ..  
...     ...    .=***+...       ...          ...      ...           ..       ..***:..  ..=++**.    ..
.          .-===*****++=-.       ...      ...          ...       ...         ..****+++**+##=.       
           .+*++***#**###.          ..  ..               ... ..:.             ...+*######-.         
           .=**#*####****.            ...                  ..:..                  ........          
           . ......  ....            .....               ..:. ..                 .....              
           ...    ....          .....    ...            ...    ...          .....     ...           
.        ...         ...       ....        ..          ..        ...       ......       ..         .
 ...   ...              ..  ......            ..   ....             ..  ......            ..    ... 
   .....                 .......               .....                 ........              ...::.   
    ....               .......                  ....               .......                   .::.    ");
                    Console.WriteLine("You take the rusty key and the ghostly figure vanishes.");
                }
                else if (whisperChoice.ToLower() == "no")
                {
                    Console.WriteLine("You decide not to investigate the noise and leave the kitchen.");
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please answer 'yes' or 'no'.");
            }
        }


        private void EnterBackyard()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Program.DisplayTitle();
            Console.ResetColor();
            Console.WriteLine("You chose to go into the backyard.");
            Console.WriteLine("As you walk outside, you see an old shed with a rusty lock.");

            if (!player.Inventory.HasItem("Rusty Key"))
            {
                Console.WriteLine("You don't have the key to open the lock.");
            }
            else
            {
                Console.WriteLine("Do you want to try the rusty key on the lock?");
                Console.Write("> ");
                string shedChoice = Console.ReadLine();

                if (shedChoice == "yes")
                {
                    Console.WriteLine("You use the rusty key to open the lock. The key breaks as you unlock the door.");
                    player.Inventory.RemoveItem("Rusty Key");
                    Console.WriteLine("Inside, you find a hidden stash of gold coins.");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(@"        :::::::::---===++======                           
    :::::::::::::--------====--====                       
  ::::=::::::::::--------=======:===+                     
 ::::=:::::::::::--------========:-==+                    
 :::--:::::::::::--------========+-==+                    
 ::::=:::::::::::--------========:====                    
 =::::--:::::::::--------======-:====+                    
 ==::::::::::::::--------====-=====:##                    
 :=++-:::::::::::---==++========::+##*                    
 ::=+*+=-:::::::-----------::::-=+**+=                    
 -:::=+==-::----===+++**##*+==--=+===+                    
 ==::::-==::--===++**##%##*+==++===:*#                    
 :=++::::--=++**##%%%@@%#**++===-.*##*+                   
 ::++*+=-..:::----======----:.--=+*#+==                   
 =:::++==-::--====--=+*%##*+==--=+===+%                   
 ==-:::-=--:--===++**##%##*+===+===:##                    
 :=+++:::--=+*******#####**++==-::*##+                    
 ::-+*+==-:::::--======--:::::--=+**+=                    
 =:::-===-::--===++**#####*+==--=+==:#                    
 -==:::-===---===++**#####*+++++==:=##                    
 :=+++-:::-==++**######***++==-::+*##+                    
 :::+*+==-:::::::::::::::::--=--=+*+++=--:-               
 =::::===-::--===++**##%##*+==::::::---===----==          
::=+::::-==+--===++**##%#=::::::::::-------==========     
::-++*+:.::-==+++******:::-:::::::::--------======:-===   
=:::+*+==-::::.....:::::--::::::::::--------========:==== 
==::::-==-::--===++*-:::+:::::::::::--------=========:==++
 =++=:::-=+++===+++*-:::+:::::::::::--------=========:==+=
  ++*++=::::--==++++-::::=::::::::::--------========:====+
    *++=--:------:::=-:::::-::::::::--------=====--====-#%
       =--:---==++**+=+:::::::::::::------===========:=##*
             --==++*::++*+:::::::::----------===-:::=+*#+=
                    -::=*++=-:::::::::::::::::-==--=+++=-#
                    ==:::-==--:--===++**##%%#*++=--===--##
                    ==++-::-========++**##%%#***++==:-*## 
                      ++*+=-:::-==++++***++++==::::-=+*#  
                       **++=--:----------=****++=--==+    
                           =--:--===++***##%#*++=--       
                                  ==++**###% ");
                    Console.ResetColor();
                    player.Inventory.AddItem("Gold Coins");

                }
                else if (shedChoice == "no")
                {
                    Console.WriteLine("You decide not to open the shed.");
                    Console.WriteLine("As you turn to leave, you hear a rustling sound coming from the bushes.");
                    Console.WriteLine("Do you want to investigate the bushes? (yes/no) WARNING!");
                    string bushChoice = Console.ReadLine();

                    if (bushChoice.ToLower() == "yes")
                    {
                        Console.WriteLine("You investigate the bushes and a rabid raccoon lunges at you!");
                        Console.WriteLine("Game Over. You have been attacked by a rabid raccoon.");
                        Environment.Exit(0); // End the game
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please answer 'yes' or 'no'.");
                }
            }

            Console.WriteLine("As you turn to leave, you hear a rustling sound coming from the bushes.");
            Console.WriteLine("Do you want to investigate the bushes? (yes/no) WARNING!");
            string bushChoice2 = Console.ReadLine();

            if (bushChoice2.ToLower() == "yes")
            {
                Console.WriteLine("You investigate the bushes and a rabid raccoon lunges at you!");
                Console.WriteLine("Game Over. You have been attacked by a rabid raccoon.");
                Environment.Exit(0); // End the game
            }
        }
    }
}