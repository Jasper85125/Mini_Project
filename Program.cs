using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public static class Program
{
    public static void Main()
    {
        //make compass
        Compass compass1 = new Compass(north: "Y", east: "N", south: "N", west: "N");

        Console.WriteLine("Welcome to our game what is your name.");
        string name_of_player = Console.ReadLine();
        Player player = new(100, 6, 1, 100, name_of_player);

        Console.WriteLine($"Welcome {player.Name}");

        bool QuestActive1 = false;
        bool QuestActive2 = false; 
        bool QuestActive3 = false;

        bool Quest1 = false;
        bool Quest2 = false; 
        bool Quest3 = false; 

        bool keepGaming = true; 
        while(keepGaming)
        {
            //HOME
            while(player.CurrentLocation == 1)
            {
                //draw compass
                compass1.DrawCompass();

                //start the writing
                Console.WriteLine($"You are currently {World.LocationByID(player.CurrentLocation).Name} what would you like to do.");
                Console.WriteLine("1: look around");
                Console.WriteLine("2: leave the house");
                Console.WriteLine("3: go back to bed");
                Console.WriteLine("Q to quit the game");
                string choice1 = Console.ReadLine();

                if(choice1 == "1")
                {
                    // returns the locations
                    Console.WriteLine(World.LocationByID(player.CurrentLocation).Description);
                }
                else if(choice1 == "2")
                {
                    Console.WriteLine("you open the door and walk to Town square");
                    player.CurrentLocation = 2;
                    break;
                }
                else if(choice1 == "3")
                {
                    Console.WriteLine("You go back to bed, but cant sleep better go do somting");
                }
                else if (choice1 == "Q")
                {
                    keepGaming = false;
                    break;
                }
                else
                {
                    Console.WriteLine("That is not a valid input");
                }
            }
            
            //TOWN_SQUARE
            while(player.CurrentLocation == 2)
            {
                Compass compass2 = new Compass(north: "Y", east: "Y", south: "Y", west: "Y");

                //draw compass
                compass2.DrawCompass();

                Console.WriteLine($"You arrive at the {World.LocationByID(player.CurrentLocation).Name}.");
                Console.WriteLine("There is not much to do what do you want to do.");
                Console.WriteLine("1: Look around");
                Console.WriteLine("2: North -> Alchemist Hut");
                Console.WriteLine("3: East -> Guard Post");
                Console.WriteLine("4: South -> Home");
                Console.WriteLine("5: West -> Farm House");
                Console.WriteLine("Q to quit the game");
                string choice1 = Console.ReadLine();
                if(choice1 == "1")
                {
                    Console.WriteLine(World.LocationByID(player.CurrentLocation).Description);
                }
                else if(choice1 == "2")
                {
                    Console.WriteLine("You deside to go to the Alchemist Hut");
                    player.CurrentLocation = 4;
                    break;
                }
                else if(choice1 == "3")
                {
                    Console.WriteLine("You deside to walk to the Guard Post");
                    player.CurrentLocation = 3;
                    break;
                }
                else if(choice1 == "4")
                {
                    Console.WriteLine("You deside to go Home");
                    player.CurrentLocation = 1;
                    break;
                }
                else if(choice1 == "5")
                {
                    Console.WriteLine("The farm house looks interesting you deside to go there");
                    player.CurrentLocation = 6;
                    break;
                }
                else if(choice1 == "Q")
                {
                    keepGaming = false;
                    break;
                }
                else
                {
                    Console.WriteLine("That is not a valid input");
                }
            }

            //GUARD_POST
            while(player.CurrentLocation == 3)
            {
                Compass compass3 = new Compass(north: "N", east: "Y", south: "N", west: "Y");

                //draw compass
                compass3.DrawCompass();
                
                Console.WriteLine($"You arrive at the {World.LocationByID(player.CurrentLocation).Name}.");
                Console.WriteLine("what do you want to do.");
                Console.WriteLine("1: Look around");
                Console.WriteLine("2: East -> Bridge");
                Console.WriteLine("3: West -> Town square");
                Console.WriteLine("Q to quit the game");
                string choice3 = Console.ReadLine();

                if(choice3 == "1")
                {
                    // returns the locations
                    Console.WriteLine(World.LocationByID(player.CurrentLocation).Description);
                }

                else if (choice3 == "2")
                {
                    Console.WriteLine("You leave the Guard post and go to Bridge");
                    player.CurrentLocation = 8;
                }

                else if (choice3 == "3")
                {
                    Console.WriteLine("You leave the Guard post and go to Town square");
                    player.CurrentLocation = 2;
                }
                else if (choice3 == "Q")
                {
                    keepGaming = false;
                    break;
                }
                else
                {
                    Console.WriteLine("That is not a valid input");
                }

            }

            //Alchemist`s hut
            while(player.CurrentLocation == 4)
            {
                Compass compass4 = new Compass(north: "N", east: "Y", south: "N", west: "Y");

                //draw compass
                compass4.DrawCompass();

                Console.WriteLine($"You arrive at the {World.LocationByID(player.CurrentLocation).Name}.");
                Console.WriteLine($"you notice a weathered signpost planted at its entrance. \nThe sign provides directions for travelers:");
                Console.WriteLine("1: Look around");
                Console.WriteLine("2: South -> Town Square");
                Console.WriteLine("3: North -> Alchemist's Garden");
                Console.WriteLine("4: Talk to the Alchemist");
                Console.WriteLine("Q to quit the game");
                string choice4 = Console.ReadLine();

                if(choice4 == "1")
                {
                    // returns the locations
                    Console.WriteLine(World.LocationByID(player.CurrentLocation).Description);
                }
                else if(choice4 == "2")
                {
                    Console.WriteLine("As you decide to head south, you start walking too Town Square.");
                    player.CurrentLocation = 2;
                }
                else if(choice4 == "3")
                {
                    Console.WriteLine("Choosing the path north, you walk past the hut to the alchemist's garden.");
                    Console.WriteLine("As you get closer too the alchemist's garden you see more and more flora.");
                    player.CurrentLocation = 5;
                }
                else if(choice4 == "4")
                {
                    if(Quest1 == false){
                        Console.WriteLine("The Alchemist gives you the following quest:");
                        Console.WriteLine(World.QuestByID(1).Description);
                        QuestActive1 = true;
                    }
                    else
                    {
                        Console.WriteLine("You already helped the Alchemist, she is very thankfull!");
                    }
                }
                else if (choice4 == "Q")
                {
                    keepGaming = false;
                    break;
                }
                else
                {
                    Console.WriteLine("That is not a valid input");
                }
            }
            
            // Alchemist Garden
            while(player.CurrentLocation == 5)
            {
                Compass compass5 = new Compass(north: "N", east: "N", south: "Y", west: "N");

                //draw compass
                compass5.DrawCompass();

                Console.WriteLine($"You arrive at the {World.LocationByID(player.CurrentLocation).Name}.");
                Console.WriteLine($"You look into a garden full of strange flowers and trees \nA strange smell reminding you of medicine fills the air:");
                Console.WriteLine("1: Look around");
                Console.WriteLine("2: South -> Alchemist's Hut");
                Console.WriteLine("3: Fight the Rats");
                Console.WriteLine("Q to quit the game");
                string choice5 = Console.ReadLine();

                if(choice5 == "1")
                {
                    // returns the locations
                    Console.WriteLine(World.LocationByID(player.CurrentLocation).Description);
                }
                else if(choice5 == "2")
                {
                    Console.WriteLine("As you decide to head south and go back inside the Alchemist's Hut.");
                    player.CurrentLocation = 4;
                }
                else if(choice5 == "3")
                {
                    if(Quest1 == false && QuestActive1 == true)
                    {
                        Console.WriteLine("Hier moet Quest 1 komen, Type 'Y' om de Quest te 'voltooien'");
                        string testOption = Console.ReadLine();

                        if(testOption == "Y")
                        {
                            // Hier moet de Quest beginnen
                            Console.WriteLine("Quest gelukt!");
                            Quest1 = true; 
                        }
                        else
                        {
                            Console.WriteLine("Probeer het nog een keer.");
                        }
                    }
                    else if (Quest1 == false && QuestActive1 == false)
                    {
                        Console.WriteLine("Go talk to the Alchemist");
                    }
                    else
                    {
                        Console.WriteLine("The Rats are already dead");
                    }
                }
                else if (choice5 == "Q")
                {
                    keepGaming = false;
                    break;
                }
                else
                {
                    Console.WriteLine("That is not a valid input");
                }
            }

            //FARMHOUSE
            while(player.CurrentLocation == 6)
            {
                Compass compass6 = new Compass(north: "N", east: "Y", south: "N", west: "Y");

                //draw compass
                compass6.DrawCompass();

                Console.WriteLine($"You arrive at the {World.LocationByID(player.CurrentLocation).Name}.");
                Console.WriteLine("There is a man standing outside, it looks like he needs your help.");
                Console.WriteLine("1: Look around");
                Console.WriteLine("2: East -> Town Square");
                Console.WriteLine("3: West -> Farmer's Field");
                Console.WriteLine("4: Talk to the man");
                Console.WriteLine("Q to quit the game");
                string choice1 = Console.ReadLine();

                if(choice1 == "1")
                {
                    // returns the locations
                    Console.WriteLine(World.LocationByID(player.CurrentLocation).Description);
                }
                else if(choice1 == "2")
                {
                    Console.WriteLine("you open the door and walk to Town square");
                    player.CurrentLocation = 2;
                    break;
                }
                else if(choice1 == "3")
                {
                    Console.WriteLine("You go to the Farmer's Field");
                    player.CurrentLocation = 7;
                    break;
                }
                else if(choice1 == "4")
                {
                    if(Quest2 == false){
                        Console.WriteLine("The farmer gives you the following quest:");
                        Console.WriteLine(World.QuestByID(2).Description);
                        QuestActive2 = true;
                    }
                    else
                    {
                        Console.WriteLine("You already helped the farmer, he is very thankfull!");
                    }
                }
                else if (choice1 == "Q")
                {
                    keepGaming = false;
                    break;
                }
                else
                {
                    Console.WriteLine("That is not a valid input");
                }
            }

            //FARMER'S FIELD
            while(player.CurrentLocation == 7)
            {
                Compass compass7 = new Compass(north: "N", east: "Y", south: "N", west: "Y");

                //draw compass
                compass7.DrawCompass();

                Console.WriteLine($"You arrive at the {World.LocationByID(player.CurrentLocation).Name}.");
                Console.WriteLine($"You walk into a big field");
                Console.WriteLine("1: Look around");
                Console.WriteLine("2: East -> Farmhouse");
                Console.WriteLine("3: Fight the snakes!");
                Console.WriteLine("Q to quit the game");
                string choice7 = Console.ReadLine();

                if(choice7 == "1")
                {
                    // returns the locations
                    Console.WriteLine(World.LocationByID(player.CurrentLocation).Description);
                }
                else if(choice7 == "2")
                {
                    Console.WriteLine("You go back to the farm house.");
                    player.CurrentLocation = 6;
                }
                else if(choice7 == "3")
                {
                    if(Quest2 == false && QuestActive2 == true){
                        Monster snake = World.MonsterByID(2);
                        Weapon sword = World.WeaponByID(1);
                        while(snake.CurrentHitPoints > 0 && player.CurrentHitPoints > 0)
                        {
                            Console.WriteLine($"You see a {snake.Name}");
                            Console.WriteLine($"The {snake.Name} has {snake.CurrentHitPoints}");
                            Console.WriteLine($"You have {player.CurrentHitPoints} hit points");
                            Console.WriteLine("What would you like to do");
                            Console.WriteLine("1: Attack the monster");
                            Console.WriteLine("2: drink a posion");
                            string choice = Console.ReadLine();
                            if(choice == "1")
                            {
                                Console.WriteLine($"You attack the monster and deal {sword.MaximumDamage}");
                                Console.WriteLine($"The {snake.Name} attacked you back and deals {snake.MaximumDamage} points of damage");
                                snake.Monster_attack_player(player);
                                snake.player_attack_monster(sword);
                            }
                            else if(choice == "2")
                            {
                                player.CurrentHitPoints += 5;
                            }
                            else
                            {
                                Console.WriteLine("That is not a valid input");
                            }
                        }
                        // Console.WriteLine("Hier moet Quest 2 komen, Type 'Y' om de Quest te 'voltooien'");
                        // string testOption = Console.ReadLine();

                        if(snake.CurrentHitPoints <= 0){
                            // Hier moet de Quest beginnen
                            Console.WriteLine($"{snake.Name} has been defeted");
                            Quest2 = true; 
                        }
                        else{
                            Console.WriteLine("Probeer het nog een keer.");
                        }
                    }
                    else if(Quest2 == false && QuestActive2 == false)
                    {
                        Console.WriteLine("Go talk to the farmer");
                    }
                    else{
                        Console.WriteLine("The snakes are already dead");
                    }
                }
                else if (choice7 == "Q")
                {
                    keepGaming = false;
                    break;
                }
                else
                {
                    Console.WriteLine("That is not a valid input");
                }
            }

           //BRIDGE
            while(player.CurrentLocation == 8)
            {
                Compass compass8 = new Compass(north: "N", east: "Y", south: "N", west: "Y");

                //draw compass
                compass8.DrawCompass();

                Console.WriteLine($"You arrive at the {World.LocationByID(player.CurrentLocation).Name}.");
                Console.WriteLine($"you notice a weathered signpost planted at its entrance. \nThe sign provides directions for travelers:");
                Console.WriteLine("1: Look around");
                Console.WriteLine("2: West -> Guard Post");
                Console.WriteLine("3: East -> Spider Field");
                Console.WriteLine("4: Talk to the woman");
                Console.WriteLine("Q to quit the game");
                string choice8 = Console.ReadLine();

                if(choice8 == "1")
                {
                    // returns the locations
                    Console.WriteLine(World.LocationByID(player.CurrentLocation).Description);
                }
                else if(choice8 == "2")
                {
                    Console.WriteLine("As you decide to head west across the creaky bridge, the atmosphere changes subtly.");
                    Console.WriteLine("The path leads you through a dense path.");
                    player.CurrentLocation = 3;
                }
                else if(choice8 == "3")
                {
                    Console.WriteLine("Choosing the spooky path east, you walk across the creaky bridge.");
                    Console.WriteLine("As you get closer too the spider field you start noticing more and more tangled spider webs!");
                    player.CurrentLocation = 9;
                }
                else if(choice8 == "4")
                {
                    if(Quest3 == false){
                        Console.WriteLine("The woman gives you the following quest:");
                        Console.WriteLine(World.QuestByID(3).Description);
                        QuestActive3 = true;
                    }
                    else
                    {
                        Console.WriteLine("You already helped the woman, she is very thankfull!");
                    }
                }
                else if (choice8 == "Q")
                {
                    keepGaming = false;
                    break;
                }
                else
                {
                    Console.WriteLine("That is not a valid input");
                }
            }

            //spider field
            while(player.CurrentLocation == 9)
            {
                Compass compass9 = new Compass(north: "N", east: "Y", south: "N", west: "Y");

                //draw compass
                compass9.DrawCompass();

                Console.WriteLine($"You arrive at the {World.LocationByID(player.CurrentLocation).Name}.");
                Console.WriteLine($"you notice a weathered signpost planted in the middle of the field. \nThe sign provides directions for travelers:");
                Console.WriteLine("1: Look around");
                Console.WriteLine("2: West -> Bridge");
                Console.WriteLine("3: Fight the spider!");
                Console.WriteLine("Q to quit the game");
                string choice9 = Console.ReadLine();

                if(choice9 == "1")
                {
                    // returns the locations
                    Console.WriteLine(World.LocationByID(player.CurrentLocation).Description);
                }
                else if(choice9 == "2")
                {
                    Console.WriteLine("As you decide to head west too the bridge, you start walking.");
                    Console.WriteLine("Back on this spooky path!");
                    player.CurrentLocation = 8;
                }
                else if(choice9 == "3")
                {
                    if(Quest3 == false && QuestActive3 == true){
                        Console.WriteLine("Hier moet Quest 3 komen, Type 'Y' om de Quest te 'voltooien'");
                        string testOption = Console.ReadLine();

                        if(testOption == "Y"){
                            // Hier moet de Quest beginnen
                            Console.WriteLine("Quest gelukt!");
                            Quest3 = true; 
                        }
                        else{
                            Console.WriteLine("Probeer het nog een keer.");
                        }
                    }
                    else if(Quest3 == false && QuestActive3 == false)
                    {
                        Console.WriteLine("Go talk to the woman");
                    }
                    else{
                        Console.WriteLine("The spider is already dead");
                    }
                }
                else if (choice9 == "Q")
                {
                    keepGaming = false;
                    break;
                }
                else
                {
                    Console.WriteLine("That is not a valid input");
                }
            }
        
        }
        Console.WriteLine("The game is finished");
    }

}
