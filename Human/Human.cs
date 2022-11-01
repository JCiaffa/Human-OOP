public class Human
{
    public string Name;
    public int Strength = 3;
    public int Intelligence = 3;
    public int Dexterity =3;
    public int Health = 100;

    public Human(string name){
        Name = name;
    }
    public Human(string name, int str, int intel, int dex, int health)
    {
        Name = name;
        Strength = str;
        Intelligence = intel;
        Dexterity = dex;
        Health = health;
    }
     
    // Add a constructor to assign custom values to all fields
     
    // Build Attack method
    public void Attack(Human target)
    {
        Human enemy = target as Human;
        if(enemy != null){
            enemy.Health -= 3 * Strength;
        }
        else
        {
            Console.WriteLine("Attack Failed");
        }
    }
}

