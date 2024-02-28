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
        Player player = new(5, 1, 1, 10, name_of_player);

        Console.WriteLine($"Welcome {player.Name}");

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

                Console.WriteLine($"You arive at the {World.LocationByID(player.CurrentLocation).Name}.");
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
                
                Console.WriteLine($"You arive at the {World.LocationByID(player.CurrentLocation).Name}.");
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

            //FARMHOUSE
            while(player.CurrentLocation == 6)
            {
                Compass compass6 = new Compass(north: "N", east: "Y", south: "N", west: "Y");

                //draw compass
                compass6.DrawCompass();

                Console.WriteLine($"You arive at the {World.LocationByID(player.CurrentLocation).Name}.");
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
                    Console.WriteLine("Hier krijgt de user een dikke vette quest");
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

            //BRIDGE
            while(player.CurrentLocation == 8)
            {
                Compass compass8 = new Compass(north: "N", east: "Y", south: "N", west: "Y");

                //draw compass
                compass8.DrawCompass();

                Console.WriteLine($"You arive at the {World.LocationByID(player.CurrentLocation).Name}.");
                Console.WriteLine($"you notice a weathered signpost planted at its entrance. \nThe sign provides directions for travelers:");
                Console.WriteLine("1: Look around");
                Console.WriteLine("2: West -> Guard Post");
                Console.WriteLine("3: East -> Spider Field");
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
                    player.CurrentLocation = 7;
                }
                else if(choice8 == "3")
                {
                    Console.WriteLine("Choosing the spooky path east, you walk across the creaky bridge.");
                    Console.WriteLine("As you get closer too the spider field you start noticing more and more tangled spider webs!");
                    player.CurrentLocation = 9;
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
        }

        Console.WriteLine("The game is finished");
    }

}
