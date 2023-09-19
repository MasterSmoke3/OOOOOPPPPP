// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
public class Player{
    int lvl;
    int Helth;
    int Damage;
    int Armor;
    int Magic;

    public Player(int Damage, int Helth, int Armor, int Magic, int lvl){
        this.Damage = Damage;
        this.Helth = Helth;
        this.Armor = Armor;
        this.Magic = Magic;
    }

    public Player(int lvl, int Helth) {
        this.lvl = lvl;
        this.Helth = Helth;
    }

    public int GetSquare(){
        return lvl * Helth;
    }
}

public class Mones{
    public static void Main(){
        Player firstRoom = new Player(2, 13);
        Player secondRoom = new Player(1, 4, 5, 7, 1);
        Console.WriteLine(firstRoom.GetSquare());
        Console.WriteLine(secondRoom.GetSquare());
    }

}