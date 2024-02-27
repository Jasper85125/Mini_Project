Monster monster = new();
string input = Console.ReadLine();
int input2 = Convert.ToInt32(input);
int attack = 5;
switch (input2) 
{
    case 1:
        Monster.attack(attack);
        Console.WriteLine($"You did {attack} damage");
        Console.WriteLine(monster.healthpoints);
        break;
    case 2:
        
        break;
    case 3:
        
        break;
    case 4:
        
        break;
    default:
        break;

}


string =North 
Compass compass = new("Y", "Y", "Y", "Y");
compass.DrawCompass();